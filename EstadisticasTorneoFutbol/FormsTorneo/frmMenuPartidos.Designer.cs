namespace FormsTorneo
{
    partial class frmMenuPartidos
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
            btnDetallePartidos = new Button();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Purple;
            lblTituloInicial.Location = new Point(115, 9);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(103, 31);
            lblTituloInicial.TabIndex = 5;
            lblTituloInicial.Text = "Partidos";
            // 
            // btnDetallePartidos
            // 
            btnDetallePartidos.BackColor = Color.LightCoral;
            btnDetallePartidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDetallePartidos.Location = new Point(48, 115);
            btnDetallePartidos.Name = "btnDetallePartidos";
            btnDetallePartidos.Size = new Size(227, 43);
            btnDetallePartidos.TabIndex = 8;
            btnDetallePartidos.Text = "Detalle Partidos";
            btnDetallePartidos.UseVisualStyleBackColor = false;
            // 
            // frmMenuPartidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 248);
            Controls.Add(btnDetallePartidos);
            Controls.Add(lblTituloInicial);
            Name = "frmMenuPartidos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMenuPartidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnDetallePartidos;
    }
}