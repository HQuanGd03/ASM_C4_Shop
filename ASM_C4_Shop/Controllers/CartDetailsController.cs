using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;
using ASM_C4_Shop.Services;
using Microsoft.AspNetCore.Mvc;


namespace ASM_C4_Shop.Controllers
{
    public class CartDetailsController : Controller
    {
        private readonly IProductServices productServices;// Interface
        private readonly ICartDetailsServices cartDetailsServices;// Interface

        public IActionResult Index()
        {
            return View();
        }
        public CartDetailsController()
        {
            productServices=new ProductServices();
            cartDetailsServices = new CartDetailsServices();
        }
  
    }
}
