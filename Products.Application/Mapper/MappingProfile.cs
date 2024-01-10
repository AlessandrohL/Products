using AutoMapper;
using Products.Application.DTOs;
using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }

    }
}
