namespace TorneoPOO
{
    partial class frmNuevoJugador
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
            btnGuardarJugador = new Button();
            lblNombre = new Label();
            lblCamisola = new Label();
            txtNombreJugador = new TextBox();
            upCamisola = new NumericUpDown();
            cmbEquipo = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)upCamisola).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(74, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(177, 31);
            lblTituloInicial.TabIndex = 1;
            lblTituloInicial.Text = "Nuevo Jugador";
            // 
            // btnGuardarJugador
            // 
            btnGuardarJugador.BackColor = Color.MediumSeaGreen;
            btnGuardarJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarJugador.Location = new Point(53, 173);
            btnGuardarJugador.Name = "btnGuardarJugador";
            btnGuardarJugador.Size = new Size(227, 43);
            btnGuardarJugador.TabIndex = 3;
            btnGuardarJugador.Text = "Guardar";
            btnGuardarJugador.UseVisualStyleBackColor = false;
            btnGuardarJugador.Click += btnGuardarJugador_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(39, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblCamisola
            // 
            lblCamisola.AutoSize = true;
            lblCamisola.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCamisola.Location = new Point(39, 89);
            lblCamisola.Name = "lblCamisola";
            lblCamisola.Size = new Size(74, 19);
            lblCamisola.TabIndex = 5;
            lblCamisola.Text = "Camisola:";
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(163, 54);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(133, 23);
            txtNombreJugador.TabIndex = 6;
            // 
            // upCamisola
            // 
            upCamisola.Location = new Point(163, 89);
            upCamisola.Name = "upCamisola";
            upCamisola.Size = new Size(133, 23);
            upCamisola.TabIndex = 7;
            // 
            // cmbEquipo
            // 
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(163, 128);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(133, 23);
            cmbEquipo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(39, 129);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 9;
            label1.Text = "Equipo:";
            // 
            // frmNuevoJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(label1);
            Controls.Add(cmbEquipo);
            Controls.Add(upCamisola);
            Controls.Add(txtNombreJugador);
            Controls.Add(lblCamisola);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardarJugador);
            Controls.Add(lblTituloInicial);
            Name = "frmNuevoJugador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNuevoJugador";
            Load += frmNuevoJugador_Load;
            ((System.ComponentModel.ISupportInitialize)upCamisola).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarJugador;
        private Label lblNombre;
        private Label lblCamisola;
        private TextBox txtNombreJugador;
        private NumericUpDown upCamisola;
        private ComboBox cmbEquipo;
        private Label label1;
    }
}