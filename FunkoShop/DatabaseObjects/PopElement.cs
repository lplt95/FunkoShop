using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunkoShop.Models;

namespace FunkoShop.DatabaseObjects
{
    public class PopElement
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Collection { get; set; }
        public FunkoPopModel ConvertToModel(PopElement element)
        {
            return new FunkoPopModel()
            {
                Collection = element.Collection,
                Description = element.Description,
                Price = element.Price,
                ProductName = element.Name
            };
        }
    }
}
