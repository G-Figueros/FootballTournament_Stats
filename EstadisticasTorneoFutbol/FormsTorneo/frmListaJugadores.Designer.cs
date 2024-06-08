namespace TorneoPOO
{
    partial class frmListaJugadores
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
            dgvListaJugadores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            NoCamisola = new DataGridViewTextBoxColumn();
            TarjetasAmarillas = new DataGridViewTextBoxColumn();
            TarjetasRojas = new DataGridViewTextBoxColumn();
            Goles = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaJugadores).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(222, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(179, 31);
            lblTituloInicial.TabIndex = 1;
            lblTituloInicial.Text = "Lista Jugadores";
            // 
            // dgvListaJugadores
            // 
            dgvListaJugadores.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvListaJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaJugadores.Columns.AddRange(new DataGridViewColumn[] { Nombre, NoCamisola, TarjetasAmarillas, TarjetasRojas, Goles });
            dgvListaJugadores.Location = new Point(35, 66);
            dgvListaJugadores.Name = "dgvListaJugadores";
            dgvListaJugadores.Size = new Size(553, 243);
            dgvListaJugadores.TabIndex = 2;
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
            // TarjetasAmarillas
            // 
            TarjetasAmarillas.HeaderText = "TarjetasAmarillas";
            TarjetasAmarillas.Name = "TarjetasAmarillas";
            // 
            // TarjetasRojas
            // 
            TarjetasRojas.HeaderText = "TarjetasRojas";
            TarjetasRojas.Name = "TarjetasRojas";
            // 
            // Goles
            // 
            Goles.HeaderText = "Goles";
            Goles.Name = "Goles";
            // 
            // frmListaJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(627, 344);
            Controls.Add(dgvListaJugadores);
            Controls.Add(lblTituloInicial);
            Name = "frmListaJugadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaJugadores";
            Load += frmListaJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private DataGridView dataGridView1;
        private DataGridView dgvListaJugadores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn NoCamisola;
        private DataGridViewTextBoxColumn TarjetasAmarillas;
        private DataGridViewTextBoxColumn TarjetasRojas;
        private DataGridViewTextBoxColumn Goles;
    }
}