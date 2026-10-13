namespace ElRinconDelSaber
{
    partial class FrmAjustes
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
            lblTitulo = new Label();
            label1 = new Label();
            grpInformacionBiblioteca = new GroupBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombreBiblioteca = new TextBox();
            lblNombreBiblioteca = new Label();
            btnGuardarCambios = new Button();
            gpbSeguridad = new GroupBox();
            lblConfirmarContraseña = new Label();
            lblNuevaContraseña = new Label();
            txtConfirmarContraseña = new TextBox();
            txtNuevaContraseña = new TextBox();
            txtContraseñaActual = new TextBox();
            lblContraseñaUsuario = new Label();
            grpInformacionSistema = new GroupBox();
            lblInfo = new Label();
            lblVersion = new Label();
            btnLimpiarContraseña = new Button();
            grpInformacionBiblioteca.SuspendLayout();
            gpbSeguridad.SuspendLayout();
            grpInformacionSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(60, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 30);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Ajustes del sistema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(68, 48);
            label1.Name = "label1";
            label1.Size = new Size(312, 19);
            label1.TabIndex = 43;
            label1.Text = "Administra la configuración de El Rincón del saber\r\n";
            // 
            // grpInformacionBiblioteca
            // 
            grpInformacionBiblioteca.Controls.Add(txtDescripcion);
            grpInformacionBiblioteca.Controls.Add(lblDescripcion);
            grpInformacionBiblioteca.Controls.Add(txtNombreBiblioteca);
            grpInformacionBiblioteca.Controls.Add(lblNombreBiblioteca);
            grpInformacionBiblioteca.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInformacionBiblioteca.ForeColor = Color.FromArgb(138, 31, 61);
            grpInformacionBiblioteca.Location = new Point(33, 287);
            grpInformacionBiblioteca.Name = "grpInformacionBiblioteca";
            grpInformacionBiblioteca.Size = new Size(739, 191);
            grpInformacionBiblioteca.TabIndex = 44;
            grpInformacionBiblioteca.TabStop = false;
            grpInformacionBiblioteca.Text = "INFORMACIÓN DE LA BIBLIOTECA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12.25F);
            txtDescripcion.Location = new Point(27, 142);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(685, 29);
            txtDescripcion.TabIndex = 67;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.Black;
            lblDescripcion.Location = new Point(27, 111);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 19);
            lblDescripcion.TabIndex = 66;
            lblDescripcion.Text = "Descripción";
            // 
            // txtNombreBiblioteca
            // 
            txtNombreBiblioteca.Font = new Font("Segoe UI", 12.25F);
            txtNombreBiblioteca.Location = new Point(27, 69);
            txtNombreBiblioteca.Name = "txtNombreBiblioteca";
            txtNombreBiblioteca.Size = new Size(685, 29);
            txtNombreBiblioteca.TabIndex = 65;
            // 
            // lblNombreBiblioteca
            // 
            lblNombreBiblioteca.AutoSize = true;
            lblNombreBiblioteca.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreBiblioteca.ForeColor = Color.Black;
            lblNombreBiblioteca.Location = new Point(27, 38);
            lblNombreBiblioteca.Name = "lblNombreBiblioteca";
            lblNombreBiblioteca.Size = new Size(177, 19);
            lblNombreBiblioteca.TabIndex = 64;
            lblNombreBiblioteca.Text = "Nombre de la biblioteca:";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(138, 31, 61);
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarCambios.Location = new Point(627, 238);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(145, 43);
            btnGuardarCambios.TabIndex = 66;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // gpbSeguridad
            // 
            gpbSeguridad.Controls.Add(lblConfirmarContraseña);
            gpbSeguridad.Controls.Add(lblNuevaContraseña);
            gpbSeguridad.Controls.Add(txtConfirmarContraseña);
            gpbSeguridad.Controls.Add(txtNuevaContraseña);
            gpbSeguridad.Controls.Add(txtContraseñaActual);
            gpbSeguridad.Controls.Add(lblContraseñaUsuario);
            gpbSeguridad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gpbSeguridad.ForeColor = Color.FromArgb(138, 31, 61);
            gpbSeguridad.Location = new Point(33, 93);
            gpbSeguridad.Name = "gpbSeguridad";
            gpbSeguridad.Size = new Size(739, 127);
            gpbSeguridad.TabIndex = 67;
            gpbSeguridad.TabStop = false;
            gpbSeguridad.Text = "SEGURIDAD";
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmarContraseña.ForeColor = Color.Black;
            lblConfirmarContraseña.Location = new Point(503, 38);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(158, 19);
            lblConfirmarContraseña.TabIndex = 69;
            lblConfirmarContraseña.Text = "Confirmar contraseña:";
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNuevaContraseña.ForeColor = Color.Black;
            lblNuevaContraseña.Location = new Point(264, 38);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(133, 19);
            lblNuevaContraseña.TabIndex = 68;
            lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Segoe UI", 12.25F);
            txtConfirmarContraseña.Location = new Point(503, 69);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(209, 29);
            txtConfirmarContraseña.TabIndex = 67;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Segoe UI", 12.25F);
            txtNuevaContraseña.Location = new Point(264, 69);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(214, 29);
            txtNuevaContraseña.TabIndex = 66;
            txtNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Font = new Font("Segoe UI", 12.25F);
            txtContraseñaActual.Location = new Point(27, 69);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(208, 29);
            txtContraseñaActual.TabIndex = 65;
            txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // lblContraseñaUsuario
            // 
            lblContraseñaUsuario.AutoSize = true;
            lblContraseñaUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContraseñaUsuario.ForeColor = Color.Black;
            lblContraseñaUsuario.Location = new Point(27, 38);
            lblContraseñaUsuario.Name = "lblContraseñaUsuario";
            lblContraseñaUsuario.Size = new Size(132, 19);
            lblContraseñaUsuario.TabIndex = 64;
            lblContraseñaUsuario.Text = "Contraseña actual:";
            // 
            // grpInformacionSistema
            // 
            grpInformacionSistema.Controls.Add(lblInfo);
            grpInformacionSistema.Controls.Add(lblVersion);
            grpInformacionSistema.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInformacionSistema.ForeColor = Color.FromArgb(138, 31, 61);
            grpInformacionSistema.Location = new Point(33, 498);
            grpInformacionSistema.Name = "grpInformacionSistema";
            grpInformacionSistema.Size = new Size(739, 101);
            grpInformacionSistema.TabIndex = 68;
            grpInformacionSistema.TabStop = false;
            grpInformacionSistema.Text = "INFORMACIÓN DEL SISTEMA";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 10.75F);
            lblInfo.ForeColor = Color.Black;
            lblInfo.Location = new Point(27, 66);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(311, 20);
            lblInfo.TabIndex = 65;
            lblInfo.Text = "Tecnologías: C# · Windows Forms · SQL Server";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 10.75F);
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(27, 38);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(83, 20);
            lblVersion.TabIndex = 64;
            lblVersion.Text = "Version: 1.0";
            // 
            // btnLimpiarContraseña
            // 
            btnLimpiarContraseña.BackColor = Color.White;
            btnLimpiarContraseña.FlatAppearance.BorderColor = Color.White;
            btnLimpiarContraseña.FlatStyle = FlatStyle.Flat;
            btnLimpiarContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarContraseña.ForeColor = Color.Black;
            btnLimpiarContraseña.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarContraseña.Location = new Point(459, 238);
            btnLimpiarContraseña.Name = "btnLimpiarContraseña";
            btnLimpiarContraseña.Size = new Size(145, 43);
            btnLimpiarContraseña.TabIndex = 69;
            btnLimpiarContraseña.Text = "Limpiar campos";
            btnLimpiarContraseña.UseVisualStyleBackColor = false;
            btnLimpiarContraseña.Click += btnLimpiarContraseña_Click;
            // 
            // FrmAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(799, 611);
            Controls.Add(btnLimpiarContraseña);
            Controls.Add(grpInformacionSistema);
            Controls.Add(gpbSeguridad);
            Controls.Add(btnGuardarCambios);
            Controls.Add(grpInformacionBiblioteca);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAjustes";
            Text = "FrmAjustes";
            grpInformacionBiblioteca.ResumeLayout(false);
            grpInformacionBiblioteca.PerformLayout();
            gpbSeguridad.ResumeLayout(false);
            gpbSeguridad.PerformLayout();
            grpInformacionSistema.ResumeLayout(false);
            grpInformacionSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private GroupBox grpInformacionBiblioteca;
        private Button btnGuardarCambios;
        private TextBox txtNombreBiblioteca;
        private Label lblNombreBiblioteca;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private GroupBox gpbSeguridad;
        private TextBox txtNuevaContraseña;
        private TextBox txtContraseñaActual;
        private Label lblContraseñaUsuario;
        private GroupBox grpInformacionSistema;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblVersion;
        private Label lblInfo;
        private TextBox txtConfirmarContraseña;
        private Label lblConfirmarContraseña;
        private Label lblNuevaContraseña;
        private Button btnLimpiarContraseña;
    }
}