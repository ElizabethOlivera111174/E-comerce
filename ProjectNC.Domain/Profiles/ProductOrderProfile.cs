using System;
using AutoMapper;
using ProjectNC.Domain.DTOs.ProductOrder;
using ProjectNC.Domain.Entities;

namespace ProjectNC.Domain.Profiles
{
    public class ProductOrderProfile : Profile
    {
         public ProductOrderProfile()
        {
            CreateMap<ProductOrder, ProductOrderDTO>().ReverseMap();
        }
    }
}
