namespace Parcial_1_Emily_Chiriboga.Vistas.Evaluaciones
{
    partial class UcEvaluaciones
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
            panel2 = new Panel();
            dgvEvaluaciones = new DataGridView();
            panel1 = new Panel();
            btnBuscar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvEvaluaciones);
            panel2.Location = new Point(0, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 372);
            panel2.TabIndex = 3;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Dock = DockStyle.Fill;
            dgvEvaluaciones.Location = new Point(0, 0);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.Size = new Size(784, 372);
            dgvEvaluaciones.TabIndex = 0;
            dgvEvaluaciones.CellClick += dgvEvaluaciones_CellClick;
            dgvEvaluaciones.DataBindingComplete += dgvEvaluaciones_DataBindingComplete;
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
            panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 64);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Right;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(599, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 52);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 86, 253);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Dock = DockStyle.Right;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(695, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 52);
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
            // UcEvaluaciones
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 195);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(784, 456);
            Name = "UcEvaluaciones";
            Size = new Size(784, 456);
            Load += UcEvaluacions_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvEvaluaciones;
        private Panel panel1;
        private Button btnAgregar;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}
