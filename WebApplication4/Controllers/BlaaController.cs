using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Produces("application/json")]
    [Route("api/Blaa")]
    public class BlaaController : Controller
    {

        public IActionResult Hello4()
        {
            return Json(new { bla = "hello!!!!!!!!!" });

        }

    }
}