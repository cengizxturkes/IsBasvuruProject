using Application.Features.OrderFeatures.Commands;
using Application.Features.ProductFeatures.Command;
using Application.Features.ProductFeatures.Dtos;
using Application.Features.ProductFeatures.Models;
using Application.Features.ProductFeatures.Queries;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<IPaginate<Product>, ProductListModel>().ReverseMap();
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Product, GetByCategoryProductResponse>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetById>().ReverseMap();
            CreateMap<Product, ProductGetByIdDto>().ReverseMap();

        }
    }
}
