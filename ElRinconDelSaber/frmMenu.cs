using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ElRinconDelSaber
{
    public partial class frmMenu : Form
    {
        private string rolUsuario;
        private Form? formularioActivo = null;
        public frmMenu(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
            AplicarPermisos();
        }

        //Para poder mover un formulario de Windows Forms arrastrándolo con el mouse
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarPermisos()
        {
            if (rolUsuario == "Administrador")
            {
                btnUsuarios.Enabled = true;
                btnAbrirUsuarios.Enabled = true;
            }
            else
            {
                btnUsuarios.Enabled = false;
                btnAbrirUsuarios.Enabled = false;
            }
        }
        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Cierra el módulo anterior si había uno abierto
            if (formularioActivo != null)
                formularioActivo.Close();

            // Oculta los elementos de Inicio
            foreach (Control control in panelContenedor.Controls)
            {
                control.Visible = false;
            }

            formularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }


        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAbrirUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmGestionDeUsuarios());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmGestionDeUsuarios());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            foreach (Control control in panelContenedor.Controls)
            {
                control.Visible = true;
            }
        }
    }
}
