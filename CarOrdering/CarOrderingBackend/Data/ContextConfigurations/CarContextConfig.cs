using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;


namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class CarContextConfig : IEntityTypeConfiguration<Car>
    {
        private Guid[] _ids;
        public CarContextConfig() 
        {
        }

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasData
                (
                    new Car
                    {
                        Id = _ids[0],
                        Name = "CustomCar1"
                    },

                    new Car
                    {
                        Id = _ids[1],
                        Name = "CustomCar2"
                    },

                    new Car
                    {
                        Id = _ids[2],
                        Name = "CustomCar3"
                    }
                );
        }
        
    }   
}