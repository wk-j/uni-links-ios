using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [ApiController]
    public class WellController : ControllerBase
    {
        [HttpGet(".well-known/apple-app-site-association")]
        public IActionResult Get()
        {
            return Ok(new
            {
                Applinks = new
                {
                    Apps = new List<dynamic>(),
                    Details = new List<dynamic> {
                        new {
                            AppID = "PV39P3M2FD.com.wk.uniLinksIos",
                            Paths = new List<string> {
                                "/signin",
                            },
                        },
                    },
                },
            });
        }
    }
}