

namespace Parcial_1_Emily_Chiriboga.Modelos
{
    public class Resultado
    {
        public int ResultadoId { get; set; }
        public int EstudianteId { get; set; }
        public string EstudianteNombre { get; set; }
        public string EstudianteApellido { get; set; }

        public int EvaluacionId { get; set; }
        public string EvaluacionNombre { get; set; }
        public string EvaluacionDescripcion { get; set; }
        public float PuntajeMaximoEvaluacion { get; set; }
        public string? MateriaEvaluacion { get; set; }
        public DateTime? FechaEvaluacion { get; set; }

        public float PuntajeObtenido { get; set; }
        public string Comentarios { get; set; }

    }
}
