using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesManagement.Data;

namespace SalesManagement.UI.Controllers
{
    public class DemoLoginController : Controller
    {
        // GET: DemoLogin
        SalesManagementDemoEntities _obj = new SalesManagementDemoEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}