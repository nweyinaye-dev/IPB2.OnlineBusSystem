
using IPB2.OnlineBusSystem.DataBase.AppDbContextModels;
using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule
{
    public class ScheduleService
    {
        AppDbContext _db = new AppDbContext();
        public async Task<GetScheduleResponse> GetScheduleAsync()
        {
            var Schedule = await _db.TblSchedules
                .Where(x => !x.IsDelete)
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

        public async Task<ServiceResponse> CreateAsync(CreateScheduleRequest request)
        {
            var Schedule = new TblSchedule
            {
                Id = Guid.NewGuid().ToString(),
                BusId = request.BusId,
                Date = request.Date,
                Fare = request.Fare,
                ArrivalTime = request.ArrivalTime,
                DepartureTime = request.DepartureTime,
                RouteId = request.RouteId,
                AvaliableSeat = 30,
                BookSeat = 0,
                IsDelete = false
            };

            _db.TblSchedules.Add(Schedule);
            await _db.SaveChangesAsync();

            return new ServiceResponse
            {
                Status = ResponseType.Success,
                Message = "Schedule created successfully."
            };
        }

        public async Task<ServiceResponse> UpsertAsync(UpsertScheduleRequest request, string id)
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
                var isBusExist = await _db.TblBusDetails.AnyAsync(x => x.Id == request.BusId);

                if (!isBusExist)
                    return new ServiceResponse { Status = ResponseType.NotFound, Message = "Bus id not found." };                
            }
            if (!string.IsNullOrEmpty(request.RouteId))
            {
                var isRouteExist = await _db.TblRoutes.AnyAsync(x => x.Id == request.RouteId);

                if (!isRouteExist)
                    return new ServiceResponse { Status = ResponseType.NotFound, Message = "Route id not found." };
               
            }
            Schedule.BusId = request.BusId;
            Schedule.RouteId = request.RouteId;
            Schedule.ArrivalTime = request.ArrivalTime;
            Schedule.DepartureTime = request.DepartureTime;
            Schedule.Date = request.Date;

            await _db.SaveChangesAsync();

            return new ServiceResponse
            {
                Status = ResponseType.Success,
                Message = "Schedule updated successfully."
            };
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
                var isBusExist = await _db.TblBusDetails.AnyAsync(x => x.Id == request.BusId);

                if (!isBusExist)
                    return new ServiceResponse { Status = ResponseType.NotFound, Message = "Bus id not found." };
                Schedule.BusId = request.BusId;
            }
            if (!string.IsNullOrEmpty(request.RouteId))
            {
                var isRouteExist = await _db.TblRoutes.AnyAsync(x => x.Id == request.RouteId);

                if (!isRouteExist)
                    return new ServiceResponse { Status = ResponseType.NotFound, Message = "Route id not found." };
                Schedule.RouteId = request.RouteId;
            }

            await _db.SaveChangesAsync();

            return new ServiceResponse
            {
                Status = ResponseType.Success,
                Message = "Schedule updated successfully."
            };
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
