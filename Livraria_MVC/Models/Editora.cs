using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models
{
    public class Editora
    {
        public virtual decimal Id_Editora { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Pais { get; set; }
    }
}