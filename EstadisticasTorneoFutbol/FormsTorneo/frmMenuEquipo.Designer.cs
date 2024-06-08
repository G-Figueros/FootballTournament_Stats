namespace TorneoPOO
{
    partial class frmMenuEquipo
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
            btnVerEquipos = new Button();
            btnNuevoEquipo = new Button();
            lblTituloInicial = new Label();
            SuspendLayout();
            // 
            // btnVerEquipos
            // 
            btnVerEquipos.BackColor = Color.LightCoral;
            btnVerEquipos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerEquipos.Location = new Point(53, 112);
            btnVerEquipos.Name = "btnVerEquipos";
            btnVerEquipos.Size = new Size(227, 43);
            btnVerEquipos.TabIndex = 6;
            btnVerEquipos.Text = "Ver Equipos";
            btnVerEquipos.UseVisualStyleBackColor = false;
            btnVerEquipos.Click += btnVerEquipos_Click;
            // 
            // btnNuevoEquipo
            // 
            btnNuevoEquipo.BackColor = SystemColors.ActiveCaption;
            btnNuevoEquipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoEquipo.Location = new Point(53, 63);
            btnNuevoEquipo.Name = "btnNuevoEquipo";
            btnNuevoEquipo.Size = new Size(227, 43);
            btnNuevoEquipo.TabIndex = 5;
            btnNuevoEquipo.Text = "Nuevo Equipo";
            btnNuevoEquipo.UseVisualStyleBackColor = false;
            btnNuevoEquipo.Click += btnNuevoEquipo_Click;
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(120, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(89, 31);
            lblTituloInicial.TabIndex = 4;
            lblTituloInicial.Text = "Equipo";
            // 
            // frmMenuEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(btnVerEquipos);
            Controls.Add(btnNuevoEquipo);
            Controls.Add(lblTituloInicial);
            Name = "frmMenuEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuEquipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerEquipos;
        private Button btnNuevoEquipo;
        private Label lblTituloInicial;
    }
}