namespace TorneoPOO
{
    partial class frmRojas
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
            btnGuardarRojas = new Button();
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
            lblTituloInicial.Location = new Point(125, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(71, 31);
            lblTituloInicial.TabIndex = 2;
            lblTituloInicial.Text = "Rojas";
            // 
            // btnGuardarRojas
            // 
            btnGuardarRojas.BackColor = Color.MediumSeaGreen;
            btnGuardarRojas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarRojas.Location = new Point(48, 173);
            btnGuardarRojas.Name = "btnGuardarRojas";
            btnGuardarRojas.Size = new Size(227, 43);
            btnGuardarRojas.TabIndex = 7;
            btnGuardarRojas.Text = "Guardar";
            btnGuardarRojas.UseVisualStyleBackColor = false;
            btnGuardarRojas.Click += btnGuardarRojas_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJugador.Location = new Point(35, 112);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(69, 19);
            lblJugador.TabIndex = 13;
            lblJugador.Text = "Jugador:";
            // 
            // cmbJugador
            // 
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(159, 111);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(133, 23);
            cmbJugador.TabIndex = 12;
            // 
            // upCantidad
            // 
            upCantidad.Location = new Point(159, 72);
            upCantidad.Name = "upCantidad";
            upCantidad.Size = new Size(133, 23);
            upCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad.Location = new Point(35, 72);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 19);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // frmRojas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 228);
            Controls.Add(lblJugador);
            Controls.Add(cmbJugador);
            Controls.Add(upCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnGuardarRojas);
            Controls.Add(lblTituloInicial);
            Name = "frmRojas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRojas";
            Load += frmRojas_Load;
            ((System.ComponentModel.ISupportInitialize)upCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGuardarRojas;
        private Label lblJugador;
        private ComboBox cmbJugador;
        private NumericUpDown upCantidad;
        private Label lblCantidad;
    }
}