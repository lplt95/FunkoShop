using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoShop.Models
{
    public class UserModel
    {
        public string Login { get; set; }
        public string ActiveBasketID { get; set; }
        public int ID { get; set; }
        public override string ToString()
        {
            return Login;
        }
    }
}
