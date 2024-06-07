namespace TorneoPOO
{
    partial class frmJugador
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
            this.btnIncrementarAmarillas = new System.Windows.Forms.Button();
            this.btnIncrementarGoles = new System.Windows.Forms.Button();
            this.btnNuevoJugador = new System.Windows.Forms.Button();
            this.btnIncrementarRojas = new System.Windows.Forms.Button();
            this.btnVerJugadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloInicial
            // 
            this.lblTituloInicial.AutoSize = true;
            this.lblTituloInicial.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloInicial.ForeColor = System.Drawing.Color.Purple;
            this.lblTituloInicial.Location = new System.Drawing.Point(112, -1);
            this.lblTituloInicial.Name = "lblTituloInicial";
            this.lblTituloInicial.Size = new System.Drawing.Size(101, 31);
            this.lblTituloInicial.TabIndex = 1;
            this.lblTituloInicial.Text = "Jugador";
            // 
            // btnIncrementarAmarillas
            // 
            this.btnIncrementarAmarillas.BackColor = System.Drawing.Color.Khaki;
            this.btnIncrementarAmarillas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncrementarAmarillas.Location = new System.Drawing.Point(50, 129);
            this.btnIncrementarAmarillas.Name = "btnIncrementarAmarillas";
            this.btnIncrementarAmarillas.Size = new System.Drawing.Size(227, 43);
            this.btnIncrementarAmarillas.TabIndex = 6;
            this.btnIncrementarAmarillas.Text = "Incrementar Amarillas";
            this.btnIncrementarAmarillas.UseVisualStyleBackColor = false;
            this.btnIncrementarAmarillas.Click += new System.EventHandler(this.btnIncrementarAmarillas_Click);
            // 
            // btnIncrementarGoles
            // 
            this.btnIncrementarGoles.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIncrementarGoles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncrementarGoles.Location = new System.Drawing.Point(50, 80);
            this.btnIncrementarGoles.Name = "btnIncrementarGoles";
            this.btnIncrementarGoles.Size = new System.Drawing.Size(227, 43);
            this.btnIncrementarGoles.TabIndex = 5;
            this.btnIncrementarGoles.Text = "Incrementar Goles";
            this.btnIncrementarGoles.UseVisualStyleBackColor = false;
            this.btnIncrementarGoles.Click += new System.EventHandler(this.btnIncrementarGoles_Click);
            // 
            // btnNuevoJugador
            // 
            this.btnNuevoJugador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevoJugador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoJugador.Location = new System.Drawing.Point(50, 33);
            this.btnNuevoJugador.Name = "btnNuevoJugador";
            this.btnNuevoJugador.Size = new System.Drawing.Size(227, 43);
            this.btnNuevoJugador.TabIndex = 4;
            this.btnNuevoJugador.Text = "Nuevo Jugador";
            this.btnNuevoJugador.UseVisualStyleBackColor = false;
            this.btnNuevoJugador.Click += new System.EventHandler(this.btnNuevoJugador_Click);
            // 
            // btnIncrementarRojas
            // 
            this.btnIncrementarRojas.BackColor = System.Drawing.Color.LightCoral;
            this.btnIncrementarRojas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncrementarRojas.Location = new System.Drawing.Point(50, 178);
            this.btnIncrementarRojas.Name = "btnIncrementarRojas";
            this.btnIncrementarRojas.Size = new System.Drawing.Size(227, 43);
            this.btnIncrementarRojas.TabIndex = 7;
            this.btnIncrementarRojas.Text = "Incrementar Rojas";
            this.btnIncrementarRojas.UseVisualStyleBackColor = false;
            this.btnIncrementarRojas.Click += new System.EventHandler(this.btnIncrementarRojas_Click);
            // 
            // btnVerJugadores
            // 
            this.btnVerJugadores.BackColor = System.Drawing.Color.Orchid;
            this.btnVerJugadores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerJugadores.Location = new System.Drawing.Point(50, 227);
            this.btnVerJugadores.Name = "btnVerJugadores";
            this.btnVerJugadores.Size = new System.Drawing.Size(227, 43);
            this.btnVerJugadores.TabIndex = 8;
            this.btnVerJugadores.Text = "Ver Jugadores";
            this.btnVerJugadores.UseVisualStyleBackColor = false;
            this.btnVerJugadores.Click += new System.EventHandler(this.btnVerJugadores_Click);
            // 
            // frmJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 276);
            this.Controls.Add(this.btnVerJugadores);
            this.Controls.Add(this.btnIncrementarRojas);
            this.Controls.Add(this.btnIncrementarAmarillas);
            this.Controls.Add(this.btnIncrementarGoles);
            this.Controls.Add(this.btnNuevoJugador);
            this.Controls.Add(this.lblTituloInicial);
            this.Name = "frmJugador";
            this.Text = "frmJugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTituloInicial;
        private Button btnIncrementarAmarillas;
        private Button btnIncrementarGoles;
        private Button btnNuevoJugador;
        private Button btnIncrementarRojas;
        private Button btnVerJugadores;
    }
}