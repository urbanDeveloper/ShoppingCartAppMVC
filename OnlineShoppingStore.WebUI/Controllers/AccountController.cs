using OnlineShoppingStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //ANYONE CAN ACCESS
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if ()
                {

                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username and password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        
        }
    }
}