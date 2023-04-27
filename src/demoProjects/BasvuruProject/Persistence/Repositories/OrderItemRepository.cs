using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class OrderItemRepository : EfRepositoryBase<OrderItem, BaseDbContext>, IOrderItemsRepository
    {
        public OrderItemRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
