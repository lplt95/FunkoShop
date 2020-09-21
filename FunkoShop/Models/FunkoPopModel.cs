using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunkoShop.DatabaseObjects;

namespace FunkoShop.Models
{
    public class FunkoPopModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Collection { get; set; }
        public string Description { get; set; }
        public PopElement ConvertToDatabase(FunkoPopModel model)
        {
            return new PopElement()
            {
                Name = model.ProductName,
                Collection = model.Collection,
                Description = model.Description,
                Price = model.Price
            };
        }
        public override string ToString()
        {
            return Collection + ", " + ProductName;
        }
    }
}
