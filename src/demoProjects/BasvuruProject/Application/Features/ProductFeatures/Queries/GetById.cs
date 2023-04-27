using Application.Features.ProductFeatures.Dtos;
using Application.Features.ProductFeatures.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetById : IRequest<ProductGetByIdDto>
    {
        public int Id { get; set; }

        public class GetByIdHandler : IRequestHandler<GetById, ProductGetByIdDto>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetByIdHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ProductGetByIdDto> Handle(GetById request, CancellationToken cancellationToken)
            {
                Product?products = await _productRepository.GetAsync(b=>b.Id==request.Id);
                ProductGetByIdDto productListModel = _mapper.Map<ProductGetByIdDto>(products);


                return productListModel;
                //IPaginate<Product> products = await _productRepository.GetListAsync(predicate:x=>x.Category==request.Category);
                //GetByCategoryProductResponse mappedproductListModel = _mapper.Map<GetByCategoryProductResponse>(products);
                //return mappedproductListModel;
            }
        }
    }
}
