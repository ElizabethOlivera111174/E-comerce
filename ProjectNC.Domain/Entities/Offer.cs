using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class Offer : EntityBase
    {
        [Required(ErrorMessage = "El nombre de la oferta es requerido")]
        [Column(TypeName = "VARCHAR (255)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Especifique una descripcion")]
        [Column(TypeName = "VARCHAR")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Inserte una cantidad de oferta")]
        [Column(TypeName = "DOUBLE")]
        public double Quantity { get; set; }

        [Required(ErrorMessage = "Tipo de Oferta")]
        [Column(TypeName = "INTEGER")]
        public EOfferType OfferType { get; set; }

        [Required(ErrorMessage = "Cantidad de la Oferta")]
        [Column(TypeName = "INTEGER")]
        public EOfferQuantity OfferQuantity { get; set; }

        [Column(TypeName = "VARHCAR(255)")]
        public string PromoCode { get; set; }
    }
    public enum EOfferType
    {
        [Description("Ninguna")] Any,
        [Description("Fijo")] Fixed,
        [Description("Porcentaje")] Percentage
    }
    public enum EOfferQuantity
    {
        [Description("En Total")] Total = 1,
        [Description("Sobre envio")] OnDelivery
    }
}
