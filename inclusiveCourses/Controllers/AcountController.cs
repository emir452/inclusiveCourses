using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inclusiveCourses.Controllers
{
    public class AcountController : Controller
    {
        public ActionResult login()
        {
            return View();

}
        [HttpPost]
        public IActionResult login(String email, string password)
        {
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                Models.User user = new Models.User();
                user.email = email;
                user.password = password;
              return new ProfileController(user).index();
            }
            return new loginErrorController().Index();


        }

    }
}
