using Parcial_1_Emily_Chiriboga.Controladores;
using Parcial_1_Emily_Chiriboga.Modelos;

namespace Parcial_1_Emily_Chiriboga.Vistas.Evaluaciones
{
    public partial class FrmEvaluaciones : Form
    {
        private cls_Evaluacion cls_evaluacion = new cls_Evaluacion();
        private bool editar = false;
        private int idEvaluacion = 0;
        public FrmEvaluaciones(int? id)
        {
            InitializeComponent();
            if (id != 0)
            {
                editar = true;
                idEvaluacion = (int)id;
            }
        }

        public void cargarTiposMaterias()
        {
            cls_TipoMateria tipoMaterias = new cls_TipoMateria();
            cmbMateria.DataSource = tipoMaterias.todos();
            cmbMateria.ValueMember = "TipoMateriaId";
            cmbMateria.DisplayMember = "Nombre";
        }
        public void cargarTiposEvaluaciones()
        {
            cls_TipoEvaluacion tipoEvaluaciones = new cls_TipoEvaluacion();
            cmbTipo.DataSource = tipoEvaluaciones.todos();
            cmbTipo.ValueMember = "TipoEvaluacionId";
            cmbTipo.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mensaje = "";
            if (txtTitulo.Text == "" ||
                txtPuntajeMaximo.Text == "" ||
                rtbDescripcion.Text == ""

                )
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }
            if (Convert.ToInt32(txtPuntajeMaximo.Text) <= 0)
            {
                MessageBox.Show("El puntaje máximo debe ser mayor a 0");
                return;
            }

            var evaluacion = new Evaluacion
            {
                Descripcion = rtbDescripcion.Text,
                Nombre = txtTitulo.Text,
                PuntajeMaximo = Convert.ToInt32(txtPuntajeMaximo.Text),
                FechaEvaluacion = (DateTime)dtpFecha.Value,
                TipoEvaluacion = Convert.ToInt32(cmbTipo.SelectedValue),
                Materia = Convert.ToInt32(cmbMateria.SelectedValue)
            };
            try
            {
                if (this.editar)
                {
                    evaluacion.EvaluacionID = this.idEvaluacion;
                    mensaje = cls_evaluacion.editar(evaluacion);

                }
                else
                {

                    mensaje = cls_evaluacion.insertar(evaluacion);

                }

                MessageBox.Show(mensaje);


                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void FrmEvaluaciones_Load(object sender, EventArgs e)
        {
            cargarTiposMaterias();
            cargarTiposEvaluaciones();
            if (this.editar)
            {
                Evaluacion evaluacion = cls_evaluacion.uno(this.idEvaluacion);
                txtTitulo.Text = evaluacion.Nombre;
                rtbDescripcion.Text = evaluacion.Descripcion;
                txtPuntajeMaximo.Text = evaluacion.PuntajeMaximo.ToString();
                dtpFecha.Value = (DateTime)evaluacion.FechaEvaluacion;
                cmbTipo.SelectedValue = evaluacion.TipoEvaluacion;
                cmbMateria.SelectedValue = evaluacion.Materia;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPuntajeMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
