namespace Parcial_1_Emily_Chiriboga.Vistas.Estudiantes
{
    partial class UcEstudiantes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBuscar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            panel2 = new Panel();
            dgvEstudiantes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 52);
            panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 64);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Right;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(592, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 52);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 86, 253);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Dock = DockStyle.Right;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(688, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 52);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 14);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(163, 11);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(399, 29);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvEstudiantes);
            panel2.Location = new Point(0, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 372);
            panel2.TabIndex = 1;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Dock = DockStyle.Fill;
            dgvEstudiantes.Location = new Point(0, 0);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(784, 372);
            dgvEstudiantes.TabIndex = 0;
            dgvEstudiantes.CellClick += dgvEstudiantes_CellClick;
            dgvEstudiantes.CellContentClick += dgvEstudiantes_CellContentClick_1;
            dgvEstudiantes.DataBindingComplete += dgvEstudiantes_DataBindingComplete;
            // 
            // UcEstudiantes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 195);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UcEstudiantes";
            Size = new Size(784, 456);
            Load += UcEstudiantes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAgregar;
        private Label label1;
        private TextBox txtBuscar;
        private Panel panel2;
        private DataGridView dgvEstudiantes;
        private Button btnBuscar;
    }
}
