using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? MonthName { get; set; }

    public int TotalOrders { get; set; }
}
