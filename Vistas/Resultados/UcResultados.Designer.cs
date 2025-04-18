namespace Parcial_1_Emily_Chiriboga.Vistas.Resultados
{
    partial class UcResultados
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
            dgvResultados = new DataGridView();
            panel1 = new Panel();
            btnBuscar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvResultados);
            panel2.Location = new Point(0, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 372);
            panel2.TabIndex = 5;
            // 
            // dgvResultados
            // 
            dgvResultados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Dock = DockStyle.Fill;
            dgvResultados.Location = new Point(0, 0);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(784, 372);
            dgvResultados.TabIndex = 0;
            dgvResultados.CellClick += dgvResultados_CellClick;
            dgvResultados.DataBindingComplete += dgvResultados_DataBindingComplete;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 52);
            panel1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 64);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Right;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(562, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 52);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 5;
            label1.Text = "Buscar por estudiante:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(188, 11);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(338, 29);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 86, 253);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Dock = DockStyle.Right;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(667, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 52);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // UcResultados
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 233, 195);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(784, 456);
            Name = "UcResultados";
            Size = new Size(784, 456);
            Load += UcResultados_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvResultados;
        private Panel panel1;
        private Button btnAgregar;
        private Button btnBuscar;
        private Label label1;
        private TextBox txtBuscar;
    }
}
