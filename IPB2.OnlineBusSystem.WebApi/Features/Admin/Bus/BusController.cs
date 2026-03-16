using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus
{
    [Route("api/bus")]
    [ApiController]
    public class BusController : ControllerBase
    {
       BusService _busService = new BusService();

        [HttpGet]
        public async Task<IActionResult> GetBuss()
        {
            var response = await _busService.GetBusAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBus(string id)
        {
            var response = await _busService.GetBusByIdAsync(id);
            if (response == null) return NotFound();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBus(CreateBusRequest request)
        {
            var response = await _busService.CreateAsync(request);
            return ResponseHelper.ConvertResponseType(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpserBus(UpsertBusRequest request, string id)
        {
            var response = await _busService.UpsertAsync(request, id);
            return ResponseHelper.ConvertResponseType(response);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBus(UpdateBusRequest request, string id)
        {
            var response = await _busService.UpdateAsync(request, id);
            return ResponseHelper.ConvertResponseType(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBus(string id)
        {
            var response = await _busService.DeleteAsync(id);
            return ResponseHelper.ConvertResponseType(response);
        }
    }
}
