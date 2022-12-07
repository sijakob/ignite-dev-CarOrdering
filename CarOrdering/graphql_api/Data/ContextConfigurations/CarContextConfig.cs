using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using graphql_api.Models;


namespace graphql_api.Data.ContextConfigurations
{
    public class CarContextConfig : IEntityTypeConfiguration<Car>
    {
        private Guid[] _carModelIds;
        private Guid[] _paintIds;
        private Guid[] _rimsIds;
        private Guid[] _tyresIds;
        public CarContextConfig(Guid[] carModelIds, Guid[] paintIds, Guid[] rimsIds, Guid[] tyresIds) 
        {
            _carModelIds = carModelIds;
            _paintIds = paintIds;
            _rimsIds = rimsIds;
            _tyresIds = tyresIds;
        }

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasData
                (
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        CarModelId = _carModelIds[0],
                        PaintId = _paintIds[0],
                        RimId = _rimsIds[0],
                        TyreId = _tyresIds[0]
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        CarModelId = _carModelIds[1],
                        PaintId = _paintIds[1],
                        RimId = _rimsIds[1],
                        TyreId = _tyresIds[1]
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        CarModelId = _carModelIds[2],
                        PaintId = _paintIds[0],
                        RimId = _rimsIds[1],
                        TyreId = _tyresIds[0]
                    }
                );
        }
        
    }   
}