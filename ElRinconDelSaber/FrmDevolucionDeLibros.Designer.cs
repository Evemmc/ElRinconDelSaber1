namespace ElRinconDelSaber
{
    partial class FrmDevolucionDeLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucionDeLibros));
            lblTitulo = new Label();
            label1 = new Label();
            gboxBuscarPrestamo = new GroupBox();
            btnBuscarPrestamoLupa = new Button();
            txtCodigoDePrestamo = new TextBox();
            lblCodigoDePrestamo = new Label();
            gbInformacionDePrestamo = new GroupBox();
            pictureBox1 = new PictureBox();
            lblEstadoPrestamoInformacion = new Label();
            txtLibroInformacion = new TextBox();
            cmbEstadoPrestamoInformacion = new ComboBox();
            lblLibroInformacion = new Label();
            dtpFechaDevolucionInformacion = new DateTimePicker();
            txtUsuarioInformacion = new TextBox();
            lblFechaDevolucionInformacion = new Label();
            lblUsuarioInformacion = new Label();
            dtpFechaPrestamoInformacion = new DateTimePicker();
            txtCodigoDePrestamoInformacion = new TextBox();
            lblFechaPrestamoInformacion = new Label();
            lblCodigoDePrestamoInformacion = new Label();
            gbDatosDeDevolucion = new GroupBox();
            btnCancelarDevolucion = new Button();
            btnLimpiarDevolucion = new Button();
            btnRegistrarDevolucion = new Button();
            txtObservacionesDevolucion = new TextBox();
            lbObservacionesDevolucion = new Label();
            cbEstadoDeLibroDevolucion = new ComboBox();
            lblEstadoDeLibroPrestamo = new Label();
            gbPrestamosRegistrados = new GroupBox();
            ptbxLupita = new PictureBox();
            txtBuscarPrestamosLupa = new TextBox();
            dgvPrestamosRegistrados = new DataGridView();
            gboxBuscarPrestamo.SuspendLayout();
            gbInformacionDePrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDatosDeDevolucion.SuspendLayout();
            gbPrestamosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbxLupita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosRegistrados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(60, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 30);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Devolución de Libros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(68, 48);
            label1.Name = "label1";
            label1.Size = new Size(371, 19);
            label1.TabIndex = 42;
            label1.Text = "Registra la devolución de libros y actualiza su disponibilidad\r\n";
            // 
            // gboxBuscarPrestamo
            // 
            gboxBuscarPrestamo.Controls.Add(btnBuscarPrestamoLupa);
            gboxBuscarPrestamo.Controls.Add(txtCodigoDePrestamo);
            gboxBuscarPrestamo.Controls.Add(lblCodigoDePrestamo);
            gboxBuscarPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxBuscarPrestamo.ForeColor = Color.FromArgb(138, 31, 61);
            gboxBuscarPrestamo.Location = new Point(33, 94);
            gboxBuscarPrestamo.Name = "gboxBuscarPrestamo";
            gboxBuscarPrestamo.Size = new Size(739, 80);
            gboxBuscarPrestamo.TabIndex = 43;
            gboxBuscarPrestamo.TabStop = false;
            gboxBuscarPrestamo.Text = "BUSCAR PRÉSTAMO";
            // 
            // btnBuscarPrestamoLupa
            // 
            btnBuscarPrestamoLupa.BackColor = Color.FromArgb(138, 31, 61);
            btnBuscarPrestamoLupa.FlatStyle = FlatStyle.Flat;
            btnBuscarPrestamoLupa.ForeColor = Color.White;
            btnBuscarPrestamoLupa.Image = (Image)resources.GetObject("btnBuscarPrestamoLupa.Image");
            btnBuscarPrestamoLupa.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPrestamoLupa.Location = new Point(380, 34);
            btnBuscarPrestamoLupa.Name = "btnBuscarPrestamoLupa";
            btnBuscarPrestamoLupa.Size = new Size(135, 29);
            btnBuscarPrestamoLupa.TabIndex = 66;
            btnBuscarPrestamoLupa.Text = "          Buscar";
            btnBuscarPrestamoLupa.UseVisualStyleBackColor = false;
            btnBuscarPrestamoLupa.Click += btnBuscarPrestamoLupa_Click;
            // 
            // txtCodigoDePrestamo
            // 
            txtCodigoDePrestamo.Location = new Point(184, 38);
            txtCodigoDePrestamo.Name = "txtCodigoDePrestamo";
            txtCodigoDePrestamo.Size = new Size(177, 25);
            txtCodigoDePrestamo.TabIndex = 65;
            // 
            // lblCodigoDePrestamo
            // 
            lblCodigoDePrestamo.AutoSize = true;
            lblCodigoDePrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoDePrestamo.ForeColor = Color.Black;
            lblCodigoDePrestamo.Location = new Point(27, 38);
            lblCodigoDePrestamo.Name = "lblCodigoDePrestamo";
            lblCodigoDePrestamo.Size = new Size(151, 19);
            lblCodigoDePrestamo.TabIndex = 64;
            lblCodigoDePrestamo.Text = "Código de préstamo:";
            // 
            // gbInformacionDePrestamo
            // 
            gbInformacionDePrestamo.Controls.Add(pictureBox1);
            gbInformacionDePrestamo.Controls.Add(lblEstadoPrestamoInformacion);
            gbInformacionDePrestamo.Controls.Add(txtLibroInformacion);
            gbInformacionDePrestamo.Controls.Add(cmbEstadoPrestamoInformacion);
            gbInformacionDePrestamo.Controls.Add(lblLibroInformacion);
            gbInformacionDePrestamo.Controls.Add(dtpFechaDevolucionInformacion);
            gbInformacionDePrestamo.Controls.Add(txtUsuarioInformacion);
            gbInformacionDePrestamo.Controls.Add(lblFechaDevolucionInformacion);
            gbInformacionDePrestamo.Controls.Add(lblUsuarioInformacion);
            gbInformacionDePrestamo.Controls.Add(dtpFechaPrestamoInformacion);
            gbInformacionDePrestamo.Controls.Add(txtCodigoDePrestamoInformacion);
            gbInformacionDePrestamo.Controls.Add(lblFechaPrestamoInformacion);
            gbInformacionDePrestamo.Controls.Add(lblCodigoDePrestamoInformacion);
            gbInformacionDePrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbInformacionDePrestamo.ForeColor = Color.FromArgb(138, 31, 61);
            gbInformacionDePrestamo.Location = new Point(33, 191);
            gbInformacionDePrestamo.Name = "gbInformacionDePrestamo";
            gbInformacionDePrestamo.Size = new Size(739, 163);
            gbInformacionDePrestamo.TabIndex = 67;
            gbInformacionDePrestamo.TabStop = false;
            gbInformacionDePrestamo.Text = "INFORMACIÓN DE PRÉSTAMO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(616, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // lblEstadoPrestamoInformacion
            // 
            lblEstadoPrestamoInformacion.AutoSize = true;
            lblEstadoPrestamoInformacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoPrestamoInformacion.ForeColor = Color.Black;
            lblEstadoPrestamoInformacion.Location = new Point(389, 98);
            lblEstadoPrestamoInformacion.Name = "lblEstadoPrestamoInformacion";
            lblEstadoPrestamoInformacion.Size = new Size(57, 19);
            lblEstadoPrestamoInformacion.TabIndex = 73;
            lblEstadoPrestamoInformacion.Text = "Estado:";
            // 
            // txtLibroInformacion
            // 
            txtLibroInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLibroInformacion.Location = new Point(433, 60);
            txtLibroInformacion.Name = "txtLibroInformacion";
            txtLibroInformacion.Size = new Size(177, 25);
            txtLibroInformacion.TabIndex = 69;
            // 
            // cmbEstadoPrestamoInformacion
            // 
            cmbEstadoPrestamoInformacion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstadoPrestamoInformacion.FormattingEnabled = true;
            cmbEstadoPrestamoInformacion.Items.AddRange(new object[] { "Seleccione un estado", "Activo", "Inactivo" });
            cmbEstadoPrestamoInformacion.Location = new Point(389, 119);
            cmbEstadoPrestamoInformacion.Name = "cmbEstadoPrestamoInformacion";
            cmbEstadoPrestamoInformacion.Size = new Size(221, 27);
            cmbEstadoPrestamoInformacion.TabIndex = 72;
            // 
            // lblLibroInformacion
            // 
            lblLibroInformacion.AutoSize = true;
            lblLibroInformacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLibroInformacion.ForeColor = Color.Black;
            lblLibroInformacion.Location = new Point(433, 38);
            lblLibroInformacion.Name = "lblLibroInformacion";
            lblLibroInformacion.Size = new Size(48, 19);
            lblLibroInformacion.TabIndex = 68;
            lblLibroInformacion.Text = "Libro:";
            // 
            // dtpFechaDevolucionInformacion
            // 
            dtpFechaDevolucionInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucionInformacion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucionInformacion.Location = new Point(209, 120);
            dtpFechaDevolucionInformacion.Name = "dtpFechaDevolucionInformacion";
            dtpFechaDevolucionInformacion.Size = new Size(162, 25);
            dtpFechaDevolucionInformacion.TabIndex = 71;
            // 
            // txtUsuarioInformacion
            // 
            txtUsuarioInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioInformacion.Location = new Point(232, 60);
            txtUsuarioInformacion.Name = "txtUsuarioInformacion";
            txtUsuarioInformacion.Size = new Size(177, 25);
            txtUsuarioInformacion.TabIndex = 67;
            // 
            // lblFechaDevolucionInformacion
            // 
            lblFechaDevolucionInformacion.AutoSize = true;
            lblFechaDevolucionInformacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaDevolucionInformacion.ForeColor = Color.Black;
            lblFechaDevolucionInformacion.Location = new Point(209, 98);
            lblFechaDevolucionInformacion.Name = "lblFechaDevolucionInformacion";
            lblFechaDevolucionInformacion.Size = new Size(130, 19);
            lblFechaDevolucionInformacion.TabIndex = 70;
            lblFechaDevolucionInformacion.Text = "Fecha Devolución:";
            // 
            // lblUsuarioInformacion
            // 
            lblUsuarioInformacion.AutoSize = true;
            lblUsuarioInformacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioInformacion.ForeColor = Color.Black;
            lblUsuarioInformacion.Location = new Point(232, 38);
            lblUsuarioInformacion.Name = "lblUsuarioInformacion";
            lblUsuarioInformacion.Size = new Size(64, 19);
            lblUsuarioInformacion.TabIndex = 66;
            lblUsuarioInformacion.Text = "Usuario:";
            // 
            // dtpFechaPrestamoInformacion
            // 
            dtpFechaPrestamoInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamoInformacion.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamoInformacion.Location = new Point(27, 120);
            dtpFechaPrestamoInformacion.Name = "dtpFechaPrestamoInformacion";
            dtpFechaPrestamoInformacion.Size = new Size(162, 25);
            dtpFechaPrestamoInformacion.TabIndex = 69;
            // 
            // txtCodigoDePrestamoInformacion
            // 
            txtCodigoDePrestamoInformacion.Location = new Point(27, 60);
            txtCodigoDePrestamoInformacion.Name = "txtCodigoDePrestamoInformacion";
            txtCodigoDePrestamoInformacion.Size = new Size(177, 25);
            txtCodigoDePrestamoInformacion.TabIndex = 65;
            // 
            // lblFechaPrestamoInformacion
            // 
            lblFechaPrestamoInformacion.AutoSize = true;
            lblFechaPrestamoInformacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaPrestamoInformacion.ForeColor = Color.Black;
            lblFechaPrestamoInformacion.Location = new Point(27, 98);
            lblFechaPrestamoInformacion.Name = "lblFechaPrestamoInformacion";
            lblFechaPrestamoInformacion.Size = new Size(119, 19);
            lblFechaPrestamoInformacion.TabIndex = 68;
            lblFechaPrestamoInformacion.Text = "Fecha préstamo:";
            // 
            // lblCodigoDePrestamoInformacion
            // 
            lblCodigoDePrestamoInformacion.AutoSize = true;
            lblCodigoDePrestamoInformacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoDePrestamoInformacion.ForeColor = Color.Black;
            lblCodigoDePrestamoInformacion.Location = new Point(27, 38);
            lblCodigoDePrestamoInformacion.Name = "lblCodigoDePrestamoInformacion";
            lblCodigoDePrestamoInformacion.Size = new Size(151, 19);
            lblCodigoDePrestamoInformacion.TabIndex = 64;
            lblCodigoDePrestamoInformacion.Text = "Código de préstamo:";
            // 
            // gbDatosDeDevolucion
            // 
            gbDatosDeDevolucion.Controls.Add(btnCancelarDevolucion);
            gbDatosDeDevolucion.Controls.Add(btnLimpiarDevolucion);
            gbDatosDeDevolucion.Controls.Add(btnRegistrarDevolucion);
            gbDatosDeDevolucion.Controls.Add(txtObservacionesDevolucion);
            gbDatosDeDevolucion.Controls.Add(lbObservacionesDevolucion);
            gbDatosDeDevolucion.Controls.Add(cbEstadoDeLibroDevolucion);
            gbDatosDeDevolucion.Controls.Add(lblEstadoDeLibroPrestamo);
            gbDatosDeDevolucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDatosDeDevolucion.ForeColor = Color.FromArgb(138, 31, 61);
            gbDatosDeDevolucion.Location = new Point(33, 371);
            gbDatosDeDevolucion.Name = "gbDatosDeDevolucion";
            gbDatosDeDevolucion.Size = new Size(739, 118);
            gbDatosDeDevolucion.TabIndex = 68;
            gbDatosDeDevolucion.TabStop = false;
            gbDatosDeDevolucion.Text = "DATOS DE DEVOLUCIÓN";
            // 
            // btnCancelarDevolucion
            // 
            btnCancelarDevolucion.BackColor = Color.FromArgb(138, 31, 61);
            btnCancelarDevolucion.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnCancelarDevolucion.FlatAppearance.BorderColor = Color.YellowGreen;
            btnCancelarDevolucion.FlatAppearance.BorderSize = 0;
            btnCancelarDevolucion.FlatStyle = FlatStyle.Flat;
            btnCancelarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelarDevolucion.ForeColor = Color.AliceBlue;
            btnCancelarDevolucion.Image = Properties.Resources.icons8_plus_24;
            btnCancelarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarDevolucion.Location = new Point(579, 82);
            btnCancelarDevolucion.Name = "btnCancelarDevolucion";
            btnCancelarDevolucion.Size = new Size(145, 23);
            btnCancelarDevolucion.TabIndex = 78;
            btnCancelarDevolucion.Text = "Cancelar";
            btnCancelarDevolucion.UseVisualStyleBackColor = false;
            btnCancelarDevolucion.Click += btnCancelarDevolucion_Click;
            // 
            // btnLimpiarDevolucion
            // 
            btnLimpiarDevolucion.BackColor = Color.FromArgb(138, 31, 61);
            btnLimpiarDevolucion.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnLimpiarDevolucion.FlatAppearance.BorderColor = Color.YellowGreen;
            btnLimpiarDevolucion.FlatAppearance.BorderSize = 0;
            btnLimpiarDevolucion.FlatStyle = FlatStyle.Flat;
            btnLimpiarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarDevolucion.ForeColor = Color.AliceBlue;
            btnLimpiarDevolucion.Image = Properties.Resources.icons8_plus_24;
            btnLimpiarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarDevolucion.Location = new Point(579, 53);
            btnLimpiarDevolucion.Name = "btnLimpiarDevolucion";
            btnLimpiarDevolucion.Size = new Size(145, 23);
            btnLimpiarDevolucion.TabIndex = 77;
            btnLimpiarDevolucion.Text = "Limpiar";
            btnLimpiarDevolucion.UseVisualStyleBackColor = false;
            btnLimpiarDevolucion.Click += btnLimpiarDevolucion_Click;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = Color.FromArgb(138, 31, 61);
            btnRegistrarDevolucion.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnRegistrarDevolucion.FlatAppearance.BorderColor = Color.YellowGreen;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarDevolucion.ForeColor = Color.AliceBlue;
            btnRegistrarDevolucion.Image = Properties.Resources.icons8_plus_24;
            btnRegistrarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarDevolucion.Location = new Point(579, 24);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(145, 23);
            btnRegistrarDevolucion.TabIndex = 76;
            btnRegistrarDevolucion.Text = "Registrar devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // txtObservacionesDevolucion
            // 
            txtObservacionesDevolucion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacionesDevolucion.Location = new Point(271, 59);
            txtObservacionesDevolucion.Multiline = true;
            txtObservacionesDevolucion.Name = "txtObservacionesDevolucion";
            txtObservacionesDevolucion.PlaceholderText = "Escribe una observación (opcional)...";
            txtObservacionesDevolucion.Size = new Size(282, 46);
            txtObservacionesDevolucion.TabIndex = 69;
            // 
            // lbObservacionesDevolucion
            // 
            lbObservacionesDevolucion.AutoSize = true;
            lbObservacionesDevolucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbObservacionesDevolucion.ForeColor = Color.Black;
            lbObservacionesDevolucion.Location = new Point(271, 38);
            lbObservacionesDevolucion.Name = "lbObservacionesDevolucion";
            lbObservacionesDevolucion.Size = new Size(112, 19);
            lbObservacionesDevolucion.TabIndex = 75;
            lbObservacionesDevolucion.Text = "Observaciones:";
            // 
            // cbEstadoDeLibroDevolucion
            // 
            cbEstadoDeLibroDevolucion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEstadoDeLibroDevolucion.FormattingEnabled = true;
            cbEstadoDeLibroDevolucion.Location = new Point(27, 60);
            cbEstadoDeLibroDevolucion.Name = "cbEstadoDeLibroDevolucion";
            cbEstadoDeLibroDevolucion.Size = new Size(221, 27);
            cbEstadoDeLibroDevolucion.TabIndex = 74;
            // 
            // lblEstadoDeLibroPrestamo
            // 
            lblEstadoDeLibroPrestamo.AutoSize = true;
            lblEstadoDeLibroPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoDeLibroPrestamo.ForeColor = Color.Black;
            lblEstadoDeLibroPrestamo.Location = new Point(27, 38);
            lblEstadoDeLibroPrestamo.Name = "lblEstadoDeLibroPrestamo";
            lblEstadoDeLibroPrestamo.Size = new Size(118, 19);
            lblEstadoDeLibroPrestamo.TabIndex = 64;
            lblEstadoDeLibroPrestamo.Text = "Estado del libro:";
            // 
            // gbPrestamosRegistrados
            // 
            gbPrestamosRegistrados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPrestamosRegistrados.Controls.Add(ptbxLupita);
            gbPrestamosRegistrados.Controls.Add(txtBuscarPrestamosLupa);
            gbPrestamosRegistrados.Controls.Add(dgvPrestamosRegistrados);
            gbPrestamosRegistrados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPrestamosRegistrados.ForeColor = Color.FromArgb(138, 31, 61);
            gbPrestamosRegistrados.Location = new Point(33, 505);
            gbPrestamosRegistrados.Name = "gbPrestamosRegistrados";
            gbPrestamosRegistrados.Size = new Size(739, 204);
            gbPrestamosRegistrados.TabIndex = 69;
            gbPrestamosRegistrados.TabStop = false;
            gbPrestamosRegistrados.Text = "PRÉSTAMO REGISTRADOS";
            // 
            // ptbxLupita
            // 
            ptbxLupita.BackColor = Color.FromArgb(232, 224, 229);
            ptbxLupita.Image = (Image)resources.GetObject("ptbxLupita.Image");
            ptbxLupita.Location = new Point(454, 17);
            ptbxLupita.Name = "ptbxLupita";
            ptbxLupita.Size = new Size(24, 25);
            ptbxLupita.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbxLupita.TabIndex = 55;
            ptbxLupita.TabStop = false;
            ptbxLupita.Click += ptbxLupita_Click;
            // 
            // txtBuscarPrestamosLupa
            // 
            txtBuscarPrestamosLupa.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPrestamosLupa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPrestamosLupa.Location = new Point(484, 17);
            txtBuscarPrestamosLupa.Name = "txtBuscarPrestamosLupa";
            txtBuscarPrestamosLupa.PlaceholderText = "   Buscar por título, autor o ISBN...";
            txtBuscarPrestamosLupa.Size = new Size(234, 25);
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
            // FrmDevolucionDeLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(799, 611);
            Controls.Add(gbPrestamosRegistrados);
            Controls.Add(gbDatosDeDevolucion);
            Controls.Add(gbInformacionDePrestamo);
            Controls.Add(gboxBuscarPrestamo);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDevolucionDeLibros";
            Text = "FrmDevolucionDeLibros";
            gboxBuscarPrestamo.ResumeLayout(false);
            gboxBuscarPrestamo.PerformLayout();
            gbInformacionDePrestamo.ResumeLayout(false);
            gbInformacionDePrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDatosDeDevolucion.ResumeLayout(false);
            gbDatosDeDevolucion.PerformLayout();
            gbPrestamosRegistrados.ResumeLayout(false);
            gbPrestamosRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbxLupita).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosRegistrados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private GroupBox gboxBuscarPrestamo;
        private TextBox txtCodigoDePrestamo;
        private Label lblCodigoDePrestamo;
        private Button btnBuscarPrestamoLupa;
        private GroupBox gbInformacionDePrestamo;
        private Label lblUsuarioInformacion;
        private TextBox txtCodigoDePrestamoInformacion;
        private Label lblCodigoDePrestamoInformacion;
        private TextBox txtLibroInformacion;
        private Label lblLibroInformacion;
        private TextBox txtUsuarioInformacion;
        private Label lblEstadoPrestamoInformacion;
        private ComboBox cmbEstadoPrestamoInformacion;
        private DateTimePicker dtpFechaDevolucionInformacion;
        private Label lblFechaDevolucionInformacion;
        private DateTimePicker dtpFechaPrestamoInformacion;
        private Label lblFechaPrestamoInformacion;
        private PictureBox pictureBox1;
        private GroupBox gbDatosDeDevolucion;
        private Label lblEstadoDeLibroPrestamo;
        private ComboBox cbEstadoDeLibroDevolucion;
        private Label lbObservacionesDevolucion;
        private TextBox txtObservacionesDevolucion;
        private Button btnCancelarDevolucion;
        private Button btnLimpiarDevolucion;
        private Button btnRegistrarDevolucion;
        private GroupBox gbPrestamosRegistrados;
        private PictureBox ptbxLupita;
        private TextBox txtBuscarPrestamosLupa;
        private DataGridView dgvPrestamosRegistrados;
    }
}