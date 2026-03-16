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
        public async Task<IActionResult> GetSchedules()
        {
            var response = await _scheduleService.GetScheduleAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSchedule(string id)
        {
            var response = await _scheduleService.GetScheduleByIdAsync(id);
            if (response == null) return NotFound();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule(CreateScheduleRequest request)
        {
            var response = await _scheduleService.CreateAsync(request);
            return ResponseHelper.ConvertResponseType(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpserSchedule(UpsertScheduleRequest request, string id)
        {
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
    }
}
