using AutoMapper;
using ProjectNC.Domain.DTOs;
using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Profiles
{
    public class CommentProductProfile : Profile
    {
        public CommentProductProfile()
        {
            CreateMap<CommentProduct, CommentProductDTO>().ReverseMap();
        }
    }
}
