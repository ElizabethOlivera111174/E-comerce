using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNC.Domain.Entities
{
    public class Category: EntityBase
    {
        [Required(ErrorMessage = "Nombre de la categoria es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Name {get; set;}

        [Required(ErrorMessage = "La descripcion es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Description {get; set;}

        [Required(ErrorMessage = "El criterio de busqueda es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string MetaData {get; set;}

        [Required(ErrorMessage = "El criterio de busqueda es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string MetaTitle {get;set;}

        [Required(ErrorMessage = "El criterio de busqueda es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string MetaDescription {get; set;}

    }
}
