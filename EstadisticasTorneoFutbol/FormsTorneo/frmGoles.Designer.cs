namespace TorneoPOO
{
    partial class frmGoles
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
            btnGuardarGoles = new Button();
            lblJugador = new Label();
            cmbJugador = new ComboBox();
            upCantidad = new NumericUpDown();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)upCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(123, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(73, 31);
            lblTituloInicial.TabIndex = 2;
            lblTituloInicial.Text = "Goles";
            // 
            // btnGuardarGoles
            // 
            btnGuardarGoles.BackColor = Color.MediumSeaGreen;
            btnGuardarGoles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarGoles.Location = new Point(52, 173);
            btnGuardarGoles.Name = "btnGuardarGoles";
            btnGuardarGoles.Size = new Size(227, 43);
            btnGuardarGoles.TabIndex = 6;
            btnGuardarGoles.Text = "Guardar";
            btnGuardarGoles.UseVisualStyleBackColor = false;
            btnGuardarGoles.Click += btnGuardarGoles_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJugador.Location = new Point(41, 114);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(69, 19);
            lblJugador.TabIndex = 17;
            lblJugador.Text = "Jugador:";
            // 
            // cmbJugador
            // 
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(165, 113);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(133, 23);
            cmbJugador.TabIndex = 16;
            // 
            // upCantidad
            // 
            upCantidad.Location = new Point(165, 74);
            upCantidad.Name = "upCantidad";
            upCantidad.Size = new Size(133, 23);
            upCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.Location = new Point(41, 74);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 19);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad:";
            // 
            // frmGoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(lblJugador);
            Controls.Add(cmbJugador);
            Controls.Add(upCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnGuardarGoles);
            Controls.Add(lblTituloInicial);
            Name = "frmGoles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGoles";
            Load += frmGoles_Load;
            ((System.ComponentModel.ISupportInitialize)upCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarGoles;
        private Label lblJugador;
        private ComboBox cmbJugador;
        private NumericUpDown upCantidad;
        private Label lblCantidad;
    }
}