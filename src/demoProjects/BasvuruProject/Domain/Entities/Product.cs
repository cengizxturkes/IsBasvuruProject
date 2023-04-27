using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product:Entity
    {
        public Product()
        {

        }
        public Product(int Id,string Name, string Description, string Category, string Unit, Decimal UnitPrice, bool Status, DateTime CreateTime, DateTime UpdateTime)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
                this.Category = Category;
            this.Unit = Unit;
            this.UnitPrice = UnitPrice;
            this.Status = Status;
            this.CreateTime = CreateTime;
            this.UpdateTime = UpdateTime;
            
            
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public Decimal UnitPrice { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
