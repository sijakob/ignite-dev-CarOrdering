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
                        Id = _ids[0],
                        Name = "Dragmaster",
                        Size = 18
                    },

                    new Rims
                    {
                        Id = _ids[1],
                        Name = "Occult",
                        Size = 19
                    }
                );
        }
    }
}