using AutoMapper;
using ProjectNC.Domain.DTOs.DeliveryDTOs;
using ProjectNC.Domain.DTOs.ImagenDTOs;
using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Profiles
{
    public class ImageProfile : Profile
    {
           public ImageProfile()
        {
            CreateMap<Image, ImageDTO>().ReverseMap();
        }
    }
}
