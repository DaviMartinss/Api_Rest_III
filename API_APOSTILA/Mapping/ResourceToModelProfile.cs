using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Models;
using API_APOSTILA.Resources;
using AutoMapper;

namespace API_APOSTILA.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
             CreateMap<SaveProductResource, Product>();
            CreateMap<SaveUserResource, User>();

            CreateMap<AuthUserResource, User>();
        }
    }
}
