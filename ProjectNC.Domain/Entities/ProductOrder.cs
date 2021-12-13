using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNC.Domain.Entities
{
    public class ProductOrder : EntityBase
    {
        [Required]
        [ForeignKey("Order")]
        public int OrderId {get; set;}

        [Required]
        [ForeignKey("User")]

        public int UserId {get; set;}

        [Required]
        [ForeignKey("Product")]
        public int  ProductId {get; set;}

        [Required]
        [ForeignKey("Offer")]
        public int  OfferId {get; set;}

        [Required(ErrorMessage = "Nombe del prudcto")]
        [Column(TypeName = "VARCHAR")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Inserte una cantidad de Unidades")]
        [Column(TypeName = "INTEGER")]
        public int Units {get; set;}

        [Required(ErrorMessage = "Inserte Precio de Catalogo")]
        [Column(TypeName = "DOUBLE")]
        public double CatalogPrice {get; set;}

        [Required(ErrorMessage = "Inserte Precio Pedido")]
        [Column(TypeName = "DOUBLE")]
        public double OrderPrice {get; set;}

        [Required(ErrorMessage = "Inserte Fecha de Pedido")]
        [DataType(DataType.DateTime)]
        public DateTime DateOrder {get; set;}
    }    
}
