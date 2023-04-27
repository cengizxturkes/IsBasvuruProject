using Application.Features.ProductFeatures.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Caching;
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
    public class GetListProductByCategoryQuery : IRequest<ProductListModel>, ICachableRequest
    {
        public string Category { get; set; }


        public bool BypassCache { get; set; }

        public string CacheKey => $"GetListProductByCategory({Category})";
        public string CacheGroupKey => "GetProducts";

        public TimeSpan? SlidingExpiration { get; }

        public class GetListProductByCategoryQueryHandler : IRequestHandler<GetListProductByCategoryQuery, ProductListModel>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mappper;

            public GetListProductByCategoryQueryHandler(IProductRepository productRepository, IMapper mappper)
            {
                _productRepository = productRepository;
                _mappper = mappper;
            }

            public async Task<ProductListModel> Handle(GetListProductByCategoryQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Product> products = await _productRepository.GetListAsync(x=>x.Category.Equals(request.Category));
                ProductListModel mappedproductListModel = _mappper.Map<ProductListModel>(products);
                return mappedproductListModel;
            }
        }
    }
}
