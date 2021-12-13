using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNC.Domain.Entities
{
    public class Order : EntityBase
    {
        [ForeignKey("Client")]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Seleccione su forma de pago")]
        public EPaymentType PaymentType { get; set; }

        [ForeignKey("Delivery")]
        public int DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Ingrese su numero de telefono")]
        [Column(TypeName = "INTEGER")]
        public int Phone { get; set; }

        public int TotalItems { get; set; }

        [ForeignKey("Offer")]
        public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }

        [Required]
        [Column(TypeName ="DOUBLE")]
        public double Total { get; set; }

        public EStatus Status { get; set; }
    }

    public enum EStatus
    {
        [Description("En proceso")] InProcess = 1,
        [Description("Pendiente pago-transferencia")] PendingTransfer,
        [Description("Pendiente pago-efectivo")] PendingCash,
        [Description("Enviado ")] Sent,
        [Description("Entregada ")] Completed,
    }
}