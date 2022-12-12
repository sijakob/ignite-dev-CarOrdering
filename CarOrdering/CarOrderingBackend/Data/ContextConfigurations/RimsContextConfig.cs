using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{

    public class RimsContextConfig : IEntityTypeConfiguration<Rims>
    {
        private Guid[] _ids;
        public RimsContextConfig(Guid[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Rims> builder)
        {
            builder
                .HasData
                (
                    new Rims
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dragmaster",
                        Size = 18,
                        CarId = _ids[0]
                    },

                    new Rims
                    {
                        Id = Guid.NewGuid(),
                        Name = "Occult",
                        Size = 19,
                        CarId = _ids[1]
                    },

                    new Rims
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dream",
                        Size = 17,
                        CarId = _ids[2]
                    }
                );
        }
    }
}