using System;
using System.Collections.Generic;

namespace dotnetmicroservicetwo.Models;
public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public string ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }

public string OrderStatus { get; set; }
}
