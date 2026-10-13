using DocumentFormat.OpenXml.Spreadsheet;
using ElRinconDelSaber.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElRinconDelSaber
{
    public partial class FrmAjustes : Form
    {
        private readonly string rolActual;
        public FrmAjustes(string rol)
        {
            InitializeComponent();

            rolActual = rol;

            bool esAdministrador =
                rolActual.Equals("Administrador",
                StringComparison.OrdinalIgnoreCase);

            grpInformacionBiblioteca.Visible = esAdministrador;
            grpInformacionSistema.Visible = esAdministrador;

            txtNombreBiblioteca.ReadOnly = !esAdministrador;
            txtDescripcion.ReadOnly = !esAdministrador;

            if (esAdministrador)
            {
                CargarConfiguracion();
            }

            txtContraseñaActual.UseSystemPasswordChar = true;
            txtNuevaContraseña.UseSystemPasswordChar = true;
        }

        private bool CambiarContrasena()
        {
            string actual = txtContraseñaActual.Text;
            string nueva = txtNuevaContraseña.Text;
            string confirmar = txtConfirmarContraseña.Text;

            if (string.IsNullOrWhiteSpace(actual) ||
                string.IsNullOrWhiteSpace(nueva) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Completa los tres campos de contraseña.");
                return false;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.");
                return false;
            }

            if (nueva.Length < 8)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres.");
                return false;
            }

            if (SesionActual.IdUsuario <= 0)
            {
                MessageBox.Show("No se pudo identificar al usuario actual.");
                return false;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();
                cn.Open();

                string consulta = @"
            UPDATE Usuarios
            SET Contrasena = @Nueva
            WHERE IdUsuario = @IdUsuario
              AND Contrasena = @Actual
              AND Estado = 1";

                using SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@Nueva", nueva);
                cmd.Parameters.AddWithValue("@Actual", actual);
                cmd.Parameters.AddWithValue("@IdUsuario", SesionActual.IdUsuario);

                int filas = cmd.ExecuteNonQuery();

                if (filas == 0)
                {
                    MessageBox.Show(
                        "La contraseña actual es incorrecta o la cuenta está inactiva.");
                    return false;
                }

                txtContraseñaActual.Clear();
                txtNuevaContraseña.Clear();
                txtConfirmarContraseña.Clear();

                MessageBox.Show("Contraseña actualizada correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar la contraseña:\n" + ex.Message);
                return false;
            }
        }
        private void CargarConfiguracion()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();
                cn.Open();

                string consulta = @"
            SELECT NombreBiblioteca, Descripcion
            FROM Configuracion
            WHERE IdConfiguracion = 1";

                using SqlCommand cmd = new SqlCommand(consulta, cn);
                using SqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    txtNombreBiblioteca.Text =
                        lector["NombreBiblioteca"].ToString();

                    txtDescripcion.Text =
                        lector["Descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la configuración:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            bool esAdministrador = rolActual.Equals(
                "Administrador",
                StringComparison.OrdinalIgnoreCase);

            bool quiereCambiarContrasena =
                !string.IsNullOrEmpty(txtContraseñaActual.Text) ||
                !string.IsNullOrEmpty(txtNuevaContraseña.Text) ||
                !string.IsNullOrEmpty(txtConfirmarContraseña.Text);

            // Si escribió algo en los campos de contraseña,
            // primero procesamos el cambio de contraseña.
            if (quiereCambiarContrasena)
            {
                if (!CambiarContrasena())
                {
                    return;
                }

                // Los usuarios que no son administradores
                // solamente pueden cambiar su contraseña.
                if (!esAdministrador)
                {
                    return;
                }
            }

            // Los usuarios normales no pueden modificar
            // la configuración de la biblioteca.
            if (!esAdministrador)
            {
                MessageBox.Show(
                    "Escribe tu contraseña actual y la nueva contraseña.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // A partir de aquí, solo el administrador
            // puede guardar la configuración.
            string nombre = txtNombreBiblioteca.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Debes ingresar el nombre de la biblioteca.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (nombre.Length > 150 || descripcion.Length > 500)
            {
                MessageBox.Show(
                    "El nombre no puede superar 150 caracteres " +
                    "y la descripción no puede superar 500.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();
                cn.Open();

                string consulta = @"
            UPDATE Configuracion
            SET NombreBiblioteca = @Nombre,
                Descripcion = @Descripcion
            WHERE IdConfiguracion = 1";

                using SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show(
                        "Configuración guardada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró la configuración para actualizar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la configuración:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseñaActual.Clear();
            txtNuevaContraseña.Clear();
            txtConfirmarContraseña.Clear();

            txtContraseñaActual.Focus();
        }
    }
}