using Livraria_MVC.Models;
using Livraria_MVC.Models.Mapeamento;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livraria_MVC.Controllers
{
    public class LivrariaController : Controller
    {
        // GET: Livraria
        public ActionResult Index()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var livros = session.Query<Livro>().OrderBy(l => l.Nome).ToList();
                return View(livros);
            }
        }

        // GET: Livraria/Details/5
        public ActionResult Details(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var livro = session.Get<Livro>(id);
                return View(livro);
            }
        }

        // GET: Livraria/Create
        public ActionResult Create()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                ViewBag.Autor = session.Query<Autor>().ToList();
                ViewBag.Genero = session.Query<Genero>().ToList();
                ViewBag.Editora = session.Query<Editora>().ToList();
            }
            return View();
        }

        // POST: Livraria/Create
        [HttpPost]
        public ActionResult Create(Livro livro)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(livro);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Livraria/Edit/5
        public ActionResult Edit(long id)
        {         
            
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var livro = session.Get<Livro>(id);

                ViewBag.Autor = session.Query<Autor>().ToList();
                ViewBag.Genero = session.Query<Genero>().ToList();
                ViewBag.Editora = session.Query<Editora>().ToList();
                return View(livro);
            }
        }

        // POST: Livraria/Edit/5
        [HttpPost]
        public ActionResult Edit(long id, Livro livro)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    var livroAlterado = session.Get<Livro>(id);
                    livroAlterado.Ano_Edicao = livro.Ano_Edicao;
                    livroAlterado.Autor = session.Get<Autor>(livro.Autor.Id_Autor);
                    livroAlterado.Editora = session.Get<Editora>(livro.Editora.Id_Editora);
                    livroAlterado.Nome = livro.Nome;
                    livroAlterado.Genero = session.Get<Genero>(livro.Genero.Id_Genero);
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(livroAlterado);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Livraria/Delete/5
        public ActionResult Delete(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var livro = session.Get<Livro>(id);
                return View(livro);
            }
        }

        // POST: Livraria/Delete/5
        [HttpPost]
        public ActionResult Delete(long id, Livro livro)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        var livroExcluir = session.Get<Livro>(id);
                        session.Delete(livroExcluir);
                        transaction.Commit();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
