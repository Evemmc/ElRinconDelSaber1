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
    public partial class FrmBuscarUsuario : Form
    {
        public FrmBuscarUsuario()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        public int IdUsuarioSeleccionado { get; private set; }
        public string NombreUsuarioSeleccionado { get; private set; } = "";

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT
                                IdUsuario,
                                Nombre,
                                Apellido,
                                Usuario
                            FROM Usuarios
                            WHERE Estado = 1
                            ORDER BY Nombre, Apellido";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dtgvBuscarUsuarios.DataSource = tabla;
                dtgvBuscarUsuarios.ReadOnly = true;
                dtgvBuscarUsuarios.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dtgvBuscarUsuarios.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarUsuarios();
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT IdUsuario, Nombre, Apellido, Usuario
                        FROM Usuarios
                        WHERE Estado = 1
                        AND (
                            Nombre LIKE @Busqueda
                            OR Apellido LIKE @Busqueda
                            OR Usuario LIKE @Busqueda
                            OR CONCAT(Nombre, ' ', Apellido) LIKE @Busqueda
                        )
                        ORDER BY Nombre, Apellido";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                adaptador.SelectCommand.Parameters.AddWithValue(
                    "@Busqueda", "%" + busqueda + "%");

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dtgvBuscarUsuarios.DataSource = tabla;
                dtgvBuscarUsuarios.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron usuarios con ese criterio.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar usuarios.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dtgvBuscarUsuarios.CurrentRow == null ||
                dtgvBuscarUsuarios.CurrentRow.IsNewRow ||
                !dtgvBuscarUsuarios.CurrentRow.Selected)
            {
                MessageBox.Show("Seleccione un usuario de la tabla.");
                return;
            }

            DataGridViewRow fila = dtgvBuscarUsuarios.CurrentRow;

            IdUsuarioSeleccionado =
                Convert.ToInt32(fila.Cells["IdUsuario"].Value);

            string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";
            string apellido = fila.Cells["Apellido"].Value?.ToString() ?? "";

            NombreUsuarioSeleccionado = nombre + " " + apellido;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
