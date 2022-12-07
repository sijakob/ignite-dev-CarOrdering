using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace graphql_api.Models
{
    public class CarModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string? Name { get; set; }
        public int ModelYear { get; set; }
    }
}