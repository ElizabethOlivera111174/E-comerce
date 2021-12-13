using AutoMapper;
using ProjectNC.Domain.DTOs.NoveltyDTOs;
using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Profiles
{
    public class NoveltyProfile : Profile
    {
        public NoveltyProfile()
        {
            CreateMap<Novelty, NoveltyDTO>().ReverseMap();
        }
    }
}
