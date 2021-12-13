using AutoMapper;
using ProjectNC.Domain.DTOs.ClientBilling;
using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Profiles
{
    public class ClientBillingProfile : Profile
    {
        public ClientBillingProfile()
        {
            CreateMap<ClientBilling, ClientBillingDTO>().ReverseMap();
        }
    }
}
