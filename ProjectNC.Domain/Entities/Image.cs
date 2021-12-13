using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNC.Domain.Entities
{
    public class Image : EntityBase
    {
        [Required]
        [ForeignKey("Product")]
        public int ProductId  {get; set;}

        [Required(ErrorMessage = "La descripcion es requerida")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
		public string Description {get; set;}

        [Required(ErrorMessage = "La Imagen es requerida")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
		public string Url {get; set;}

        [Required(ErrorMessage = "La descripcion es requerida")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
		public string Alt {get; set;}

    }
}
