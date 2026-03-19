using IPB2.OnlineScheduleSystem.WebApi.Features.Admin.Schedule;
using Microsoft.AspNetCore.Mvc;

namespace IPB2.OnlineBusSystem.WebApi.Features.Report
{
    [Route("api/booking")]
    [ApiController]
    public class BookingReportController : ControllerBase
    {
        BookingReportService _reportService = new BookingReportService();
      

        [HttpGet]
        public async Task<IActionResult> GetSchedules()
        {
            var response = await _reportService.GetBookingDetailAsync();
            return Ok(response);
        }
    }
}
