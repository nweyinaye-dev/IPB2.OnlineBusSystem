using Dapper;
using IPB2.OnlineBusSystem.DataBase.AppDbContextModels;
using IPB2.OnlineBusSystem.WebApi.Common;
using IPB2.OnlineBusSystem.WebApi.Features.Admin.Route;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IPB2.OnlineBusSystem.WebApi.Features.User
{
    public class BookingService
    {
        AppDbContext _db = new AppDbContext();

        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "IPB2_OnlineBusBooking",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };

        public async Task<SearchBusResponse> SearchBus(SearchBusRequest request)
        {
            using (IDbConnection db = new SqlConnection(connectionString.ConnectionString))
            {
                db.Open();

                var sql = $@"SELECT s.id as secheduleId,b.BusNo,b.BusName,s.DepartureTime,s.ArrivalTime,s.AvaliableSeat,s.Fare
                        FROM [dbo].[Tbl_Schedule] s
                        INNER JOIN [dbo].[Tbl_Route] r ON s.RouteId = r.ID
                        INNER JOIN [dbo].[Tbl_BusDetail] b ON s.BusId = b.ID
                        WHERE 
                            s.IsDelete = 0 
                            AND r.IsDelete = 0
                            AND b.IsDelete = 0
                            AND s.AvaliableSeat > 0
                            AND s.Date = '{request.TravelDate}'
                            AND r.Origin = '{request.Origin}'
                            AND r.Destination = '{request.Destination}'";

                List<SearchBusResponseModel> results = db.Query<SearchBusResponseModel>(sql).ToList();
                return new SearchBusResponse { Buss = results };
            }
        }

        public async Task<ServiceResponse> CreateAsync(BookRequest request)
        {
          
            // 1. Fetch Schedule
            var schedule = await _db.TblSchedules.FirstOrDefaultAsync(x => x.Id == request.ScheduleId && !x.IsDelete);
            if (schedule == null)
                return new ServiceResponse { Status = ResponseType.NotFound, Message = "Schedule not found." };

            int totalSeatsToBook = request.Passengers.Count;
            int maxCapacity = schedule.AvaliableSeat + schedule.BookSeat;

            // 2. Check Capacity and Seat Validity
            if (schedule.AvaliableSeat < totalSeatsToBook)
                return new ServiceResponse { Status = ResponseType.None, Message = "Not enough seats available." };

            var requestedSeats = request.Passengers.Select(x => x.SeatNo).ToList();
            if (requestedSeats.Any(s => s > maxCapacity))
                return new ServiceResponse { Status = ResponseType.None, Message = "One or more Seat numbers are invalid for this schedule." };

            // 3. Check for existing bookings (optimized query)
            var alreadyBooked = await _db.TblBooks
                .Where(x => x.ScheduleId == request.ScheduleId && !x.IsDelete && requestedSeats.Contains(x.Seatno))
                .Select(x => x.Seatno)
                .ToListAsync();

            if (alreadyBooked.Any())
                return new ServiceResponse { Status = ResponseType.AlreadyExists, Message = $"Seats already taken: {string.Join(", ", alreadyBooked)}" };

            // 4. Bulk Add Bookings
            var bookings = request.Passengers.Select(p => new TblBook
            {
                Id = Guid.NewGuid().ToString(),
                ScheduleId = request.ScheduleId,
                Seatno = p.SeatNo,
                Username = p.Username,
                Phoneno = p.Phoneno,
                IsDelete = false
            });

            _db.TblBooks.AddRange(bookings);

            schedule.AvaliableSeat -= totalSeatsToBook;
            schedule.BookSeat += totalSeatsToBook;

            return await _db.SaveChangesAsync() > 0
                ? new ServiceResponse { Status = ResponseType.Success, Message = "Booking created successfully." }
                : new ServiceResponse { Status = ResponseType.None, Message = "Failed to save booking." };
        }

    }
}
