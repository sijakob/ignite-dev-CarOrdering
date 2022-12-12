using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarOrderingBackend.Models
{
    public class CarModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string? Name { get; set; }
        public int ModelYear { get; set; }


        [ForeignKey("CarId")]
        public Guid CarId { get; set; }
        public Car Car { get; set; }
    }
}