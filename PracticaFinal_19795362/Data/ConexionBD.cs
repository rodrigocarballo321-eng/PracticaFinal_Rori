using System.Configuration;
using System.Data.SqlClient;

namespace PracticaFinal_19795362.Data
{
    /// <summary>
    /// Centraliza el acceso a la cadena de conexión y la creación de
    /// conexiones hacia la base de datos "becas".
    /// </summary>
    public static class ConexionBD
    {
        public static string ConnectionString =>
            @"Data Source=RODRISSJ\SQLEXPRESS;Initial Catalog=becas;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connect Timeout=0";

        /// <summary>
        /// Crea una nueva instancia de SqlConnection lista para abrir.
        /// </summary>
        public static SqlConnection ObtenerConexion()
        {
            // ¡CORREGIDO! Pasamos la variable ConnectionString directamente (SIN COMILLAS)
            return new SqlConnection(ConnectionString);
        }
    }
}
