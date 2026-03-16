using System;
using System.Collections.Generic;

namespace IPB2.OnlineBusSystem.DataBase.AppDbContextModels;

public partial class TblBusDetail
{
    public string Id { get; set; } = null!;

    public string BusNo { get; set; } = null!;

    public string BusName { get; set; } = null!;

    public string BusType { get; set; } = null!;

    public int TotalSeat { get; set; }

    public bool IsDelete { get; set; }
}
