using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.ClientShippingDTO
{
    public class ClientDeliveryDTO
    {
        [Required(ErrorMessage = "El id del envio es requerido")]
        public int DeliveryId { get; set; }

        [Required(ErrorMessage = "El id del cliente es requerido")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage ="El apellido es requerido")]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        public int PhoneNumber { get; set; }
    }
}
