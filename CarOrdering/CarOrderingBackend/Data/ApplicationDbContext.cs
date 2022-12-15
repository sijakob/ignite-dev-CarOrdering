using Microsoft.EntityFrameworkCore;
using CarOrderingBackend.Data.ContextConfigurations;
using CarOrderingBackend.Models;


namespace CarOrderingBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            builder.ApplyConfiguration(new CarContextConfig(ids));
            builder.ApplyConfiguration(new CarModelContextConfig());
            builder.ApplyConfiguration(new PaintContextConfig());
            builder.ApplyConfiguration(new RimsContextConfig());
            builder.ApplyConfiguration(new TyresContextConfig());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Paint> Paints { get; set; }
        public DbSet<Rims> Rims { get; set; }
        public DbSet<Tyres> Tyres { get; set; }
    }
}