using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models.Mapeamento
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Id(x => x.Id_Livro);
            Map(x => x.Nome);
            Map(x => x.Ano_Edicao);

            References(x => x.Autor).Column("FK_AUTOR").Not.LazyLoad();

            References(x => x.Editora).Column("FK_EDITORA").Not.LazyLoad(); 

            References(x => x.Genero).Column("FK_GENERO").Not.LazyLoad();             

            Table("Livro");
        }

    }
}