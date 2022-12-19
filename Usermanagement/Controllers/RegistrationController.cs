using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Usermanagement.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
           
        public ActionResult Register()
        {
            return View();
        }
    }
}