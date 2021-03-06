﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KKZadar.Models;

namespace KKZadar.Data
{
    public class ManagerContext : DbContext
    {
        public ManagerContext (DbContextOptions<ManagerContext> options)
            : base(options)
        {
        }

        public DbSet<KKZadar.Models.Manager> Manager { get; set; }
    }
}
