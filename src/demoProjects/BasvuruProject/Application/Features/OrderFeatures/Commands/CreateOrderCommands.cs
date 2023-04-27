using Application.Features.OrderFeatures.Queries;
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
         [ForeignKey("ProductId")]
        public int ProductId { get; set; }
       
        //public virtual IEnumerable<GetById> OrderItems { get; set; }


        public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreatedOrderResponse>
        {
            private readonly IProductRepository _orderItemsRepository;

            private readonly IOrderRepository _orderRepository;
            private readonly IMapper _mapper;
            private readonly IMailQueue _mailQueue;

            public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, IProductRepository orderItemsRepository, IMailQueue mailQueue)
            {
                _orderRepository = orderRepository;
                _mapper = mapper;
                _orderItemsRepository = orderItemsRepository;
                _mailQueue = mailQueue;
            }

            public async Task<CreatedOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                //    SomeFeatureEntity mappedSomeFeatureEntity = _mapper.Map<SomeFeatureEntity>(request);
                //    SomeFeatureEntity createdSomeFeatureEntity = await _someFeatureEntityRepository.AddAsync(mappedSomeFeatureEntity);
                //    CreatedSomeFeatureEntityDto createdSomeFeatureEntityDto = _mapper.Map<CreatedSomeFeatureEntityDto>(createdSomeFeatureEntity);
                Order mappedorder = _mapper.Map<Order>(request);
                Order createorder = await _orderRepository.AddAsync(mappedorder);
                createorder.Product =await _orderItemsRepository.GetAsync(x => x.Id == mappedorder.ProductId);
                _mailQueue.AddQueue(createorder);
                //foreach (var item in request.OrderItems)
                //{
                //    item.OrderID = createdOrder.Id;
                //    OrderItem mappedOrderItem = _mapper.Map<OrderItem>(item);
                //    OrderItem createdOrderItem = await _orderItemRepository.AddAsync(mappedOrderItem);
                //}

                CreatedOrderResponse response = _mapper.Map<CreatedOrderResponse>(createorder);
                return response;
            }
        }
    }
}
