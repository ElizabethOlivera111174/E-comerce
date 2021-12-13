using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs
{
    public class OfferDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public EOfferType OfferType { get; set; }
        public EOfferQuantity OfferQuantity { get; set; }
        public string PromoCode { get; set; }
    }
}
