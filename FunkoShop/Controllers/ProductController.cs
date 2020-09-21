using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FunkoShop.DataAccess;

namespace FunkoShop.Controllers
{ 
    public class ProductController : Controller
    {
        private ProductDao productDao;
        public ProductController() : base()
        {
            productDao = new ProductDao();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet()]
        public ActionResult ShowProduct()
        {
            var pop = productDao.GetPopByPopID();
            return View("ShowProduct", pop);
        }
    }
}