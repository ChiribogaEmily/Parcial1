
using System.Data.SqlClient;

namespace Parcial_1_Emily_Chiriboga.Config
{
    public class Conexion
    {
        private readonly string conexionString =
            "Server=.;Database=Parcial_1_EmilyChiriboga;uid=root;pwd=123456;TrustServerCertificate=True";

        public SqlConnection obtenerConexion()
        {

            return new SqlConnection(conexionString);
        }
    }
}
