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
            this.lblJugadores = new System.Windows.Forms.Label();
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCamisola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugadores.ForeColor = System.Drawing.Color.Black;
            this.lblJugadores.Location = new System.Drawing.Point(202, 20);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(211, 28);
            this.lblJugadores.TabIndex = 7;
            this.lblJugadores.Text = "Jugadores asociados:";
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Black;
            this.lblTituloInicial.Location = new System.Drawing.Point(25, 20);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(91, 28);
            this.lblTituloInicial.TabIndex = 6;
            this.lblTituloInicial.Text = "Equipos:";
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(25, 63);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(140, 23);
            this.cmbEquipos.TabIndex = 5;
            this.cmbEquipos.SelectedIndexChanged += new System.EventHandler(this.cmbEquipos_SelectedIndexChanged);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.NoCamisola});
            this.dgvJugadores.Location = new System.Drawing.Point(202, 63);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowTemplate.Height = 25;
            this.dgvJugadores.Size = new System.Drawing.Size(251, 148);
            this.dgvJugadores.TabIndex = 4;
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
            // frmListaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 232);
            this.Controls.Add(this.lblJugadores);
            this.Controls.Add(this.lblTituloInicial);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.dgvJugadores);
            this.Name = "frmListaEquipos";
            this.Text = "frmListaEquipos";
            this.Load += new System.EventHandler(this.frmListaEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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