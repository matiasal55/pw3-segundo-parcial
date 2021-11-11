using System.Collections.Generic;
using BD.Modelos;
using Microsoft.AspNetCore.Mvc;
using Servicio;

namespace Web.Controllers
{
    public class ObrasDeArteController : Controller
    {
        private IServicioObras _servicioObras;

        public ObrasDeArteController(IServicioObras servicioObras)
        {
            _servicioObras = servicioObras;
        }

        // GET
        public IActionResult CrearObraDeArte()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CrearObraDeArte(ObraDeArte obra)
        {
            _servicioObras.CrearObraDeArte(obra);
            return RedirectToAction(nameof(SigloXIX));
        }
        
        public IActionResult SigloXIX()
        {
            List<ObraDeArte> obrasDelSigloXIX = _servicioObras.ObtenerObrasDelSigloXIX();
            ViewBag.Obras = obrasDelSigloXIX;
            return View();
        }
    }
}