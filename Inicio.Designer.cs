namespace Parcial_1_Emily_Chiriboga
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            contenedor = new Panel();
            panel2 = new Panel();
            btnEvaluaciones = new Button();
            btnEstudiantes = new Button();
            btnResultados = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            contenedor.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 233, 195);
            panel1.Controls.Add(contenedor);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 516);
            panel1.TabIndex = 0;
            // 
            // contenedor
            // 
            contenedor.Controls.Add(label1);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 60);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(784, 456);
            contenedor.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 24, 216);
            panel2.Controls.Add(btnEvaluaciones);
            panel2.Controls.Add(btnEstudiantes);
            panel2.Controls.Add(btnResultados);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 60);
            panel2.TabIndex = 0;
            // 
            // btnEvaluaciones
            // 
            btnEvaluaciones.Dock = DockStyle.Left;
            btnEvaluaciones.FlatStyle = FlatStyle.Flat;
            btnEvaluaciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvaluaciones.ForeColor = SystemColors.ButtonHighlight;
            btnEvaluaciones.Location = new Point(254, 0);
            btnEvaluaciones.Name = "btnEvaluaciones";
            btnEvaluaciones.Size = new Size(287, 60);
            btnEvaluaciones.TabIndex = 4;
            btnEvaluaciones.Text = "Evaluaciones";
            btnEvaluaciones.UseVisualStyleBackColor = true;
            btnEvaluaciones.Click += btnEvaluaciones_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Dock = DockStyle.Left;
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstudiantes.ForeColor = SystemColors.ButtonHighlight;
            btnEstudiantes.Location = new Point(0, 0);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(254, 60);
            btnEstudiantes.TabIndex = 3;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += btnEstudiantes_Click;
            // 
            // btnResultados
            // 
            btnResultados.Dock = DockStyle.Right;
            btnResultados.FlatStyle = FlatStyle.Flat;
            btnResultados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultados.ForeColor = SystemColors.ButtonHighlight;
            btnResultados.Location = new Point(539, 0);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(245, 60);
            btnResultados.TabIndex = 2;
            btnResultados.Text = "Resultados";
            btnResultados.UseVisualStyleBackColor = true;
            btnResultados.Click += btnResultados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(154, 191);
            label1.Name = "label1";
            label1.Size = new Size(500, 21);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido/a al sistema de gestion de evaluaciones y resultados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 516);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Inicio";
            Text = "Evaluacion Parcial 1 - Emily Chiriboga";
            panel1.ResumeLayout(false);
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnEvaluaciones;
        private Button btnEstudiantes;
        private Button btnResultados;
        private Panel contenedor;
        private Label label1;
    }
}
