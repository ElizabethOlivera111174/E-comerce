using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class ClientDelivery : EntityBase
    {
        [Required]
        [ForeignKey("Delivery")]
        public int DeliveryId { get; set; }
        public virtual Delivery Delivery { get; set; }

        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR (255)")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR (255)")]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "INTEGER")]
        public int PhoneNumber { get; set; }

    }
}
