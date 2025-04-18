using Parcial_1_Emily_Chiriboga.Controladores;
using Parcial_1_Emily_Chiriboga.Modelos;


namespace Parcial_1_Emily_Chiriboga.Vistas.Resultados
{
    public partial class FrmResultados : Form
    {
        private bool editar = false;
        private int idResultado = 0;

        public FrmResultados(int? id)
        {
            InitializeComponent();
            if (id != 0)
            {
                editar = true;
                idResultado = (int)id;
            }
        }

        public void cargarEstudiantes()
        {
            cls_Estudiante estudiantes = new cls_Estudiante();
            cmbEstudiante.DataSource = estudiantes.todos();
            cmbEstudiante.ValueMember = "EstudianteId";
            cmbEstudiante.DisplayMember = "NombreCompleto";
        }

        public void cargarEvaluaciones()
        {
            cls_Evaluacion evaluaciones = new cls_Evaluacion();
            cmbEvaluaciones.DataSource = evaluaciones.todos();
            cmbEvaluaciones.ValueMember = "EvaluacionId";
            cmbEvaluaciones.DisplayMember = "Nombre";
            cargarPuntajeMaximo(1);

        }

        public void cargarPuntajeMaximo(int idEvaluacion)
        {
            cls_Evaluacion evaluaciones = new cls_Evaluacion();
            var evaluacion = evaluaciones.uno(idEvaluacion);
            if (evaluacion != null)
            {
                txtPuntajeMaximo.Enabled = true;
                txtPuntajeMaximo.Text = evaluacion.PuntajeMaximo.ToString();
                txtPuntajeMaximo.Enabled = false;

            }
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            cargarEstudiantes();
            cargarEvaluaciones();
            if (editar)
            {
                cls_Resultado cls_resultado = new cls_Resultado();
                var resultado = cls_resultado.uno(idResultado);
                if (resultado != null)
                {
                    txtPuntajeObtenido.Text = resultado.PuntajeObtenido.ToString();

                    cmbEstudiante.SelectedValue = resultado.EstudianteId;
                    cmbEvaluaciones.SelectedValue = resultado.EvaluacionId;
                    cargarPuntajeMaximo(resultado.EvaluacionId);
                }
            }
        }

        private void txtPuntajeMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEvaluaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void cmbEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void cmbEvaluaciones_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbEvaluaciones.SelectedValue.GetType().ToString() == "System.Int32")
            {

                cargarPuntajeMaximo((int)cmbEvaluaciones.SelectedValue);
            }
        }

        private void cmbEvaluaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPuntajeObtenido.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }
            if (Convert.ToInt32(txtPuntajeObtenido.Text) < 0)
            {
                MessageBox.Show("El puntaje obtenido debe ser mayor a 0");
                return;
            }
            if (Convert.ToInt32(txtPuntajeObtenido.Text) > Convert.ToInt32(txtPuntajeMaximo.Text))
            {
                MessageBox.Show("El puntaje obtenido no puede ser mayor al puntaje máximo");
                return;
            }
            cls_Resultado cls_resultado = new cls_Resultado();

            var resultado = new Resultado
            {
                PuntajeObtenido = Convert.ToInt32(txtPuntajeObtenido.Text),
                EstudianteId = (int)cmbEstudiante.SelectedValue,
                EvaluacionId = (int)cmbEvaluaciones.SelectedValue,
                Comentarios = rtbComentarios.Text.Length == 0 ? "Sin comentarios" : rtbComentarios.Text
            };
            var mensaje = "";
            if (editar)
            {
                resultado.ResultadoId = idResultado;
                mensaje = cls_resultado.editar(resultado);

            }
            else
            {

                mensaje = cls_resultado.insertar(resultado);

            }
            MessageBox.Show(mensaje);
            this.Close();
        }
    }
}
