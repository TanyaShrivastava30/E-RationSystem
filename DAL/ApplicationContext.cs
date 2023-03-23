using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Role> role { get; set; }
        public DbSet<Login> login { get; set; }

        public DbSet<Consumer> consumer { get; set; }

        public DbSet<Stock> stock { get; set; }

        public DbSet<Card_Stock> cardType { get; set; }

        public DbSet<Distributor> distributor { get; set; }

        public DbSet<Supplier> supplier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conString = @"server=127.0.0.1; uid=root; password=Root@123; database=rationsystem";
            options.EnableSensitiveDataLogging();
            options.UseMySql(conString, ServerVersion.AutoDetect(conString));
        }
    }
}
