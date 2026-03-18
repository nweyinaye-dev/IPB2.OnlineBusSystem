using IPB2.OnlineBusSystem.ConsoleApp.Common;
using IPB2.OnlineBusSystem.DataBase.AppDbContextModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.RouteDetail
{
    public class RouteService
    {
        AppDbContext _db = new AppDbContext();
        public async Task<GetRoutesResponse> GetRoutesAsync(int pageNo, int pageSize)
        {
            var routes = await _db.TblRoutes
                .Where(x => !x.IsDelete)
                .OrderByDescending(x => x.RouteName)
                .Skip((pageNo - 1) * pageSize)
                 .Take(pageSize)
                .Select(x => new RouteResponse
                {
                    Id = x.Id,
                    RouteName = x.RouteName,
                    Origin = x.Origin,
                    Destination = x.Destination
                })
                .ToListAsync();

            return new GetRoutesResponse { Routes = routes };
        }

        public async Task<RouteResponse?> GetRouteByIdAsync(string id)
        {
            var route = await _db.TblRoutes
                .Where(x => x.Id == id && !x.IsDelete)
                .Select(x => new RouteResponse
                {
                    Id = x.Id,
                    RouteName = x.RouteName,
                    Origin = x.Origin,
                    Destination = x.Destination
                })
                .FirstOrDefaultAsync();

            return route;
        }

        public async Task<ServiceResponse> CreateAsync(UpsertRouteRequest request)
        {
            var route = new TblRoute
            {
                Id = Guid.NewGuid().ToString(),
                RouteName = request.RouteName,
                Origin = request.Origin,
                Destination = request.Destination,
                IsDelete = false
            };

            _db.TblRoutes.Add(route);
            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Route created successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }

        public async Task<ServiceResponse> UpsertAsync(UpsertRouteRequest request, string id)
        {
            var route = await _db.TblRoutes
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (route == null)
            {
                return new ServiceResponse
                {
                    Status = Common.ResponseType.NotFound,
                    Message = "Route not found."
                };
            }
            route.RouteName = request.RouteName;
            route.Origin = request.Origin;
            route.Destination = request.Destination;

            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
               ? new ServiceResponse { Status = ResponseType.Success, Message = "Route updated successfully." }
               : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }
        public async Task<ServiceResponse> UpdateAsync(UpdateRouteRequest request, string id)
        {
            var route = await _db.TblRoutes
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (route == null)
            {
                return new ServiceResponse
                {
                    Status = Common.ResponseType.NotFound,
                    Message = "Route not found."
                };
            }
            if (!string.IsNullOrEmpty(request.RouteName))
            {

                route.RouteName = request.RouteName;
            }
            if (!string.IsNullOrEmpty(request.Origin))
            {

                route.Origin = request.Origin;
            }
            if (!string.IsNullOrEmpty(request.Destination))
            {
                route.Destination = request.Destination;
            }

            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
               ? new ServiceResponse { Status = ResponseType.Success, Message = "Route updated successfully." }
               : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }

        public async Task<ServiceResponse> DeleteAsync(string id)
        {
            var route = await _db.TblRoutes
                .Where(x => x.Id == id && !x.IsDelete)
                .FirstOrDefaultAsync();

            if (route == null)
            {
                return new ServiceResponse
                {
                    Status = Common.ResponseType.NotFound,
                    Message = "Route not found."
                };
            }

            route.IsDelete = true;
            int rowAffected = await _db.SaveChangesAsync();

            return rowAffected > 0
               ? new ServiceResponse { Status = ResponseType.Success, Message = "Route deleted successfully." }
               : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };
        }
    }
}
