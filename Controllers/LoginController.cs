﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller1.Models;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;


namespace Taller1.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration configuration;
        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [BindProperty]
        public string UsuarioF { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string PasswordF { get; set; }
        public int UsuarioIdF { get; set; }
        public string Message { get; set; }
        public async Task<IActionResult> Loguear()
        {
            try {   
            
                var user = configuration.GetSection("Login").Get<UserProfile>();

                if (!ModelState.IsValid)
                {
                    ViewData["Message"] = "Credenciales invalidas, por favor intente nuevamente";
                    return View("Index");
                }

                if (UsuarioF == user.userName && PasswordF == user.password)
                {

                    var identity1 = new ClaimsIdentity("cookie1");
                    identity1.AddClaim(new Claim("name", UsuarioF));
                    await HttpContext.SignInAsync("cookie1", new ClaimsPrincipal(identity1));

                    return RedirectToAction("Index", "Ingreso");
                }
                ViewData["Message"] = "Credenciales invalidas, por favor intente nuevamente";
                return View("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }
        }



        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync("cookie1");
            return RedirectToAction("Index");
        }

    }
}
