using EFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loais { get; set;}
        public DbSet<HangHoa> HangHoas { get; set;}

        public DbSet<KhachHang> KhachHang { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=BINHMINH\SQLEXPRESS;Initial Catalog=EFCoreCodeFirst-QLBH;User ID=sa;Password=123");
            }
        }
    }
}
    