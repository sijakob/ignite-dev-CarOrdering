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
                        Id = _ids[0],
                        Color = "Midnight Blue",
                        PaintType = PaintType.Regular
                    },

                    new Paint
                    {
                        Id = _ids[1],
                        Color = "Space Black",
                        PaintType = PaintType.Metallic
                    }
                );
        }
    }
}