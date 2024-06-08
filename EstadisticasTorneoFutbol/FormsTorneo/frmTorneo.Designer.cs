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
            lblTituloInicial = new Label();
            btnGuardarTorneo = new Button();
            txtNombreTorneo = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(119, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(88, 31);
            lblTituloInicial.TabIndex = 3;
            lblTituloInicial.Text = "Torneo";
            // 
            // btnGuardarTorneo
            // 
            btnGuardarTorneo.BackColor = Color.MediumSeaGreen;
            btnGuardarTorneo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarTorneo.Location = new Point(48, 173);
            btnGuardarTorneo.Name = "btnGuardarTorneo";
            btnGuardarTorneo.Size = new Size(227, 43);
            btnGuardarTorneo.TabIndex = 7;
            btnGuardarTorneo.Text = "Guardar";
            btnGuardarTorneo.UseVisualStyleBackColor = false;
            btnGuardarTorneo.Click += btnGuardarTorneo_Click;
            // 
            // txtNombreTorneo
            // 
            txtNombreTorneo.Location = new Point(159, 104);
            txtNombreTorneo.Name = "txtNombreTorneo";
            txtNombreTorneo.Size = new Size(133, 23);
            txtNombreTorneo.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(35, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre:";
            // 
            // frmTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(txtNombreTorneo);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardarTorneo);
            Controls.Add(lblTituloInicial);
            Name = "frmTorneo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTorneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarTorneo;
        private TextBox txtNombreTorneo;
        private Label lblNombre;
    }
}