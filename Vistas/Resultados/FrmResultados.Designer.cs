namespace Parcial_1_Emily_Chiriboga.Vistas.Resultados
{
    partial class FrmResultados
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
            label6 = new Label();
            cmbEstudiante = new ComboBox();
            rtbComentarios = new RichTextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            txtPuntajeObtenido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPuntajeMaximo = new TextBox();
            label4 = new Label();
            cmbEvaluaciones = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(51, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 38;
            label6.Text = "Estudiante";
            // 
            // cmbEstudiante
            // 
            cmbEstudiante.FormattingEnabled = true;
            cmbEstudiante.Location = new Point(51, 63);
            cmbEstudiante.Margin = new Padding(4);
            cmbEstudiante.Name = "cmbEstudiante";
            cmbEstudiante.Size = new Size(242, 29);
            cmbEstudiante.TabIndex = 37;
            cmbEstudiante.KeyPress += cmbEstudiante_KeyPress;
            // 
            // rtbComentarios
            // 
            rtbComentarios.Location = new Point(51, 237);
            rtbComentarios.Margin = new Padding(4);
            rtbComentarios.Name = "rtbComentarios";
            rtbComentarios.Size = new Size(498, 112);
            rtbComentarios.TabIndex = 34;
            rtbComentarios.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(51, 373);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 57);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Blue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(418, 373);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 57);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 29;
            label3.Text = "Puntaje Obtenido";
            // 
            // txtPuntajeObtenido
            // 
            txtPuntajeObtenido.Location = new Point(51, 160);
            txtPuntajeObtenido.Margin = new Padding(4);
            txtPuntajeObtenido.Name = "txtPuntajeObtenido";
            txtPuntajeObtenido.Size = new Size(180, 29);
            txtPuntajeObtenido.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 204);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 27;
            label2.Text = "Comentarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(369, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 40;
            label1.Text = "Puntaje Máximo";
            // 
            // txtPuntajeMaximo
            // 
            txtPuntajeMaximo.Location = new Point(369, 160);
            txtPuntajeMaximo.Margin = new Padding(4);
            txtPuntajeMaximo.Name = "txtPuntajeMaximo";
            txtPuntajeMaximo.Size = new Size(180, 29);
            txtPuntajeMaximo.TabIndex = 39;
            txtPuntajeMaximo.KeyPress += txtPuntajeMaximo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(307, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 42;
            label4.Text = "Evaluacion";
            // 
            // cmbEvaluaciones
            // 
            cmbEvaluaciones.FormattingEnabled = true;
            cmbEvaluaciones.Location = new Point(307, 63);
            cmbEvaluaciones.Margin = new Padding(4);
            cmbEvaluaciones.Name = "cmbEvaluaciones";
            cmbEvaluaciones.Size = new Size(242, 29);
            cmbEvaluaciones.TabIndex = 41;
            cmbEvaluaciones.SelectedIndexChanged += cmbEvaluaciones_SelectedIndexChanged;
            cmbEvaluaciones.SelectedValueChanged += cmbEvaluaciones_SelectedValueChanged;
            cmbEvaluaciones.KeyPress += cmbEvaluaciones_KeyPress;
            // 
            // FrmResultados
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 195);
            ClientSize = new Size(570, 446);
            Controls.Add(label4);
            Controls.Add(cmbEvaluaciones);
            Controls.Add(label1);
            Controls.Add(txtPuntajeMaximo);
            Controls.Add(label6);
            Controls.Add(cmbEstudiante);
            Controls.Add(rtbComentarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txtPuntajeObtenido);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmResultados";
            Text = "Resultados";
            Load += FrmResultados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cmbEstudiante;
        private RichTextBox rtbComentarios;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label3;
        private TextBox txtPuntajeObtenido;
        private Label label2;
        private Label label1;
        private TextBox txtPuntajeMaximo;
        private Label label4;
        private ComboBox cmbEvaluaciones;
    }
}