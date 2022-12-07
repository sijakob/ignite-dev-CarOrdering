using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using graphql_api.Models;

namespace graphql_api.Data.ContextConfigurations
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
                        Id = _ids[0],
                        Manufacturer = "Michelin",
                        SeasonType = SeasonType.Summer
                    },

                    new Tyres
                    {
                        Id = _ids[1],
                        Manufacturer = "Continental",
                        SeasonType = SeasonType.WinterNoStud
                    }
                );

        }

    }
}