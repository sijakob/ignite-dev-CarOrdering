using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class CarModelContextConfig : IEntityTypeConfiguration<CarModel>
    {
        private Guid[] _ids;
        public CarModelContextConfig(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder
                .HasData
                (
                    new CarModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "XC90",
                        ModelYear = 2020,
                        CarId = _ids[0]
                    },
                    new CarModel 
                    {
                        Id = Guid.NewGuid(),
                        Name = "S90",
                        ModelYear = 2021,
                        CarId = _ids[1]
                    },
                    new CarModel
                    {
                        Id = _ids[2],
                        Name = "V60",
                        ModelYear = 2018,
                        CarId = _ids[2]
                    }
                );
        }
    }
}