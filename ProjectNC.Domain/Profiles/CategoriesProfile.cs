using System;
using AutoMapper;
using ProjectNC.Domain.DTOs.CategoriesDTOs;
using ProjectNC.Domain.Entities;

namespace ProjectNC.Domain.Profiles
{
    public class CategoriesProfile : Profile
    {
        public CategoriesProfile()
        {
            CreateMap<Category, CategoriesDTO>().ReverseMap();
        }
    }
}
