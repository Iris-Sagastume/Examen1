namespace transporteCabezal.Models
{
    /// <summary>
    /// Clase Singleton que garantiza una única instancia de configuración global del sistema.
    /// </summary>
    public class ConfiguracionSistema
    {
        private static ConfiguracionSistema instancia;
        private static readonly object bloqueo = new object();

        // Propiedad de configuración
        public string NombreSistema { get; private set; }

        // Constructor privado evita instanciación directa
        private ConfiguracionSistema()
        {
            NombreSistema = "Sistema de Transporte de Cabezal";
        }

        /// <summary>
        /// Devuelve la instancia única del sistema.
        /// </summary>
        public static ConfiguracionSistema ObtenerInstancia()
        {
            if (instancia == null)
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                        instancia = new ConfiguracionSistema();
                }
            }
            return instancia;
        }
    }
}
