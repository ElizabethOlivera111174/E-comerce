using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class User : EntityBase
    {
        [Required(ErrorMessage = "Ingrese su nombre")]
        [Column(TypeName = "VARCHAR(255)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ingrese su apellido")]
        [Column(TypeName = "VARCHAR(255)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Ingrese su correo electronico")]
        [Column(TypeName = "VARCHAR(255)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese una contraseña valida")]
        [Column(TypeName = "VARCHAR NOT NULL")]
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
