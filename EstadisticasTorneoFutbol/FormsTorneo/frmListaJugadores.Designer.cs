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
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.dgvListaJugadores = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCamisola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetasAmarillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetasRojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(222, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(179, 31);
            this.lblTituloInicial.TabIndex = 1;
            this.lblTituloInicial.Text = "Lista Jugadores";
            // 
            // dgvListaJugadores
            // 
            this.dgvListaJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvListaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.NoCamisola,
            this.TarjetasAmarillas,
            this.TarjetasRojas,
            this.Goles});
            this.dgvListaJugadores.Location = new System.Drawing.Point(35, 66);
            this.dgvListaJugadores.Name = "dgvListaJugadores";
            this.dgvListaJugadores.RowTemplate.Height = 25;
            this.dgvListaJugadores.Size = new System.Drawing.Size(553, 243);
            this.dgvListaJugadores.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // NoCamisola
            // 
            this.NoCamisola.HeaderText = "NoCamisola";
            this.NoCamisola.Name = "NoCamisola";
            // 
            // TarjetasAmarillas
            // 
            this.TarjetasAmarillas.HeaderText = "TarjetasAmarillas";
            this.TarjetasAmarillas.Name = "TarjetasAmarillas";
            // 
            // TarjetasRojas
            // 
            this.TarjetasRojas.HeaderText = "TarjetasRojas";
            this.TarjetasRojas.Name = "TarjetasRojas";
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.Name = "Goles";
            // 
            // frmListaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 344);
            this.Controls.Add(this.dgvListaJugadores);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmListaJugadores";
            this.Text = "frmListaJugadores";
            this.Load += new System.EventHandler(this.frmListaJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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