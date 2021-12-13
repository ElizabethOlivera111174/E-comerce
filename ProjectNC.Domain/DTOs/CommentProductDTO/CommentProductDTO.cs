using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs
{
    public class CommentProductDTO
    {
        [Required(ErrorMessage ="El cliente es requerido")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "El producto es requerido")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "El comentario es requerido")]
        [MaxLength(255)]
        public string Comment { get; set; }

        [Required]
        [MaxLength(255)]
        public string State { get; set; }

        [Required]
        public bool Recomend { get; set; }
    }
}
