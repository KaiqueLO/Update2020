using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerServicce;

        public SellersController(SellerService sellerService)
        {
            _sellerServicce = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerServicce.FindAll();
            return View(list);
        }
    }
}