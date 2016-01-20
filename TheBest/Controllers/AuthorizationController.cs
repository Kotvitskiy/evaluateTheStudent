using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBest.Models.Authorization;

namespace TheBest.Controllers
{
    public class AuthorizationController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(LoginInputModel model)
        {
            return View();
        }
    }
}