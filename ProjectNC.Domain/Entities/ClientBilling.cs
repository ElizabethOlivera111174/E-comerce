using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class ClientBilling : EntityBase
    {
        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

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

        [Required]
        [Column(TypeName = "INTEGER")]
        public int PostalCode { get; set; }
    }
}
