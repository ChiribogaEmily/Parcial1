namespace Parcial_1_Emily_Chiriboga.Vistas.Estudiantes
{
    partial class FrmEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnInsertar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 29);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(317, 29);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 200);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(317, 29);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(12, 272);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(317, 29);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Blue;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(227, 347);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(102, 41);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(12, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 41);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(163, 21);
            label4.TabIndex = 9;
            label4.Text = "Fecha de Nacimiento";
            // 
            // FrmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 195);
            ClientSize = new Size(357, 419);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudiantes";
            Load += FrmEstudiantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnInsertar;
        private Button btnCancelar;
        private Label label4;
    }
}