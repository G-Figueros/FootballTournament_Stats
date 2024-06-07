namespace TorneoPOO
{
    partial class frmEquipo
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
            this.btnGuardarEquipo = new System.Windows.Forms.Button();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(78, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(165, 31);
            this.lblTituloInicial.TabIndex = 4;
            this.lblTituloInicial.Text = "Nuevo Equipo";
            // 
            // btnGuardarEquipo
            // 
            this.btnGuardarEquipo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarEquipo.Location = new System.Drawing.Point(50, 173);
            this.btnGuardarEquipo.Name = "btnGuardarEquipo";
            this.btnGuardarEquipo.Size = new System.Drawing.Size(227, 43);
            this.btnGuardarEquipo.TabIndex = 8;
            this.btnGuardarEquipo.Text = "Guardar";
            this.btnGuardarEquipo.UseVisualStyleBackColor = false;
            this.btnGuardarEquipo.Click += new System.EventHandler(this.btnGuardarEquipo_Click);
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTorneo.Location = new System.Drawing.Point(35, 114);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(60, 19);
            this.lblTorneo.TabIndex = 15;
            this.lblTorneo.Text = "Torneo:";
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(159, 113);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(133, 23);
            this.cmbTorneo.TabIndex = 14;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(159, 78);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(133, 23);
            this.txtNombreEquipo.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(35, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardarEquipo);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmEquipo";
            this.Text = "frmEquipo";
            this.Load += new System.EventHandler(this.frmEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarEquipo;
        private Label lblTorneo;
        private ComboBox cmbTorneo;
        private TextBox txtNombreEquipo;
        private Label lblNombre;
    }
}