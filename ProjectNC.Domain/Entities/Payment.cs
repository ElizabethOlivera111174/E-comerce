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
    public class Payment : EntityBase
    {
        [Required(ErrorMessage = "Ingrese el nombre de la compra")]
        [Column(TypeName = "VARCHAR(255)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Description { get; set; }

        [Required]
        public EPaymentType PaymentType { get; set; }
    }

    public enum EPaymentType
    {
        [Description("Transferencia Bancaria")] WireTransfer = 1,
        [Description("Efectivo")] Cash = 2
    }
}
