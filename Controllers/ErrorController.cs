using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/x00")]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
