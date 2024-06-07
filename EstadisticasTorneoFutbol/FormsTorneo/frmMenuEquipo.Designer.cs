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
            this.btnVerEquipos = new System.Windows.Forms.Button();
            this.btnNuevoEquipo = new System.Windows.Forms.Button();
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerEquipos
            // 
            this.btnVerEquipos.BackColor = System.Drawing.Color.LightCoral;
            this.btnVerEquipos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerEquipos.Location = new System.Drawing.Point(53, 112);
            this.btnVerEquipos.Name = "btnVerEquipos";
            this.btnVerEquipos.Size = new System.Drawing.Size(227, 43);
            this.btnVerEquipos.TabIndex = 6;
            this.btnVerEquipos.Text = "Ver Equipos";
            this.btnVerEquipos.UseVisualStyleBackColor = false;
            this.btnVerEquipos.Click += new System.EventHandler(this.btnVerEquipos_Click);
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevoEquipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoEquipo.Location = new System.Drawing.Point(53, 63);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(227, 43);
            this.btnNuevoEquipo.TabIndex = 5;
            this.btnNuevoEquipo.Text = "Nuevo Equipo";
            this.btnNuevoEquipo.UseVisualStyleBackColor = false;
            this.btnNuevoEquipo.Click += new System.EventHandler(this.btnNuevoEquipo_Click);
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(120, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(89, 31);
            this.lblTituloInicial.TabIndex = 4;
            this.lblTituloInicial.Text = "Equipo";
            // 
            // frmMenuEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.btnVerEquipos);
            this.Controls.Add(this.btnNuevoEquipo);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmMenuEquipo";
            this.Text = "frmMenuEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerEquipos;
        private Button btnNuevoEquipo;
        private Label lblTituloInicial;
    }
}