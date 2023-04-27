using Application.Features.ProductFeatures.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetByCategoryQuery : IRequest<ProductListModel>
    {
        public string Category { get; set; }

        public class GetByCategoryQueryHandler : IRequestHandler<GetByCategoryQuery, ProductListModel>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetByCategoryQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ProductListModel> Handle(GetByCategoryQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Product> products = await _productRepository.GetListAsync(index: request.Category.Length,predicate:x=>x.Category==request.Category); 
                ProductListModel productListModel = _mapper.Map<ProductListModel>(products);


                return productListModel;
                //IPaginate<Product> products = await _productRepository.GetListAsync(predicate:x=>x.Category==request.Category);
                //GetByCategoryProductResponse mappedproductListModel = _mapper.Map<GetByCategoryProductResponse>(products);
                //return mappedproductListModel;
            }
        }
    }
}
