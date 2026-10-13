using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ElRinconDelSaber
{
    public partial class frmMenu : Form
    {
        private string rolUsuario;
        private Form? formularioActivo = null;
        public frmMenu(string rol)
        {
            InitializeComponent();

            pnlEncabezado.Resize += (s, e) =>
            {
                pnlEncabezado.Left =
                    (pnlEncabezado.ClientSize.Width - pnlEncabezado.Width) / 2;
            };

            rolUsuario = rol;
            AplicarPermisos();

            this.Resize += frmMenu_Resize;
            frmMenu_Resize(this, EventArgs.Empty);
        }

        public void MostrarInicio()
        {
            btnInicio_Click(this, EventArgs.Empty);
        }
        private void frmMenu_Resize(object sender, EventArgs e)
        {
            Panel[] tarjetas =
          {
             pnlUsuarios,
             pnlLibros,
             pnlPrestamo,
             pnlDevoluciones,
             pnlReportes,
             pnlAjustes
          };

            int izquierda = tarjetas.Min(p => p.Left);
            int derecha = tarjetas.Max(p => p.Right);

            int anchoTotal = derecha - izquierda;

            int nuevaIzquierda = (panelContenedor.ClientSize.Width - anchoTotal) / 2;

            int desplazamiento = nuevaIzquierda - izquierda;

            foreach (Panel tarjeta in tarjetas)
            {
                tarjeta.Left += desplazamiento;
            }

        }

        //Para poder mover un formulario de Windows Forms arrastrándolo con el mouse
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AplicarPermisos()
        {
            bool esAdministrador = rolUsuario.Equals(
                "Administrador",
                StringComparison.OrdinalIgnoreCase);

            bool esBibliotecario = rolUsuario.Equals(
                "Bibliotecario",
                StringComparison.OrdinalIgnoreCase);

            // USUARIOS: solo administrador y bibliotecario
            btnUsuarios.Enabled = esAdministrador || esBibliotecario;
            btnAbrirUsuarios.Enabled = esAdministrador || esBibliotecario;

            // REPORTES: administrador y bibliotecario
            btnReportes.Enabled = esAdministrador || esBibliotecario;
            btnAbrirReportes.Enabled = esAdministrador || esBibliotecario;

            // DEVOLUCIONES: administrador y bibliotecario
            btnDevolver.Enabled = esAdministrador || esBibliotecario;
            btnAbrirDevoluciones.Enabled = esAdministrador || esBibliotecario;

            // PRÉSTAMOS: administrador y bibliotecario
            btnPrestar.Enabled = esAdministrador || esBibliotecario;
            btnAbrirPrestamos.Enabled = esAdministrador || esBibliotecario;
        }
        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Cierra el módulo anterior si había uno abierto
            if (formularioActivo != null)
                formularioActivo.Close();

            // Oculta los elementos de Inicio
            foreach (System.Windows.Forms.Control control in panelContenedor.Controls)
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

            foreach (System.Windows.Forms.Control control in panelContenedor.Controls)
            {
                control.Visible = true;
            }
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {

            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            foreach (System.Windows.Forms.Control control in panelContenedor.Controls)
            {
                control.Visible = false;
            }

            FrmGestionDeLibros libros = new FrmGestionDeLibros();

            libros.TopLevel = false;
            libros.FormBorderStyle = FormBorderStyle.None;
            libros.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(libros);

            formularioActivo = libros;

            libros.BringToFront();
            libros.Show();
        }

        private void btnAbrirLibros_Click(object sender, EventArgs e)
        {
            btnLibros_Click(sender, e);
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            foreach (System.Windows.Forms.Control control in panelContenedor.Controls)
            {
                control.Visible = false;
            }

            FrmPrestamoDeLibros prestamos = new FrmPrestamoDeLibros();

            prestamos.TopLevel = false;
            prestamos.FormBorderStyle = FormBorderStyle.None;
            prestamos.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(prestamos);

            formularioActivo = prestamos;

            prestamos.BringToFront();
            prestamos.Show();
        }

        private void btnAbrirPrestamos_Click(object sender, EventArgs e)
        {
            btnPrestar_Click(sender, e);
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            foreach (System.Windows.Forms.Control control in panelContenedor.Controls)
            {
                control.Visible = false;
            }

            FrmDevolucionDeLibros devoluciones = new FrmDevolucionDeLibros();

            devoluciones.TopLevel = false;
            devoluciones.FormBorderStyle = FormBorderStyle.None;
            devoluciones.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(devoluciones);

            formularioActivo = devoluciones;

            devoluciones.BringToFront();
            devoluciones.Show();
        }

        private void btnAbrirDevoluciones_Click(object sender, EventArgs e)
        {
            btnDevolver_Click(sender, e);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            foreach (System.Windows.Forms.Control control in panelContenedor.Controls)
            {
                control.Visible = false;
            }

            FrmReportes reportes = new FrmReportes();

            reportes.TopLevel = false;
            reportes.FormBorderStyle = FormBorderStyle.None;
            reportes.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(reportes);

            formularioActivo = reportes;

            reportes.BringToFront();
            reportes.Show();
        }

        private void btnAbrirReportes_Click(object sender, EventArgs e)
        {
            btnReportes_Click(sender, e);
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Deseas cerrar la sesión?",
            "Cerrar sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();

                this.Hide();
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmAjustes(rolUsuario));
        }

        private void btnAbrirAjustes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmAjustes(rolUsuario));
        }
    }
}
