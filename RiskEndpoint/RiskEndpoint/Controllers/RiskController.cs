using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Riskified.SDK.Model;
using Riskified.SDK.Model.Internal;
using Riskified.SDK.Utils;

namespace RiskEndpoint.Controllers
{
    public class RiskController : Controller
    {
        [HttpPost]
        public JsonResult Index()
        {
            string authToken = ConfigurationManager.AppSettings["MerchantAuthenticationToken"];
            var notificationData = HttpUtils.ParsePostRequestToObject<OrderWrapper<Notification>>(Request, authToken);
            return Json(notificationData);
        }
    }
}
