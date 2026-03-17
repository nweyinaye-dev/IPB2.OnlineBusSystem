using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.AspNetCore.Mvc;

namespace IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule
{
    [Route("api/schedules")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
       ScheduleService _scheduleService = new ScheduleService();

        [HttpGet]
        public async Task<IActionResult> GetSchedules(int pageNo, int pageSize)
        {
            var response = await _scheduleService.GetScheduleAsync(pageNo, pageSize);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSchedule(string id)
        {
            var response = await _scheduleService.GetScheduleByIdAsync(id);
            if (response == null) return NotFound(new ResponseBaseModel { IsSuccess = false, Message = "Schedule not found." });
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule(UpsertScheduleRequest request)
        {
            ResponseBaseModel validationRes = Validation(request);

            if (!validationRes.IsSuccess)
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = validationRes.Message });

            var response = await _scheduleService.CreateAsync(request);
            return ResponseHelper.ConvertResponseType(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpserSchedule(UpsertScheduleRequest request, string id)
        {
            ResponseBaseModel validationRes = Validation(request);

            if (!validationRes.IsSuccess)
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = validationRes.Message });

            var response = await _scheduleService.UpsertAsync(request, id);
            return ResponseHelper.ConvertResponseType(response);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateSchedule(UpdateScheduleRequest request, string id)
        {
            var response = await _scheduleService.UpdateAsync(request, id);
            return ResponseHelper.ConvertResponseType(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchedule(string id)
        {
            var response = await _scheduleService.DeleteAsync(id);
            return ResponseHelper.ConvertResponseType(response);
        }
        private ResponseBaseModel Validation(UpsertScheduleRequest request)
        {
            // Require Validation
            if (string.IsNullOrWhiteSpace(request.BusId))
                return new ResponseBaseModel { IsSuccess = false, Message = "BusId is required." };
            //if (string.IsNullOrWhiteSpace(request.Date))
            //    return new ResponseBaseModel { IsSuccess = false, Message = "BusNo is required." };
            if (request.Fare == 0)
                return new ResponseBaseModel { IsSuccess = false, Message = "Fare is required." };
            if (string.IsNullOrWhiteSpace(request.ArrivalTime))
                return new ResponseBaseModel { IsSuccess = false, Message = "ArrivalTime is required." };
            if (string.IsNullOrWhiteSpace(request.DepartureTime))
                return new ResponseBaseModel { IsSuccess = false, Message = "DepartureTime is required." };
            if (string.IsNullOrWhiteSpace(request.RouteId))
                return new ResponseBaseModel { IsSuccess = false, Message = "RouteId is required." };

            return new ResponseBaseModel { IsSuccess = true, Message = "Validatin successfully." };

        }
    }
}
