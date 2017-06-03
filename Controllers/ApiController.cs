using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace retrieveip.info.Controllers
{
    [Route("api/v1")]
    public class ApiController : Controller
    {
        [Produces("application/json")]
        [HttpGet("{ip:regex(^ip$)}.{json?}", Name="IpJsonRoute")]
        public IActionResult Json()
        {
            return new JsonResult(new {ip = HttpContext.Connection.RemoteIpAddress.ToString()});
        }

        [Produces("text/plain")]
        [HttpGet("ip/{newline?}", Name="IpTextRoute")]
        public string PlainText(string newline)
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();

            if (null != newline) {
                return $"{ip}\n";
            }
            else {
                return ip;
            }
        }
    }    
}