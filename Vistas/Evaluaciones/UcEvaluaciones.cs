using Parcial_1_Emily_Chiriboga.Controladores;
using Parcial_1_Emily_Chiriboga.Vistas.Evaluaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Emily_Chiriboga.Vistas.Evaluaciones
{
    public partial class UcEvaluaciones : UserControl
    {
        public UcEvaluaciones()
        {
            InitializeComponent();
            this.llenarGrilla(1);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEvaluaciones frmEvaluaciones = new FrmEvaluaciones(0);
            frmEvaluaciones.ShowDialog();
            this.llenarGrilla(1);

        }
        /*
         int number = Parametro para identificar el tipo de carga de la grilla
        number = 1; llamar a todos()
        number = 2; llamar a buscar()
         */
        public void llenarGrilla(int number)
        {
            var cls_evaluacion = new cls_Evaluacion();

            dgvEvaluaciones.DataSource = "";
            dgvEvaluaciones.Columns.Clear();
            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvEvaluaciones.Columns.Add(autoIncrement);

            if (number == 1)
            {

                dgvEvaluaciones.DataSource = cls_evaluacion.todos();
            }
            else if (number == 2)
            {
                dgvEvaluaciones.DataSource = cls_evaluacion.buscar(txtBuscar.Text.Trim());

            }


            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            dgvEvaluaciones.Columns["Nombre"].HeaderText = "Titulo";
            dgvEvaluaciones.Columns["TipoEvaluacionDetalle"].HeaderText = "Tipo";
            dgvEvaluaciones.Columns["PuntajeMaximo"].HeaderText = "Puntaje Maximo";
            dgvEvaluaciones.Columns["Descripcion"].HeaderText = "Descripcion";
            dgvEvaluaciones.Columns["MateriaDetalle"].HeaderText = "Materia";
            dgvEvaluaciones.Columns["FechaEvaluacion"].HeaderText = "Fecha";
            dgvEvaluaciones.Columns["EvaluacionId"].Visible = false;
            dgvEvaluaciones.Columns["TipoEvaluacion"].Visible = false;
            dgvEvaluaciones.Columns["Materia"].Visible = false;

            dgvEvaluaciones.Columns.Add(btnEditar);
            dgvEvaluaciones.Columns.Add(btnEliminar);

        }
        private void dgvEvaluaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEvaluaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            for (int i = 0; i < dgvEvaluaciones.Rows.Count; i++)
            {
                dgvEvaluaciones.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void editarEvaluacion(int id)
        {
            FrmEvaluaciones frmEvaluaciones = new FrmEvaluaciones(id);
            frmEvaluaciones.ShowDialog();
            this.llenarGrilla(1);

        }
        public void eliminarEvaluacion(int id)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Eliminar Evaluacion", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cls_Evaluacion cls_evaluacion = new cls_Evaluacion();

                if (cls_evaluacion.eliminar(id))
                {
                    MessageBox.Show("Registro se ha eliminado correctamente");
                    this.llenarGrilla(1);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar");


                }
                this.llenarGrilla(1);
            }
            else
            {
                MessageBox.Show("El usuario canceló la eliminación");
            }
        }
        private void dgvEvaluaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvEvaluaciones.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaSeleccionada = dgvEvaluaciones.Rows[e.RowIndex];
                var idEvaluacion = filaSeleccionada.Cells["EvaluacionId"].Value;


                if (dgvEvaluaciones.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    editarEvaluacion((int)idEvaluacion);
                }

                if (dgvEvaluaciones.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    eliminarEvaluacion((int)idEvaluacion);
                }

            }
        }
        private void UcEvaluacions_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvEvaluaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.llenarGrilla(2);
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.llenarGrilla(2);

        }
    }
}
