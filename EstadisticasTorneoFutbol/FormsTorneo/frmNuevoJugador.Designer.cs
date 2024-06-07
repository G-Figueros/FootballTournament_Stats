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
            this.lblTituloInicial = new System.Windows.Forms.Label();
            this.btnGuardarJugador = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCamisola = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.upCamisola = new System.Windows.Forms.NumericUpDown();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upCamisola)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(74, 9);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(177, 31);
            this.lblTituloInicial.TabIndex = 1;
            this.lblTituloInicial.Text = "Nuevo Jugador";
            // 
            // btnGuardarJugador
            // 
            this.btnGuardarJugador.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardarJugador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarJugador.Location = new System.Drawing.Point(53, 173);
            this.btnGuardarJugador.Name = "btnGuardarJugador";
            this.btnGuardarJugador.Size = new System.Drawing.Size(227, 43);
            this.btnGuardarJugador.TabIndex = 3;
            this.btnGuardarJugador.Text = "Guardar";
            this.btnGuardarJugador.UseVisualStyleBackColor = false;
            this.btnGuardarJugador.Click += new System.EventHandler(this.btnGuardarJugador_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(39, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCamisola
            // 
            this.lblCamisola.AutoSize = true;
            this.lblCamisola.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCamisola.Location = new System.Drawing.Point(39, 89);
            this.lblCamisola.Name = "lblCamisola";
            this.lblCamisola.Size = new System.Drawing.Size(74, 19);
            this.lblCamisola.TabIndex = 5;
            this.lblCamisola.Text = "Camisola:";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(163, 54);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(133, 23);
            this.txtNombreJugador.TabIndex = 6;
            // 
            // upCamisola
            // 
            this.upCamisola.Location = new System.Drawing.Point(163, 89);
            this.upCamisola.Name = "upCamisola";
            this.upCamisola.Size = new System.Drawing.Size(133, 23);
            this.upCamisola.TabIndex = 7;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(163, 128);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(133, 23);
            this.cmbEquipo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Equipo:";
            // 
            // frmNuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.upCamisola);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.lblCamisola);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardarJugador);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmNuevoJugador";
            this.Text = "frmNuevoJugador";
            this.Load += new System.EventHandler(this.frmNuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upCamisola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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