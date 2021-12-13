using Microsoft.EntityFrameworkCore;
using ProjectNC.Domain.Entities;
using ProjectNC.Domain.Helpers.Commons;
using System;

namespace ProjectNC.Infrastructure.Data
{

    /// <summary>
    /// ModelBuidlerExtension es donde volcamos los Seeds para la Db
    /// </summary>
    public static class ModelBuilderExtension
    {
        public static void OfferSeed(this ModelBuilder builder)
        {
            builder.Entity<Offer>()
                .HasData
                (
                    new Offer
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = $"Seed Oferta Descuento Total",
                        Description = "Se hace un descuento del 15% sobre la compra total",
                        Quantity = 0.15,
                        OfferType = EOfferType.Percentage,
                        OfferQuantity = EOfferQuantity.Total,
                        PromoCode = "all15promo"
                    },
                    new Offer
                    {
                        Id = 2,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = $"Seed Oferta Fija Envio",
                        Description = "Oferta por $300 pesos",
                        Quantity = 300,
                        OfferType = EOfferType.Fixed,
                        OfferQuantity = EOfferQuantity.OnDelivery,
                        PromoCode = "delivery300promo"
                    },
                    new Offer
                    {
                        Id = 3,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = $"Seed Oferta Descuento Envio",
                        Description = "Oferta del 10% del costo de envio",
                        Quantity = 0.10,
                        OfferType = EOfferType.Percentage,
                        OfferQuantity = EOfferQuantity.OnDelivery,
                        PromoCode = "delivery10promo"
                    },
                    new Offer
                    {
                        Id = 4,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = $"Seed Oferta Fija Total",
                        Description = "Oferta por $1000 del total de tu compra",
                        Quantity = 1000,
                        OfferType = EOfferType.Fixed,
                        OfferQuantity = EOfferQuantity.Total,
                        PromoCode = "all1000promo"
                    }
                );
        }
        public static void DeliverySeed(this ModelBuilder builder)
        {
            builder.Entity<Delivery>()
                .HasData
                (
                    new Delivery
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = "Seed Delivery para cliente",
                        Description = "Se entrega con un minimo de 2 unidades",
                        MinQuantity = 2,
                        Quantity = 2,
                        OrderId = 1,
                    },
                    new Delivery
                    {
                        Id = 2,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = "Seed Delivery para cliente 2",
                        Description = "Se entrega con un minimo de 2 unidades",
                        MinQuantity = 2,
                        Quantity = 5,
                        OrderId = 2,
                    }
                );
        }
        public static void PaymentSeed(this ModelBuilder builder)
        {
            builder.Entity<Payment>()
                .HasData
                (
                    new Payment
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = "Pago Seeded 1",
                        Description = "Descripcion de pago seed 1, Efectivo",
                        PaymentType = EPaymentType.Cash
                    },
                    new Payment
                    {
                        Id = 2,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true,
                        Name = "Pago Seeded 1",
                        Description = "Descripcion de pago seed 2, Transferencia",
                        PaymentType = EPaymentType.WireTransfer
                    }
                );
        }
        public static void ClientSeed(this ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasData
                (
                    new Client
                    {
                        Id = 1,
                        Name = "Nombre1",
                        LastName = "Apellido1",
                        Email = "email@cliente1.com",
                        Password = "123456",
                        CreatedAt = new DateTime(2020, 11, 15),
                        Active = true
                    },
                    new Client
                    {
                        Id = 2,
                        Name = "Nombre2",
                        LastName = "Apellido2",
                        Email = "email@cliente2.com",
                        Password = "123456",
                        CreatedAt = new DateTime(2019, 11, 15),
                        Active = true
                    }
                );
        }
        public static void ClientDeliverySeed(this ModelBuilder builder)
        {
            builder.Entity<ClientDelivery>()
                .HasData
                (
                    new ClientDelivery
                    {
                        Id = 1,
                        ClientId = 1,
                        DeliveryId = 1,
                        Name = "Nombre1",
                        LastName = "Apellido1",
                        PhoneNumber = 12345678,
                        CreatedAt = new DateTime(2020, 11, 15),
                        Active = true
                    },
                    new ClientDelivery
                    {
                        Id = 2,
                        ClientId = 2,
                        DeliveryId = 2,
                        Name = "Nombre2",
                        LastName = "Apellido2",
                        PhoneNumber = 12345678,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true
                    }
                );
        }
        public static void ClientBillingSeed(this ModelBuilder builder)
        {
            builder.Entity<ClientBilling>()
                .HasData
                (
                    new ClientBilling
                    {
                        Id = 1,
                        ClientId = 1,
                        OrderId = 1,
                        Name = "Nombre1",
                        LastName = "Apellido1",
                        PhoneNumber = 12345678,
                        PostalCode = 2258,
                        CreatedAt = new DateTime(2020, 11, 15),
                        Active = true
                    },
                    new ClientBilling
                    {
                        Id = 2,
                        ClientId = 2,
                        OrderId = 2,
                        Name = "Nombre2",
                        LastName = "Apellido2",
                        PhoneNumber = 12345678,
                        PostalCode = 2258,
                        CreatedAt = new DateTime(2021, 11, 15),
                        Active = true
                    }
                );
        }
        public static void CategorySeed(this ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasData
                (
                    new Category
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 20),
                        Active = true,
                        Name = "CategoriaSeed",
                        Description = "CategoriaSeedDescription",
                        MetaTitle = "metacategory",
                        MetaDescription = "metadescription",
                        MetaData = "metadata"
                    }
                );
        }
        public static void SubCategorySeed(this ModelBuilder builder)
        {
            builder.Entity<SubCategory>()
             .HasData
               (
                   new SubCategory
                   {
                       Id = 1,
                       Name = "Lavarropas",
                       Description = "Lavado Rapido y Potente",
                       MetaTitulo = "Lavarropas"
                   }
               );

        }
        public static void ImageSeed(this ModelBuilder builder)
        {
            builder.Entity<Image>()
                .HasData
                (
                    new Image
                    {
                        ProductId = 1,
                        Description = "Lavarropas wirpul",
                        Url = "Imagen 1",
                        Alt = "Lavarropas"
                    },
                    new Image
                    {
                        ProductId = 2,
                        Description = "Lavarropas Aurora",
                        Url = "Imagen 2",
                        Alt = "Lavarropas"
                    }
                );
        }
        public static void UserSeed(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData
                (
                    new User
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 19),
                        Active = true,
                        FirstName = "NombreSeed1",
                        LastName = "Apellido1Seed1",
                        Email = "example1@example.com",
                        Password = Encrypt.GetSHA256("123456789"),
                        RoleId = 1
                    },
                    new User
                    {
                        Id = 2,
                        CreatedAt = new DateTime(2021, 11, 19),
                        Active = true,
                        FirstName = "NombreSeed2",
                        LastName = "Apellido1Seed2",
                        Email = "example2@example.com",
                        Password = Encrypt.GetSHA256("123456789"),
                        RoleId = 2
                    },
                    new User
                    {
                        Id = 3,
                        CreatedAt = new DateTime(2021, 11, 19),
                        Active = true,
                        FirstName = "NombreSeed3",
                        LastName = "Apellido1Seed3",
                        Email = "example3@example.com",
                        Password = Encrypt.GetSHA256("123456789"),
                        RoleId = 3
                    }
                );
        }
        public static void RolesSeed(this ModelBuilder builder)
        {
            builder.Entity<Role>()
                .HasData
                (
                    new Role
                    {
                        Id = 1,
                        CreatedAt = DateTime.Now,
                        Active = true,
                        Name = "User",
                        Description = "User: puede hacer compras, ventas. Pueden modificar solo sus datos, no los de otros"
                    },
                    new Role
                    {
                        Id = 2,
                        CreatedAt = DateTime.Now,
                        Active = true,
                        Name = "Admin",
                        Description = "Admin: puede modificar datos de cualquier usuario, asi como agregar entradas a la base de datos"
                    },
                    new Role
                    {
                        Id = 3,
                        CreatedAt = DateTime.Now,
                        Active = true,
                        Name = "SuperUser",
                        Description = "SuperUser: puede modificar algunos datos y metadatos, tambien tiene acceso al sistema completo"
                    }
                );
        }
        public static void OrdersSeed(this ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasData
                (
                    new Order
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 19),
                        Active = true,
                        ClientID = 1,
                        PaymentType = EPaymentType.WireTransfer,
                        DeliveryId = 1,
                        Date = DateTime.UtcNow,
                        Phone = 1138313792,
                        TotalItems = 2,
                        Total = 50000,
                        Status = EStatus.InProcess
                    }
                );
        }
        public static void ProductSeed(this ModelBuilder buidler)
        {
            buidler.Entity<Product>()
               .HasData
               (
                   new Product
                   {
                       Id = 1,
                       Name = "Lavarropas",
                       Description = "wirpul",
                       Price = 45000,
                       MetaTitle = "Electro",
                       MetaDescription = "Linea blanca",
                       CategoryId = 1,
                       SubCategoryId = 1,
                       CreatedAt = new DateTime(2020, 11, 15),
                       Active = true
                   },
                   new Product
                   {
                       Id = 2,
                       Name = "Lavarropas",
                       Description = "Aurora",
                       Price = 40000,
                       MetaTitle = "Electro",
                       MetaDescription = "Linea blanca",
                       CategoryId = 2,
                       SubCategoryId = 2,
                       CreatedAt = new DateTime(2019, 11, 15),
                       Active = true
                   }
               );
        }
        public static void ProductOrederSeed(this ModelBuilder buidler)
        {
            buidler.Entity<ProductOrder>()
                .HasData
                (
                    new ProductOrder
                    {
                        Id = 1,
                        OrderId = 1,
                        UserId = 1,
                        ProductId = 1,
                        OfferId = 1,
                        Name = "Imagen 1",
                        CatalogPrice = 123,
                        OrderPrice = 123,
                        DateOrder = new DateTime(2020, 11, 15)
                    },
                    new ProductOrder
                    {
                        Id = 2,
                        OfferId = 2,
                        UserId = 2,
                        ProductId = 2,
                        OrderId = 2,
                        Name = "Imagen 1",
                        CatalogPrice = 123,
                        OrderPrice = 123,
                        DateOrder = new DateTime(2020, 11, 15)
                    }
                );
        }
        public static void CommentProductSeed(this ModelBuilder buidler)
        {
            buidler.Entity<CommentProduct>()
               .HasData
               (
                   new CommentProduct
                   {
                       Id = 1,
                       ClientId = 2,
                       ProductId = 2,
                       Comment = "no compren",
                       State = "entregado",
                       Recomend = false,
                       CreatedAt = new DateTime(2020, 11, 15),
                       Active = true
                   },
                   new CommentProduct
                   {
                       Id = 2,
                       ClientId = 1,
                       ProductId = 1,
                       Comment = "funcional",
                       State = "entregado",
                       Recomend = true,
                       CreatedAt = new DateTime(2019, 11, 15),
                       Active = true
                   }
               );
        }
        public static void NoveltiesSeed(this ModelBuilder builder)
        {
            builder.Entity<Novelty>()
                .HasData
                (
                    new Novelty
                    {
                        Id = 1,
                        CreatedAt = new DateTime(2021, 11, 20),
                        Active = true,
                        Name = "NovedadSeed1",
                        Email = "novedadseed1@example.com",
                        Description = "DescripcionSeed1"
                    },
                    new Novelty
                    {
                        Id = 2,
                        CreatedAt = new DateTime(2021, 11, 20),
                        Active = true,
                        Name = "NovedadSeed2",
                        Email = "novedadseed2@example.com",
                        Description = "DescripcionSeed2"
                    }
                );
        }
    }
}
