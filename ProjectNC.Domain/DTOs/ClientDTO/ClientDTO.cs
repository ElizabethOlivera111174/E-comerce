using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.DeliveryDTOs
{
    public class ClientDTO
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [MaxLength(320)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [MaxLength(255)]
        public string Password { get; set; }
    }
}
