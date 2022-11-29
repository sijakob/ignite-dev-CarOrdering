using Microsoft.EntityFrameworkCore;

namespace CarOrderingBackend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarModel> CarModels { get; set; }

        //Where to store Sqlite Db

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data source= Database\CarDb.db");
    }
}
