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

namespace Parcial_1_Emily_Chiriboga.Vistas.Resultados
{
    public partial class UcResultados : UserControl
    {
        public UcResultados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmResultados frmResultados = new FrmResultados(0);
            frmResultados.ShowDialog();
            this.llenarGrilla(1);
        }

        /*
         int number = Parametro para identificar el tipo de carga de la grilla
        number = 1; llamar a todos()
        number = 2; llamar a buscar()
         */
        public void llenarGrilla(int number)
        {
            var cls_resultado = new cls_Resultado();

            dgvResultados.DataSource = "";
            dgvResultados.Columns.Clear();
            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvResultados.Columns.Add(autoIncrement);

            if (number == 1)
            {

                dgvResultados.DataSource = cls_resultado.todos();
            } else if(number == 2)
            {

                var buscar = txtBuscar.Text;
                dgvResultados.DataSource = cls_resultado.buscar(buscar);
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


            dgvResultados.Columns["EstudianteNombre"].HeaderText = "Estudiante";
            dgvResultados.Columns["EvaluacionNombre"].HeaderText = "Evaluacion";
            dgvResultados.Columns["MateriaEvaluacion"].HeaderText = "Materia";
            dgvResultados.Columns["PuntajeObtenido"].HeaderText = "Puntaje";
            dgvResultados.Columns["PuntajeMaximoEvaluacion"].HeaderText = "Puntaje Maximo";
            dgvResultados.Columns["FechaEvaluacion"].HeaderText = "Fecha";
            dgvResultados.Columns["Comentarios"].Visible = false;
            dgvResultados.Columns["ResultadoId"].Visible = false;
            dgvResultados.Columns["EstudianteApellido"].Visible = false;
            dgvResultados.Columns["EvaluacionDescripcion"].Visible = false;
            dgvResultados.Columns["EvaluacionId"].Visible = false;
            dgvResultados.Columns["EstudianteId"].Visible = false;


            dgvResultados.Columns.Add(btnEditar);
            dgvResultados.Columns.Add(btnEliminar);

        }
        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResultados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            for (int i = 0; i < dgvResultados.Rows.Count; i++)
            {
                dgvResultados.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void editarEvaluacion(int id)
        {
            FrmResultados frmResultados = new FrmResultados(id);
            frmResultados.ShowDialog();
            this.llenarGrilla(1);

        }
        public void eliminarEvaluacion(int id)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Eliminar Resultado", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cls_Resultado cls_resultado = new cls_Resultado();

                if (cls_resultado.eliminar(id))
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
        private void dgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvResultados.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaSeleccionada = dgvResultados.Rows[e.RowIndex];
                var idResultado = filaSeleccionada.Cells["ResultadoId"].Value;


                if (dgvResultados.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    editarEvaluacion((int)idResultado);
                }

                if (dgvResultados.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    eliminarEvaluacion((int)idResultado);
                }

            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.llenarGrilla(2);
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.llenarGrilla(2);

        }

        private void UcResultados_Load(object sender, EventArgs e)
        {
            this.llenarGrilla(1);
        }
    }
}
