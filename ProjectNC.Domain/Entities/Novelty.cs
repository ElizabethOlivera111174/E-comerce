using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class Novelty : EntityBase
    {
        [Required(ErrorMessage = "Ingrese el nombre de la novedad")]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)     ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese la descripcion")]
        [Column(TypeName = "VARCHAR")]
        public string Description { get; set; }

    }
}
