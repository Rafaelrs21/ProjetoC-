using Projeto_Teste_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Teste_MVC.Listas
{
    public class AmigoLista
    {
        public List<AmigoModel> AmigosOrdenados { get; set; } = new List<AmigoModel>();

        public List<AmigoModel> Aniversariantes { get; set; } = new List<AmigoModel>();
    }
}
