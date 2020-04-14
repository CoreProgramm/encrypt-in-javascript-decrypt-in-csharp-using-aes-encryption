using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Encrypt_JavaScript_Decrypt_Csharp.Models;

namespace Encrypt_JavaScript_Decrypt_Csharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login objUL)
        {
            if (ModelState.IsValid)
            {
                var username = AESEncryption.DecryptStringAES(objUL.Username);
                var password = AESEncryption.DecryptStringAES(objUL.Password);

                if (username == "keyError" && password == "keyError")
                {
                    TempData["notice"] = "Invalid  Login";
                }
                else
                {
                    TempData["notice"] = "login successfully";
                }
                return View(objUL);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid  Login");
                return View(objUL);
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
