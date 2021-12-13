using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.ClientBilling
{
    public class ClientBillingDTO
    {
        [Required]
        public int ClientId { get; set; }
        
        [Required]
        public int OrderId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public int PostalCode { get; set; }
    }
}
