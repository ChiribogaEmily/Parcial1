using Parcial_1_Emily_Chiriboga.Controladores;
using Parcial_1_Emily_Chiriboga.Modelos;
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
    public partial class FrmEstudiantes : Form
    {
        private bool editar = false;
        private int estudianteId = 0;
        public FrmEstudiantes(int? idEstudiante)
        {
            InitializeComponent();
            if (idEstudiante != 0)
            {
                editar = true;
                estudianteId = (int)idEstudiante;
                cargarDatosEstudiantes((int)idEstudiante);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            cargarDatosEstudiantes(estudianteId);
        }

        private void cargarDatosEstudiantes(int id)
        {
            if (editar)
            {
                cls_Estudiante cls_estudiante = new cls_Estudiante();
                var estudiante = cls_estudiante.uno(id);
                if (estudiante != null)
                {
                    txtNombre.Text = estudiante.Nombre;
                    txtApellido.Text = estudiante.Apellido;
                    txtTelefono.Text = estudiante.Telefono;
                    dtpFechaNacimiento.Value = (DateTime)estudiante.FechaNacimiento;
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }
            if (txtTelefono.Text.Length < 10)
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos");
                return;
            }
            if (txtTelefono.Text.Length > 11)
            {
                MessageBox.Show("El número de teléfono no debe tener más de 11 dígitos");
                return;
            }
            cls_Estudiante cls_estudiante = new cls_Estudiante();
            var mensaje = "";
            Estudiante estudiante = new Estudiante
            {
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dtpFechaNacimiento.Value
            };
            if (editar)
            {
                estudiante.EstudianteId = estudianteId;
                mensaje = cls_estudiante.actualizar(estudiante);
            }
            else
            {
                mensaje = cls_estudiante.insertar(estudiante);
            }

            MessageBox.Show(mensaje);
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
