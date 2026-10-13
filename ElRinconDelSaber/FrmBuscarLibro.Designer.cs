namespace ElRinconDelSaber
{
    partial class FrmBuscarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarLibro));
            lblTitulo = new Label();
            lblTituloBusqueda = new Label();
            btnSeleccionarLibro = new Button();
            btnCancelarLibro = new Button();
            dtgvBuscarLibros = new DataGridView();
            pictureBox3 = new PictureBox();
            btnBuscarLibro = new Button();
            txtBuscarLibro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvBuscarLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(33, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(129, 30);
            lblTitulo.TabIndex = 61;
            lblTitulo.Text = "Buscar libro";
            // 
            // lblTituloBusqueda
            // 
            lblTituloBusqueda.AutoSize = true;
            lblTituloBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloBusqueda.Location = new Point(42, 50);
            lblTituloBusqueda.Name = "lblTituloBusqueda";
            lblTituloBusqueda.Size = new Size(306, 17);
            lblTituloBusqueda.TabIndex = 62;
            lblTituloBusqueda.Text = "Busca y selecciona un libro disponible del catálogo";
            // 
            // btnSeleccionarLibro
            // 
            btnSeleccionarLibro.BackColor = Color.FromArgb(138, 31, 61);
            btnSeleccionarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnSeleccionarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnSeleccionarLibro.FlatAppearance.BorderSize = 0;
            btnSeleccionarLibro.FlatStyle = FlatStyle.Flat;
            btnSeleccionarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeleccionarLibro.ForeColor = Color.AliceBlue;
            btnSeleccionarLibro.Image = Properties.Resources.icons8_plus_24;
            btnSeleccionarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeleccionarLibro.Location = new Point(239, 414);
            btnSeleccionarLibro.Name = "btnSeleccionarLibro";
            btnSeleccionarLibro.Size = new Size(101, 32);
            btnSeleccionarLibro.TabIndex = 68;
            btnSeleccionarLibro.Text = "Seleccionar";
            btnSeleccionarLibro.UseVisualStyleBackColor = false;
            btnSeleccionarLibro.Click += btnSeleccionarLibro_Click;
            // 
            // btnCancelarLibro
            // 
            btnCancelarLibro.BackColor = Color.White;
            btnCancelarLibro.BackgroundImage = Properties.Resources.icons8_plus_24;
            btnCancelarLibro.FlatAppearance.BorderColor = Color.YellowGreen;
            btnCancelarLibro.FlatAppearance.BorderSize = 0;
            btnCancelarLibro.FlatStyle = FlatStyle.Flat;
            btnCancelarLibro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelarLibro.ForeColor = Color.Black;
            btnCancelarLibro.Image = Properties.Resources.icons8_plus_24;
            btnCancelarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarLibro.Location = new Point(367, 414);
            btnCancelarLibro.Name = "btnCancelarLibro";
            btnCancelarLibro.Size = new Size(101, 32);
            btnCancelarLibro.TabIndex = 67;
            btnCancelarLibro.Text = "Cancelar";
            btnCancelarLibro.UseVisualStyleBackColor = false;
            btnCancelarLibro.Click += btnCancelarLibro_Click;
            // 
            // dtgvBuscarLibros
            // 
            dtgvBuscarLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBuscarLibros.Location = new Point(33, 143);
            dtgvBuscarLibros.Name = "dtgvBuscarLibros";
            dtgvBuscarLibros.Size = new Size(435, 253);
            dtgvBuscarLibros.TabIndex = 66;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(232, 224, 229);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 65;
            pictureBox3.TabStop = false;
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
            btnBuscarLibro.Location = new Point(486, 86);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(101, 32);
            btnBuscarLibro.TabIndex = 64;
            btnBuscarLibro.Text = "Buscar";
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.BackColor = Color.White;
            txtBuscarLibro.Font = new Font("Segoe UI", 12F);
            txtBuscarLibro.Location = new Point(71, 89);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.PlaceholderText = "Título, autor o ISBN...";
            txtBuscarLibro.Size = new Size(389, 29);
            txtBuscarLibro.TabIndex = 63;
            // 
            // FrmBuscarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 224, 229);
            ClientSize = new Size(623, 491);
            Controls.Add(btnSeleccionarLibro);
            Controls.Add(btnCancelarLibro);
            Controls.Add(dtgvBuscarLibros);
            Controls.Add(pictureBox3);
            Controls.Add(btnBuscarLibro);
            Controls.Add(txtBuscarLibro);
            Controls.Add(lblTituloBusqueda);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBuscarLibro";
            Text = "FrmBuscarLibro";
            ((System.ComponentModel.ISupportInitialize)dtgvBuscarLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTituloBusqueda;
        private Button btnSeleccionarLibro;
        private Button btnCancelarLibro;
        private DataGridView dtgvBuscarLibros;
        private PictureBox pictureBox3;
        private Button btnBuscarLibro;
        private TextBox txtBuscarLibro;
    }
}