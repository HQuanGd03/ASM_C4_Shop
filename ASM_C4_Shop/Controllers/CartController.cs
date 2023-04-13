using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;
using ASM_C4_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM_C4_Shop.Controllers
{
    public class CartController : Controller
    {
   
        private readonly ICartServices cartServices;
    
        public CartController() {

            cartServices = new CartServices();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
