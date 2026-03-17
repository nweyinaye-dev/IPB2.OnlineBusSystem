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
            Password = "system",
            TrustServerCertificate = true,
        };

        public async Task<SearchBusResponse> SearchBus(SearchBusRequest request)
        {
            using (IDbConnection db = new SqlConnection(connectionString.ConnectionString))
            {
                db.Open();

                var sql = $@"SELECT s.id,b.BusNo,b.BusName,s.DepartureTime,s.ArrivalTime,s.AvaliableSeat,s.Fare
                        FROM [dbo].[Tbl_Schedule] s
                        INNER JOIN [dbo].[Tbl_Route] r ON s.RouteId = r.ID
                        INNER JOIN [dbo].[Tbl_BusDetail] b ON s.BusId = b.ID
                        WHERE 
                            s.IsDelete = 0 
                            AND r.IsDelete = 0
                            AND b.IsDelete = 0
                            AND s.Date = '{request.TravelDate}'
                            AND r.Origin = '{request.Origin}'
                            AND r.Destination = '{request.Destination}'";

                List<SearchBusResponseModel> results = db.Query<SearchBusResponseModel>(sql).ToList();
                return new SearchBusResponse { Buss = results };
            }
        }

        public async Task<ServiceResponse> CreateAsync(BookRequest request)
        {
            int totalSeatsToBook = request.Passengers.Count;

            if (totalSeatsToBook == 0)
                return new ServiceResponse { Status = ResponseType.None, Message = "No passengers provided." };
          
            var schedule = await _db.TblSchedules
                    .FirstOrDefaultAsync(x => x.Id == request.ScheduleId && !x.IsDelete);

            if (schedule == null)
                    return new ServiceResponse { Status = ResponseType.NotFound, Message = "Schedule not found." };

            if (schedule.AvaliableSeat < totalSeatsToBook)
                    return new ServiceResponse { Status = ResponseType.None, Message = "Not enough seats available." };

            int totalSeats = schedule.AvaliableSeat + schedule.BookSeat;
           
            // var requestedSeats = request.Passengers.Select(x => x.SeatNo).ToList();

            // check already book seatno
            //var alreadyBooked = await _db.TblBooks
            //    .Where(x => x.ScheduleId == request.ScheduleId
            //             && !x.IsDelete
            //             && requestedSeats.Contains(x.Seatno))
            //    .Select(x => x.Seatno)
            //    .ToListAsync();

            //if (alreadyBooked.Any())
            //{
            //    return new ServiceResponse
            //    {
            //        Status = ResponseType.AlreadyExists,
            //        Message = $"These seats are already taken: {string.Join(", ", alreadyBooked)}"
            //    };
            //}

            foreach (var p in request.Passengers)
            {
                if (p.SeatNo > totalSeats)
                    return new ServiceResponse { Status = ResponseType.None, Message = $"Invalid SeatNo : {p.SeatNo}." };

                var booking = new TblBook
                    {
                        Id = Guid.NewGuid().ToString(),
                        ScheduleId = request.ScheduleId,
                        Seatno = p.SeatNo,      
                        Username = p.Username,  
                        Phoneno = p.Phoneno,    
                        IsDelete = false
                    };
                    _db.TblBooks.Add(booking);
             }

                schedule.AvaliableSeat -= totalSeatsToBook;
                schedule.BookSeat += totalSeatsToBook;

                int rowAffected = await _db.SaveChangesAsync();

                return rowAffected > 0
                    ? new ServiceResponse { Status = ResponseType.Success, Message = "Booking created successfully." }
                    : new ServiceResponse { Status = ResponseType.None, Message = "Failed. No rows were affected." };


        }
    }
}
