using Microsoft.AspNetCore.Mvc;
using Projeto_Teste_MVC.Data;
using Projeto_Teste_MVC.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Teste_MVC.Controllers
{
    public class ListasController : Controller
    {

        public ListasController(BancoDados bancoDados)
        {
            BancoDados = bancoDados;
        }

        private BancoDados BancoDados;


        [HttpGet]
        public IActionResult AmigoAniversariante()
        {
            var aniversariante = new AmigoLista();

            aniversariante.AmigosOrdenados = BancoDados.Amigos.ToList();

            var amigoDoDia =  aniversariante.AmigosOrdenados.OrderByDescending(x => x.Aniversario.Month);
           
            return View(amigoDoDia);
        }

        [HttpGet]
        public IActionResult Aniversariante()
        {
            var aniversariante = new AmigoLista();

            aniversariante.Aniversariantes = BancoDados.Amigos.ToList();

            var aniversarioDoDia = aniversariante.Aniversariantes.Where(x => x.Aniversario == DateTime.Today);
            
            return View(aniversarioDoDia);
        }
    }
}
