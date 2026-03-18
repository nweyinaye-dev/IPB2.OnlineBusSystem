
using IPB2.OnlineBusSystem.DataBase.AppDbContextModels;
using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule
{
    public class ScheduleService
    {
        AppDbContext _db = new AppDbContext();
        public async Task<GetScheduleResponse> GetScheduleAsync(int pageNo, int pageSize)
        {
            var Schedule = await _db.TblSchedules
                .Where(x => !x.IsDelete)
                .OrderByDescending(x => x.Date)
                .Skip((pageNo - 1) * pageSize)
                 .Take(pageSize)
                .Select(x => new ScheduleResponse
                {
                    Id = x.Id,
                    BusId = x.BusId,
                    Date = x.Date,
                    Fare = x.Fare,
                    ArrivalTime = x.ArrivalTime,
                    DepartureTime = x.DepartureTime,
                    RouteId = x.RouteId,
                    AvaliableSeat = x.AvaliableSeat,
                    BookSeat = x.BookSeat
                })
                .ToListAsync();

            return new GetScheduleResponse { Schedules = Schedule };
        }

        public async Task<ScheduleResponse?> GetScheduleByIdAsync(string id)
        {
            var Schedule = await _db.TblSchedules
            .Where(x => x.Id == id && !x.IsDelete)
            .Select(x => new ScheduleResponse
            {
                Id = x.Id,
                BusId = x.BusId,
                Date = x.Date,
                Fare = x.Fare,
                ArrivalTime = x.ArrivalTime,
                DepartureTime = x.DepartureTime,
                RouteId = x.RouteId,
                AvaliableSeat = x.AvaliableSeat,
                BookSeat = x.BookSeat
            })
            .FirstOrDefaultAsync();


            return Schedule;
        }

        public async Task<ServiceResponse> CreateAsync(UpsertScheduleRequest request)
        {
            var isScheduleExist = await _db.TblSchedules.Where(x => !x.IsDelete && x.Date == request.Date)
                                .AnyAsync(x => x.BusId == request.BusId);
            if(isScheduleExist)
                return new ServiceResponse { Status = ResponseType.AlreadyExists, Message = $"Bus is already assigned for {request.Date}." };

            var item = await _db.TblBusDetails.FirstOrDefaultAsync(x => x.Id == request.BusId && !x.IsDelete);
            if (item is null) return new ServiceResponse { Status = ResponseType.NotFound, Message = "Bus id not found." };

            var isRouteExist = await _db.TblRoutes.Where(x => !x.IsDelete)
                .AnyAsync(x => x.Id == request.RouteId);

            if (!isRouteExist)
                return new ServiceResponse { Status = ResponseType.NotFound, Message = "Route id not found." };


            var Schedule = new TblSchedule
            {
                Id = Guid.NewGuid().ToString(),
                BusId = request.BusId,
                Date = request.Date,
                Fare = request.Fare,
                ArrivalTime = request.ArrivalTime,
                DepartureTime = request.DepartureTime,
                RouteId = request.RouteId,
                AvaliableSeat = item.TotalSeat,
                BookSeat = 0,
                IsDelete = false
            };

            _db.TblSchedules.Add(Schedule);
            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Schedule created successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }

        public async Task<ServiceResponse> UpsertAsync(UpsertScheduleRequest request, string id)
        {
            var Schedule = await _db.TblSchedules.Where(x => x.Id == id && !x.IsDelete).FirstOrDefaultAsync();

            if (Schedule == null)
            {
                return new ServiceResponse
                {
                    Status = ResponseType.NotFound,
                    Message = "Schedule not found."
                };
            }

            var isScheduleExist = await _db.TblSchedules.Where(x => !x.IsDelete && x.Date == request.Date 
                                    && x.BusId == request.BusId).AnyAsync();                            
            if (isScheduleExist)
                return new ServiceResponse { Status = ResponseType.AlreadyExists, Message = $"Bus is already assigned for {request.Date}." };


            var item = await _db.TblBusDetails.FirstOrDefaultAsync(x => x.Id == request.BusId && !x.IsDelete);
            if (item is null) return new ServiceResponse { Status = ResponseType.NotFound, Message = "Bus id not found." };

            var isRouteExist = await _db.TblRoutes.Where(x => !x.IsDelete)
                .AnyAsync(x => x.Id == request.RouteId);

            if (!isRouteExist)
                return new ServiceResponse { Status = ResponseType.NotFound, Message = "Route id not found." };

            Schedule.BusId = request.BusId;
            Schedule.RouteId = request.RouteId;
            Schedule.ArrivalTime = request.ArrivalTime;
            Schedule.DepartureTime = request.DepartureTime;
            Schedule.Date = request.Date;

            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Schedule updated successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }
        public async Task<ServiceResponse> UpdateAsync(UpdateScheduleRequest request, string id)
        {
            var Schedule = await _db.TblSchedules
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (Schedule == null)
            {
                return new ServiceResponse
                {
                    Status = ResponseType.NotFound,
                    Message = "Schedule not found."
                };
            }            

            if (!string.IsNullOrEmpty(request.BusId))
            {
                var item = await _db.TblBusDetails.FirstOrDefaultAsync(x => x.Id == request.BusId && !x.IsDelete);
                if (item is null) return new ServiceResponse { Status = ResponseType.NotFound, Message = "Bus id not found." };

                Schedule.BusId = request.BusId;
                Schedule.AvaliableSeat = item.TotalSeat;
            }
            if (!string.IsNullOrEmpty(request.RouteId))
            {
                var isRouteExist = await _db.TblRoutes.Where(x => !x.IsDelete)
                 .AnyAsync(x => x.Id == request.RouteId);

                if (!isRouteExist)
                    return new ServiceResponse { Status = ResponseType.NotFound, Message = "Route id not found." };

                Schedule.RouteId = request.RouteId;
            }
            if (request.Fare > 0)
                Schedule.Fare = request.Fare;

            if (!string.IsNullOrEmpty(request.ArrivalTime))
                Schedule.ArrivalTime = request.ArrivalTime;

            if (!string.IsNullOrEmpty(request.DepartureTime))
                Schedule.DepartureTime = request.DepartureTime;
            if (request.Date.HasValue)
                Schedule.Date = request.Date.Value;

                var isScheduleExist = await _db.TblSchedules.Where(x => !x.IsDelete && x.Date == Schedule.Date
                                && x.BusId == Schedule.BusId).AnyAsync();
            if (isScheduleExist)
                return new ServiceResponse { Status = ResponseType.AlreadyExists, Message = $"Bus is already assigned for {Schedule.Date}." };


            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Schedule updated successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }

        public async Task<ServiceResponse> DeleteAsync(string id)
        {
            var Schedule = await _db.TblSchedules
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (Schedule == null)
            {
                return new ServiceResponse
                {
                    Status = ResponseType.NotFound,
                    Message = "Schedule not found."
                };
            }

            Schedule.IsDelete = true;
            await _db.SaveChangesAsync();

            return new ServiceResponse
            {
                Status = ResponseType.Success,
                Message = "Schedule deleted successfully."
            };
        }
    }
}
