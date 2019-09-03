using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [ApiController]
    public class WellController : ControllerBase
    {
        [HttpGet(".well-known/apple-app-site-association")]
        public IActionResult Get()
        {
            var file = "Files/apple-app-site-association";
            var apple = new FileStream(file, FileMode.Open, FileAccess.Read);
            var stream = new MemoryStream();
            apple.CopyTo(stream);
            stream.Position = 0;

            var mimeType = "application/octet-stream";
            return File(stream, mimeType, file);
        }

        [HttpGet(".well-known/apple-app-site-association-0")]
        public IActionResult Get0()
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