namespace TorneoPOO
{
    partial class frmListaTorneos
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
            dgvEquipos = new DataGridView();
            cmbTorneos = new ComboBox();
            lblTituloInicial = new Label();
            lblEquipos = new Label();
            Equipo = new DataGridViewTextBoxColumn();
            PJ = new DataGridViewTextBoxColumn();
            G = new DataGridViewTextBoxColumn();
            E = new DataGridViewTextBoxColumn();
            P = new DataGridViewTextBoxColumn();
            GF = new DataGridViewTextBoxColumn();
            GC = new DataGridViewTextBoxColumn();
            DG = new DataGridViewTextBoxColumn();
            PTS = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipos
            // 
            dgvEquipos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { Equipo, PJ, G, E, P, GF, GC, DG, PTS });
            dgvEquipos.Location = new Point(27, 110);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.Size = new Size(942, 250);
            dgvEquipos.TabIndex = 0;
            // 
            // cmbTorneos
            // 
            cmbTorneos.FormattingEnabled = true;
            cmbTorneos.Location = new Point(114, 26);
            cmbTorneos.Name = "cmbTorneos";
            cmbTorneos.Size = new Size(140, 23);
            cmbTorneos.TabIndex = 1;
            cmbTorneos.SelectedIndexChanged += cmbTorneos_SelectedIndexChanged;
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.Black;
            lblTituloInicial.Location = new Point(17, 21);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(91, 28);
            lblTituloInicial.TabIndex = 2;
            lblTituloInicial.Text = "Torneos:";
            // 
            // lblEquipos
            // 
            lblEquipos.AutoSize = true;
            lblEquipos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblEquipos.ForeColor = Color.Black;
            lblEquipos.Location = new Point(17, 70);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(305, 28);
            lblEquipos.TabIndex = 3;
            lblEquipos.Text = "Estadisticas equipos asociados:";
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            // 
            // PJ
            // 
            PJ.HeaderText = "PJ";
            PJ.Name = "PJ";
            PJ.ReadOnly = true;
            // 
            // G
            // 
            G.HeaderText = "G";
            G.Name = "G";
            G.ReadOnly = true;
            // 
            // E
            // 
            E.HeaderText = "E";
            E.Name = "E";
            E.ReadOnly = true;
            // 
            // P
            // 
            P.HeaderText = "P";
            P.Name = "P";
            P.ReadOnly = true;
            // 
            // GF
            // 
            GF.HeaderText = "GF";
            GF.Name = "GF";
            GF.ReadOnly = true;
            // 
            // GC
            // 
            GC.HeaderText = "GC";
            GC.Name = "GC";
            GC.ReadOnly = true;
            // 
            // DG
            // 
            DG.HeaderText = "DG";
            DG.Name = "DG";
            DG.ReadOnly = true;
            // 
            // PTS
            // 
            PTS.HeaderText = "PTS";
            PTS.Name = "PTS";
            PTS.ReadOnly = true;
            // 
            // frmListaTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(992, 379);
            Controls.Add(lblEquipos);
            Controls.Add(lblTituloInicial);
            Controls.Add(cmbTorneos);
            Controls.Add(dgvEquipos);
            Name = "frmListaTorneos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaTorneos";
            Load += frmListaTorneos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEquipos;
        private ComboBox cmbTorneos;
        private Label lblTituloInicial;
        private Label lblEquipos;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn PJ;
        private DataGridViewTextBoxColumn G;
        private DataGridViewTextBoxColumn E;
        private DataGridViewTextBoxColumn P;
        private DataGridViewTextBoxColumn GF;
        private DataGridViewTextBoxColumn GC;
        private DataGridViewTextBoxColumn DG;
        private DataGridViewTextBoxColumn PTS;
    }
}