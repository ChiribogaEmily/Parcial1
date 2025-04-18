using System.Data.SqlClient;
using Parcial_1_Emily_Chiriboga.Modelos;
namespace Parcial_1_Emily_Chiriboga.Controladores
{
    
    public class cls_Estudiante
    {
        private readonly Config.Conexion cn = new Config.Conexion();

        public string insertar(Estudiante estudiante)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"INSERT INTO Estudiantes(Nombre, Apellido, FechaNacimiento, Telefono) " +
                              $"VALUES('{estudiante.Nombre}', '{estudiante.Apellido}', " +
                              $"'{estudiante.FechaNacimiento.Value.ToString("yyyy-MM-dd")}', "  +
                              $"'{estudiante.Telefono}');";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "Estudiante registrado correctamente";
                    }
                    catch (Exception e)
                    {
                        return $"Error al registrar estudiante: {e.Message}";
                    }
                }
            }
        }

        public List<Estudiante> todos()
        {
            var listaEstudiantes = new List<Estudiante>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "SELECT *, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM Estudiantes;";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var estudiante = new Estudiante
                            {
                                EstudianteId = (int)lector["EstudianteId"],
                                Nombre = lector["Nombre"].ToString(),
                                Apellido = lector["Apellido"].ToString(),
                                Telefono = lector["Telefono"].ToString(),
                                NombreCompleto = lector["NombreCompleto"].ToString(),
                                FechaNacimiento = (DateTime)lector["FechaNacimiento"]
                            };

   

                            listaEstudiantes.Add(estudiante);
                        }
                    }
                }
            }
            return listaEstudiantes;
        }

        public Estudiante uno(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT * FROM Estudiantes WHERE EstudianteId = {id};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            var estudiante = new Estudiante
                            {
                                EstudianteId = (int)lector["EstudianteId"],
                                Nombre = lector["Nombre"].ToString(),
                                Apellido = lector["Apellido"].ToString(),
                                Telefono = lector["Telefono"].ToString(),
                                FechaNacimiento = (DateTime)lector["FechaNacimiento"]
                            };


                            return estudiante;
                        }
                        return null;
                    }
                }
            }
        }

        public string actualizar(Estudiante estudiante)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"UPDATE Estudiantes SET " +
                              $"Nombre = '{estudiante.Nombre}', " +
                              $"Apellido = '{estudiante.Apellido}', " +
                              $"FechaNacimiento = '{estudiante.FechaNacimiento.Value.ToString("yyyy-MM-dd"): 'NULL'} ' , " +
                              $"Telefono = '{estudiante.Telefono}' " +
                              $"WHERE EstudianteId = {estudiante.EstudianteId};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        int afectadas = comando.ExecuteNonQuery();
                        return afectadas > 0 ? "Estudiante actualizado correctamente" : "No se encontró el estudiante";
                    }
                    catch (Exception e)
                    {
                        return $"Error al actualizar estudiante: {e.Message}";
                    }
                }
            }
        }

        public bool eliminar(int id)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"DELETE FROM Estudiantes WHERE EstudianteId = {id};";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        int afectadas = comando.ExecuteNonQuery();
                        return afectadas > 0 ;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }
        }

        public List<Estudiante> buscar(string cadenaABuscar)
        {
            var listaEstudiantes = new List<Estudiante>();

            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"SELECT * FROM Estudiantes " +
                              $"WHERE Nombre LIKE '%{cadenaABuscar}%' OR Apellido LIKE '%{cadenaABuscar}%';";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var estudiante = new Estudiante
                            {
                                EstudianteId = (int)lector["EstudianteId"],
                                Nombre = lector["Nombre"].ToString(),
                                Apellido = lector["Apellido"].ToString(),
                                Telefono = lector["Telefono"].ToString(),
                                FechaNacimiento = (DateTime)lector["FechaNacimiento"]
                            };

                            listaEstudiantes.Add(estudiante);
                        }
                    }
                }
            }
            return listaEstudiantes;
        }

    }
}
