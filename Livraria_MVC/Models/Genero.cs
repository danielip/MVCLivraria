using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models
{
    public class Genero
    {
        public virtual decimal Id_Genero { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Abreviacao { get; set; }
    }
}