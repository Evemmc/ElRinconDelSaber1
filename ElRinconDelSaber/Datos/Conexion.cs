using Microsoft.Data.SqlClient;

namespace ElRinconDelSaber.Datos
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=DESKTOP-DF9K9E2\SQLEXPRESS;
              Database=ElRinconDelSaber;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}