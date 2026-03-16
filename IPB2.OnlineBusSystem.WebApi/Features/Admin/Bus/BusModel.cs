public class CreateBusRequest
{
    public string BusNo { get; set; } = null!;
    public string BusName { get; set; } = null!;
    public string BusType { get; set; } = null!;
    public int TotalSeat { get; set; }
}

public class UpsertBusRequest
{
    public string BusNo { get; set; } = null!;
    public string BusName { get; set; } = null!;
    public string BusType { get; set; } = null!;
    public int TotalSeat { get; set; }
}
public class UpdateBusRequest
{
    public string? BusNo { get; set; } = null!;
    public string? BusName { get; set; } = null!;
    public string? BusType { get; set; } = null!;
    public int TotalSeat { get; set; }
}
public class BusResponse
{
    public string Id { get; set; } = null!;
    public string BusNo { get; set; } = null!;
    public string BusName { get; set; } = null!;
    public string BusType { get; set; } = null!;
    public int TotalSeat { get; set; } 
}

public class GetBusRequest
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetBusResponse
{
    public List<BusResponse> Buss { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
}
