using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroserviceone.Models;

public class ProductDbContext : DbContext
{
    public ProductDbContext()
    {
    }

    public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

}
