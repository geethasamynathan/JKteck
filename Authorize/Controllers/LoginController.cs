using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Authorizationdemo1.Models;

namespace Authorizationdemo1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(Userdetail user)
        {
            if(ModelState.IsValid)
            {
                if(user.Username=="system" && user.Password=="Admin")
                {
                    Session["username"] = user.Username;

                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("SecureMethod", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid credetials");
                  
                }
               
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }

    }
}