namespace ElRinconDelSaber
{
    partial class FrmPrestamoDeLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamoDeLibros));
            label1 = new Label();
            lblTitulo = new Label();
            gboxDatosDelPrestamo = new GroupBox();
            txtCodigoPrestamo = new TextBox();
            lblCodigoPrestamo = new Label();
            lblEstadoPrestamo = new Label();
            cmbEstadoPrestamo = new ComboBox();
            dtpFechaDevolucion = new DateTimePicker();
            lblFechaDevolucion = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            btnLibroPrestamo = new Button();
            cmbLibroPrestamo = new ComboBox();
            lblLibroPrestamo = new Label();
            btnUsuarioPrestamo = new Button();
            pictureBox1 = new PictureBox();
            cboxUsuarioPrestamo = new ComboBox();
            lblUsuarioPrestamo = new Label();
            lblFechaPrestamo = new Label();
            gbDetallesDelPrestamo = new GroupBox();
            txtObservaciones = new TextBox();
            lbObservaciones = new Label();
            gboxAccionesPrestamo = new GroupBox();
            btnLimpiarPrestamo = new Button();
            btnBuscarPrestamo = new Button();
            btnEliminarPrestamo = new Button();
            btnEditarPrestamo = new Button();
            btnGuardarPrestamo = new Button();
            gbPrestamosRegistrados = new GroupBox();
            pictureBox3 = new PictureBox();
            txtBuscarPrestamosLupa = new TextBox();
            dgvPrestamosRegistrados = new DataGridView();
            gboxDatosDelPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDetallesDelPrestamo.SuspendLayout();
            gboxAccionesPrestamo.SuspendLayout();
            gbPrestamosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosRegistrados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(68, 48);
            label1.Name = "label1";
            label1.Size = new Size(349, 19);
            label1.TabIndex = 41;
            label1.Text = "Registra el préstamo de libros a los usuarios del sistema\r\n";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(60, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 30);
            lblTitulo.TabIndex = 40;
            lblTitulo.Text = "Préstamo de Libros";
            // 
            // gboxDatosDelPrestamo
            // 
            gboxDatosDelPrestamo.Controls.Add(txtCodigoPrestamo);
            gboxDatosDelPrestamo.Controls.Add(lblCodigoPrestamo);
            gboxDatosDelPrestamo.Controls.Add(lblEstadoPrestamo);
            gboxDatosDelPrestamo.Controls.Add(cmbEstadoPrestamo);
            gboxDatosDelPrestamo.Controls.Add(dtpFechaDevolucion);
            gboxDatosDelPrestamo.Controls.Add(lblFechaDevolucion);
            gboxDatosDelPrestamo.Controls.Add(dtpFechaPrestamo);
            gboxDatosDelPrestamo.Controls.Add(btnLibroPrestamo);
            gboxDatosDelPrestamo.Controls.Add(cmbLibroPrestamo);
            gboxDatosDelPrestamo.Controls.Add(lblLibroPrestamo);
            gboxDatosDelPrestamo.Controls.Add(btnUsuarioPrestamo);
            gboxDatosDelPrestamo.Controls.Add(pictureBox1);
            gboxDatosDelPrestamo.Controls.Add(cboxUsuarioPrestamo);
            gboxDatosDelPrestamo.Controls.Add(lblUsuarioPrestamo);
            gboxDatosDelPrestamo.Controls.Add(lblFechaPrestamo);
            gboxDatosDelPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxDatosDelPrestamo.ForeColor = Color.FromArgb(138, 31, 61);
            gboxDatosDelPrestamo.Location = new Point(33, 94);
            gboxDatosDelPrestamo.Name = "gboxDatosDelPrestamo";
            gboxDatosDelPrestamo.Size = new Size(739, 179);
            gboxDatosDelPrestamo.TabIndex = 42;
            gboxDatosDelPrestamo.TabStop = false;
            gboxDatosDelPrestamo.Text = "DATOS DEL PRÉSTAMO";
            // 
            // txtCodigoPrestamo
            // 
            txtCodigoPrestamo.Location = new Point(27, 56);
            txtCodigoPrestamo.Name = "txtCodigoPrestamo";
            txtCodigoPrestamo.Size = new Size(76, 25);
            txtCodigoPrestamo.TabIndex = 65;
            // 
            // lblCodigoPrestamo
            // 
            lblCodigoPrestamo.AutoSize = true;
            lblCodigoPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoPrestamo.ForeColor = Color.Black;
            lblCodigoPrestamo.Location = new Point(24, 34);
            lblCodigoPrestamo.Name = "lblCodigoPrestamo";
            lblCodigoPrestamo.Size = new Size(62, 19);
            lblCodigoPrestamo.TabIndex = 64;
            lblCodigoPrestamo.Text = "Código:";
            // 
            // lblEstadoPrestamo
            // 
            lblEstadoPrestamo.AutoSize = true;
            lblEstadoPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoPrestamo.ForeColor = Color.Black;
            lblEstadoPrestamo.Location = new Point(389, 106);
            lblEstadoPrestamo.Name = "lblEstadoPrestamo";
            lblEstadoPrestamo.Size = new Size(57, 19);
            lblEstadoPrestamo.TabIndex = 63;
            lblEstadoPrestamo.Text = "Estado:";
            // 
            // cmbEstadoPrestamo
            // 
            cmbEstadoPrestamo.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstadoPrestamo.FormattingEnabled = true;
            cmbEstadoPrestamo.Location = new Point(389, 127);
            cmbEstadoPrestamo.Name = "cmbEstadoPrestamo";
            cmbEstadoPrestamo.Size = new Size(187, 27);
            cmbEstadoPrestamo.TabIndex = 62;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(209, 128);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(162, 25);
            dtpFechaDevolucion.TabIndex = 61;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaDevolucion.ForeColor = Color.Black;
            lblFechaDevolucion.Location = new Point(209, 106);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(130, 19);
            lblFechaDevolucion.TabIndex = 60;
            lblFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(27, 128);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(162, 25);
            dtpFechaPrestamo.TabIndex = 59;
            dtpFechaPrestamo.ValueChanged += dtpFechaPrestamo_ValueChanged;
            // 
            // btnLibroPrestamo
            // 
            btnLibroPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnLibroPrestamo.FlatStyle = FlatStyle.Flat;
            btnLibroPrestamo.Image = (Image)resources.GetObject("btnLibroPrestamo.Image");
            btnLibroPrestamo.Location = new Point(527, 54);
            btnLibroPrestamo.Name = "btnLibroPrestamo";
            btnLibroPrestamo.Size = new Size(49, 29);
            btnLibroPrestamo.TabIndex = 58;
            btnLibroPrestamo.UseVisualStyleBackColor = false;
            btnLibroPrestamo.Click += btnLibroPrestamo_Click;
            // 
            // cmbLibroPrestamo
            // 
            cmbLibroPrestamo.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLibroPrestamo.FormattingEnabled = true;
            cmbLibroPrestamo.Location = new Point(370, 56);
            cmbLibroPrestamo.Name = "cmbLibroPrestamo";
            cmbLibroPrestamo.Size = new Size(151, 27);
            cmbLibroPrestamo.TabIndex = 57;
            // 
            // lblLibroPrestamo
            // 
            lblLibroPrestamo.AutoSize = true;
            lblLibroPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLibroPrestamo.ForeColor = Color.Black;
            lblLibroPrestamo.Location = new Point(370, 34);
            lblLibroPrestamo.Name = "lblLibroPrestamo";
            lblLibroPrestamo.Size = new Size(48, 19);
            lblLibroPrestamo.TabIndex = 56;
            lblLibroPrestamo.Text = "Libro:";
            // 
            // btnUsuarioPrestamo
            // 
            btnUsuarioPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnUsuarioPrestamo.FlatStyle = FlatStyle.Flat;
            btnUsuarioPrestamo.Image = (Image)resources.GetObject("btnUsuarioPrestamo.Image");
            btnUsuarioPrestamo.Location = new Point(301, 56);
            btnUsuarioPrestamo.Name = "btnUsuarioPrestamo";
            btnUsuarioPrestamo.Size = new Size(49, 29);
            btnUsuarioPrestamo.TabIndex = 55;
            btnUsuarioPrestamo.UseVisualStyleBackColor = false;
            btnUsuarioPrestamo.Click += btnUsuarioPrestamo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(591, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // cboxUsuarioPrestamo
            // 
            cboxUsuarioPrestamo.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxUsuarioPrestamo.FormattingEnabled = true;
            cboxUsuarioPrestamo.Location = new Point(124, 56);
            cboxUsuarioPrestamo.Name = "cboxUsuarioPrestamo";
            cboxUsuarioPrestamo.Size = new Size(171, 27);
            cboxUsuarioPrestamo.TabIndex = 42;
            // 
            // lblUsuarioPrestamo
            // 
            lblUsuarioPrestamo.AutoSize = true;
            lblUsuarioPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioPrestamo.ForeColor = Color.Black;
            lblUsuarioPrestamo.Location = new Point(125, 34);
            lblUsuarioPrestamo.Name = "lblUsuarioPrestamo";
            lblUsuarioPrestamo.Size = new Size(64, 19);
            lblUsuarioPrestamo.TabIndex = 10;
            lblUsuarioPrestamo.Text = "Usuario:";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPrestamo.ForeColor = Color.Black;
            lblFechaPrestamo.Location = new Point(27, 106);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(119, 19);
            lblFechaPrestamo.TabIndex = 12;
            lblFechaPrestamo.Text = "Fecha préstamo:";
            // 
            // gbDetallesDelPrestamo
            // 
            gbDetallesDelPrestamo.Controls.Add(txtObservaciones);
            gbDetallesDelPrestamo.Controls.Add(lbObservaciones);
            gbDetallesDelPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDetallesDelPrestamo.ForeColor = Color.FromArgb(138, 31, 61);
            gbDetallesDelPrestamo.Location = new Point(33, 289);
            gbDetallesDelPrestamo.Name = "gbDetallesDelPrestamo";
            gbDetallesDelPrestamo.Size = new Size(739, 111);
            gbDetallesDelPrestamo.TabIndex = 64;
            gbDetallesDelPrestamo.TabStop = false;
            gbDetallesDelPrestamo.Text = "DETALLES DEL PRÉSTAMO";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservaciones.Location = new Point(27, 52);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Escribe una observación (opcional)...";
            txtObservaciones.Size = new Size(688, 39);
            txtObservaciones.TabIndex = 11;
            // 
            // lbObservaciones
            // 
            lbObservaciones.AutoSize = true;
            lbObservaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbObservaciones.ForeColor = Color.Black;
            lbObservaciones.Location = new Point(27, 30);
            lbObservaciones.Name = "lbObservaciones";
            lbObservaciones.Size = new Size(112, 19);
            lbObservaciones.TabIndex = 10;
            lbObservaciones.Text = "Observaciones:";
            // 
            // gboxAccionesPrestamo
            // 
            gboxAccionesPrestamo.Controls.Add(btnLimpiarPrestamo);
            gboxAccionesPrestamo.Controls.Add(btnBuscarPrestamo);
            gboxAccionesPrestamo.Controls.Add(btnEliminarPrestamo);
            gboxAccionesPrestamo.Controls.Add(btnEditarPrestamo);
            gboxAccionesPrestamo.Controls.Add(btnGuardarPrestamo);
            gboxAccionesPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxAccionesPrestamo.ForeColor = Color.FromArgb(138, 31, 61);
            gboxAccionesPrestamo.Location = new Point(33, 415);
            gboxAccionesPrestamo.Name = "gboxAccionesPrestamo";
            gboxAccionesPrestamo.Size = new Size(739, 83);
            gboxAccionesPrestamo.TabIndex = 65;
            gboxAccionesPrestamo.TabStop = false;
            gboxAccionesPrestamo.Text = "ACCIONES";
            // 
            // btnLimpiarPrestamo
            // 
            btnLimpiarPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnLimpiarPrestamo.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnLimpiarPrestamo.FlatAppearance.BorderColor = Color.YellowGreen;
            btnLimpiarPrestamo.FlatAppearance.BorderSize = 0;
            btnLimpiarPrestamo.FlatStyle = FlatStyle.Flat;
            btnLimpiarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarPrestamo.ForeColor = Color.AliceBlue;
            btnLimpiarPrestamo.Image = Properties.Resources.icons8_plus_24;
            btnLimpiarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarPrestamo.Location = new Point(590, 34);
            btnLimpiarPrestamo.Name = "btnLimpiarPrestamo";
            btnLimpiarPrestamo.Size = new Size(101, 32);
            btnLimpiarPrestamo.TabIndex = 28;
            btnLimpiarPrestamo.Text = "Limpiar";
            btnLimpiarPrestamo.UseVisualStyleBackColor = false;
            btnLimpiarPrestamo.Click += btnLimpiarPrestamo_Click;
            // 
            // btnBuscarPrestamo
            // 
            btnBuscarPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnBuscarPrestamo.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnBuscarPrestamo.FlatAppearance.BorderColor = Color.YellowGreen;
            btnBuscarPrestamo.FlatAppearance.BorderSize = 0;
            btnBuscarPrestamo.FlatStyle = FlatStyle.Flat;
            btnBuscarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarPrestamo.ForeColor = Color.AliceBlue;
            btnBuscarPrestamo.Image = Properties.Resources.icons8_plus_24;
            btnBuscarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPrestamo.Location = new Point(454, 34);
            btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            btnBuscarPrestamo.Size = new Size(101, 32);
            btnBuscarPrestamo.TabIndex = 27;
            btnBuscarPrestamo.Text = "Buscar";
            btnBuscarPrestamo.UseVisualStyleBackColor = false;
            btnBuscarPrestamo.Click += btnBuscarPrestamo_Click;
            // 
            // btnEliminarPrestamo
            // 
            btnEliminarPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnEliminarPrestamo.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnEliminarPrestamo.FlatAppearance.BorderColor = Color.YellowGreen;
            btnEliminarPrestamo.FlatAppearance.BorderSize = 0;
            btnEliminarPrestamo.FlatStyle = FlatStyle.Flat;
            btnEliminarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarPrestamo.ForeColor = Color.AliceBlue;
            btnEliminarPrestamo.Image = Properties.Resources.icons8_plus_24;
            btnEliminarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarPrestamo.Location = new Point(314, 34);
            btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            btnEliminarPrestamo.Size = new Size(101, 32);
            btnEliminarPrestamo.TabIndex = 26;
            btnEliminarPrestamo.Text = "Eliminar";
            btnEliminarPrestamo.UseVisualStyleBackColor = false;
            btnEliminarPrestamo.Click += btnEliminarPrestamo_Click;
            // 
            // btnEditarPrestamo
            // 
            btnEditarPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnEditarPrestamo.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnEditarPrestamo.FlatAppearance.BorderColor = Color.YellowGreen;
            btnEditarPrestamo.FlatAppearance.BorderSize = 0;
            btnEditarPrestamo.FlatStyle = FlatStyle.Flat;
            btnEditarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarPrestamo.ForeColor = Color.White;
            btnEditarPrestamo.Image = Properties.Resources.icons8_plus_24;
            btnEditarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarPrestamo.Location = new Point(174, 34);
            btnEditarPrestamo.Name = "btnEditarPrestamo";
            btnEditarPrestamo.Size = new Size(101, 32);
            btnEditarPrestamo.TabIndex = 25;
            btnEditarPrestamo.Text = "Editar";
            btnEditarPrestamo.UseVisualStyleBackColor = false;
            btnEditarPrestamo.Click += btnEditarPrestamo_Click;
            // 
            // btnGuardarPrestamo
            // 
            btnGuardarPrestamo.BackColor = Color.FromArgb(138, 31, 61);
            btnGuardarPrestamo.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnGuardarPrestamo.FlatAppearance.BorderColor = Color.YellowGreen;
            btnGuardarPrestamo.FlatAppearance.BorderSize = 0;
            btnGuardarPrestamo.FlatStyle = FlatStyle.Flat;
            btnGuardarPrestamo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarPrestamo.ForeColor = Color.AliceBlue;
            btnGuardarPrestamo.Image = Properties.Resources.icons8_plus_24;
            btnGuardarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarPrestamo.Location = new Point(35, 34);
            btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            btnGuardarPrestamo.Size = new Size(101, 32);
            btnGuardarPrestamo.TabIndex = 20;
            btnGuardarPrestamo.Text = "Guardar";
            btnGuardarPrestamo.UseVisualStyleBackColor = false;
            btnGuardarPrestamo.Click += btnGuardarPrestamo_Click;
            // 
            // gbPrestamosRegistrados
            // 
            gbPrestamosRegistrados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPrestamosRegistrados.Controls.Add(pictureBox3);
            gbPrestamosRegistrados.Controls.Add(txtBuscarPrestamosLupa);
            gbPrestamosRegistrados.Controls.Add(dgvPrestamosRegistrados);
            gbPrestamosRegistrados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPrestamosRegistrados.ForeColor = Color.FromArgb(138, 31, 61);
            gbPrestamosRegistrados.Location = new Point(33, 514);
            gbPrestamosRegistrados.Name = "gbPrestamosRegistrados";
            gbPrestamosRegistrados.Size = new Size(739, 204);
            gbPrestamosRegistrados.TabIndex = 66;
            gbPrestamosRegistrados.TabStop = false;
            gbPrestamosRegistrados.Text = "PRÉSTAMO REGISTRADOS";
            gbPrestamosRegistrados.Enter += gbPrestamosRegistrados_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(232, 224, 229);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(447, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // txtBuscarPrestamosLupa
            // 
            txtBuscarPrestamosLupa.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPrestamosLupa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPrestamosLupa.Location = new Point(482, 17);
            txtBuscarPrestamosLupa.Name = "txtBuscarPrestamosLupa";
            txtBuscarPrestamosLupa.PlaceholderText = "     Buscar por título, autor o ISBN...";
            txtBuscarPrestamosLupa.Size = new Size(236, 25);
            txtBuscarPrestamosLupa.TabIndex = 30;
            // 
            // dgvPrestamosRegistrados
            // 
            dgvPrestamosRegistrados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrestamosRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosRegistrados.Location = new Point(24, 48);
            dgvPrestamosRegistrados.Name = "dgvPrestamosRegistrados";
            dgvPrestamosRegistrados.Size = new Size(696, 150);
            dgvPrestamosRegistrados.TabIndex = 29;
            dgvPrestamosRegistrados.CellClick += dgvPrestamosRegistrados_CellClick;
            // 
            // FrmPrestamoDeLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(799, 611);
            Controls.Add(gbPrestamosRegistrados);
            Controls.Add(gboxAccionesPrestamo);
            Controls.Add(gbDetallesDelPrestamo);
            Controls.Add(gboxDatosDelPrestamo);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrestamoDeLibros";
            Text = "FrmPrestamoDeLibros";
            gboxDatosDelPrestamo.ResumeLayout(false);
            gboxDatosDelPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDetallesDelPrestamo.ResumeLayout(false);
            gbDetallesDelPrestamo.PerformLayout();
            gboxAccionesPrestamo.ResumeLayout(false);
            gbPrestamosRegistrados.ResumeLayout(false);
            gbPrestamosRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosRegistrados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private GroupBox gboxDatosDelPrestamo;
        private PictureBox pictureBox1;
        private ComboBox cboxUsuarioPrestamo;
        private Label lblUsuarioPrestamo;
        private Label lblFechaPrestamo;
        private Button btnUsuarioPrestamo;
        private Button btnLibroPrestamo;
        private ComboBox cmbLibroPrestamo;
        private Label lblLibroPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Label lblFechaDevolucion;
        private Label lblEstadoPrestamo;
        private ComboBox cmbEstadoPrestamo;
        private GroupBox gbDetallesDelPrestamo;
        private Label lbObservaciones;
        private TextBox txtObservaciones;
        private GroupBox gboxAccionesPrestamo;
        private Button btnLimpiarPrestamo;
        private Button btnBuscarPrestamo;
        private Button btnEliminarPrestamo;
        private Button btnEditarPrestamo;
        private Button btnGuardarPrestamo;
        private GroupBox gbPrestamosRegistrados;
        private PictureBox pictureBox3;
        private TextBox txtBuscarPrestamosLupa;
        private DataGridView dgvPrestamosRegistrados;
        private TextBox txtCodigoPrestamo;
        private Label lblCodigoPrestamo;
    }
}