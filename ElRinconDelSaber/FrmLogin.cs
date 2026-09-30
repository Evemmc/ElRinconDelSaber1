using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using ElRinconDelSaber.Datos;

namespace ElRinconDelSaber
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(
            System.IntPtr hwnd,
            int wmsg,
            int wparam,
            int lparam
        );

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text))
            {
                MessageBox.Show("Ingrese su usuario.");
                txtUsuarioLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasenaLogin.Text))
            {
                MessageBox.Show("Ingrese su contraseña.");
                txtContrasenaLogin.Focus();
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"
            SELECT 
                U.IdUsuario,
                U.Nombre,
                U.Estado,
                R.NombreRol
            FROM Usuarios U
            INNER JOIN Roles R ON U.IdRol = R.IdRol
            WHERE U.Usuario = @Usuario
              AND U.Contrasena = @Contrasena";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue(
                    "@Usuario",
                    txtUsuarioLogin.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@Contrasena",
                    txtContrasenaLogin.Text
                );

                cn.Open();

                using SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    bool estado = Convert.ToBoolean(lector["Estado"]);

                    if (!estado)
                    {
                        MessageBox.Show(
                            "Este usuario se encuentra inactivo.",
                            "Acceso denegado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    string nombre = lector["Nombre"].ToString() ?? "";
                    string rol = lector["NombreRol"].ToString() ?? "";

                    MessageBox.Show(
                        $"Bienvenido/a {nombre}\nRol: {rol}",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    frmMenu menu = new frmMenu(rol);

                    menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    txtContrasenaLogin.Clear();
                    txtContrasenaLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar sesión:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
