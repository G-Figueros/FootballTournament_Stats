namespace FormsTorneo
{
    partial class frmDetalleTorneos
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
            lblTituloInicial = new Label();
            dgvDetalleTorneos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            btnActualizarTorneos = new Button();
            btnEliminarTorneos = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleTorneos).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(157, 25);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(180, 31);
            lblTituloInicial.TabIndex = 5;
            lblTituloInicial.Text = "Detalle Torneos";
            // 
            // dgvDetalleTorneos
            // 
            dgvDetalleTorneos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleTorneos.Columns.AddRange(new DataGridViewColumn[] { Nombre });
            dgvDetalleTorneos.Location = new Point(30, 80);
            dgvDetalleTorneos.Name = "dgvDetalleTorneos";
            dgvDetalleTorneos.Size = new Size(238, 188);
            dgvDetalleTorneos.TabIndex = 6;
            dgvDetalleTorneos.CellClick += dgvDetalleTorneos_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // btnActualizarTorneos
            // 
            btnActualizarTorneos.BackColor = SystemColors.ActiveCaption;
            btnActualizarTorneos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizarTorneos.Location = new Point(306, 80);
            btnActualizarTorneos.Name = "btnActualizarTorneos";
            btnActualizarTorneos.Size = new Size(151, 43);
            btnActualizarTorneos.TabIndex = 8;
            btnActualizarTorneos.Text = "Actualizar";
            btnActualizarTorneos.UseVisualStyleBackColor = false;
            btnActualizarTorneos.Click += btnActualizarTorneos_Click;
            // 
            // btnEliminarTorneos
            // 
            btnEliminarTorneos.BackColor = Color.LightCoral;
            btnEliminarTorneos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminarTorneos.Location = new Point(306, 129);
            btnEliminarTorneos.Name = "btnEliminarTorneos";
            btnEliminarTorneos.Size = new Size(151, 43);
            btnEliminarTorneos.TabIndex = 9;
            btnEliminarTorneos.Text = "Eliminar";
            btnEliminarTorneos.UseVisualStyleBackColor = false;
            btnEliminarTorneos.Click += btnEliminarTorneos_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.MediumSeaGreen;
            btnRefrescar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefrescar.Location = new Point(306, 178);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(151, 43);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // frmDetalleTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(483, 295);
            Controls.Add(btnRefrescar);
            Controls.Add(btnEliminarTorneos);
            Controls.Add(btnActualizarTorneos);
            Controls.Add(dgvDetalleTorneos);
            Controls.Add(lblTituloInicial);
            Name = "frmDetalleTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalleTorneos";
            Load += frmDetalleTorneos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleTorneos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private DataGridView dgvDetalleTorneos;
        private DataGridViewTextBoxColumn Nombre;
        private Button btnActualizarTorneos;
        private Button btnEliminarTorneos;
        private Button btnRefrescar;
    }
}