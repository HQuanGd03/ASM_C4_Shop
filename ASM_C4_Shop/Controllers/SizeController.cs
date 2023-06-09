﻿using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;
using ASM_C4_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM_C4_Shop.Controllers
{
    public class SizeController : Controller
    {
        private readonly ISizeServices sizeServices;// Interface

        public SizeController()
        {
            sizeServices = new SizeServices();
        }
        public IActionResult Index()
        {
            return View();
        }

        //show size
        public ActionResult ShowAllSize()
        {

            List<Size> sizes = sizeServices.GetAllSizes();
            return View(sizes); // Truyền trực tiếp 1 Obj Model duy nhất sang View

        }

        //thêm sửa xóa Size
        public IActionResult CreateSize() // Hiển thị form
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSize(Size p)
        {
            if (sizeServices.CreateSize(p))
            {
                return RedirectToAction("ShowAllSize");
            }
            else return BadRequest();
        }

        public IActionResult DetailSize(Guid id)
        {
            var sizes = sizeServices.GetSizeById(id);
            return View(sizes);
        }
        public IActionResult DeleteSize(Guid id)
        {
            if (sizeServices.DeleteSize(id))
            {
                return RedirectToAction("ShowAllSize");
            }
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult EditSize(Guid id)
        {
            var sizes = sizeServices.GetSizeById(id);
            return View(sizes);
        }
        public IActionResult EditSize(Size p)
        {
            if (sizeServices.UpdateSize(p))
            {
                return RedirectToAction("ShowAllSize");
            }
            else return BadRequest();
        }






    }
}
