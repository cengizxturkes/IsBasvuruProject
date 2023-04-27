using Application.Features.OrderFeatures.Queries;
using Application.Features.ProductFeatures.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Command
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public Decimal UnitPrice { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }



        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,ProductDto>
        {
            private readonly IProductRepository _productRepository;

            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper) { 
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //    SomeFeatureEntity mappedSomeFeatureEntity = _mapper.Map<SomeFeatureEntity>(request);
                //    SomeFeatureEntity createdSomeFeatureEntity = await _someFeatureEntityRepository.AddAsync(mappedSomeFeatureEntity);
                //    CreatedSomeFeatureEntityDto createdSomeFeatureEntityDto = _mapper.Map<CreatedSomeFeatureEntityDto>(createdSomeFeatureEntity);
                Product mappedproduct = _mapper.Map<Product>(request);
                Product creatproduct = await _productRepository.AddAsync(mappedproduct);

                //foreach (var item in request.OrderItems)
                //{
                //    item.OrderID = createdOrder.Id;
                //    OrderItem mappedOrderItem = _mapper.Map<OrderItem>(item);
                //    OrderItem createdOrderItem = await _orderItemRepository.AddAsync(mappedOrderItem);
                //}

                ProductDto response = _mapper.Map<ProductDto>(creatproduct);
                return response;
            }
        }
    }
}
