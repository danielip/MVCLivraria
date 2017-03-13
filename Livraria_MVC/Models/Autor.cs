using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models
{
    public class Autor
    {
        public virtual decimal Id_Autor { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Telefone { get; set; }
    }
}