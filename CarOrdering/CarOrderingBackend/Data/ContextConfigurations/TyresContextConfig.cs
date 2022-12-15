using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class TyresContextConfig : IEntityTypeConfiguration<Tyres>
    {

        public void Configure(EntityTypeBuilder<Tyres> builder)
        {
            builder
                .HasData
                (
                    new Tyres
                    {
                        Id = Guid.NewGuid(),
                        Manufacturer = "Michelin",
                        SeasonType = SeasonType.Summer,
                    
                    },

                    new Tyres
                    {
                        Id = Guid.NewGuid(),
                        Manufacturer = "Continental",
                        SeasonType = SeasonType.WinterNoStud,
                      
                    },

                    new Tyres
                    {
                        Id = Guid.NewGuid(),
                        Manufacturer = "Pirelli",
                        SeasonType = SeasonType.WinterStud,
                  
                    }
                );
        }
    }
}