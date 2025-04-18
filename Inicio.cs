using Parcial_1_Emily_Chiriboga.Vistas.Estudiantes;
using Parcial_1_Emily_Chiriboga.Vistas.Evaluaciones;
using Parcial_1_Emily_Chiriboga.Vistas.Resultados;

namespace Parcial_1_Emily_Chiriboga
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            UcEstudiantes ucEstudiantes = new UcEstudiantes();
            ucEstudiantes.Dock = DockStyle.Fill;
            contenedor.Controls.Clear();
            contenedor.Controls.Add(ucEstudiantes);

        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            UcEvaluaciones ucEvaluaciones = new UcEvaluaciones();
            ucEvaluaciones.Dock = DockStyle.Fill;
            contenedor.Controls.Clear();
            contenedor.Controls.Add(ucEvaluaciones);
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            UcResultados ucResultados = new UcResultados();
            ucResultados.Dock = DockStyle.Fill;
            contenedor.Controls.Clear();
            contenedor.Controls.Add(ucResultados);
        }
    }
}
