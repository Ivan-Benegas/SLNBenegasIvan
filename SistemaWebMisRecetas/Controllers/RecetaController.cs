using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBRecetaContext context;

        public RecetaController(DBRecetaContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult Index()
        {
            var recetas = context.Recetas.ToList();

            return View(recetas);
        }


        [HttpGet]
        public ActionResult GetByNombre(string nombre)
        {
            var recetas = (from a in context.Recetas
                             where a.AutorNombre == nombre
                             select a).ToList();

            return View("Index", recetas);

        }


        [HttpGet]
        public ActionResult GetByApellido(string apellido)
        {
            var recetas = (from a in context.Recetas
                           where a.AutorApellido == apellido
                           select a).ToList();

            return View("Index", recetas);

        }


        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta);
        }


        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var receta = TraerUno(id);
            return View("Edit", receta);
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(int id, Receta receta)
        {
            if (id != receta.Id)
            {
                return NotFound();
            }
            else
            {
                context.Entry(receta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = TraerUno(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", receta);
            }
        }


        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Receta receta = TraerUno(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = TraerUno(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }

        }


        private Receta TraerUno(int id)
        {
            return context.Recetas.Find(id);
        }


    }
}
