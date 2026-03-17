using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;

[Route("api/routes")]
[ApiController]
public class RoutesController : ControllerBase
{
    RouteService _routeService = new RouteService();

    [HttpGet]
    public async Task<IActionResult> GetRoutes(int pageNo, int pageSize)
    {
        var response = await _routeService.GetRoutesAsync(pageNo, pageSize);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoute(string id)
    {
        var response = await _routeService.GetRouteByIdAsync(id);
        if (response == null) return NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Route not found." });
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRoute(UpsertRouteRequest request)
    {
        ResponseBaseModel validationRes = Validation(request);

        if (!validationRes.IsSuccess)
            return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = validationRes.Message });

        var response = await _routeService.CreateAsync(request);
        return ResponseHelper.ConvertResponseType(response);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpsertRoute(UpsertRouteRequest request, string id)
    {
        ResponseBaseModel validationRes = Validation(request);

        if (!validationRes.IsSuccess)
            return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = validationRes.Message });

        var response = await _routeService.UpsertAsync(request, id);
        return ResponseHelper.ConvertResponseType(response);
    }
    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateRoute(UpdateRouteRequest request, string id)
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
    private ResponseBaseModel Validation(UpsertRouteRequest request)
    {
        // Require Validation
        if (string.IsNullOrWhiteSpace(request.RouteName))
            return new ResponseBaseModel { IsSuccess = false, Message = "Route name is required." };
        if (string.IsNullOrWhiteSpace(request.Origin))
            return new ResponseBaseModel { IsSuccess = false, Message = "Origin no is required." };
        if (string.IsNullOrWhiteSpace(request.Destination))
            return new ResponseBaseModel { IsSuccess = false, Message = "Destination is required." };

        return new ResponseBaseModel { IsSuccess = true, Message = "Validatin successfully." };

    }
}