using Application.Features.OrderFeatures.Dtos;
using Application.Features.OrderFeatures.Queries;
using Application.Features.OrderItems.Commands.CreateOrderItems;
using Application.Features.ProductFeatures.Command;
using Application.Features.ProductFeatures.Queries;
using Application.Services;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using Core.Security.Hashing;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderFeatures.Commands
{
    public class CreateOrderCommand : IRequest<CreatedOrderResponse>
    {
        public string CustomerName { get; set; }
        public string CustomerMail { get; set; }
        public int CustomerGSM { get; set; }
        public int TotalAmount { get; set; }
        public int CustomerID { get; set; }
         
       
        public virtual IEnumerable<CreateOrderItemCommand> OrderItems { get; set; }


        public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreatedOrderResponse>
        {

            private readonly IOrderRepository _orderRepository;
            private readonly IOrderItemsRepository _orderItemsRepository;
            private readonly IProductRepository _productRepository;

            private readonly IMapper _mapper;
            private readonly IMailQueue _mailQueue;

            public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, IMailQueue mailQueue, IOrderItemsRepository orderItemsRepository, IProductRepository productRepository)
            {
                _orderRepository = orderRepository;
                _mapper = mapper;
                _orderItemsRepository = orderItemsRepository;
                _mailQueue = mailQueue;
                _orderItemsRepository = orderItemsRepository;
                _productRepository = productRepository;
            }

            public async Task<CreatedOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                //    SomeFeatureEntity mappedSomeFeatureEntity = _mapper.Map<SomeFeatureEntity>(request);
                //    SomeFeatureEntity createdSomeFeatureEntity = await _someFeatureEntityRepository.AddAsync(mappedSomeFeatureEntity);
                Order mappedOrder = _mapper.Map<Order>(request);
               
                Order createdOrder = await _orderRepository.AddAsync(mappedOrder);
                CreatedOrderResponse createdOrderDto = _mapper.Map<CreatedOrderResponse>(createdOrder);

                foreach (var item in request.OrderItems)
                {
                    OrderItem mappedOrderItem = _mapper.Map<OrderItem>(item);
                    mappedOrderItem.OrderID=createdOrder.Id;
                    await _orderItemsRepository.AddAsync(mappedOrderItem);
                    mappedOrderItem.Product = _productRepository.Get(x => x.Id == item.ProductID);
                    createdOrderDto.OrderItems.Append(_mapper.Map<OrderItemDto>(mappedOrderItem));

                }
                _mailQueue.AddQueue(mappedOrder);
                return createdOrderDto;
            }
        }
    }
}
