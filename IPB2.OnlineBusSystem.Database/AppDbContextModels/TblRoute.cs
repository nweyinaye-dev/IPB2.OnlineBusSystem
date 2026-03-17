using System;
using System.Collections.Generic;

namespace IPB2.OnlineBusSystem.DataBase.AppDbContextModels;

public partial class TblRoute
{
    public string Id { get; set; } = null!;

    public string RouteName { get; set; } = null!;

    public string Origin { get; set; } = null!;

    public string Destination { get; set; } = null!;

    public bool IsDelete { get; set; }
}
