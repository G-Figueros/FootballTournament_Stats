namespace TorneoPOO
{
    partial class frmAmarillas
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
            btnGuardarAmarillas = new Button();
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
            lblTituloInicial.Location = new Point(110, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(115, 31);
            lblTituloInicial.TabIndex = 2;
            lblTituloInicial.Text = "Amarillas";
            // 
            // btnGuardarAmarillas
            // 
            btnGuardarAmarillas.BackColor = Color.MediumSeaGreen;
            btnGuardarAmarillas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarAmarillas.Location = new Point(54, 173);
            btnGuardarAmarillas.Name = "btnGuardarAmarillas";
            btnGuardarAmarillas.Size = new Size(227, 43);
            btnGuardarAmarillas.TabIndex = 7;
            btnGuardarAmarillas.Text = "Guardar";
            btnGuardarAmarillas.UseVisualStyleBackColor = false;
            btnGuardarAmarillas.Click += btnGuardarAmarillas_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJugador.Location = new Point(39, 113);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(69, 19);
            lblJugador.TabIndex = 17;
            lblJugador.Text = "Jugador:";
            // 
            // cmbJugador
            // 
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(163, 112);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(133, 23);
            cmbJugador.TabIndex = 16;
            // 
            // upCantidad
            // 
            upCantidad.Location = new Point(163, 73);
            upCantidad.Name = "upCantidad";
            upCantidad.Size = new Size(133, 23);
            upCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.Location = new Point(39, 73);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 19);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad:";
            // 
            // frmAmarillas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(lblJugador);
            Controls.Add(cmbJugador);
            Controls.Add(upCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnGuardarAmarillas);
            Controls.Add(lblTituloInicial);
            Name = "frmAmarillas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAmarillas";
            Load += frmAmarillas_Load;
            ((System.ComponentModel.ISupportInitialize)upCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarAmarillas;
        private Label lblJugador;
        private ComboBox cmbJugador;
        private NumericUpDown upCantidad;
        private Label lblCantidad;
    }
}