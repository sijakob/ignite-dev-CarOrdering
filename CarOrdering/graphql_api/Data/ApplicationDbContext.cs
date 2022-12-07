using Microsoft.EntityFrameworkCore;
using graphql_api.Data.ContextConfigurations;
using graphql_api.Models;


namespace graphql_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var CarModelIds = new Guid[] {Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()};
            var PaintIds = new Guid[] {Guid.NewGuid(), Guid.NewGuid()};
            var RimsIds = new Guid[] {Guid.NewGuid(), Guid.NewGuid()};
            var TyreIds = new Guid[] {Guid.NewGuid(), Guid.NewGuid()};

            builder.ApplyConfiguration(new CarContextConfig(CarModelIds, PaintIds, RimsIds, TyreIds));
            builder.ApplyConfiguration(new CarModelContextConfig(CarModelIds));
            builder.ApplyConfiguration(new PaintContextConfig(PaintIds));
            builder.ApplyConfiguration(new RimsContextConfig(RimsIds));
            builder.ApplyConfiguration(new TyresContextConfig(TyreIds));
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Paint> Paints { get; set; }
        public DbSet<Rims> Rims { get; set; }
        public DbSet<Tyres> Tyres { get; set; }
    }
}