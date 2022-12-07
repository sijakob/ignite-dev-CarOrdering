using System.ComponentModel.DataAnnotations;

namespace CarOrderingBackend.Models
{
    public enum PaintType
    {
        Regular,
        Metallic,
        Matte
    }
    public class Paint
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Color { get; set; }
        [Required]
        public PaintType PaintType { get; set; }
    }
}