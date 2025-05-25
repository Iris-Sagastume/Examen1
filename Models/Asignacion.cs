using System;

namespace transporteCabezal.Models
{
    public class Asignacion
    {
        public int IdAsignacion { get; set; }
        public int IdCabezal { get; set; }
        public int IdRuta { get; set; }
        public DateTime FechaAsignacion { get; set; }
    }
}

