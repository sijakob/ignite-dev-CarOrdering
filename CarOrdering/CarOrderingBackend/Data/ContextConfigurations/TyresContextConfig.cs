using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class TyresContextConfig : IEntityTypeConfiguration<Tyres>
    {
        private Guid[] _ids;
        public TyresContextConfig(Guid[] ids)
        {
            _ids = ids;
        }
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
                        CarId = _ids[0]
                    },

                    new Tyres
                    {
                        Id = Guid.NewGuid(),
                        Manufacturer = "Continental",
                        SeasonType = SeasonType.WinterNoStud,
                        CarId = _ids[1]
                    },

                    new Tyres
                    {
                        Id = Guid.NewGuid(),
                        Manufacturer = "Pirelli",
                        SeasonType = SeasonType.WinterStud,
                        CarId = _ids[2]
                    }
                );
        }
    }
}