using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane_Projesi.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-CELPGIDF\\SQLEXPRESS; database=Kutuphane_Projesi; " +
                "integrated security=true");
        }
        public DbSet<Kutuphane> Kutuphanes { get; set; }
    }
}
