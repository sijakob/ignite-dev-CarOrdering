using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{

    public class RimsContextConfig : IEntityTypeConfiguration<Rims>
    {

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
               
                    },

                    new Rims
                    {
                        Id = Guid.NewGuid(),
                        Name = "Occult",
                        Size = 19,
                 
                    },

                    new Rims
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dream",
                        Size = 17,
                 
                    }
                );
        }
    }
}