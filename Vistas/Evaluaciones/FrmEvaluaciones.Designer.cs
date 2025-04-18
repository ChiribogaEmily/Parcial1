namespace Parcial_1_Emily_Chiriboga.Vistas.Evaluaciones
{
    partial class FrmEvaluaciones
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
            label4 = new Label();
            btnCancelar = new Button();
            btnInsertar = new Button();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            txtPuntajeMaximo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            rtbDescripcion = new RichTextBox();
            cmbMateria = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(42, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 19;
            label4.Text = "Fecha";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(38, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 41);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Blue;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(328, 371);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(102, 41);
            btnInsertar.TabIndex = 17;
            btnInsertar.Text = "Guardar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnGuardar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(42, 183);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(388, 29);
            dtpFecha.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(289, 92);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 15;
            label3.Text = "Puntaje Máximo";
            // 
            // txtPuntajeMaximo
            // 
            txtPuntajeMaximo.Location = new Point(289, 116);
            txtPuntajeMaximo.Name = "txtPuntajeMaximo";
            txtPuntajeMaximo.Size = new Size(141, 29);
            txtPuntajeMaximo.TabIndex = 14;
            txtPuntajeMaximo.KeyPress += txtPuntajeMaximo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(38, 231);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 13;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 17);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 11;
            label1.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(42, 41);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(219, 29);
            txtTitulo.TabIndex = 10;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(38, 255);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(392, 81);
            rtbDescripcion.TabIndex = 20;
            rtbDescripcion.Text = "";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(42, 116);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(219, 29);
            cmbMateria.TabIndex = 21;
            cmbMateria.KeyPress += cmbMateria_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(42, 92);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 22;
            label5.Text = "Materia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(289, 17);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 24;
            label6.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(289, 41);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(141, 29);
            cmbTipo.TabIndex = 23;
            cmbTipo.KeyPress += cmbTipo_KeyPress;
            // 
            // FrmEvaluaciones
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 195);
            ClientSize = new Size(472, 431);
            Controls.Add(label6);
            Controls.Add(cmbTipo);
            Controls.Add(label5);
            Controls.Add(cmbMateria);
            Controls.Add(rtbDescripcion);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtPuntajeMaximo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmEvaluaciones";
            Text = "FrmEvaluaciones";
            Load += FrmEvaluaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnCancelar;
        private Button btnInsertar;
        private DateTimePicker dtpFecha;
        private Label label3;
        private TextBox txtPuntajeMaximo;
        private Label label2;
        private Label label1;
        private TextBox txtTitulo;
        private RichTextBox rtbDescripcion;
        private ComboBox cmbMateria;
        private Label label5;
        private Label label6;
        private ComboBox cmbTipo;
    }
}