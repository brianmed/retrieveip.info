using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace retrieveip.info.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Ip"] = HttpContext.Connection.RemoteIpAddress.ToString();
            ViewData["Url_Ip"] = Url.RouteUrl("IpTextRoute", null, HttpContext.Request.Scheme);

            return View();
        }
    }
}
