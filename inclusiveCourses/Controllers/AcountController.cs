using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using inclusiveCourses.Models;
namespace inclusiveCourses.Controllers
{
    public class AcountController : Controller
    {
        private User currentUser;
        public AcountController()
        {
            currentUser=null;
        }
        public IActionResult login()
        {
            return View();

}
        [HttpPost]
        public ActionResult login(User user)
        {
            currentUser = user;
            if ((string.IsNullOrEmpty(currentUser.email) && string.IsNullOrEmpty(currentUser.password)) == false)
            {
                return RedirectToAction("profile");
}
            return RedirectToAction("loginError"); 
}
public ActionResult loginError()
        {
            return View();
        }
       
public ActionResult profile()
        {
            return View(currentUser);
            

        }
}
}
