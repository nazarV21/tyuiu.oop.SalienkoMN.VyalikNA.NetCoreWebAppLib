using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tyuiu.oop.SalienkoMN.VyalikNA.NetCoreWebAppLib.Data
{
    public class tyuiuoopSalienkoMNVyalikNANetCoreWebAppLibContext : DbContext
    {
        public tyuiuoopSalienkoMNVyalikNANetCoreWebAppLibContext (DbContextOptions<tyuiuoopSalienkoMNVyalikNANetCoreWebAppLibContext> options)
            : base(options)
        {
        }

        public DbSet<People> People { get; set; } = default!;
    }
}
