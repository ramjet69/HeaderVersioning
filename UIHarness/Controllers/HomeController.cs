using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIHarness.Models;
using UIHarness.Service;

namespace UIHarness.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Method1PeopleV1()
        {
            var service = new Method1PeopleService();

            var model = service.Method1GetPeopleV1();

            return View("Method1PeopleV1", model);
        }

        public ActionResult Method1PeopleV2()
        {
            var service = new Method1PeopleService();

            var model = service.Method1GetPeopleV2();

            return View("Method1PeopleV2", model);
        }
	}
}