using System.Data.SqlClient;

namespace BaseDatos
{
    public class Conexion
    {
        private readonly string connetionString;

        public Conexion(string valor)
        {
            this.connetionString = valor;
        }

        public SqlConnection ObtenerConexion()
        {
            var conexion = new SqlConnection(this.connetionString);
            conexion.Open();
            return conexion;
        }
    }
}
