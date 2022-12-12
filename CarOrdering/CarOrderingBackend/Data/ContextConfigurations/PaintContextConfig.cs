using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CarOrderingBackend.Models;

namespace CarOrderingBackend.Data.ContextConfigurations
{
    public class PaintContextConfig : IEntityTypeConfiguration<Paint>
    {
        private Guid[] _ids;
        public PaintContextConfig(Guid[] ids)
        {
            _ids = ids;
        }
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
                        CarId = _ids[0]
                    },

                    new Paint
                    {
                        Id = Guid.NewGuid(),
                        Color = "Night Black",
                        PaintType = PaintType.Metallic,
                        CarId = _ids[1]
                    },

                    new Paint
                    {
                        Id = Guid.NewGuid(),
                        Color = "Snow White",
                        PaintType = PaintType.Matte,
                        CarId = _ids[2]
                    }
                );
        }
    }
}