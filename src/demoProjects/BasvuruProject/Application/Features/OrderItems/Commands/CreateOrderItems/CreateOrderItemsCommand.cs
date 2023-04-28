using Application.Features.OrderItems.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderItems.Commands.CreateOrderItems
{
    public class CreateOrderItemCommand
 : IRequest<CreatedOrderItemDto>
    {

        public int ProductID { get; set; }
        

        public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, CreatedOrderItemDto>
        {
            private readonly IOrderItemsRepository _orderItemRepository;
            private readonly IMapper _mapper;


            public CreateOrderItemCommandHandler(IOrderItemsRepository orderItemRepository, IMapper mapper)
            {
                _orderItemRepository = orderItemRepository;
                _mapper = mapper;

            }

            public async Task<CreatedOrderItemDto> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
            {


                OrderItem orderItem = _mapper.Map<OrderItem>(request);
                OrderItem createdOrderItem = await _orderItemRepository.AddAsync(orderItem);
                CreatedOrderItemDto createdOrderItemDto = _mapper.Map<CreatedOrderItemDto>(createdOrderItem);

                return createdOrderItemDto;

            }
        }
    }
}