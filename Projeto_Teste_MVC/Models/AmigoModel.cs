using Projeto_Teste_MVC.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Projeto_Teste_MVC.Models
{
    public class AmigoModel
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime Aniversario { get; set; }

    }
}