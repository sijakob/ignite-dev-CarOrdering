using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarOrderingBackend.Models
{
    public enum SeasonType
    {
        Summer,
        WinterStud,
        WinterNoStud
    }
    public class Tyres
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Manufacturer { get; set; }
        public SeasonType SeasonType { get; set; }

        [ForeignKey("CarId")]
        public Guid CarId { get; set; }
        public Car Car { get; set; }
    }
}