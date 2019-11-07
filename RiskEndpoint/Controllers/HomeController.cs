using Riskified.SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiskEndpoint.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [HttpPost]
        public JsonResult NotificationReceived(OrderNotification notification)
        {
            return Json(notification);
        }
    }
}
