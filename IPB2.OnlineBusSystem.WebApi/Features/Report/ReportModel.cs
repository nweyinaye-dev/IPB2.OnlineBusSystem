namespace IPB2.OnlineBusSystem.WebApi.Features.Report;

public class BookingDetailResponse
{
    public List<BookingDetailModel> bookings { get; set; } = new();
}
    public class BookingDetailModel
{
    public DateTime TravelDate { get; set; }
    public string BookedArrivalTime { get; set; }
    public string BookedDepartureTime { get; set; }
    public decimal BookedFare { get; set; }
    public string Username { get; set; }
    public string Phoneno { get; set; }
    public string SeatNo { get; set; }
    public string BookedBusNo { get; set; }
    public string BookedBusName { get; set; }
    public string BookedBusType { get; set; }
    public string BookedOrigin { get; set; }
    public string BookedDestination { get; set; }
}
