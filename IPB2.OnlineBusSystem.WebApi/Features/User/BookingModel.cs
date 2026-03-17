namespace IPB2.OnlineBusSystem.WebApi.Features.User;

public class  SearchBusRequest
{
    public DateOnly TravelDate { get; set; }
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
}

public class SearchBusResponseModel
{
    public string secheduleId { get; set; } = null!;
    public string BusNo { get; set; } = null!;
    public string BusName { get; set; } = null!;
    public string DepartureTime { get; set; } = null!;
    public string ArrivalTime { get; set; } = null!;
    public int AvailableSeats { get; set; }
    public int Fare { get; set; }
}
public class SearchBusResponse
{
    public List<SearchBusResponseModel> Buss { get; set; } = new();
}
public class Passenger
{
    public int SeatNo { get; set; } 
    public string Username { get; set; } = null!;
    public string Phoneno { get; set; } = null!;
}

public class BookRequest
{
    public string ScheduleId { get; set; } = null!;
    public List<Passenger> Passengers { get; set; } = new();
}

