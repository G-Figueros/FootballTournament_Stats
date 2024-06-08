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
            lblTituloInicial = new Label();
            btnGuardarEquipo = new Button();
            lblTorneo = new Label();
            cmbTorneo = new ComboBox();
            txtNombreEquipo = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(78, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(165, 31);
            lblTituloInicial.TabIndex = 4;
            lblTituloInicial.Text = "Nuevo Equipo";
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.BackColor = Color.MediumSeaGreen;
            btnGuardarEquipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarEquipo.Location = new Point(50, 173);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(227, 43);
            btnGuardarEquipo.TabIndex = 8;
            btnGuardarEquipo.Text = "Guardar";
            btnGuardarEquipo.UseVisualStyleBackColor = false;
            btnGuardarEquipo.Click += btnGuardarEquipo_Click;
            // 
            // lblTorneo
            // 
            lblTorneo.AutoSize = true;
            lblTorneo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTorneo.Location = new Point(35, 114);
            lblTorneo.Name = "lblTorneo";
            lblTorneo.Size = new Size(60, 19);
            lblTorneo.TabIndex = 15;
            lblTorneo.Text = "Torneo:";
            // 
            // cmbTorneo
            // 
            cmbTorneo.FormattingEnabled = true;
            cmbTorneo.Location = new Point(159, 113);
            cmbTorneo.Name = "cmbTorneo";
            cmbTorneo.Size = new Size(133, 23);
            cmbTorneo.TabIndex = 14;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(159, 78);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(133, 23);
            txtNombreEquipo.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(35, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // frmEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(lblTorneo);
            Controls.Add(cmbTorneo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardarEquipo);
            Controls.Add(lblTituloInicial);
            Name = "frmEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEquipo";
            Load += frmEquipo_Load;
            ResumeLayout(false);
            PerformLayout();
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