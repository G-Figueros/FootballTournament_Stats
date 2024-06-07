namespace TorneoPOO
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloInicial = new Label();
            btnMenuTorneo = new Button();
            btnMenuJugador = new Button();
            btnMenuEquipo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(87, 20);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(258, 31);
            lblTituloInicial.TabIndex = 0;
            lblTituloInicial.Text = "ESTADISTICAS FUTBOL";
            // 
            // btnMenuTorneo
            // 
            btnMenuTorneo.BackColor = SystemColors.ActiveCaption;
            btnMenuTorneo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuTorneo.Location = new Point(103, 91);
            btnMenuTorneo.Name = "btnMenuTorneo";
            btnMenuTorneo.Size = new Size(227, 43);
            btnMenuTorneo.TabIndex = 1;
            btnMenuTorneo.Text = "Menu Torneo";
            btnMenuTorneo.UseVisualStyleBackColor = false;
            btnMenuTorneo.Click += btnMenuTorneo_Click;
            // 
            // btnMenuJugador
            // 
            btnMenuJugador.BackColor = Color.MediumSeaGreen;
            btnMenuJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuJugador.Location = new Point(103, 189);
            btnMenuJugador.Name = "btnMenuJugador";
            btnMenuJugador.Size = new Size(227, 43);
            btnMenuJugador.TabIndex = 2;
            btnMenuJugador.Text = "Menu Jugador";
            btnMenuJugador.UseVisualStyleBackColor = false;
            btnMenuJugador.Click += btnMenuJugador_Click;
            // 
            // btnMenuEquipo
            // 
            btnMenuEquipo.BackColor = Color.LightCoral;
            btnMenuEquipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuEquipo.Location = new Point(103, 140);
            btnMenuEquipo.Name = "btnMenuEquipo";
            btnMenuEquipo.Size = new Size(227, 43);
            btnMenuEquipo.TabIndex = 3;
            btnMenuEquipo.Text = "Menu Equipo";
            btnMenuEquipo.UseVisualStyleBackColor = false;
            btnMenuEquipo.Click += btnMenuEquipo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(61, 274);
            label1.Name = "label1";
            label1.Size = new Size(305, 15);
            label1.TabIndex = 4;
            label1.Text = "Gabriel Figueros (22-9287) - Jeyson Mazariegos (16-5903)";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(429, 298);
            Controls.Add(label1);
            Controls.Add(btnMenuEquipo);
            Controls.Add(btnMenuJugador);
            Controls.Add(btnMenuTorneo);
            Controls.Add(lblTituloInicial);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnMenuTorneo;
        private Button btnMenuJugador;
        private Button btnMenuEquipo;
        private Label label1;
    }
}