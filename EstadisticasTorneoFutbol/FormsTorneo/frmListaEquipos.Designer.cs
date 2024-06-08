namespace TorneoPOO
{
    partial class frmListaEquipos
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
            lblJugadores = new Label();
            lblTituloInicial = new Label();
            cmbEquipos = new ComboBox();
            dgvJugadores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            NoCamisola = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // lblJugadores
            // 
            lblJugadores.AutoSize = true;
            lblJugadores.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblJugadores.ForeColor = Color.Black;
            lblJugadores.Location = new Point(202, 20);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(211, 28);
            lblJugadores.TabIndex = 7;
            lblJugadores.Text = "Jugadores asociados:";
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Black;
            lblTituloInicial.Location = new Point(25, 20);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(91, 28);
            lblTituloInicial.TabIndex = 6;
            lblTituloInicial.Text = "Equipos:";
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(25, 63);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(140, 23);
            cmbEquipos.TabIndex = 5;
            cmbEquipos.SelectedIndexChanged += cmbEquipos_SelectedIndexChanged;
            // 
            // dgvJugadores
            // 
            dgvJugadores.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Columns.AddRange(new DataGridViewColumn[] { Nombre, NoCamisola });
            dgvJugadores.Location = new Point(202, 63);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.Size = new Size(251, 148);
            dgvJugadores.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // NoCamisola
            // 
            NoCamisola.HeaderText = "NoCamisola";
            NoCamisola.Name = "NoCamisola";
            // 
            // frmListaEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(477, 232);
            Controls.Add(lblJugadores);
            Controls.Add(lblTituloInicial);
            Controls.Add(cmbEquipos);
            Controls.Add(dgvJugadores);
            Name = "frmListaEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaEquipos";
            Load += frmListaEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadores;
        private Label lblTituloInicial;
        private ComboBox cmbEquipos;
        private DataGridView dgvJugadores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NoCamisola;
    }
}