using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;
using ASM_C4_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM_C4_Shop.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleServices roleServices;// Interface
        public RoleController()
        {
            roleServices = new RoleServices();
        }
        public IActionResult Index()
        {
            return View();
        }



        //show Role

        public ActionResult ShowAllRole()
        {

            List<Role> roles = roleServices.GetAllRoles();
            return View(roles); // Truyền trực tiếp 1 Obj Model duy nhất sang View

        }


        //thêm sửa xóa Role


        public IActionResult CreateRole() // Hiển thị form
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRole(Role p)
        {
            if (roleServices.CreateRole(p))
            {
                return RedirectToAction("ShowAllRole");
            }
            else return BadRequest();
        }

        public IActionResult DetailRoles(Guid id)
        {
            var roles = roleServices.GetRoleById(id);
            return View(roles);
        }
        public IActionResult DeleteRole(Guid id)
        {
            if (roleServices.DeleteRole(id))
            {
                return RedirectToAction("ShowAllRole");
            }
            else return BadRequest();
        }
        [HttpGet]

        public IActionResult EditRole(Guid id)
        {
            var roles = roleServices.GetRoleById(id);
            return View(roles);
        }
        public IActionResult EditRole(Role p)
        {
            if (roleServices.UpdateRole(p))
            {
                return RedirectToAction("ShowAllRole");
            }
            else return BadRequest();
        }
    }
}
