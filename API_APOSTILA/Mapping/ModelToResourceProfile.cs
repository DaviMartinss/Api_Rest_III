using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Models;
using API_APOSTILA.Extensions;
using API_APOSTILA.Resources;
using AutoMapper;

namespace API_APOSTILA.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<User, UserResource>();

            CreateMap<Product, ProductResource>()
               .ForMember(src => src.UnitOfMeasurement,
                          opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

        }
    }
}
