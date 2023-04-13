using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;
using ASM_C4_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM_C4_Shop.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandServices brandServices;
        public BrandController()
        {
            brandServices = new BrandServices();
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAllBrand()
        {
            List<Brand> brands = brandServices.GetAllBrands();
            return View(brands);
        }

        public IActionResult CreateBrand() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(Brand p)
        {
            if (brandServices.CreateBrand(p))
            {
                return RedirectToAction("ShowAllBrand");
            }
            else return BadRequest();
        }

        public IActionResult DetailBrand(Guid id)
        {
            var brands = brandServices.GetBrandById(id);
            return View(brands);
        }
        public IActionResult DeleteBrand(Guid id)
        {
            if (brandServices.DeleteBrand(id))
            {
                return RedirectToAction("ShowAllBrand");
            }
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult EditBrand(Guid id)
        {
            var brands = brandServices.GetBrandById(id);
            return View(brands);
        }
        public IActionResult EditBrand(Brand p)
        {
            if (brandServices.UpdateBrand(p))
            {
                return RedirectToAction("ShowAllBrand");
            }
            else return BadRequest();
        }

    }
}
