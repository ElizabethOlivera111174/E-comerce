using System;

namespace ProjectNC.Domain.DTOs.ProductOrder
{
    public class ProductOrderDTO
    {
        public int IdOrder {get; set;}
        public int IdUser {get; set;}
        public int  IdProduct {get; set;}
        public int IdOffer {get; set;}
        public string Name {get; set;}
        public double CatalogPrice {get; set;}

        public double OrderPrice {get; set;}
        public DateTime DateOrder {get; set;}
    }
}
