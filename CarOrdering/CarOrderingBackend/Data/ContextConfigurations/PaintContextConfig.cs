using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class PaintContextConfig : IEntityTypeConfiguration<Paint>
    {

        public void Configure(EntityTypeBuilder<Paint> builder)
        {
            builder
                .HasData
                (
                    new Paint
                    {
                        Id = Guid.NewGuid(),
                        Color = "Midnight Blue",
                        PaintType = PaintType.Regular,
                   
                    },

                    new Paint
                    {
                        Id = Guid.NewGuid(),
                        Color = "Night Black",
                        PaintType = PaintType.Metallic,
                   
                    },

                    new Paint
                    {
                        Id = Guid.NewGuid(),
                        Color = "Snow White",
                        PaintType = PaintType.Matte,
                 
                    }
                );
        }
    }
}