using ASM_C4_Shop.IServices;
using ASM_C4_Shop.Models;
using ASM_C4_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASM_C4_Shop.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices UserServices;// Interface

        public UserController()
        {
            UserServices = new UserServices();
        }
        public IActionResult Index()
        {
            return View();
        }

        //show User
        public ActionResult ShowAllUser()
        {

            List<User> users = UserServices.GetAllUsers();
            return View(users); // Truyền trực tiếp 1 Obj Model duy nhất sang View

        }


    
        //thêm sửa xóa User



        public IActionResult CreateUser() // Hiển thị form
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User p, IFormFile LinkAnh)
        {
            if (UserServices.CreateUser(p))
            {
                return RedirectToAction("ShowAllUser");
            }
            else return BadRequest();
        }

    


 




        public IActionResult DetailUsers(Guid id)
        {
            var users = UserServices.GetUserById(id);
            return View(users);
        }

        public IActionResult DeleteUser(Guid id)
        {
            if (UserServices.DeleteUser(id))
            {
                return RedirectToAction("ShowAllUser");
            }
            else return BadRequest();
        }
        [HttpGet]

        public IActionResult EditUser(Guid id)
        {
            var users = UserServices.GetUserById(id);
            return View(users);
        }
        public IActionResult EditUser(User p, IFormFile LinkAnh)
        {

            if (UserServices.UpdateUser(p))
            {
                return RedirectToAction("ShowAllUser");
            }
            else
            {
                return BadRequest();
            }

        }






    }
}
