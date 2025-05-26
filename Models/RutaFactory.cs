using System;

namespace transporteCabezal.Models
{
    /// <summary>
    /// Factory Method para crear objetos Ruta.
    /// </summary>
    public static class RutaFactory
    {
        public static Ruta Crear(string origen, string destino, DateTime fechaHora, decimal distancia, int id)
        {
            return new Ruta
            {
                IdRuta = id,
                Origen = origen,
                Destino = destino,
                FechaHora = fechaHora,
                DistanciaKm = distancia
            };
        }
    }
}
