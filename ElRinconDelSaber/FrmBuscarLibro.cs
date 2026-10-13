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
    public partial class FrmBuscarLibro : Form
    {
        public int IdLibroSeleccionado { get; private set; }
        public FrmBuscarLibro()
        {
            InitializeComponent();
            CargarLibros();
        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT
                                IdLibro,
                                ISBN,
                                Titulo,
                                Autor,
                                Disponibles
                            FROM Libros
                            WHERE Estado = 'Activo'
                            AND Disponibles > 0
                            ORDER BY Titulo";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dtgvBuscarLibros.DataSource = tabla;

                dtgvBuscarLibros.ReadOnly = true;
                dtgvBuscarLibros.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dtgvBuscarLibros.MultiSelect = false;

                dtgvBuscarLibros.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarLibro.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarLibros();
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT IdLibro, ISBN, Titulo,
                        Autor, Disponibles
                        FROM Libros
                        WHERE Estado = 'Activo'
                        AND Disponibles > 0
                        AND (
                            Titulo LIKE @Busqueda
                            OR Autor LIKE @Busqueda
                            OR ISBN LIKE @Busqueda
                        )
                        ORDER BY Titulo";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                adaptador.SelectCommand.Parameters.AddWithValue(
                    "@Busqueda", "%" + busqueda + "%");

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dtgvBuscarLibros.DataSource = tabla;
                dtgvBuscarLibros.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron libros disponibles.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar libros.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarLibro_Click(object sender, EventArgs e)
        {
            if (dtgvBuscarLibros.CurrentRow == null ||
                dtgvBuscarLibros.CurrentRow.IsNewRow ||
                !dtgvBuscarLibros.CurrentRow.Selected)
            {
                MessageBox.Show("Primero seleccione un libro de la tabla.");
                return;
            }

            DataGridViewRow fila = dtgvBuscarLibros.CurrentRow;

            IdLibroSeleccionado =
                Convert.ToInt32(fila.Cells["IdLibro"].Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarLibro_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
