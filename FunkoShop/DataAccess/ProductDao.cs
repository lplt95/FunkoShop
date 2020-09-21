using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunkoShop.Models;

namespace FunkoShop.DataAccess
{
    public class ProductDao
    {
        public FunkoPopModel GetPopByPopID()
        {
            return new FunkoPopModel()
            {
                ProductName = "Albus Dumbledore",
                Collection = "Harry Potter",
                Description = "Albus Dumbledore in test version.",
                Price = (decimal)59.99
            };

        }
    }
}
