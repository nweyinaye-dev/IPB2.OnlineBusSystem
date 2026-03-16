using IPB2.OnlineBusSystem.DataBase.AppDbContextModels;
using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.EntityFrameworkCore;

namespace IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;

public class RouteService
{
    AppDbContext _db = new AppDbContext();
    public  async Task<GetRoutesResponse> GetRoutesAsync()
    {
        var routes = await _db.TblRoutes
            .Where(x => !x.IsDelete)
            .Select(x => new RouteResponse
            {
                Id = x.Id,
                Origin = x.Origin,
                Destination = x.Destination
            })
            .ToListAsync();

        return new GetRoutesResponse { Routes = routes };
    }

    public  async Task<RouteResponse?> GetRouteByIdAsync(string id)
    {
        var route = await _db.TblRoutes
            .Where(x => x.Id == id && !x.IsDelete)
            .Select(x => new RouteResponse
            {
                Id = x.Id,
                Origin = x.Origin,
                Destination = x.Destination
            })
            .FirstOrDefaultAsync();

        return route;
    }

    public  async Task<ServiceResponse> CreateAsync(CreateRouteRequest request)
    {
        var route = new TblRoute
        {
            Id = Guid.NewGuid().ToString(),
            Origin = request.Origin,
            Destination = request.Destination,
            IsDelete = false
        };

        _db.TblRoutes.Add(route);
        await _db.SaveChangesAsync();

        return new ServiceResponse
        {
            Status = Common.ResponseType.Success,
            Message = "Route created successfully."
        };
    }

    public  async Task<ServiceResponse> UpsertAsync(UpsertRouteRequest request,string id)
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

        route.Origin = request.Origin;
        route.Destination = request.Destination;

        await _db.SaveChangesAsync();

        return new ServiceResponse
        {
            Status = Common.ResponseType.Success,
            Message = "Route updated successfully."
        };
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
        if (!string.IsNullOrEmpty(request.Origin))
        {

            route.Origin = request.Origin;
        }
        if (!string.IsNullOrEmpty(request.Destination))
        {

            route.Destination = request.Destination;
        }

        await _db.SaveChangesAsync();

        return new ServiceResponse
        {
            Status = Common.ResponseType.Success,
            Message = "Route updated successfully."
        };
    }

    public  async Task<ServiceResponse> DeleteAsync(string id)
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
        await _db.SaveChangesAsync();

        return new ServiceResponse
        {
            Status = Common.ResponseType.Success,
            Message = "Route deleted successfully."
        };
    }
}
