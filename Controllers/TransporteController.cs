using System;
using System.Collections.Generic;
using System.Web.Mvc;
using transporteCabezal.Models;

namespace transporteCabezal.Controllers
{
    public class TransporteController : Controller
    {
        // Listas simulando la base de datos en memoria
        public static List<Cabezal> cabezales = new List<Cabezal>();
        public static List<Ruta> rutas = new List<Ruta>();
        public static List<Asignacion> asignaciones = new List<Asignacion>();

        /// <summary>
        /// Muestra la vista principal con los datos cargados.
        /// </summary>
        public ActionResult Index()
        {
            // Uso del Singleton para obtener el nombre del sistema
            var config = ConfiguracionSistema.ObtenerInstancia();
            ViewBag.NombreSistema = config.NombreSistema;

            ViewBag.Cabezales = cabezales;
            ViewBag.Rutas = rutas;
            ViewBag.Asignaciones = asignaciones;
            return View();
        }

        /// <summary>
        /// Registra un nuevo cabezal usando el patrón Factory Method.
        /// </summary>
        [HttpPost]
        public ActionResult RegistrarCabezal(string placa, string tipo, string estado)
        {
            var nuevoCabezal = CabezalFactory.Crear(placa, tipo, estado, cabezales.Count + 1);
            cabezales.Add(nuevoCabezal);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Registra una nueva ruta usando el patrón Factory Method.
        /// </summary>
        [HttpPost]
        public ActionResult RegistrarRuta(string origen, string destino, string fechaHora, decimal distancia)
        {
            var fecha = DateTime.Parse(fechaHora);
            var nuevaRuta = RutaFactory.Crear(origen, destino, fecha, distancia, rutas.Count + 1);
            rutas.Add(nuevaRuta);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Asigna un cabezal a una ruta usando el patrón Factory Method.
        /// </summary>
        [HttpPost]
        public ActionResult AsignarCabezal(int idCabezal, int idRuta)
        {
            var nuevaAsignacion = AsignacionFactory.Crear(idCabezal, idRuta, asignaciones.Count + 1);
            asignaciones.Add(nuevaAsignacion);
            return RedirectToAction("Index");
        }
    }
}
