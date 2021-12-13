using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.PaymentDTOs
{
    public class PaymentDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public EPaymentType PaymentType { get; set; }
    }
}
