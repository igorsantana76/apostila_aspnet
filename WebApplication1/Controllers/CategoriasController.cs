using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriasController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Categorias
        public ActionResult Index()
        {
            return View(context.Categorias.OrderBy(a => a.Nome).ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(context.Categorias.Where(m => m.CategoriaID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {

            if (ModelState.IsValid)
            {
                context.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

            return RedirectToAction("Details", new { id = categoria.CategoriaID});
        }

        public ActionResult Delete(long? id)
        {
            return View(context.Categorias.Where(m => m.CategoriaID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            var categoria = context.Categorias.Find(id);

            context.Categorias.Remove(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Details(long id)
        {
            return View(context.Categorias.Find(id));
        }
    }
}