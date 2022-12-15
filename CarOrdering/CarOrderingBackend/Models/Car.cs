using System.ComponentModel.DataAnnotations;

namespace CarOrderingBackend.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }


      
        public CarModel? CarModel { get; set; }
      
        public Paint? Paint { get; set; }
     
        public Rims? Rims { get; set; }  
     
        public Tyres? Tyres { get; set; }
    }
}