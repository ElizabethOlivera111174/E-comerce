using AutoMapper;
using ProjectNC.Domain.DTOs.ClientShippingDTO;
using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Profiles
{
    public class ClientDeliveryProfile : Profile
    {
        public ClientDeliveryProfile()
        {
            CreateMap<ClientDelivery, ClientDeliveryDTO>().ReverseMap();
        }
    }
}
