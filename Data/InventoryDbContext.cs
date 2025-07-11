﻿using InventoryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryAPI.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
