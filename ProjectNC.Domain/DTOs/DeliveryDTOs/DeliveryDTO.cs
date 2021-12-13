using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.DeliveryDTOs
{
    public class DeliveryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double MinQuantity { get; set; }
        public int OrderId { get; set; }
    }
}
