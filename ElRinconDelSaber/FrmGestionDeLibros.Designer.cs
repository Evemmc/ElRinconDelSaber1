namespace ElRinconDelSaber
{
    partial class FrmGestionDeLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDeLibros));
            label1 = new Label();
            lblTitulo = new Label();
            gboxDatosDelLibro = new GroupBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            txtDisponibles = new TextBox();
            lblDisponibles = new Label();
            nudCantidadTotal = new NumericUpDown();
            lblCantidadTotal = new Label();
            lblAñoPublicacion = new Label();
            nudAñoDePublicacion = new NumericUpDown();
            lblUbicacion = new Label();
            cmbUbicacion = new ComboBox();
            lblCategoria = new Label();
            cboxCategoria = new ComboBox();
            txtEditorial = new TextBox();
            lblEditorial = new Label();
            lblltitulo = new Label();
            txtTituloLibro = new TextBox();
            lblIsbn = new Label();
            txtISbn = new TextBox();
            txtAutor = new TextBox();
            lblAutor = new Label();
            gboxAccionesLibro = new GroupBox();
            btnLimpiarLibro = new Button();
            btnBuscarLibro = new Button();
            btnEliminarLibro = new Button();
            btnEditarLibro = new Button();
            btnGuardarLibro = new Button();
            gpbLibrosRegistrados = new GroupBox();
            pictureBox3 = new PictureBox();
            txtBuscarLibroLupa = new TextBox();
            dtgvLibrosRegistrados = new DataGridView();
            gboxDatosDelLibro.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAñoDePublicacion).BeginInit();
            gboxAccionesLibro.SuspendLayout();
            gpbLibrosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvLibrosRegistrados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(364, 19);
            label1.TabIndex = 39;
            label1.Text = " Administra y consulta el catálogo de los libros del sistema\r\n";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(60, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 30);
            lblTitulo.TabIndex = 38;
            lblTitulo.Text = "Gestión de Libros";
            // 
            // gboxDatosDelLibro
            // 
            gboxDatosDelLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gboxDatosDelLibro.Controls.Add(panel1);
            gboxDatosDelLibro.Controls.Add(pictureBox1);
            gboxDatosDelLibro.Controls.Add(lblEstado);
            gboxDatosDelLibro.Controls.Add(cmbEstado);
            gboxDatosDelLibro.Controls.Add(txtDisponibles);
            gboxDatosDelLibro.Controls.Add(lblDisponibles);
            gboxDatosDelLibro.Controls.Add(nudCantidadTotal);
            gboxDatosDelLibro.Controls.Add(lblCantidadTotal);
            gboxDatosDelLibro.Controls.Add(lblAñoPublicacion);
            gboxDatosDelLibro.Controls.Add(nudAñoDePublicacion);
            gboxDatosDelLibro.Controls.Add(lblUbicacion);
            gboxDatosDelLibro.Controls.Add(cmbUbicacion);
            gboxDatosDelLibro.Controls.Add(lblCategoria);
            gboxDatosDelLibro.Controls.Add(cboxCategoria);
            gboxDatosDelLibro.Controls.Add(txtEditorial);
            gboxDatosDelLibro.Controls.Add(lblEditorial);
            gboxDatosDelLibro.Controls.Add(lblltitulo);
            gboxDatosDelLibro.Controls.Add(txtTituloLibro);
            gboxDatosDelLibro.Controls.Add(lblIsbn);
            gboxDatosDelLibro.Controls.Add(txtISbn);
            gboxDatosDelLibro.Controls.Add(txtAutor);
            gboxDatosDelLibro.Controls.Add(lblAutor);
            gboxDatosDelLibro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxDatosDelLibro.ForeColor = Color.FromArgb(138, 31, 61);
            gboxDatosDelLibro.Location = new Point(33, 94);
            gboxDatosDelLibro.Name = "gboxDatosDelLibro";
            gboxDatosDelLibro.Size = new Size(739, 303);
            gboxDatosDelLibro.TabIndex = 40;
            gboxDatosDelLibro.TabStop = false;
            gboxDatosDelLibro.Text = "DATOS DEL LIBRO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(563, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 120);
            panel1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 53);
            label2.Name = "label2";
            label2.Size = new Size(127, 65);
            label2.TabIndex = 39;
            label2.Text = "Registre la información\r\n  del libro y mantenga\r\n  actualizado el estado \r\n   y la disponibilidad\r\n\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(563, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(374, 230);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 19);
            lblEstado.TabIndex = 51;
            lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Seleccione un estado", "Activo", "Inactivo" });
            cmbEstado.Location = new Point(374, 252);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(168, 27);
            cmbEstado.TabIndex = 52;
            // 
            // txtDisponibles
            // 
            txtDisponibles.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisponibles.Location = new Point(186, 252);
            txtDisponibles.Name = "txtDisponibles";
            txtDisponibles.ReadOnly = true;
            txtDisponibles.Size = new Size(166, 27);
            txtDisponibles.TabIndex = 50;
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDisponibles.ForeColor = Color.Black;
            lblDisponibles.Location = new Point(186, 230);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(90, 19);
            lblDisponibles.TabIndex = 49;
            lblDisponibles.Text = "Disponibles:";
            // 
            // nudCantidadTotal
            // 
            nudCantidadTotal.Location = new Point(27, 252);
            nudCantidadTotal.Name = "nudCantidadTotal";
            nudCantidadTotal.Size = new Size(142, 25);
            nudCantidadTotal.TabIndex = 48;
            nudCantidadTotal.ValueChanged += nudCantidadTotal_ValueChanged;
            // 
            // lblCantidadTotal
            // 
            lblCantidadTotal.AutoSize = true;
            lblCantidadTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadTotal.ForeColor = Color.Black;
            lblCantidadTotal.Location = new Point(27, 230);
            lblCantidadTotal.Name = "lblCantidadTotal";
            lblCantidadTotal.Size = new Size(108, 19);
            lblCantidadTotal.TabIndex = 47;
            lblCantidadTotal.Text = "Cantidad total:";
            // 
            // lblAñoPublicacion
            // 
            lblAñoPublicacion.AutoSize = true;
            lblAñoPublicacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAñoPublicacion.ForeColor = Color.Black;
            lblAñoPublicacion.Location = new Point(400, 104);
            lblAñoPublicacion.Name = "lblAñoPublicacion";
            lblAñoPublicacion.Size = new Size(142, 19);
            lblAñoPublicacion.TabIndex = 46;
            lblAñoPublicacion.Text = "Año de publicación:";
            // 
            // nudAñoDePublicacion
            // 
            nudAñoDePublicacion.Location = new Point(400, 126);
            nudAñoDePublicacion.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAñoDePublicacion.Name = "nudAñoDePublicacion";
            nudAñoDePublicacion.Size = new Size(142, 25);
            nudAñoDePublicacion.TabIndex = 45;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUbicacion.ForeColor = Color.Black;
            lblUbicacion.Location = new Point(303, 165);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(79, 19);
            lblUbicacion.TabIndex = 43;
            lblUbicacion.Text = "Ubicación:";
            // 
            // cmbUbicacion
            // 
            cmbUbicacion.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUbicacion.FormattingEnabled = true;
            cmbUbicacion.Items.AddRange(new object[] { "Seleccione una ubicación", "", "Estante A1", "", "Estante A2", "", "Estante B1", "", "Estante B2", "", "Sala de lectura", "", "Área infantil" });
            cmbUbicacion.Location = new Point(303, 187);
            cmbUbicacion.Name = "cmbUbicacion";
            cmbUbicacion.Size = new Size(239, 27);
            cmbUbicacion.TabIndex = 44;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(27, 165);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(79, 19);
            lblCategoria.TabIndex = 41;
            lblCategoria.Text = "Categoría:";
            // 
            // cboxCategoria
            // 
            cboxCategoria.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Items.AddRange(new object[] { "Seleccione una categoría", "", "Novela", "", "Cuento", "", "Poesía", "", "Historia", "", "Ciencia", "", "Tecnología", "", "Matemáticas", "", "Literatura", "", "Biografía", "", "Infantil", "", "Educación", "", "Otros" });
            cboxCategoria.Location = new Point(27, 187);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(255, 27);
            cboxCategoria.TabIndex = 42;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditorial.Location = new Point(213, 126);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(166, 27);
            txtEditorial.TabIndex = 17;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEditorial.ForeColor = Color.Black;
            lblEditorial.Location = new Point(213, 104);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(69, 19);
            lblEditorial.TabIndex = 16;
            lblEditorial.Text = "Editorial:";
            // 
            // lblltitulo
            // 
            lblltitulo.AutoSize = true;
            lblltitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblltitulo.ForeColor = Color.Black;
            lblltitulo.Location = new Point(213, 43);
            lblltitulo.Name = "lblltitulo";
            lblltitulo.Size = new Size(112, 19);
            lblltitulo.TabIndex = 14;
            lblltitulo.Text = "Título del libro:";
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.BackColor = Color.White;
            txtTituloLibro.Font = new Font("Segoe UI", 12F);
            txtTituloLibro.Location = new Point(213, 65);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(329, 29);
            txtTituloLibro.TabIndex = 15;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIsbn.ForeColor = Color.Black;
            lblIsbn.Location = new Point(27, 43);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(45, 19);
            lblIsbn.TabIndex = 10;
            lblIsbn.Text = "ISBN:";
            // 
            // txtISbn
            // 
            txtISbn.BackColor = Color.White;
            txtISbn.Font = new Font("Segoe UI", 12F);
            txtISbn.Location = new Point(27, 65);
            txtISbn.Name = "txtISbn";
            txtISbn.Size = new Size(166, 29);
            txtISbn.TabIndex = 11;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAutor.Location = new Point(27, 126);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(166, 27);
            txtAutor.TabIndex = 13;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAutor.ForeColor = Color.Black;
            lblAutor.Location = new Point(27, 104);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(52, 19);
            lblAutor.TabIndex = 12;
            lblAutor.Text = "Autor:";
            // 
            // gboxAccionesLibro
            // 
            gboxAccionesLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gboxAccionesLibro.Controls.Add(btnLimpiarLibro);
            gboxAccionesLibro.Controls.Add(btnBuscarLibro);
            gboxAccionesLibro.Controls.Add(btnEliminarLibro);
            gboxAccionesLibro.Controls.Add(btnEditarLibro);
            gboxAccionesLibro.Controls.Add(btnGuardarLibro);
            gboxAccionesLibro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxAccionesLibro.ForeColor = Color.FromArgb(138, 31, 61);
            gboxAccionesLibro.Location = new Point(33, 412);
            gboxAccionesLibro.Name = "gboxAccionesLibro";
            gboxAccionesLibro.Size = new Size(739, 83);
            gboxAccionesLibro.TabIndex = 41;
            gboxAccionesLibro.TabStop = false;
            gboxAccionesLibro.Text = "ACCIONES";
            // 
            // btnLimpiarLibro
            // 
            btnLimpiarLibro.BackColor = Color.FromArgb(138, 31, 61);
            btnLimpiarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnLimpiarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnLimpiarLibro.FlatAppearance.BorderSize = 0;
            btnLimpiarLibro.FlatStyle = FlatStyle.Flat;
            btnLimpiarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiarLibro.ForeColor = Color.AliceBlue;
            btnLimpiarLibro.Image = Properties.Resources.icons8_plus_24;
            btnLimpiarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarLibro.Location = new Point(590, 34);
            btnLimpiarLibro.Name = "btnLimpiarLibro";
            btnLimpiarLibro.Size = new Size(101, 32);
            btnLimpiarLibro.TabIndex = 28;
            btnLimpiarLibro.Text = "Limpiar";
            btnLimpiarLibro.UseVisualStyleBackColor = false;
            btnLimpiarLibro.Click += btnLimpiarLibro_Click;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.BackColor = Color.FromArgb(138, 31, 61);
            btnBuscarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnBuscarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnBuscarLibro.FlatAppearance.BorderSize = 0;
            btnBuscarLibro.FlatStyle = FlatStyle.Flat;
            btnBuscarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarLibro.ForeColor = Color.AliceBlue;
            btnBuscarLibro.Image = Properties.Resources.icons8_plus_24;
            btnBuscarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarLibro.Location = new Point(454, 34);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(101, 32);
            btnBuscarLibro.TabIndex = 27;
            btnBuscarLibro.Text = "Buscar";
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.BackColor = Color.FromArgb(138, 31, 61);
            btnEliminarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnEliminarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnEliminarLibro.FlatAppearance.BorderSize = 0;
            btnEliminarLibro.FlatStyle = FlatStyle.Flat;
            btnEliminarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarLibro.ForeColor = Color.AliceBlue;
            btnEliminarLibro.Image = Properties.Resources.icons8_plus_24;
            btnEliminarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarLibro.Location = new Point(314, 34);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(101, 32);
            btnEliminarLibro.TabIndex = 26;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = false;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.BackColor = Color.FromArgb(138, 31, 61);
            btnEditarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnEditarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnEditarLibro.FlatAppearance.BorderSize = 0;
            btnEditarLibro.FlatStyle = FlatStyle.Flat;
            btnEditarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarLibro.ForeColor = Color.White;
            btnEditarLibro.Image = Properties.Resources.icons8_plus_24;
            btnEditarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarLibro.Location = new Point(174, 34);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(101, 32);
            btnEditarLibro.TabIndex = 25;
            btnEditarLibro.Text = "Editar";
            btnEditarLibro.UseVisualStyleBackColor = false;
            btnEditarLibro.Click += btnEditarLibro_Click;
            // 
            // btnGuardarLibro
            // 
            btnGuardarLibro.BackColor = Color.FromArgb(138, 31, 61);
            btnGuardarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnGuardarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnGuardarLibro.FlatAppearance.BorderSize = 0;
            btnGuardarLibro.FlatStyle = FlatStyle.Flat;
            btnGuardarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarLibro.ForeColor = Color.AliceBlue;
            btnGuardarLibro.Image = Properties.Resources.icons8_plus_24;
            btnGuardarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarLibro.Location = new Point(35, 34);
            btnGuardarLibro.Name = "btnGuardarLibro";
            btnGuardarLibro.Size = new Size(101, 32);
            btnGuardarLibro.TabIndex = 20;
            btnGuardarLibro.Text = "Guardar";
            btnGuardarLibro.UseVisualStyleBackColor = false;
            btnGuardarLibro.Click += btnGuardarLibro_Click;
            // 
            // gpbLibrosRegistrados
            // 
            gpbLibrosRegistrados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpbLibrosRegistrados.Controls.Add(pictureBox3);
            gpbLibrosRegistrados.Controls.Add(txtBuscarLibroLupa);
            gpbLibrosRegistrados.Controls.Add(dtgvLibrosRegistrados);
            gpbLibrosRegistrados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gpbLibrosRegistrados.ForeColor = Color.FromArgb(138, 31, 61);
            gpbLibrosRegistrados.Location = new Point(33, 510);
            gpbLibrosRegistrados.Name = "gpbLibrosRegistrados";
            gpbLibrosRegistrados.Size = new Size(739, 204);
            gpbLibrosRegistrados.TabIndex = 42;
            gpbLibrosRegistrados.TabStop = false;
            gpbLibrosRegistrados.Text = "LIBROS REGISTRADOS";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(232, 224, 229);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(445, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // txtBuscarLibroLupa
            // 
            txtBuscarLibroLupa.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarLibroLupa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarLibroLupa.Location = new Point(478, 17);
            txtBuscarLibroLupa.Name = "txtBuscarLibroLupa";
            txtBuscarLibroLupa.PlaceholderText = "     Buscar por título, autor o ISBN...";
            txtBuscarLibroLupa.Size = new Size(240, 25);
            txtBuscarLibroLupa.TabIndex = 30;
            // 
            // dtgvLibrosRegistrados
            // 
            dtgvLibrosRegistrados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvLibrosRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLibrosRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLibrosRegistrados.Location = new Point(24, 48);
            dtgvLibrosRegistrados.Name = "dtgvLibrosRegistrados";
            dtgvLibrosRegistrados.ReadOnly = true;
            dtgvLibrosRegistrados.Size = new Size(696, 150);
            dtgvLibrosRegistrados.TabIndex = 29;
            dtgvLibrosRegistrados.CellClick += dtgvLibrosRegistrados_CellClick;
            // 
            // FrmGestionDeLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(799, 611);
            Controls.Add(gpbLibrosRegistrados);
            Controls.Add(gboxAccionesLibro);
            Controls.Add(gboxDatosDelLibro);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionDeLibros";
            Text = " ";
            gboxDatosDelLibro.ResumeLayout(false);
            gboxDatosDelLibro.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAñoDePublicacion).EndInit();
            gboxAccionesLibro.ResumeLayout(false);
            gpbLibrosRegistrados.ResumeLayout(false);
            gpbLibrosRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvLibrosRegistrados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private GroupBox gboxDatosDelLibro;
        private Label lblltitulo;
        private TextBox txtTituloLibro;
        private Label lblIsbn;
        private TextBox txtISbn;
        private TextBox txtAutor;
        private Label lblAutor;
        private TextBox txtEditorial;
        private Label lblEditorial;
        private Label lblCategoria;
        private ComboBox cboxCategoria;
        private Label lblUbicacion;
        private ComboBox cmbUbicacion;
        private Label lblAñoPublicacion;
        private NumericUpDown nudAñoDePublicacion;
        private Label lblCantidadTotal;
        private TextBox txtDisponibles;
        private Label lblDisponibles;
        private NumericUpDown nudCantidadTotal;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private GroupBox gboxAccionesLibro;
        private Button btnLimpiarLibro;
        private Button btnBuscarLibro;
        private Button btnEliminarLibro;
        private Button btnEditarLibro;
        private Button btnGuardarLibro;
        private GroupBox gpbLibrosRegistrados;
        private DataGridView dtgvLibrosRegistrados;
        private TextBox txtBuscarLibroLupa;
        private PictureBox pictureBox3;
    }
}