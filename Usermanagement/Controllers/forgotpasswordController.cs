using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Usermanagement.Controllers
{
    public class forgotpasswordController : Controller
    {
        // GET: forgotpassword
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pass()
        {
            return View();
        }
    }
}