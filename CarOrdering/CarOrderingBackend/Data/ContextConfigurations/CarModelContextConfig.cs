using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class CarModelContextConfig : IEntityTypeConfiguration<CarModel>
    {


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
               
                    },
                    new CarModel 
                    {
                        Id = Guid.NewGuid(),
                        Name = "S90",
                        ModelYear = 2021,
                  
                    },
                    new CarModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "V60",
                        ModelYear = 2018,
                 
                    }
                );
        }
    }
}