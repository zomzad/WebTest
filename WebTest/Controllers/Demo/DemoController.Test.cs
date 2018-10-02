using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Models.Demo;

namespace WebTest.Controllers.Demo
{
    public partial class DemoController
    {
        // GET: Demo
        public ActionResult Test()
        {
            TestModel model = new TestModel();
            return View();
        }
    }
}