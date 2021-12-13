using AutoMapper;
using ProjectNC.Domain.DTOs;
using ProjectNC.Domain.DTOs.PaymentDTOs;
using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Profiles
{
    public class SubCategoryProfile : Profile
    {
        public SubCategoryProfile()
        {
            CreateMap<SubCategory, SubCategoryDTO>().ReverseMap();
        }
    
    }
}
