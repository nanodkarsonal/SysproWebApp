using SYSPROWCFServicesClientLibrary40;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestSysproWcfWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SYSPROWCFServicesPrimitiveClient client = new SYSPROWCFServicesPrimitiveClient("net.tcp://localhost:91/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
            var version = client.GetVersion();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}