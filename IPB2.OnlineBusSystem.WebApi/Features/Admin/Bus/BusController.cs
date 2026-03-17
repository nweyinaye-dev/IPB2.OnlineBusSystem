using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;
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
        public async Task<IActionResult> GetBuss(int pageNo, int pageSize)
        {
            var response = await _busService.GetBusAsync(pageNo, pageSize);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBus(string id)
        {
            var response = await _busService.GetBusByIdAsync(id);
            if (response == null) return NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Bus not found." });
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBus(UpsertBusRequest request)
        {
            ResponseBaseModel validationRes = Validation(request);

            if (!validationRes.IsSuccess)
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = validationRes.Message });

            var response = await _busService.CreateAsync(request);
            return ResponseHelper.ConvertResponseType(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpsertBus(UpsertBusRequest request, string id)
        {
            ResponseBaseModel validationRes = Validation(request);

            if (!validationRes.IsSuccess)
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = validationRes.Message });

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
        private ResponseBaseModel Validation(UpsertBusRequest request)
        {
            // Require Validation
            if (string.IsNullOrWhiteSpace(request.BusName))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusName is required." };
            if (string.IsNullOrWhiteSpace(request.BusNo))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusNo is required." };
            if (string.IsNullOrWhiteSpace(request.BusType))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusType is required." };
            if (request.TotalSeat < 20)
                return new ResponseBaseModel { IsSuccess = false, Message = "Total Seat must be at leave 20 seats." };

            return new ResponseBaseModel { IsSuccess = true, Message = "Validatin successfully." };

        }
    }
}
