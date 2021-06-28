using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class PalavaraController : Controller
    {
        private DatabaseContext _db;
        public PalavaraController(DatabaseContext db)
        {
            _db = db;
        }
      public IActionResult Index()
        {
            ViewBag.Palavras = _db.Palavras.ToList();
            ViewBag.nomeBotao = "Cadastar";
            return View();
        }

        //Métodos CRUD
    [HttpGet]
    public IActionResult Cadastrar()
        {
            ViewBag.nomeBotao = "Atuliazar";
            return View();
        }
    [HttpPost]    

    public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            ViewBag.nomeBotao = "Atuliazar";
            return View();
        }
     [HttpGet]
    public IActionResult Atualizar()
        {
            ViewBag.nomeBotao = "Atuliazar";
            return View("Cadastrar");
        }

    [HttpPost]
    public IActionResult Atualizar([FromForm]Palavra palavra)
        {
            ViewBag.nomeBotao = "Atuliazar";
            return View("Cadastar");
        }
        //Palavara/Excluir/39
        //{Controller}/Action/{ID}
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            return RedirectToAction("Index");
        }

    }
}
