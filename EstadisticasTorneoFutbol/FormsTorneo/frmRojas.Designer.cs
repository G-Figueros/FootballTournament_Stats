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
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.btnGuardarRojas = new System.Windows.Forms.Button();
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
            this.lblTituloInicial.Location = new System.Drawing.Point(125, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(71, 31);
            this.lblTituloInicial.TabIndex = 2;
            this.lblTituloInicial.Text = "Rojas";
            // 
            // btnGuardarRojas
            // 
            this.btnGuardarRojas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarRojas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarRojas.Location = new System.Drawing.Point(48, 173);
            this.btnGuardarRojas.Name = "btnGuardarRojas";
            this.btnGuardarRojas.Size = new System.Drawing.Size(227, 43);
            this.btnGuardarRojas.TabIndex = 7;
            this.btnGuardarRojas.Text = "Guardar";
            this.btnGuardarRojas.UseVisualStyleBackColor = false;
            this.btnGuardarRojas.Click += new System.EventHandler(this.btnGuardarRojas_Click);
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugador.Location = new System.Drawing.Point(35, 112);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(69, 19);
            this.lblJugador.TabIndex = 13;
            this.lblJugador.Text = "Jugador:";
            // 
            // cmbJugador
            // 
            this.cmbJugador.FormattingEnabled = true;
            this.cmbJugador.Location = new System.Drawing.Point(159, 111);
            this.cmbJugador.Name = "cmbJugador";
            this.cmbJugador.Size = new System.Drawing.Size(133, 23);
            this.cmbJugador.TabIndex = 12;
            // 
            // upCantidad
            // 
            this.upCantidad.Location = new System.Drawing.Point(159, 72);
            this.upCantidad.Name = "upCantidad";
            this.upCantidad.Size = new System.Drawing.Size(133, 23);
            this.upCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(35, 72);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // frmRojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.cmbJugador);
            this.Controls.Add(this.upCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnGuardarRojas);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmRojas";
            this.Text = "frmRojas";
            this.Load += new System.EventHandler(this.frmRojas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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