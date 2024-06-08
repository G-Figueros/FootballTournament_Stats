namespace FormsTorneo
{
    partial class frmMinutos
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
            btnGuardarMinutos = new Button();
            cmbJugador = new ComboBox();
            upCantidad = new NumericUpDown();
            lblCantidad = new Label();
            lblJugador = new Label();
            ((System.ComponentModel.ISupportInitialize)upCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(115, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(104, 31);
            lblTituloInicial.TabIndex = 3;
            lblTituloInicial.Text = "Minutos";
            // 
            // btnGuardarMinutos
            // 
            btnGuardarMinutos.BackColor = Color.MediumSeaGreen;
            btnGuardarMinutos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarMinutos.Location = new Point(53, 173);
            btnGuardarMinutos.Name = "btnGuardarMinutos";
            btnGuardarMinutos.Size = new Size(227, 43);
            btnGuardarMinutos.TabIndex = 8;
            btnGuardarMinutos.Text = "Guardar";
            btnGuardarMinutos.UseVisualStyleBackColor = false;
            btnGuardarMinutos.Click += btnGuardarMinutos_Click;
            // 
            // cmbJugador
            // 
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(147, 115);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(133, 23);
            cmbJugador.TabIndex = 17;
            // 
            // upCantidad
            // 
            upCantidad.Location = new Point(147, 74);
            upCantidad.Name = "upCantidad";
            upCantidad.Size = new Size(133, 23);
            upCantidad.TabIndex = 18;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.Location = new Point(38, 74);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 19);
            lblCantidad.TabIndex = 19;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJugador.Location = new Point(38, 116);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(69, 19);
            lblJugador.TabIndex = 20;
            lblJugador.Text = "Jugador:";
            // 
            // frmMinutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(lblJugador);
            Controls.Add(lblCantidad);
            Controls.Add(upCantidad);
            Controls.Add(cmbJugador);
            Controls.Add(btnGuardarMinutos);
            Controls.Add(lblTituloInicial);
            Name = "frmMinutos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMinutos";
            ((System.ComponentModel.ISupportInitialize)upCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarMinutos;
        private ComboBox cmbJugador;
        private NumericUpDown upCantidad;
        private Label lblCantidad;
        private Label lblJugador;
    }
}