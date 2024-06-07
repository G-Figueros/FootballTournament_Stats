namespace TorneoPOO
{
    partial class frmTorneo
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
            this.btnGuardarTorneo = new System.Windows.Forms.Button();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(119, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(88, 31);
            this.lblTituloInicial.TabIndex = 3;
            this.lblTituloInicial.Text = "Torneo";
            // 
            // btnGuardarTorneo
            // 
            this.btnGuardarTorneo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarTorneo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarTorneo.Location = new System.Drawing.Point(48, 173);
            this.btnGuardarTorneo.Name = "btnGuardarTorneo";
            this.btnGuardarTorneo.Size = new System.Drawing.Size(227, 43);
            this.btnGuardarTorneo.TabIndex = 7;
            this.btnGuardarTorneo.Text = "Guardar";
            this.btnGuardarTorneo.UseVisualStyleBackColor = false;
            this.btnGuardarTorneo.Click += new System.EventHandler(this.btnGuardarTorneo_Click);
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.Location = new System.Drawing.Point(159, 104);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(133, 23);
            this.txtNombreTorneo.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(35, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.txtNombreTorneo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardarTorneo);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmTorneo";
            this.Text = "frmTorneo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarTorneo;
        private TextBox txtNombreTorneo;
        private Label lblNombre;
    }
}