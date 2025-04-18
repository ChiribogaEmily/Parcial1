

namespace Parcial_1_Emily_Chiriboga.Modelos
{
    public class Evaluacion
    {
        public int EvaluacionID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public float PuntajeMaximo { get; set; }
        public int TipoEvaluacion { get; set; }
        public string TipoEvaluacionDetalle { get; set; }
        public int Materia { get; set; }
        public string MateriaDetalle { get; set; }

    }
}
