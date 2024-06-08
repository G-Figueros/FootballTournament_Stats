namespace FormsTorneo
{
    partial class frmDetalleEquipo
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
            dgvEquipos = new DataGridView();
            lblTituloInicial = new Label();
            btnRefrescarEquipos = new Button();
            btnEliminarEquipos = new Button();
            btnActualizarEquipos = new Button();
            lblTorneo = new Label();
            cmbTorneo = new ComboBox();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Estadio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Pais, Estadio });
            dgvEquipos.Location = new Point(25, 139);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.Size = new Size(339, 150);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(152, 23);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(181, 31);
            lblTituloInicial.TabIndex = 6;
            lblTituloInicial.Text = "Detalle Equipos";
            // 
            // btnRefrescarEquipos
            // 
            btnRefrescarEquipos.BackColor = Color.MediumSeaGreen;
            btnRefrescarEquipos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefrescarEquipos.Location = new Point(389, 237);
            btnRefrescarEquipos.Name = "btnRefrescarEquipos";
            btnRefrescarEquipos.Size = new Size(151, 43);
            btnRefrescarEquipos.TabIndex = 13;
            btnRefrescarEquipos.Text = "Refrescar";
            btnRefrescarEquipos.UseVisualStyleBackColor = false;
            btnRefrescarEquipos.Click += btnRefrescarEquipos_Click;
            // 
            // btnEliminarEquipos
            // 
            btnEliminarEquipos.BackColor = Color.LightCoral;
            btnEliminarEquipos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminarEquipos.Location = new Point(389, 188);
            btnEliminarEquipos.Name = "btnEliminarEquipos";
            btnEliminarEquipos.Size = new Size(151, 43);
            btnEliminarEquipos.TabIndex = 12;
            btnEliminarEquipos.Text = "Eliminar";
            btnEliminarEquipos.UseVisualStyleBackColor = false;
            btnEliminarEquipos.Click += btnEliminarEquipos_Click;
            // 
            // btnActualizarEquipos
            // 
            btnActualizarEquipos.BackColor = SystemColors.ActiveCaption;
            btnActualizarEquipos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizarEquipos.Location = new Point(389, 139);
            btnActualizarEquipos.Name = "btnActualizarEquipos";
            btnActualizarEquipos.Size = new Size(151, 43);
            btnActualizarEquipos.TabIndex = 11;
            btnActualizarEquipos.Text = "Actualizar";
            btnActualizarEquipos.UseVisualStyleBackColor = false;
            btnActualizarEquipos.Click += btnActualizarEquipos_Click;
            // 
            // lblTorneo
            // 
            lblTorneo.AutoSize = true;
            lblTorneo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTorneo.Location = new Point(28, 89);
            lblTorneo.Name = "lblTorneo";
            lblTorneo.Size = new Size(60, 19);
            lblTorneo.TabIndex = 17;
            lblTorneo.Text = "Torneo:";
            // 
            // cmbTorneo
            // 
            cmbTorneo.FormattingEnabled = true;
            cmbTorneo.Location = new Point(152, 88);
            cmbTorneo.Name = "cmbTorneo";
            cmbTorneo.Size = new Size(133, 23);
            cmbTorneo.TabIndex = 16;
            cmbTorneo.SelectedIndexChanged += cmbTorneo_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            Pais.ReadOnly = true;
            // 
            // Estadio
            // 
            Estadio.HeaderText = "Estadio";
            Estadio.Name = "Estadio";
            Estadio.ReadOnly = true;
            // 
            // frmDetalleEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(566, 320);
            Controls.Add(lblTorneo);
            Controls.Add(cmbTorneo);
            Controls.Add(btnRefrescarEquipos);
            Controls.Add(btnEliminarEquipos);
            Controls.Add(btnActualizarEquipos);
            Controls.Add(lblTituloInicial);
            Controls.Add(dgvEquipos);
            Name = "frmDetalleEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalleEquipo";
            Load += frmDetalleEquipo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipos;
        private Label lblTituloInicial;
        private Button btnRefrescarEquipos;
        private Button btnEliminarEquipos;
        private Button btnActualizarEquipos;
        private Label lblTorneo;
        private ComboBox cmbTorneo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Estadio;
    }
}