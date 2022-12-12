using System.ComponentModel.DataAnnotations;

namespace CarOrderingBackend.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }


        [Required]
        public CarModel? CarModel { get; set; }
        [Required]
        public Paint? Paint { get; set; }
        [Required]
        public Rims? Rims { get; set; }  
        [Required]
        public Tyres? Tyres { get; set; }
    }
}