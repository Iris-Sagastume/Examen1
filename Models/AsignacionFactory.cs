using System;

namespace transporteCabezal.Models
{
    /// <summary>
    /// Factory Method para crear objetos Asignacion.
    /// </summary>
    public static class AsignacionFactory
    {
        public static Asignacion Crear(int idCabezal, int idRuta, int idAsignacion)
        {
            return new Asignacion
            {
                IdAsignacion = idAsignacion,
                IdCabezal = idCabezal,
                IdRuta = idRuta,
                FechaAsignacion = DateTime.Now
            };
        }
    }
}
