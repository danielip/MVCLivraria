using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models
{
    public class Livro
    {
        public virtual long Id_Livro { get; set; }
        public virtual string Nome { get; set; }
        public virtual int Ano_Edicao { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual Editora Editora { get; set; }
        public virtual Genero Genero { get; set; }
    }
}