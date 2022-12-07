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
                        Id = _ids[0],
                        Name = "XC90",
                        ModelYear = 2020
                    },
                    new CarModel 
                    {
                        Id = _ids[1],
                        Name = "S90",
                        ModelYear = 2021
                    },
                    new CarModel
                    {
                        Id = _ids[2],
                        Name = "V60",
                        ModelYear = 2018
                    }
                );
        }
    }
}