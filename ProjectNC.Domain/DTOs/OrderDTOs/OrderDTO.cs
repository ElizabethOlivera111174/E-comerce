using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.OrderDTOs
{
    public class OrderDTO
    {
        public int ClientID { get; set; }
        public EPaymentType PaymentType { get; set; }
        public int DeliveryId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Ingrese su numero de telefono")]
        public int Phone { get; set; }
        public int TotalItems { get; set; }

        public int OfferId { get; set; }

        [Required]
        public double Total { get; set; }
        public EStatus Status { get; set; }
    }
}
