using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Sql.Models
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options):base(options)
        {
           
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
