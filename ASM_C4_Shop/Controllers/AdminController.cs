using Microsoft.AspNetCore.Mvc;

namespace ASM_C4_Shop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
