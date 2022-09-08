using Microsoft.EntityFrameworkCore;
using POS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Data
{
    public class POSDbContext : DbContext
    {
        public POSDbContext(DbContextOptions<POSDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryM> Categories { get; set; }
        public DbSet<UnitM> Units { get; set; }
        public DbSet<BrandM> Brands { get; set; }
        public DbSet<SizeM> Sizes { get; set; }
        public DbSet<ColourM> Colours { get; set; }

    }
}
