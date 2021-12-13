using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNC.Domain.Entities
{
    public class SubCategory: EntityBase
    {
        [Required(ErrorMessage = "El nombre de la subcategoria es requerido")]
        [Column(TypeName = "VARCHAR (255)")]
        public string Name {set; get;}

        [Required(ErrorMessage = "La descripcion es requerida")]
        [Column(TypeName = "VARCHAR (255)")]
        public string Description {set; get;}

        [Required(ErrorMessage = "El criterio de busqueda es requerido")]
        [Column(TypeName = "VARCHAR (255)")]
        public string MetaTitulo {set; get;}

    }
}
