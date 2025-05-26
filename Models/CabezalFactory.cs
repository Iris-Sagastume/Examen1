namespace transporteCabezal.Models
{
    /// <summary>
    /// Factory Method para crear objetos Cabezal.
    /// </summary>
    public static class CabezalFactory
    {
        public static Cabezal Crear(string placa, string tipo, string estado, int id)
        {
            return new Cabezal
            {
                IdCabezal = id,
                Placa = placa,
                Tipo = tipo,
                Estado = estado
            };
        }
    }
}
