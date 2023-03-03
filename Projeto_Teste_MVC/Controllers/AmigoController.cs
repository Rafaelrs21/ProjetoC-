using Microsoft.AspNetCore.Mvc;
using Projeto_Teste_MVC.Data;
using Projeto_Teste_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Teste_MVC.Controllers
{
    public class AmigoController : Controller
    {
        public AmigoController(BancoDados bancoDados)
        {
            BancoDados = bancoDados;
        }

        private BancoDados BancoDados;

        [HttpGet]
        public IActionResult ListarAmigo(string pesquisa)
        {
            var ListaDeAmigo = BancoDados.Amigos.ToList();

            if (pesquisa != null)
            {
                var AmigoEscolhido = ListaDeAmigo.Where(a => a.Nome == pesquisa).ToList();
                return View(AmigoEscolhido);
            }

                return View(ListaDeAmigo);
            }

        [HttpGet]
        public IActionResult VizualizarAmigo(int id)
        {
            var amigo = BancoDados.Amigos.Find(id);

            return View(amigo);

        }

        [HttpGet]
        public IActionResult AdicionarAmigo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarAmigo(string nome, string sobrenome, int idade, DateTime aniversario)
        {
            AmigoModel amigo = new AmigoModel();

            amigo.Nome = nome;
            amigo.Sobrenome = sobrenome;
            amigo.Idade = idade;
            amigo.Aniversario = aniversario;

            BancoDados.Amigos.Add(amigo);
            BancoDados.SaveChanges();

            return Redirect("ListarAmigo");
        }

        [HttpGet]
        public IActionResult EditarAmigo(int id)
        {

            var amigo = BancoDados.Amigos.Find(id);

            return View(amigo);

        }

        [HttpPost]
        public IActionResult EditarAmigo(string nome, string sobrenome, int idade, DateTime aniversario, int id)
        {
            var amigo = BancoDados.Amigos.Find(id);

            amigo.Nome = nome;
            amigo.Sobrenome = sobrenome;
            amigo.Idade = idade;
            amigo.Aniversario = aniversario;

            BancoDados.Update(amigo);
            BancoDados.SaveChanges();

            return Redirect("ListarAmigo");
        }

        
        [HttpGet]
        public IActionResult DeletarAmigo(int id)
        {
            var amigo = BancoDados.Amigos.Find(id);

            return View(amigo);

        }

        [HttpPost]
        public IActionResult DeletarAmigoPost(int id)
        {
            var amigo = BancoDados.Amigos.Find(id);

            BancoDados.Amigos.Remove(amigo);
            BancoDados.SaveChanges();

            return Redirect("ListarAmigo");

        }
    }
}