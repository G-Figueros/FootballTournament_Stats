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
            btnVerTorneos = new Button();
            btnNuevoTorneo = new Button();
            lblTituloInicial = new Label();
            SuspendLayout();
            // 
            // btnVerTorneos
            // 
            btnVerTorneos.BackColor = Color.LightCoral;
            btnVerTorneos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerTorneos.Location = new Point(47, 112);
            btnVerTorneos.Name = "btnVerTorneos";
            btnVerTorneos.Size = new Size(227, 43);
            btnVerTorneos.TabIndex = 6;
            btnVerTorneos.Text = "Ver Torneos";
            btnVerTorneos.UseVisualStyleBackColor = false;
            btnVerTorneos.Click += btnVerTorneos_Click;
            // 
            // btnNuevoTorneo
            // 
            btnNuevoTorneo.BackColor = SystemColors.ActiveCaption;
            btnNuevoTorneo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoTorneo.Location = new Point(47, 63);
            btnNuevoTorneo.Name = "btnNuevoTorneo";
            btnNuevoTorneo.Size = new Size(227, 43);
            btnNuevoTorneo.TabIndex = 5;
            btnNuevoTorneo.Text = "Nuevo Torneo";
            btnNuevoTorneo.UseVisualStyleBackColor = false;
            btnNuevoTorneo.Click += btnNuevoTorneo_Click;
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(115, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(88, 31);
            lblTituloInicial.TabIndex = 4;
            lblTituloInicial.Text = "Torneo";
            // 
            // frmMenuTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(btnVerTorneos);
            Controls.Add(btnNuevoTorneo);
            Controls.Add(lblTituloInicial);
            Name = "frmMenuTorneo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuTorneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerTorneos;
        private Button btnNuevoTorneo;
        private Label lblTituloInicial;
    }
}