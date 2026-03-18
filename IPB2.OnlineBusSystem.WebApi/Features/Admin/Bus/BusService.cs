using IPB2.OnlineBusSystem.DataBase.AppDbContextModels;
using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus
{
    public class BusService
    {
        AppDbContext _db = new AppDbContext();
        public async Task<GetBusResponse> GetBusAsync(int pageNo, int pageSize)
        {
            var Bus = await _db.TblBusDetails
                .Where(x => !x.IsDelete)
                .OrderByDescending(x => x.BusName)
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new BusResponse
                {
                    Id = x.Id,
                    BusNo = x.BusNo,
                    BusName = x.BusName,
                    BusType = x.BusType,
                    TotalSeat = x.TotalSeat
                })
                .ToListAsync();
            return new GetBusResponse { Buss = Bus };
        }
        public async Task<BusResponse?> GetBusByIdAsync(string id)
        {
            var Bus = await _db.TblBusDetails
            .Where(x => x.Id == id && !x.IsDelete)
            .Select(x => new BusResponse
            {
                Id = x.Id,
                BusNo = x.BusNo,
                BusName = x.BusName,
                BusType = x.BusType,
                TotalSeat = x.TotalSeat
            })
            .FirstOrDefaultAsync();


            return Bus;
        }
        public async Task<ServiceResponse> CreateAsync(UpsertBusRequest request)
        {
            var Bus = new TblBusDetail
            {
                Id = Guid.NewGuid().ToString(),
                BusNo = request.BusNo,
                BusName = request.BusName,
                BusType = request.BusType,
                TotalSeat = request.TotalSeat,
                IsDelete = false
            };

            _db.TblBusDetails.Add(Bus);
            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Bus created successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }
        public async Task<ServiceResponse> UpsertAsync(UpsertBusRequest request, string id)
        {
            var Bus = await _db.TblBusDetails
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (Bus == null)
            {
                return new ServiceResponse
                {
                    Status = Common.ResponseType.NotFound,
                    Message = "Bus not found."
                };
            }

            Bus.BusNo = request.BusNo;
            Bus.BusName = request.BusName;
            Bus.BusType = request.BusType;
            Bus.TotalSeat = request.TotalSeat;

            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Bus updated successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };

        }
        public async Task<ServiceResponse> UpdateAsync(UpdateBusRequest request, string id)
        {
            var Bus = await _db.TblBusDetails
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (Bus == null)
            {
                return new ServiceResponse
                {
                    Status = Common.ResponseType.NotFound,
                    Message = "Bus not found."
                };
            }
            if (!string.IsNullOrEmpty(request.BusNo))  Bus.BusNo = request.BusNo;
            if (!string.IsNullOrEmpty(request.BusName)) Bus.BusName = request.BusName;
            if (!string.IsNullOrEmpty(request.BusType)) Bus.BusType = request.BusType;
            if (request.TotalSeat >= 20) Bus.TotalSeat = request.TotalSeat;

            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Bus updated successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
         }
        public async Task<ServiceResponse> DeleteAsync(string id)
        {
            var Bus = await _db.TblBusDetails
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (Bus == null)
            {
                return new ServiceResponse
                {
                    Status = Common.ResponseType.NotFound,
                    Message = "Bus not found."
                };
            }

            Bus.IsDelete = true;
            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Bus deleted successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };

        }
    }
}
