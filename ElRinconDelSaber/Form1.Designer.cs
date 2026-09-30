namespace ElRinconDelSaber
{
    partial class FrmGestionDeUsuarios
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblidUsuario = new Label();
            txtIdUsuario = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            lblRol = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cboxRol = new ComboBox();
            lblEstado = new Label();
            cboxEstado = new ComboBox();
            lblFechaRegistro = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnGuardar = new Button();
            dgvUsuarios = new DataGridView();
            gboxDatosDeUsuarios = new GroupBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            gboxAcciones = new GroupBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gboxDatosDeUsuarios.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gboxAcciones.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(60, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(208, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Usuarios";
            // 
            // lblidUsuario
            // 
            lblidUsuario.AutoSize = true;
            lblidUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblidUsuario.ForeColor = Color.Black;
            lblidUsuario.Location = new Point(29, 47);
            lblidUsuario.Name = "lblidUsuario";
            lblidUsuario.Size = new Size(82, 19);
            lblidUsuario.TabIndex = 2;
            lblidUsuario.Text = "ID Usuario:";
            lblidUsuario.Click += lblidUsuario_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BackColor = Color.White;
            txtIdUsuario.Font = new Font("Segoe UI", 12F);
            txtIdUsuario.Location = new Point(29, 69);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(125, 29);
            txtIdUsuario.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(166, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(172, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.Black;
            lblApellido.Location = new Point(340, 47);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 19);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(340, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 27);
            txtApellido.TabIndex = 7;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(29, 117);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 19);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(29, 139);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 9;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.Black;
            lblContraseña.Location = new Point(172, 117);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(88, 19);
            lblContraseña.TabIndex = 10;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(172, 139);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(144, 27);
            txtContraseña.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.ForeColor = Color.Black;
            lblRol.Location = new Point(340, 117);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 19);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cboxRol
            // 
            cboxRol.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxRol.FormattingEnabled = true;
            cboxRol.Items.AddRange(new object[] { "Seleccione un rol", "Administrador", "Bibliotecario", "Usuario" });
            cboxRol.Location = new Point(340, 139);
            cboxRol.Name = "cboxRol";
            cboxRol.Size = new Size(157, 27);
            cboxRol.TabIndex = 14;
            cboxRol.SelectedIndexChanged += cboxRol_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(29, 190);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 19);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado:";
            // 
            // cboxEstado
            // 
            cboxEstado.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxEstado.FormattingEnabled = true;
            cboxEstado.Items.AddRange(new object[] { "Seleccione un estado", "Activo", "Inactivo" });
            cboxEstado.Location = new Point(29, 212);
            cboxEstado.Name = "cboxEstado";
            cboxEstado.Size = new Size(163, 27);
            cboxEstado.TabIndex = 16;
            cboxEstado.SelectedIndexChanged += cboxEstado_SelectedIndexChanged;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaRegistro.ForeColor = Color.Black;
            lblFechaRegistro.Location = new Point(214, 190);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(129, 19);
            lblFechaRegistro.TabIndex = 17;
            lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(214, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(138, 31, 61);
            btnGuardar.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnGuardar.FlatAppearance.BorderColor = Color.YellowGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.AliceBlue;
            btnGuardar.Image = Properties.Resources.icons8_plus_24;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(35, 34);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 32);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(35, 38);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(675, 112);
            dgvUsuarios.TabIndex = 26;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // gboxDatosDeUsuarios
            // 
            gboxDatosDeUsuarios.BackColor = Color.FromArgb(232, 224, 229);
            gboxDatosDeUsuarios.Controls.Add(panel1);
            gboxDatosDeUsuarios.Controls.Add(pictureBox1);
            gboxDatosDeUsuarios.Controls.Add(cboxRol);
            gboxDatosDeUsuarios.Controls.Add(lblEstado);
            gboxDatosDeUsuarios.Controls.Add(lblidUsuario);
            gboxDatosDeUsuarios.Controls.Add(dateTimePicker1);
            gboxDatosDeUsuarios.Controls.Add(lblFechaRegistro);
            gboxDatosDeUsuarios.Controls.Add(cboxEstado);
            gboxDatosDeUsuarios.Controls.Add(lblRol);
            gboxDatosDeUsuarios.Controls.Add(txtIdUsuario);
            gboxDatosDeUsuarios.Controls.Add(lblNombre);
            gboxDatosDeUsuarios.Controls.Add(txtNombre);
            gboxDatosDeUsuarios.Controls.Add(lblApellido);
            gboxDatosDeUsuarios.Controls.Add(txtUsuario);
            gboxDatosDeUsuarios.Controls.Add(txtApellido);
            gboxDatosDeUsuarios.Controls.Add(lblUsuario);
            gboxDatosDeUsuarios.Controls.Add(lblContraseña);
            gboxDatosDeUsuarios.Controls.Add(txtContraseña);
            gboxDatosDeUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxDatosDeUsuarios.ForeColor = Color.FromArgb(138, 31, 61);
            gboxDatosDeUsuarios.Location = new Point(33, 94);
            gboxDatosDeUsuarios.Name = "gboxDatosDeUsuarios";
            gboxDatosDeUsuarios.Size = new Size(739, 265);
            gboxDatosDeUsuarios.TabIndex = 34;
            gboxDatosDeUsuarios.TabStop = false;
            gboxDatosDeUsuarios.Text = "DATOS DE USUARIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(520, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 120);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 67);
            label2.Name = "label2";
            label2.Size = new Size(184, 39);
            label2.TabIndex = 39;
            label2.Text = "Asigne un rol y estado al usuario.\r\nLos roles determinan los permisos\r\n            dentro del sistema.\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_26_ago_2026__02_54_38_p_m_;
            pictureBox2.Location = new Point(67, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_26_ago_2026__02_46_25_p_m_;
            pictureBox1.Location = new Point(550, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // gboxAcciones
            // 
            gboxAcciones.Controls.Add(btnLimpiar);
            gboxAcciones.Controls.Add(btnBuscar);
            gboxAcciones.Controls.Add(btnEliminar);
            gboxAcciones.Controls.Add(btnEditar);
            gboxAcciones.Controls.Add(btnGuardar);
            gboxAcciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gboxAcciones.ForeColor = Color.FromArgb(138, 31, 61);
            gboxAcciones.Location = new Point(43, 384);
            gboxAcciones.Name = "gboxAcciones";
            gboxAcciones.Size = new Size(739, 83);
            gboxAcciones.TabIndex = 35;
            gboxAcciones.TabStop = false;
            gboxAcciones.Text = "ACCIONES";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(138, 31, 61);
            btnLimpiar.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnLimpiar.FlatAppearance.BorderColor = Color.YellowGreen;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.AliceBlue;
            btnLimpiar.Image = Properties.Resources.icons8_plus_24;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(590, 34);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 32);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(138, 31, 61);
            btnBuscar.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnBuscar.FlatAppearance.BorderColor = Color.YellowGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.AliceBlue;
            btnBuscar.Image = Properties.Resources.icons8_plus_24;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(454, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 32);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(138, 31, 61);
            btnEliminar.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnEliminar.FlatAppearance.BorderColor = Color.YellowGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.AliceBlue;
            btnEliminar.Image = Properties.Resources.icons8_plus_24;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(314, 34);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 32);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(138, 31, 61);
            btnEditar.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnEditar.FlatAppearance.BorderColor = Color.YellowGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources.icons8_plus_24;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(174, 34);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 32);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUsuarios);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(138, 31, 61);
            groupBox2.Location = new Point(43, 488);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(739, 204);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "USUARIOS REGISTRADOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(60, 48);
            label1.Name = "label1";
            label1.Size = new Size(295, 19);
            label1.TabIndex = 37;
            label1.Text = " Administra los usuarios del sistema y sus roles";
            // 
            // FrmGestionDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(815, 650);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(gboxDatosDeUsuarios);
            Controls.Add(gboxAcciones);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionDeUsuarios";
            Text = "Gestión de usuarios";
            Load += FrmGestionDeUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gboxDatosDeUsuarios.ResumeLayout(false);
            gboxDatosDeUsuarios.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gboxAcciones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDatosDeUsuario;
        private Label lblidUsuario;
        private TextBox txtIdUsuario;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Label lblRol;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cboxRol;
        private Label lblEstado;
        private ComboBox cboxEstado;
        private Label lblFechaRegistro;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardar;
        private Button btnBuscar;
        private DataGridView dgvUsuarios;
        private Label lblRolesDisponibles;
        private GroupBox gboxDatosDeUsuarios;
        private GroupBox gboxAcciones;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnLimpiar;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
