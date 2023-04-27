using Application.Features.ProductFeatures.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Models
{
    public class ProductListModel : BasePageableModel
    {
        public IList<ProductDto> Items { get; set; }
    }
}
