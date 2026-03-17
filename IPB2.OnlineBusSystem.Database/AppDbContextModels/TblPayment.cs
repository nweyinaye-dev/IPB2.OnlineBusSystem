using System;
using System.Collections.Generic;

namespace IPB2.OnlineBusSystem.DataBase.AppDbContextModels;

public partial class TblPayment
{
    public string Id { get; set; } = null!;

    public string BookId { get; set; } = null!;

    public string PaymentType { get; set; } = null!;

    public string Payment { get; set; } = null!;

    public string CardNo { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public DateOnly Date { get; set; }

    public bool IsDelete { get; set; }
}
