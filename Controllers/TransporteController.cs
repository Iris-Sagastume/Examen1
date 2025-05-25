using System;
using System.Collections.Generic;
using System.Web.Mvc;
using transporteCabezal.Models;

namespace transporteCabezal.Controllers
{
    public class TransporteController : Controller
    {
        public static List<Cabezal> cabezales = new List<Cabezal>();
        public static List<Ruta> rutas = new List<Ruta>();
        public static List<Asignacion> asignaciones = new List<Asignacion>();

        public ActionResult Index()
        {
            ViewBag.Cabezales = cabezales;
            ViewBag.Rutas = rutas;
            ViewBag.Asignaciones = asignaciones;
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarCabezal(string placa, string tipo, string estado)
        {
            cabezales.Add(new Cabezal
            {
                IdCabezal = cabezales.Count + 1,
                Placa = placa,
                Tipo = tipo,
                Estado = estado
            });
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RegistrarRuta(string origen, string destino, string fechaHora, decimal distancia)
        {
            rutas.Add(new Ruta
            {
                IdRuta = rutas.Count + 1,
                Origen = origen,
                Destino = destino,
                FechaHora = DateTime.Parse(fechaHora),
                DistanciaKm = distancia
            });
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AsignarCabezal(int idCabezal, int idRuta)
        {
            asignaciones.Add(new Asignacion
            {
                IdAsignacion = asignaciones.Count + 1,
                IdCabezal = idCabezal,
                IdRuta = idRuta,
                FechaAsignacion = DateTime.Now
            });
            return RedirectToAction("Index");
        }
    }
}
