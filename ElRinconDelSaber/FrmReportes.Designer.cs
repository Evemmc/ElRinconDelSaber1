namespace ElRinconDelSaber
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            lblTituloReportes = new Label();
            label1 = new Label();
            gboxFiltroDeReportes = new GroupBox();
            dtpFechaHasta = new DateTimePicker();
            lblFechaHasta = new Label();
            dtpFechaDesde = new DateTimePicker();
            lblFechaDesde = new Label();
            cmbTipoDeReportes = new ComboBox();
            btnBuscarReporte = new Button();
            lblTipoDeReportes = new Label();
            gbResultadoDeReporte = new GroupBox();
            lblTotalRegistros = new Label();
            btnExportarExcel = new Button();
            dgvResultadosDelReportes = new DataGridView();
            gboxFiltroDeReportes.SuspendLayout();
            gbResultadoDeReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosDelReportes).BeginInit();
            SuspendLayout();
            // 
            // lblTituloReportes
            // 
            lblTituloReportes.AutoSize = true;
            lblTituloReportes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloReportes.ForeColor = Color.Black;
            lblTituloReportes.Location = new Point(60, 18);
            lblTituloReportes.Name = "lblTituloReportes";
            lblTituloReportes.Size = new Size(100, 30);
            lblTituloReportes.TabIndex = 42;
            lblTituloReportes.Text = "Reportes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(68, 48);
            label1.Name = "label1";
            label1.Size = new Size(328, 19);
            label1.TabIndex = 43;
            label1.Text = "Consulta y genera reportes del sistema de biblioteca\r\n";
            // 
            // gboxFiltroDeReportes
            // 
            gboxFiltroDeReportes.Controls.Add(dtpFechaHasta);
            gboxFiltroDeReportes.Controls.Add(lblFechaHasta);
            gboxFiltroDeReportes.Controls.Add(dtpFechaDesde);
            gboxFiltroDeReportes.Controls.Add(lblFechaDesde);
            gboxFiltroDeReportes.Controls.Add(cmbTipoDeReportes);
            gboxFiltroDeReportes.Controls.Add(btnBuscarReporte);
            gboxFiltroDeReportes.Controls.Add(lblTipoDeReportes);
            gboxFiltroDeReportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxFiltroDeReportes.ForeColor = Color.FromArgb(138, 31, 61);
            gboxFiltroDeReportes.Location = new Point(33, 94);
            gboxFiltroDeReportes.Name = "gboxFiltroDeReportes";
            gboxFiltroDeReportes.Size = new Size(739, 111);
            gboxFiltroDeReportes.TabIndex = 44;
            gboxFiltroDeReportes.TabStop = false;
            gboxFiltroDeReportes.Text = "FILTROS DE REPORTES";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(431, 60);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(132, 25);
            dtpFechaHasta.TabIndex = 77;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaHasta.ForeColor = Color.Black;
            lblFechaHasta.Location = new Point(431, 38);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(93, 19);
            lblFechaHasta.TabIndex = 76;
            lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(278, 60);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(132, 25);
            dtpFechaDesde.TabIndex = 75;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaDesde.ForeColor = Color.Black;
            lblFechaDesde.Location = new Point(278, 38);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(95, 19);
            lblFechaDesde.TabIndex = 74;
            lblFechaDesde.Text = "Fecha desde:";
            // 
            // cmbTipoDeReportes
            // 
            cmbTipoDeReportes.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoDeReportes.FormattingEnabled = true;
            cmbTipoDeReportes.Location = new Point(35, 60);
            cmbTipoDeReportes.Name = "cmbTipoDeReportes";
            cmbTipoDeReportes.Size = new Size(224, 27);
            cmbTipoDeReportes.TabIndex = 73;
            // 
            // btnBuscarReporte
            // 
            btnBuscarReporte.BackColor = Color.FromArgb(138, 31, 61);
            btnBuscarReporte.FlatStyle = FlatStyle.Flat;
            btnBuscarReporte.ForeColor = Color.White;
            btnBuscarReporte.Image = (Image)resources.GetObject("btnBuscarReporte.Image");
            btnBuscarReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarReporte.Location = new Point(585, 51);
            btnBuscarReporte.Name = "btnBuscarReporte";
            btnBuscarReporte.Size = new Size(133, 36);
            btnBuscarReporte.TabIndex = 66;
            btnBuscarReporte.Text = "          Buscar";
            btnBuscarReporte.UseVisualStyleBackColor = false;
            btnBuscarReporte.Click += btnBuscarReporte_Click;
            // 
            // lblTipoDeReportes
            // 
            lblTipoDeReportes.AutoSize = true;
            lblTipoDeReportes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipoDeReportes.ForeColor = Color.Black;
            lblTipoDeReportes.Location = new Point(35, 38);
            lblTipoDeReportes.Name = "lblTipoDeReportes";
            lblTipoDeReportes.Size = new Size(125, 19);
            lblTipoDeReportes.TabIndex = 64;
            lblTipoDeReportes.Text = "Tipo de reportes:";
            // 
            // gbResultadoDeReporte
            // 
            gbResultadoDeReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbResultadoDeReporte.Controls.Add(lblTotalRegistros);
            gbResultadoDeReporte.Controls.Add(btnExportarExcel);
            gbResultadoDeReporte.Controls.Add(dgvResultadosDelReportes);
            gbResultadoDeReporte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbResultadoDeReporte.ForeColor = Color.FromArgb(138, 31, 61);
            gbResultadoDeReporte.Location = new Point(33, 221);
            gbResultadoDeReporte.Name = "gbResultadoDeReporte";
            gbResultadoDeReporte.Size = new Size(739, 315);
            gbResultadoDeReporte.TabIndex = 70;
            gbResultadoDeReporte.TabStop = false;
            gbResultadoDeReporte.Text = "RESULTADOS DEL REPORTE";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.ForeColor = Color.Black;
            lblTotalRegistros.Location = new Point(24, 252);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(142, 19);
            lblTotalRegistros.TabIndex = 68;
            lblTotalRegistros.Text = "Total de registros: 0";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(138, 31, 61);
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.ForeColor = Color.White;
            btnExportarExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarExcel.Location = new Point(561, 252);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(157, 40);
            btnExportarExcel.TabIndex = 67;
            btnExportarExcel.Text = "  Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // dgvResultadosDelReportes
            // 
            dgvResultadosDelReportes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultadosDelReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosDelReportes.Location = new Point(24, 48);
            dgvResultadosDelReportes.Name = "dgvResultadosDelReportes";
            dgvResultadosDelReportes.Size = new Size(696, 185);
            dgvResultadosDelReportes.TabIndex = 29;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(799, 611);
            Controls.Add(gbResultadoDeReporte);
            Controls.Add(gboxFiltroDeReportes);
            Controls.Add(label1);
            Controls.Add(lblTituloReportes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReportes";
            Text = "FrmReportes";
            gboxFiltroDeReportes.ResumeLayout(false);
            gboxFiltroDeReportes.PerformLayout();
            gbResultadoDeReporte.ResumeLayout(false);
            gbResultadoDeReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosDelReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloReportes;
        private Label label1;
        private GroupBox gboxFiltroDeReportes;
        private Button btnBuscarReporte;
        private TextBox txtCodigoDePrestamo;
        private Label lblTipoDeReportes;
        private ComboBox cmbTipoDeReportes;
        private DateTimePicker dtpFechaHasta;
        private Label lblFechaHasta;
        private DateTimePicker dtpFechaDesde;
        private Label lblFechaDesde;
        private GroupBox gbResultadoDeReporte;
        private Button btnExportarExcel;
        private DataGridView dgvResultadosDelReportes;
        private Label lblTotalRegistros;
    }
}