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
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.btnGuardarAmarillas = new System.Windows.Forms.Button();
            this.lblJugador = new System.Windows.Forms.Label();
            this.cmbJugador = new System.Windows.Forms.ComboBox();
            this.upCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(110, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(115, 31);
            this.lblTituloInicial.TabIndex = 2;
            this.lblTituloInicial.Text = "Amarillas";
            // 
            // btnGuardarAmarillas
            // 
            this.btnGuardarAmarillas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarAmarillas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarAmarillas.Location = new System.Drawing.Point(54, 173);
            this.btnGuardarAmarillas.Name = "btnGuardarAmarillas";
            this.btnGuardarAmarillas.Size = new System.Drawing.Size(227, 43);
            this.btnGuardarAmarillas.TabIndex = 7;
            this.btnGuardarAmarillas.Text = "Guardar";
            this.btnGuardarAmarillas.UseVisualStyleBackColor = false;
            this.btnGuardarAmarillas.Click += new System.EventHandler(this.btnGuardarAmarillas_Click);
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugador.Location = new System.Drawing.Point(39, 113);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(69, 19);
            this.lblJugador.TabIndex = 17;
            this.lblJugador.Text = "Jugador:";
            // 
            // cmbJugador
            // 
            this.cmbJugador.FormattingEnabled = true;
            this.cmbJugador.Location = new System.Drawing.Point(163, 112);
            this.cmbJugador.Name = "cmbJugador";
            this.cmbJugador.Size = new System.Drawing.Size(133, 23);
            this.cmbJugador.TabIndex = 16;
            // 
            // upCantidad
            // 
            this.upCantidad.Location = new System.Drawing.Point(163, 73);
            this.upCantidad.Name = "upCantidad";
            this.upCantidad.Size = new System.Drawing.Size(133, 23);
            this.upCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(39, 73);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 14;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // frmAmarillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.cmbJugador);
            this.Controls.Add(this.upCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnGuardarAmarillas);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmAmarillas";
            this.Text = "frmAmarillas";
            this.Load += new System.EventHandler(this.frmAmarillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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