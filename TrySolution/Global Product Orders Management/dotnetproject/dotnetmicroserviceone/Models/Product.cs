using System;
using System.Collections.Generic;

namespace dotnetmicroserviceone.Models;
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Availability { get; set; }

}
