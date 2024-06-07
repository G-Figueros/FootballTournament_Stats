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
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTorneos = new System.Windows.Forms.ComboBox();
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.lblEquipos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Jugadores});
            this.dgvEquipos.Location = new System.Drawing.Point(194, 64);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.RowTemplate.Height = 25;
            this.dgvEquipos.Size = new System.Drawing.Size(251, 148);
            this.dgvEquipos.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Jugadores
            // 
            this.Jugadores.HeaderText = "Jugadores";
            this.Jugadores.Name = "Jugadores";
            // 
            // cmbTorneos
            // 
            this.cmbTorneos.FormattingEnabled = true;
            this.cmbTorneos.Location = new System.Drawing.Point(17, 64);
            this.cmbTorneos.Name = "cmbTorneos";
            this.cmbTorneos.Size = new System.Drawing.Size(140, 23);
            this.cmbTorneos.TabIndex = 1;
            this.cmbTorneos.SelectedIndexChanged += new System.EventHandler(this.cmbTorneos_SelectedIndexChanged);
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Black;
            this.lblTituloInicial.Location = new System.Drawing.Point(17, 21);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(91, 28);
            this.lblTituloInicial.TabIndex = 2;
            this.lblTituloInicial.Text = "Torneos:";
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquipos.ForeColor = System.Drawing.Color.Black;
            this.lblEquipos.Location = new System.Drawing.Point(194, 21);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(189, 28);
            this.lblEquipos.TabIndex = 3;
            this.lblEquipos.Text = "Equipos asociados:";
            // 
            // frmListaTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 232);
            this.Controls.Add(this.lblEquipos);
            this.Controls.Add(this.lblTituloInicial);
            this.Controls.Add(this.cmbTorneos);
            this.Controls.Add(this.dgvEquipos);
            this.Name = "frmListaTorneos";
            this.Text = "frmListaTorneos";
            this.Load += new System.EventHandler(this.frmListaTorneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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