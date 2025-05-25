using System;

namespace transporteCabezal.Models
{
    public class Ruta
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal DistanciaKm { get; set; }
    }
}

