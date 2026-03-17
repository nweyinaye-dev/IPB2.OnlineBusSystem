using System;
using System.Collections.Generic;

namespace IPB2.OnlineBusSystem.DataBase.AppDbContextModels;

public partial class TblBook
{
    public string Id { get; set; } = null!;

    public string ScheduleId { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Phoneno { get; set; } = null!;

    public int Seatno { get; set; }

    public bool IsDelete { get; set; }
}
