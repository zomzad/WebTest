using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Controllers
{
    public class _BaseController : Controller
    {
        // GET: _Base
        public ActionResult Index()
        {
            return View();
        }
    }
}