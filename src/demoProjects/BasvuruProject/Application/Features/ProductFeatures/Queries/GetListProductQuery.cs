using Application.Features.ProductFeatures.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
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
    public class GetListProductQuery : IRequest<ProductListModel>
    {
        public PageRequest PageRequest;
        public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, ProductListModel>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mappper;

            public GetListProductQueryHandler(IProductRepository productRepository, IMapper mappper)
            {
                _productRepository = productRepository;
                _mappper = mappper;
            }

            public async Task<ProductListModel> Handle(GetListProductQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Product> products = await _productRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                ProductListModel mappedproductListModel = _mappper.Map<ProductListModel>(products);
                return mappedproductListModel;
            }
        }
    }
}
