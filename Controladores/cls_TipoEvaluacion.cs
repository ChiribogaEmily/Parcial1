using System.Data.SqlClient;

namespace Parcial_1_Emily_Chiriboga.Controladores
{
    public class cls_TipoEvaluacion
    {
        private readonly Config.Conexion cn = new Config.Conexion();
        public string insertar(Modelos.TipoEvaluacion tipoEvaluacion)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"INSERT INTO TipoEvaluacion(Nombre) " +
                              $"VALUES('{tipoEvaluacion.Nombre}');";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "Tipo de evaluación registrado correctamente";
                    }
                    catch (Exception e)
                    {
                        return $"Error al registrar tipo de evaluación: {e.Message}";
                    }
                }
            }
        }
        public List<Modelos.TipoEvaluacion> todos()
        {
            var listaTipoEvaluacion = new List<Modelos.TipoEvaluacion>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM TipoEvaluacion;";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var tipoEvaluacion = new Modelos.TipoEvaluacion
                            {
                                TipoEvaluacionId = (int)lector["TipoEvaluacionId"],
                                Nombre = lector["Nombre"].ToString()
                            };
                            listaTipoEvaluacion.Add(tipoEvaluacion);
                        }
                    }
                }
            }
            return listaTipoEvaluacion;
        }
    }
}
