namespace TorneoPOO
{
    partial class frmMenuTorneo
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
            this.btnVerTorneos = new System.Windows.Forms.Button();
            this.btnNuevoTorneo = new System.Windows.Forms.Button();
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerTorneos
            // 
            this.btnVerTorneos.BackColor = System.Drawing.Color.LightCoral;
            this.btnVerTorneos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerTorneos.Location = new System.Drawing.Point(47, 112);
            this.btnVerTorneos.Name = "btnVerTorneos";
            this.btnVerTorneos.Size = new System.Drawing.Size(227, 43);
            this.btnVerTorneos.TabIndex = 6;
            this.btnVerTorneos.Text = "Ver Torneos";
            this.btnVerTorneos.UseVisualStyleBackColor = false;
            this.btnVerTorneos.Click += new System.EventHandler(this.btnVerTorneos_Click);
            // 
            // btnNuevoTorneo
            // 
            this.btnNuevoTorneo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevoTorneo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoTorneo.Location = new System.Drawing.Point(47, 63);
            this.btnNuevoTorneo.Name = "btnNuevoTorneo";
            this.btnNuevoTorneo.Size = new System.Drawing.Size(227, 43);
            this.btnNuevoTorneo.TabIndex = 5;
            this.btnNuevoTorneo.Text = "Nuevo Torneo";
            this.btnNuevoTorneo.UseVisualStyleBackColor = false;
            this.btnNuevoTorneo.Click += new System.EventHandler(this.btnNuevoTorneo_Click);
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(115, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(88, 31);
            this.lblTituloInicial.TabIndex = 4;
            this.lblTituloInicial.Text = "Torneo";
            // 
            // frmMenuTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.btnVerTorneos);
            this.Controls.Add(this.btnNuevoTorneo);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmMenuTorneo";
            this.Text = "frmMenuTorneo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerTorneos;
        private Button btnNuevoTorneo;
        private Label lblTituloInicial;
    }
}