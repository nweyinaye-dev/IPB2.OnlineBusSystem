using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Bus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPB2.OnlineBusSystem.WebApi.Features.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        BookingService _bookService = new BookingService();

        [HttpPost("/search")]
        public async Task<IActionResult> SearchBus(SearchBusRequest request)
        {

            if (string.IsNullOrWhiteSpace(request.Origin))
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Origin is required." });
            if (string.IsNullOrWhiteSpace(request.Destination))
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Destination is required." });
            //if (string.IsNullOrWhiteSpace(request.TravelDate))
            //    return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Origin is required." });

            var response = await _bookService.SearchBus(request);
            return Ok(response);
        }

        [HttpPost("/book")]
        public async Task<IActionResult> CreateBooking(BookRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.ScheduleId))
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Schedule Id is required." });

            if (request.Passengers == null || !request.Passengers.Any())
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "No passengers provided." });

            if (request.Passengers.Any(p => p.SeatNo <= 0 || string.IsNullOrWhiteSpace(p.Username) || string.IsNullOrWhiteSpace(p.Phoneno)))
                return BadRequest(new ResponseBaseModel { IsSuccess = false, Message = "Passenger details (Seat, Name, Phone) are required." });


            var response = await _bookService.CreateAsync(request);
            return ResponseHelper.ConvertResponseType(response);
        }

    }
}
