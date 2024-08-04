using Models;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrudPolizas.Controllers
{
    public class PolizaController : Controller
    {
        private readonly IPoliza _ipoliza;

        public PolizaController(IPoliza ipoliza)
        {
            _ipoliza = ipoliza;
        }

        // GET: PolizaController
        public ActionResult Index()
        {
            var poliza = _ipoliza.Listar();
            return View(poliza);
        }

        // GET: PolizaController/Details/5
        public ActionResult Details(int id)
        {
            var poliza = _ipoliza.Obtener(id);
            return View(poliza);
        }

        // GET: PolizaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PolizaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Poliza poliza)
        {
            try
            {
                _ipoliza.Registrar(poliza);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PolizaController/Edit/5
        public ActionResult Edit(int id)
        {
            var poliza = _ipoliza.Obtener(id);
            return View(poliza);
        }

        // POST: PolizaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Poliza poliza)
        {
            try
            {
                _ipoliza.Modificar(poliza);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PolizaController/Delete/5
        public ActionResult Delete(int id)
        {
            var poliza = _ipoliza.Obtener(id);

            if(poliza == null)
                return NotFound();

            return View(poliza);
        }

        // POST: PolizaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmado(int numeroPoliza)
        {
            try
            {
                _ipoliza.Eliminar(numeroPoliza);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
