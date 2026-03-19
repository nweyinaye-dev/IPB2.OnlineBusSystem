using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.OnlineBusSystem.ConsoleApp.Features.Admin.Schdeule;

public class UpsertScheduleRequest
{
    public string BusId { get; set; } = null!;
    public DateOnly Date { get; set; }
    public int Fare { get; set; }
    public string ArrivalTime { get; set; } = null!;
    public string DepartureTime { get; set; } = null!;
    public string RouteId { get; set; } = null!;
}
public class UpdateScheduleRequest
{
    public string? BusId { get; set; } = null!;
    public DateOnly? Date { get; set; }
    public int Fare { get; set; }
    public string? ArrivalTime { get; set; } = null!;
    public string? DepartureTime { get; set; } = null!;
    public string? RouteId { get; set; } = null!;
}
public class ScheduleResponse
{
    public string Id { get; set; }
    public string BusId { get; set; } = null!;
    public DateOnly Date { get; set; }
    public int Fare { get; set; }
    public string ArrivalTime { get; set; } = null!;
    public string DepartureTime { get; set; } = null!;
    public string RouteId { get; set; } = null!;
    public int AvaliableSeat { get; set; }
    public int BookSeat { get; set; }
}

public class GetScheduleRequest
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetScheduleResponse
{
    public List<ScheduleResponse> Schedules { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
}

