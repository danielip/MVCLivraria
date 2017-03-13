using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria_MVC.Models.Mapeamento
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                  .ConnectionString(@"Data Source=WS799\SQL2014EXP;Initial Catalog=Livraria;Integrated Security=True")
                              .ShowSql()
                )
               .Mappings(m =>
                          m.FluentMappings
                              .AddFromAssemblyOf<Editora>())
               .Mappings(m =>
                          m.FluentMappings
                                .AddFromAssemblyOf<Autor>())
              .Mappings(m =>
                          m.FluentMappings
                                  .AddFromAssemblyOf<Livro>())
              .Mappings(m =>
                          m.FluentMappings
                                    .AddFromAssemblyOf<Genero>())

                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                                .Create(false, false))
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}