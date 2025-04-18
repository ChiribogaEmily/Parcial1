
using Parcial_1_Emily_Chiriboga.Modelos;
using System.Data.SqlClient;

namespace Parcial_1_Emily_Chiriboga.Controladores
{
    public class cls_TipoMateria
    {
        private readonly Config.Conexion cn = new Config.Conexion();
        public string insertar(TipoMateria tipoMateria)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"INSERT INTO TipoEvaluacion(Nombre) " +
                              $"VALUES('{tipoMateria.Nombre}');";
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
        public List<TipoMateria> todos()
        {
            var listaTipoMateria = new List<TipoMateria>();
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT * FROM TipoMateria;";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var tipoMateria = new TipoMateria
                            {
                                TipoMateriaId = (int)lector["TipoMateriaId"],
                                Nombre = lector["Nombre"].ToString()
                            };
                            listaTipoMateria.Add(tipoMateria);
                        }
                    }
                }
            }
            return listaTipoMateria;
        }

    }
}
