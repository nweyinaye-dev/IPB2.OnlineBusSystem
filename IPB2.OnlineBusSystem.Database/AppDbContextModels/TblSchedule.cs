using System;
using System.Collections.Generic;

namespace IPB2.OnlineBusSystem.DataBase.AppDbContextModels;

public partial class TblSchedule
{
    public string Id { get; set; } = null!;

    public string BusId { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int Fare { get; set; }

    public string ArrivalTime { get; set; } = null!;

    public string DepartureTime { get; set; } = null!;

    public string RouteId { get; set; } = null!;

    public int AvaliableSeat { get; set; }

    public int BookSeat { get; set; }

    public bool IsDelete { get; set; }
}
