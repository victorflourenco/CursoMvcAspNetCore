using Microsoft.AspNetCore.Mvc;
using Site01.Library;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }

        public IActionResult receberContato([FromForm]Contato contato)
        {
            //string conteudo = string.Format("Nome {0}, Email {1}, Assunto {2}, Mensagem {3}", contato.nome, contato.email, contato.assunto, contato.mensagem);
           // return new ContentResult() { Content = conteudo };
            
            if (ModelState.IsValid)
            {
                //string conteudo = string.Format("Nome {0}, Email {1}, Assunto {2}, Mensagem {3}", contato.nome, contato.email, contato.assunto, contato.mensagem);
                //return new ContentResult() { Content = conteudo };

                ViewBag.Contato = new Contato();
                EnviarEmail.EnviarEmailContato(contato);
                ViewBag.xyz = "Mensagem enviada com Sucesso";
                return View("Index");
            }
            else
            {
                ViewBag.Contato = contato;
                return View("Index");
            }
            
           
        }
    }
}
