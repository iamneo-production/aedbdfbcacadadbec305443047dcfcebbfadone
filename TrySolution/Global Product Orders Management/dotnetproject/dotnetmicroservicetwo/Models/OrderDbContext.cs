using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroservicetwo.Models;

public class OrderDbContext : DbContext
{

    public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Order> Orders { get; set; }
}
