using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Controllers
{
    [Authorize(AuthenticationSchemes = "cookie1")]
    public class IngresoController : Controller
    { 
     [Authorize(AuthenticationSchemes = "cookie1")]
    public IActionResult Index()
    {
        ViewData["Message"] = "Ingreso Correctamente";
        return View();
    }

}
}
