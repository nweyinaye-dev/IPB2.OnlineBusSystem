using Dapper;
using IPB2.OnlineBusSystem.WebApi.Common;
using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IPB2.OnlineBusSystem.WebApi.Features.Report
{
    public class BookingReportService
    {

        public async Task<BookingDetailResponse> GetBookingDetailAsync(string? search)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString.GetConnection()))
            {
                db.Open();
                var sql = $@"select s.Date as TravelDate,book.Username,
                            book.Phoneno,book.SeatNo,b.BusNo as BookedBusNo,b.BusName as BookedBusName,
							b.BusType as BookedBusType,s.ArrivalTime as BookedArrivalTime,
                            s.DepartureTime as BookedDepartureTime,s.Fare as BookedFare,r.Origin as BookedOrigin,r.Destination as BookedDestination
							FROM [dbo].[Tbl_Schedule] s
							INNER JOIN [dbo].[Tbl_Route] r ON s.RouteId = r.ID
							INNER JOIN [dbo].[Tbl_BusDetail] b ON s.BusId = b.ID
							INNER JOIN [dbo].[Tbl_Book] book ON s.Id = book.ScheduleId
                        ";

                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += $@" WHERE b.BusNo LIKE '%{search}%' 
                      OR b.BusName LIKE '%{search}%'  
                      OR book.Username LIKE '%{search}%' ";
                }

                

                List<BookingDetailModel> results = db.Query<BookingDetailModel>(sql).ToList();
                return new BookingDetailResponse { bookings = results };
            }
        }
        
        public async Task<BookingDetailResponse> GetBookingDetailByUserAsync(string username, string phoneno)
        {
            using (IDbConnection db = new SqlConnection(ConnectionString.GetConnection()))
            {
                db.Open();

                var sql = $@"select s.Date as TravelDate,book.Username,
                            book.Phoneno,book.SeatNo,b.BusNo as BookedBusNo,b.BusName as BookedBusName,
							b.BusType as BookedBusType,s.ArrivalTime as BookedArrivalTime,
                            s.DepartureTime as BookedDepartureTime,s.Fare as BookedFare,r.Origin as BookedOrigin,r.Destination as BookedDestination
							FROM [dbo].[Tbl_Schedule] s
							INNER JOIN [dbo].[Tbl_Route] r ON s.RouteId = r.ID
							INNER JOIN [dbo].[Tbl_BusDetail] b ON s.BusId = b.ID
							INNER JOIN [dbo].[Tbl_Book] book ON s.Id = book.ScheduleId
                            Where book.username = '{username}' and book.phoneno = '{phoneno}'
                        ";

                List<BookingDetailModel> results = db.Query<BookingDetailModel>(sql).ToList();
                return new BookingDetailResponse { bookings = results };
            }
        }
    }
}
