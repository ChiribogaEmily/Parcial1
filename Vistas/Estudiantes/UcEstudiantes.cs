using Parcial_1_Emily_Chiriboga.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Emily_Chiriboga.Vistas.Estudiantes
{
    public partial class UcEstudiantes : UserControl
    {
        public UcEstudiantes()
        {
            InitializeComponent();
            this.llenarGrilla(1);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frmEstudiantes = new FrmEstudiantes(0);
            frmEstudiantes.ShowDialog();
            this.llenarGrilla(1);

        }
        /*
         int number = Parametro para identificar el tipo de carga de la grilla
        number = 1; llamar a todos()
        number = 2; llamar a buscar()
         */
        public void llenarGrilla(int number)
        {
            var cls_estudiante = new cls_Estudiante();
            
            dgvEstudiantes.DataSource = "";
            dgvEstudiantes.Columns.Clear();
            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvEstudiantes.Columns.Add(autoIncrement);


            if (number == 1)
            {

                dgvEstudiantes.DataSource = cls_estudiante.todos();
            }
            else if (number == 2)
            {
                dgvEstudiantes.DataSource = cls_estudiante.buscar(txtBuscar.Text.Trim());

            }


           

            dgvEstudiantes.Columns["Nombre"].HeaderText = "Nombre";
            dgvEstudiantes.Columns["Apellido"].HeaderText = "Apellido";
            dgvEstudiantes.Columns["Telefono"].HeaderText = "Telefono";
            dgvEstudiantes.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvEstudiantes.Columns["EstudianteId"].Visible = false;

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


            dgvEstudiantes.Columns.Add(btnEditar);
            dgvEstudiantes.Columns.Add(btnEliminar);

        }
        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEstudiantes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            for (int i = 0; i < dgvEstudiantes.Rows.Count; i++)
            {
                dgvEstudiantes.Rows[i].Cells[0].Value = i + 1;
            }

        }

        public void editarEstudiante(int id)
        {

            FrmEstudiantes frmPersonal = new FrmEstudiantes(id);
            frmPersonal.ShowDialog();
            this.llenarGrilla(1);

        }
        public void eliminarEstudiante(int id)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Eliminar Estudiante", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cls_Estudiante cls_estudiante = new cls_Estudiante();

                if (cls_estudiante.eliminar(id))
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
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvEstudiantes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaSeleccionada = dgvEstudiantes.Rows[e.RowIndex];
                var idEstudiante = filaSeleccionada.Cells["EstudianteId"].Value;


                if (dgvEstudiantes.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    editarEstudiante((int)idEstudiante);
                }

                if (dgvEstudiantes.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    eliminarEstudiante((int)idEstudiante);
                }

            }
        }
        private void UcEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.llenarGrilla(2);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.llenarGrilla(2);

        }
    }
}
