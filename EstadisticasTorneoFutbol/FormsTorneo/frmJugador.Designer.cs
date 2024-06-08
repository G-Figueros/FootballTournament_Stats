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
            lblTituloInicial = new Label();
            btnIncrementarAmarillas = new Button();
            btnIncrementarGoles = new Button();
            btnNuevoJugador = new Button();
            btnIncrementarRojas = new Button();
            btnVerJugadores = new Button();
            btnIncrementarMinutos = new Button();
            btnDetalleJugadores = new Button();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(112, -1);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(101, 31);
            lblTituloInicial.TabIndex = 1;
            lblTituloInicial.Text = "Jugador";
            // 
            // btnIncrementarAmarillas
            // 
            btnIncrementarAmarillas.BackColor = Color.Khaki;
            btnIncrementarAmarillas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIncrementarAmarillas.Location = new Point(50, 129);
            btnIncrementarAmarillas.Name = "btnIncrementarAmarillas";
            btnIncrementarAmarillas.Size = new Size(227, 43);
            btnIncrementarAmarillas.TabIndex = 6;
            btnIncrementarAmarillas.Text = "Incrementar Amarillas";
            btnIncrementarAmarillas.UseVisualStyleBackColor = false;
            btnIncrementarAmarillas.Click += btnIncrementarAmarillas_Click;
            // 
            // btnIncrementarGoles
            // 
            btnIncrementarGoles.BackColor = Color.Plum;
            btnIncrementarGoles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIncrementarGoles.Location = new Point(50, 80);
            btnIncrementarGoles.Name = "btnIncrementarGoles";
            btnIncrementarGoles.Size = new Size(227, 43);
            btnIncrementarGoles.TabIndex = 5;
            btnIncrementarGoles.Text = "Incrementar Goles";
            btnIncrementarGoles.UseVisualStyleBackColor = false;
            btnIncrementarGoles.Click += btnIncrementarGoles_Click;
            // 
            // btnNuevoJugador
            // 
            btnNuevoJugador.BackColor = SystemColors.ActiveCaption;
            btnNuevoJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoJugador.Location = new Point(50, 33);
            btnNuevoJugador.Name = "btnNuevoJugador";
            btnNuevoJugador.Size = new Size(227, 43);
            btnNuevoJugador.TabIndex = 4;
            btnNuevoJugador.Text = "Nuevo Jugador";
            btnNuevoJugador.UseVisualStyleBackColor = false;
            btnNuevoJugador.Click += btnNuevoJugador_Click;
            // 
            // btnIncrementarRojas
            // 
            btnIncrementarRojas.BackColor = Color.MistyRose;
            btnIncrementarRojas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIncrementarRojas.Location = new Point(50, 178);
            btnIncrementarRojas.Name = "btnIncrementarRojas";
            btnIncrementarRojas.Size = new Size(227, 43);
            btnIncrementarRojas.TabIndex = 7;
            btnIncrementarRojas.Text = "Incrementar Rojas";
            btnIncrementarRojas.UseVisualStyleBackColor = false;
            btnIncrementarRojas.Click += btnIncrementarRojas_Click;
            // 
            // btnVerJugadores
            // 
            btnVerJugadores.BackColor = Color.MediumSeaGreen;
            btnVerJugadores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerJugadores.Location = new Point(50, 330);
            btnVerJugadores.Name = "btnVerJugadores";
            btnVerJugadores.Size = new Size(227, 43);
            btnVerJugadores.TabIndex = 8;
            btnVerJugadores.Text = "Estadísticas Jugadores";
            btnVerJugadores.UseVisualStyleBackColor = false;
            btnVerJugadores.Click += btnVerJugadores_Click;
            // 
            // btnIncrementarMinutos
            // 
            btnIncrementarMinutos.BackColor = Color.Coral;
            btnIncrementarMinutos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIncrementarMinutos.Location = new Point(50, 227);
            btnIncrementarMinutos.Name = "btnIncrementarMinutos";
            btnIncrementarMinutos.Size = new Size(227, 43);
            btnIncrementarMinutos.TabIndex = 9;
            btnIncrementarMinutos.Text = "Incrementar Minutos";
            btnIncrementarMinutos.UseVisualStyleBackColor = false;
            // 
            // btnDetalleJugadores
            // 
            btnDetalleJugadores.BackColor = Color.LightCoral;
            btnDetalleJugadores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDetalleJugadores.Location = new Point(50, 276);
            btnDetalleJugadores.Name = "btnDetalleJugadores";
            btnDetalleJugadores.Size = new Size(227, 43);
            btnDetalleJugadores.TabIndex = 10;
            btnDetalleJugadores.Text = "Detalles Jugadores";
            btnDetalleJugadores.UseVisualStyleBackColor = false;
            // 
            // frmJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(331, 385);
            Controls.Add(btnDetalleJugadores);
            Controls.Add(btnIncrementarMinutos);
            Controls.Add(btnVerJugadores);
            Controls.Add(btnIncrementarRojas);
            Controls.Add(btnIncrementarAmarillas);
            Controls.Add(btnIncrementarGoles);
            Controls.Add(btnNuevoJugador);
            Controls.Add(lblTituloInicial);
            Name = "frmJugador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmJugador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnIncrementarAmarillas;
        private Button btnIncrementarGoles;
        private Button btnNuevoJugador;
        private Button btnIncrementarRojas;
        private Button btnVerJugadores;
        private Button btnIncrementarMinutos;
        private Button btnDetalleJugadores;
    }
}