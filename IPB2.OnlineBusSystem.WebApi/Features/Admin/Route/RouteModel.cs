using System.ComponentModel.DataAnnotations;

namespace IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;

public class UpsertRouteRequest
{
    public string RouteName { get; set; } = null!;
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
}
public class UpdateRouteRequest
{
    public string? RouteName { get; set; } = null!;
    public string? Origin { get; set; } 
    public string? Destination { get; set; }
}
public class RouteResponse
{
    public string Id { get; set; } = null!;
    public string RouteName { get; set; } = null!;
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
}

public class GetRoutesRequest
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetRoutesResponse
{
    public List<RouteResponse> Routes { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
}
public class RouteComboSetModel
{
    public string Id { get; set; } = null!;
    public string RouteName { get; set; } = null!;
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
}