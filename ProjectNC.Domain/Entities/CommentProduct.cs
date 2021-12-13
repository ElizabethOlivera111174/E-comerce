using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class CommentProduct : EntityBase
    {
        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Comment { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string State { get; set; }

        [Required]
        [Column(TypeName = "BOOL")]
        public bool Recomend { get; set; }
    }
}
