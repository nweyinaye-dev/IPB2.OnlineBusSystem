using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.AspNetCore.Mvc;

namespace IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;

[Route("api/routes")]
[ApiController]
public class RoutesController : ControllerBase
{
    RouteService _routeService = new RouteService();

    [HttpGet]
    public async Task<IActionResult> GetRoutes()
    {
        var response = await _routeService.GetRoutesAsync();
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoute(string id)
    {
        var response = await _routeService.GetRouteByIdAsync(id);
        if (response == null) return NotFound();
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRoute(CreateRouteRequest request)
    {
        var response = await _routeService.CreateAsync(request);
        return ResponseHelper.ConvertResponseType(response);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpserRoute(UpsertRouteRequest request,string id)
    {
        var response = await _routeService.UpsertAsync(request, id);
        return ResponseHelper.ConvertResponseType(response);
    }
    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateRoute(UpdateRouteRequest request,string id)
    {
        var response = await _routeService.UpdateAsync(request, id);
        return ResponseHelper.ConvertResponseType(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRoute(string id)
    {
        var response = await _routeService.DeleteAsync(id);
        return ResponseHelper.ConvertResponseType(response);
    }
}
