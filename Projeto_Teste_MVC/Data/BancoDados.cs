using Microsoft.EntityFrameworkCore;
using Projeto_Teste_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Teste_MVC.Data
{
    public class BancoDados : DbContext
    {
        public BancoDados(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AmigoModel> Amigos { get; set; }
    }
}
