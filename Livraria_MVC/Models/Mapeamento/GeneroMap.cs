using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models.Mapeamento
{
    public class GeneroMap : ClassMap<Genero>
    {
        public GeneroMap()
        {
            Id(x => x.Id_Genero);
            Map(x => x.Nome);
            Map(x => x.Abreviacao);
            Table("Genero");
        }
    }
}