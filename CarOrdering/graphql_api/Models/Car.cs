using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace graphql_api.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("CarModelId")]
        public Guid CarModelId { get; set; }

        [ForeignKey("PaintId")]
        public Guid PaintId { get; set; }

        [ForeignKey("RimId")]
        public Guid RimId { get; set; }

        [ForeignKey("TyreId")]
        public Guid TyreId { get; set; }
    }
}