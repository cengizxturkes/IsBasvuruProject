using Application.Features.OrderFeatures.Commands;
using Application.Features.OrderFeatures.Dtos;
using Application.Features.OrderFeatures.Queries;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderFeatures.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, CreatedOrderResponse>().ReverseMap();
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<Order, OrderItem>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<OrderItemDto, OrderItem>().ReverseMap();

        }
    }
}
