using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models.Mapeamento
{
    public class AutorMap : ClassMap<Autor>
    {
        public AutorMap()
        {
            Id(x => x.Id_Autor);
            Map(x => x.Nome);
            Map(x => x.Email);
            Map(x => x.Telefone);
            Table("Autor");
        }
    }
}