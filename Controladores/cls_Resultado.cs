using Parcial_1_Emily_Chiriboga.Config;
using Parcial_1_Emily_Chiriboga.Modelos;
using System.Data.SqlClient;

namespace Parcial_1_Emily_Chiriboga.Controladores
{
    public class cls_Resultado
    {
        private readonly Conexion cn = new Conexion();

        public string insertar(Resultado resultado)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"INSERT INTO Resultados(EstudianteId, EvaluacionId, PuntajeObtenido, Comentarios) " +
                              $"VALUES({resultado.EstudianteId}, {resultado.EvaluacionId}, " +
                              $"{resultado.PuntajeObtenido}, " +
                              $"{(resultado.Comentarios != null ? $"'{resultado.Comentarios}'" : "NULL")});";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "Resultado registrado correctamente";
                    }
                    catch (Exception e)
                    {
                        return $"Error al registrar resultado: {e.Message}";
                    }
                }
            }
        }

        public List<Resultado> todos()
        {
            var listaResultados = new List<Resultado>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT r.*, CONCAT(e.Nombre, ' ',  e.Apellido) AS Estudiante, " +
                    $"ev.Nombre AS EvaluacionNombre, ev.Descripcion AS EvaluacionDescripcion, ev.Fecha, ev.PuntajeMaximo, " +
                    $"tp.Nombre as Materia " +
                    $"FROM Resultados r " +
                    $"JOIN Estudiantes e ON r.EstudianteId = e.EstudianteId " +
                    $"JOIN Evaluaciones ev ON r.EvaluacionId = ev.EvaluacionId " +
                    $"JOIN TipoMateria tp ON ev.Materia = tp.TipoMateriaId;";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var resultado = new Resultado
                            {
                                ResultadoId = (int)lector["ResultadosId"],
                                EstudianteId = (int)lector["EstudianteId"],
                                EstudianteNombre = lector["Estudiante"].ToString(),
                                EvaluacionId = (int)lector["EvaluacionId"],
                                FechaEvaluacion = (DateTime)lector["Fecha"],
                                EvaluacionNombre = lector["EvaluacionNombre"].ToString(),
                                EvaluacionDescripcion = lector["EvaluacionDescripcion"].ToString(),
                                PuntajeObtenido = Convert.ToSingle(lector["PuntajeObtenido"]),
                                PuntajeMaximoEvaluacion = Convert.ToSingle(lector["PuntajeMaximo"]),
                                MateriaEvaluacion = lector["Materia"].ToString(),
                                Comentarios = lector["Comentarios"]?.ToString()
                            };


                            listaResultados.Add(resultado);
                        }
                    }
                }
            }
            return listaResultados;
        }

        public Resultado uno(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT r.*, e.Nombre AS EstudianteNombre, e.Apellido AS EstudianteApellido, " +
                              $"ev.Nombre AS EvaluacionNombre, ev.Descripcion AS EvaluacionDescripcion, ev.Fecha " +
                              $"FROM Resultados r " +
                              $"JOIN Estudiantes e ON r.EstudianteId = e.EstudianteId " +
                              $"JOIN Evaluaciones ev ON r.EvaluacionId = ev.EvaluacionId " +
                              $"WHERE r.ResultadosId = {id};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            var resultado = new Resultado
                            {
                                ResultadoId = (int)lector["ResultadosId"],
                                EstudianteId = (int)lector["EstudianteId"],
                                EvaluacionId = (int)lector["EvaluacionId"],
                                EvaluacionNombre = lector["EvaluacionNombre"].ToString(),
                                PuntajeObtenido = Convert.ToSingle(lector["PuntajeObtenido"]),
                                Comentarios = lector["Comentarios"]?.ToString()
                            };


                            return resultado;
                        }
                        return null;
                    }
                }
            }
        }

        public string editar(Resultado resultado)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"UPDATE Resultados SET " +
                              $"EstudianteId = {resultado.EstudianteId}, " +
                              $"EvaluacionId = {resultado.EvaluacionId}, " +
                              $"PuntajeObtenido = {resultado.PuntajeObtenido}, " +
                              $"Comentarios = {(resultado.Comentarios != null ? $"'{resultado.Comentarios}'" : "NULL")} " +
                              $"WHERE ResultadosId = {resultado.ResultadoId};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        int afectadas = comando.ExecuteNonQuery();
                        return afectadas > 0 ? "Resultado actualizado correctamente" : "No se encontró el resultado";
                    }
                    catch (Exception e)
                    {
                        return $"Error al actualizar resultado: {e.Message}";
                    }
                }
            }
        }

        public bool eliminar(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"DELETE FROM Resultados WHERE ResultadosId = {id};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        int afectadas = comando.ExecuteNonQuery();
                        
                            MessageBox.Show($"{afectadas}");
                        
                        return afectadas > 0;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Error al eliminar resultado: {e.Message}");
                        return false;
                    }
                }
            }
        }
        public List<Resultado> buscar(string cadenaABuscar)
        {
            var listaResultados = new List<Resultado>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT r.*, CONCAT(e.Nombre, ' ',  e.Apellido) AS Estudiante, " +
                    $"ev.Nombre AS EvaluacionNombre, ev.Descripcion AS EvaluacionDescripcion, ev.Fecha, ev.PuntajeMaximo, " +
                    $"tp.Nombre as Materia " +
                    $"FROM Resultados r " +
                    $"JOIN Estudiantes e ON r.EstudianteId = e.EstudianteId " +
                    $"JOIN Evaluaciones ev ON r.EvaluacionId = ev.EvaluacionId " +
                    $"JOIN TipoMateria tp ON ev.Materia = tp.TipoMateriaId " +
                    $"WHERE e.Nombre LIKE '%{cadenaABuscar}%' OR e.Apellido LIKE '%{cadenaABuscar}%' ;";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var resultado = new Resultado
                            {
                                ResultadoId = (int)lector["ResultadosId"],
                                EstudianteId = (int)lector["EstudianteId"],
                                EstudianteNombre = lector["Estudiante"].ToString(),
                                EvaluacionId = (int)lector["EvaluacionId"],
                                FechaEvaluacion = (DateTime)lector["Fecha"],
                                EvaluacionNombre = lector["EvaluacionNombre"].ToString(),
                                EvaluacionDescripcion = lector["EvaluacionDescripcion"].ToString(),
                                PuntajeObtenido = Convert.ToSingle(lector["PuntajeObtenido"]),
                                PuntajeMaximoEvaluacion = Convert.ToSingle(lector["PuntajeMaximo"]),
                                MateriaEvaluacion = lector["Materia"].ToString(),
                                Comentarios = lector["Comentarios"]?.ToString()
                            };


                            listaResultados.Add(resultado);
                        }
                    }
                }
            }
            return listaResultados;
        }
    }
}
