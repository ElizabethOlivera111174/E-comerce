using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class Delivery : EntityBase
    {
        [Required(ErrorMessage = "Ingrese el nombre del envio")]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ingrese la descripcion del envio")]
        [Column(TypeName = "VARCHAR(255)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de productos")]
        [Column(TypeName = "DOUBLE")]
        public double Quantity { get; set; }

        [Column(TypeName = "DOUBLE")]
        public double MinQuantity { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
