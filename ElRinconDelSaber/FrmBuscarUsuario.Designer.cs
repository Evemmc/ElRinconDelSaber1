namespace ElRinconDelSaber
{
    partial class FrmBuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarUsuario));
            lblTituloBusqueda = new Label();
            txtBuscarUsuario = new TextBox();
            btnBuscarUsuario = new Button();
            pictureBox3 = new PictureBox();
            dtgvBuscarUsuarios = new DataGridView();
            btnCancelarUsuario = new Button();
            btnSeleccionar = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBuscarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblTituloBusqueda
            // 
            lblTituloBusqueda.AutoSize = true;
            lblTituloBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloBusqueda.Location = new Point(33, 50);
            lblTituloBusqueda.Name = "lblTituloBusqueda";
            lblTituloBusqueda.Size = new Size(254, 17);
            lblTituloBusqueda.TabIndex = 40;
            lblTituloBusqueda.Text = " Busca y selecciona un usuario del sistema";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.BackColor = Color.White;
            txtBuscarUsuario.Font = new Font("Segoe UI", 12F);
            txtBuscarUsuario.Location = new Point(71, 94);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Escribir nombre, apellido o usuario...";
            txtBuscarUsuario.Size = new Size(389, 29);
            txtBuscarUsuario.TabIndex = 41;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(138, 31, 61);
            btnBuscarUsuario.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnBuscarUsuario.FlatAppearance.BorderColor = Color.YellowGreen;
            btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            btnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarUsuario.ForeColor = Color.AliceBlue;
            btnBuscarUsuario.Image = Properties.Resources.icons8_plus_24;
            btnBuscarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarUsuario.Location = new Point(486, 91);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(101, 32);
            btnBuscarUsuario.TabIndex = 42;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(232, 224, 229);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // dtgvBuscarUsuarios
            // 
            dtgvBuscarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBuscarUsuarios.Location = new Point(33, 148);
            dtgvBuscarUsuarios.Name = "dtgvBuscarUsuarios";
            dtgvBuscarUsuarios.Size = new Size(435, 253);
            dtgvBuscarUsuarios.TabIndex = 57;
            // 
            // btnCancelarUsuario
            // 
            btnCancelarUsuario.BackColor = Color.White;
            btnCancelarUsuario.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnCancelarUsuario.FlatAppearance.BorderColor = Color.YellowGreen;
            btnCancelarUsuario.FlatAppearance.BorderSize = 0;
            btnCancelarUsuario.FlatStyle = FlatStyle.Flat;
            btnCancelarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelarUsuario.ForeColor = Color.Black;
            btnCancelarUsuario.Image = Properties.Resources.icons8_plus_24;
            btnCancelarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarUsuario.Location = new Point(367, 419);
            btnCancelarUsuario.Name = "btnCancelarUsuario";
            btnCancelarUsuario.Size = new Size(101, 32);
            btnCancelarUsuario.TabIndex = 58;
            btnCancelarUsuario.Text = "Cancelar";
            btnCancelarUsuario.UseVisualStyleBackColor = false;
            btnCancelarUsuario.Click += btnCancelarUsuario_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(138, 31, 61);
            btnSeleccionar.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnSeleccionar.FlatAppearance.BorderColor = Color.YellowGreen;
            btnSeleccionar.FlatAppearance.BorderSize = 0;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.AliceBlue;
            btnSeleccionar.Image = Properties.Resources.icons8_plus_24;
            btnSeleccionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeleccionar.Location = new Point(239, 419);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(101, 32);
            btnSeleccionar.TabIndex = 59;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(33, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 30);
            lblTitulo.TabIndex = 60;
            lblTitulo.Text = "Buscar usuario";
            // 
            // FrmBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(610, 485);
            Controls.Add(lblTitulo);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelarUsuario);
            Controls.Add(dtgvBuscarUsuarios);
            Controls.Add(pictureBox3);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(lblTituloBusqueda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscarUsuario";
            Text = "FrmBuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBuscarUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloBusqueda;
        private TextBox txtBuscarUsuario;
        private Button btnBuscarUsuario;
        private PictureBox pictureBox3;
        private DataGridView dtgvBuscarUsuarios;
        private Button btnCancelarUsuario;
        private Button btnSeleccionar;
        private Label lblTitulo;
    }
}