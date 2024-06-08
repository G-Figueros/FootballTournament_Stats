namespace TorneoPOO
{
    partial class frmListaTorneos
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
            Nombre = new DataGridViewTextBoxColumn();
            Jugadores = new DataGridViewTextBoxColumn();
            cmbTorneos = new ComboBox();
            lblTituloInicial = new Label();
            lblEquipos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Jugadores });
            dgvEquipos.Location = new Point(194, 64);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.Size = new Size(251, 148);
            dgvEquipos.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Jugadores
            // 
            Jugadores.HeaderText = "Jugadores";
            Jugadores.Name = "Jugadores";
            // 
            // cmbTorneos
            // 
            cmbTorneos.FormattingEnabled = true;
            cmbTorneos.Location = new Point(17, 64);
            cmbTorneos.Name = "cmbTorneos";
            cmbTorneos.Size = new Size(140, 23);
            cmbTorneos.TabIndex = 1;
            cmbTorneos.SelectedIndexChanged += cmbTorneos_SelectedIndexChanged;
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Black;
            lblTituloInicial.Location = new Point(17, 21);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(91, 28);
            lblTituloInicial.TabIndex = 2;
            lblTituloInicial.Text = "Torneos:";
            // 
            // lblEquipos
            // 
            lblEquipos.AutoSize = true;
            lblEquipos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblEquipos.ForeColor = Color.Black;
            lblEquipos.Location = new Point(194, 21);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(189, 28);
            lblEquipos.TabIndex = 3;
            lblEquipos.Text = "Equipos asociados:";
            // 
            // frmListaTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(477, 232);
            Controls.Add(lblEquipos);
            Controls.Add(lblTituloInicial);
            Controls.Add(cmbTorneos);
            Controls.Add(dgvEquipos);
            Name = "frmListaTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaTorneos";
            Load += frmListaTorneos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipos;
        private ComboBox cmbTorneos;
        private Label lblTituloInicial;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Jugadores;
        private Label lblEquipos;
    }
}