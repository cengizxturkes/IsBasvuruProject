using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Order:Entity
    {
        public string CustomerName { get; set; }
        public string CustomerMail { get; set; }
        public int CustomerGSM { get; set; }
        public int TotalAmount { get; set; }
        public virtual IEnumerable<OrderItem> OrderItems { get; set; }

    }
}
