using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models.Mapeamento
{
    public class EditoraMap : ClassMap<Editora>
    {
        public EditoraMap()
        {
            Id(x => x.Id_Editora);
            Map(x => x.Nome);
            Map(x => x.Pais);
            Map(x => x.Cidade);
            Table("Editora");
        }
    }
}