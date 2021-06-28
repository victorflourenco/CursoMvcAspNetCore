using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           // return new ContentResult() { Content = "Olá mundo!", ContentType = "text/plain" };
           return View("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Usuario usuario)
        {
            if (usuario.email == "victor.flourenco@outlook.com" && usuario.senha == "123")
            {
                return RedirectToAction("Index", "Palavara");
            }
            else
            {
                ViewBag.Mensagem = "Os dados informados são inválidos";
                return View();
            }
        }
    }
}
