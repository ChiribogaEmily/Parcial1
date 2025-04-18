

using Parcial_1_Emily_Chiriboga.Config;
using Parcial_1_Emily_Chiriboga.Modelos;
using System.Data.SqlClient;

namespace Parcial_1_Emily_Chiriboga.Controladores
{
    public class cls_Evaluacion
    {
        private readonly Conexion cn = new Conexion();

        public string insertar(Evaluacion evaluacion)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"INSERT INTO Evaluaciones(Nombre, Descripcion, Fecha, PuntajeMaximo, " +
                              $"Tipo, Materia) " +
                              $"VALUES('{evaluacion.Nombre}', '{evaluacion.Descripcion}', " +
                              $"'{evaluacion.FechaEvaluacion.ToString("yyyy-MM-dd")}', " +
                              $"{evaluacion.PuntajeMaximo}, {evaluacion.TipoEvaluacion}, " +
                              $"{evaluacion.Materia});";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "Evaluación registrada correctamente";
                    }
                    catch (Exception e)
                    {
                        return $"Error al registrar evaluación: {e.Message}";
                    }
                }
            }
        }

        public List<Evaluacion> todos()
        {
            var listaEvaluaciones = new List<Evaluacion>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT *,TipoEvaluacion.TipoEvaluacionId ,TipoEvaluacion.Nombre as TipoEvaluacionDetalle," +
                    "TipoMateria.TipoMateriaId ,TipoMateria.Nombre as TipoMateriaDetalle " +
                    "FROM Evaluaciones " +
                    "JOIN TipoEvaluacion ON  Tipo = TipoEvaluacion.TipoEvaluacionId " +
                    "JOIN TipoMateria ON Materia = TipoMateria.TipoMateriaId;";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var evaluacion = new Evaluacion
                            {
                                EvaluacionID = (int)lector["EvaluacionID"],
                                Nombre = lector["Nombre"].ToString(),
                                Descripcion = lector["Descripcion"].ToString(),
                                FechaEvaluacion = (DateTime)lector["Fecha"],
                                PuntajeMaximo = Convert.ToSingle(lector["PuntajeMaximo"]),
                                TipoEvaluacion = (int)lector["Tipo"],
                                TipoEvaluacionDetalle = lector["TipoEvaluacionDetalle"].ToString(),
                                Materia = (int)lector["Materia"],
                                MateriaDetalle = lector["TipoMateriaDetalle"].ToString()
                            };

                            listaEvaluaciones.Add(evaluacion);
                        }
                    }
                }
            }
            return listaEvaluaciones;
        }


        public Evaluacion uno(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT * FROM Evaluaciones WHERE EvaluacionId = {id};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Evaluacion
                            {
                                EvaluacionID = (int)lector["EvaluacionID"],
                                Nombre = lector["Nombre"].ToString(),
                                Descripcion = lector["Descripcion"].ToString(),
                                FechaEvaluacion = (DateTime)lector["Fecha"],
                                PuntajeMaximo = Convert.ToSingle(lector["PuntajeMaximo"]),
                                TipoEvaluacion = (int)lector["Tipo"],
                                Materia = (int)lector["Materia"]
                            };
                        }
                        return null;
                    }
                }
            }
        }

        // Método para actualizar una evaluación
        public string editar(Evaluacion evaluacion)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"UPDATE Evaluaciones SET " +
                              $"Nombre = '{evaluacion.Nombre}', " +
                              $"Descripcion = '{evaluacion.Descripcion}', " +
                              $"Fecha = '{evaluacion.FechaEvaluacion.ToString("yyyy-MM-dd")}', " +
                              $"PuntajeMaximo = {evaluacion.PuntajeMaximo}, " +
                              $"Tipo = {evaluacion.TipoEvaluacion}, " +
                              $"Materia = {evaluacion.Materia} " +
                              $"WHERE EvaluacionId = {evaluacion.EvaluacionID};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        int afectadas = comando.ExecuteNonQuery();
                        return afectadas > 0 ? "Evaluación actualizada correctamente" : "No se encontró la evaluación";
                    }
                    catch (Exception e)
                    {
                        return $"Error al actualizar evaluación: {e.Message}";
                    }
                }
            }
        }

        public bool eliminar(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {


                string cadena = $"DELETE FROM Evaluaciones WHERE EvaluacionID = {id};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        int afectadas = comando.ExecuteNonQuery();
                        return afectadas > 0;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }
        }


        public List<Evaluacion> buscar(string cadenaABuscar)
        {
            var listaEvaluaciones = new List<Evaluacion>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT *,TipoEvaluacion.TipoEvaluacionId ,TipoEvaluacion.Nombre as TipoEvaluacionDetalle, " +
                              $" TipoMateria.TipoMateriaId, TipoMateria.Nombre as TipoMateriaDetalle FROM Evaluaciones " +
                              "JOIN TipoEvaluacion ON  Tipo = TipoEvaluacion.TipoEvaluacionId " +
                              "JOIN TipoMateria ON Materia = TipoMateria.TipoMateriaId"+
                              $" WHERE Evaluaciones.Nombre LIKE '%{cadenaABuscar}%' OR Evaluaciones.Descripcion LIKE '%{cadenaABuscar}%'; " 
;

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                     
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var evaluacion = new Evaluacion
                            {
                                EvaluacionID = (int)lector["EvaluacionId"],
                                Nombre = lector["Nombre"].ToString(),
                                Descripcion = lector["Descripcion"].ToString(),
                                FechaEvaluacion = (DateTime)lector["Fecha"],
                                PuntajeMaximo = Convert.ToSingle(lector["PuntajeMaximo"]),
                                TipoEvaluacion = (int)lector["Tipo"],
                                TipoEvaluacionDetalle = lector["TipoMateriaDetalle"].ToString(),
                                Materia = (int)lector["Materia"],
                                MateriaDetalle = lector["MateriaDetalle"].ToString()
                            };

                            listaEvaluaciones.Add(evaluacion);
                        }
                    }
                }
            }
            return listaEvaluaciones;
        }

    }
}
