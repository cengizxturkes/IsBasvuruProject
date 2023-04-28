using Core.Application;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderFeatures.Queries{
    public class CreatedOrderResponse:IResponse
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMail { get; set; }
        public int CustomerGSM { get; set; }
        public int TotalAmount { get; set; }
        public virtual IEnumerable<OrderItemDto> OrderItems { get; set; }=new List<OrderItemDto>();

    }
}
