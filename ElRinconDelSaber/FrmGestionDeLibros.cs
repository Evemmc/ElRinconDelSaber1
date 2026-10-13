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
    public partial class FrmGestionDeLibros : Form
    {
        private int idLibroSeleccionado = 0;
        public FrmGestionDeLibros()
        {
            InitializeComponent();

            bool puedeModificar =
            SesionActual.Rol.Equals(
             "Administrador",
              StringComparison.OrdinalIgnoreCase)
              ||
           SesionActual.Rol.Equals(
             "Bibliotecario",
             StringComparison.OrdinalIgnoreCase);

            btnGuardarLibro.Enabled = puedeModificar;
            btnEditarLibro.Enabled = puedeModificar;
            btnEliminarLibro.Enabled = puedeModificar;

            // Campos de texto
            txtISbn.ReadOnly = !puedeModificar;
            txtTituloLibro.ReadOnly = !puedeModificar;
            txtAutor.ReadOnly = !puedeModificar;
            txtEditorial.ReadOnly = !puedeModificar;

            // Campos numéricos
            nudAñoDePublicacion.Enabled = puedeModificar;
            nudCantidadTotal.Enabled = puedeModificar;

            // Listas desplegables
            cboxCategoria.Enabled = puedeModificar;
            cmbUbicacion.Enabled = puedeModificar;
            cmbEstado.Enabled = puedeModificar;

            cboxCategoria.SelectedIndex = 0;
            cmbUbicacion.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            CargarLibros();
        }

        private void LimpiarCampos()
        {
            txtISbn.Clear();
            txtTituloLibro.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();

            nudAñoDePublicacion.Value = 0;
            nudCantidadTotal.Value = 0;

            txtDisponibles.Clear();

            cboxCategoria.SelectedIndex = 0;
            cmbUbicacion.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            idLibroSeleccionado = 0;

            dtgvLibrosRegistrados.ClearSelection();
        }

        private void nudCantidadTotal_ValueChanged(object sender, EventArgs e)
        {
            txtDisponibles.Text = nudCantidadTotal.Value.ToString();
        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT IdLibro, ISBN, Titulo, Autor,
                            Editorial, AnioPublicacion, Categoria,
                            Ubicacion, CantidadTotal, Disponibles, Estado
                            FROM Libros
                            ORDER BY IdLibro DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dtgvLibrosRegistrados.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISbn.Text))
            {
                MessageBox.Show("Ingrese el ISBN del libro.");
                txtISbn.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("Ingrese el título del libro.");
                txtTituloLibro.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Ingrese el autor del libro.");
                txtAutor.Focus();
                return;
            }

            if (nudAñoDePublicacion.Value <= 0)
            {
                MessageBox.Show("Ingrese un año de publicación válido.");
                return;
            }

            if (cboxCategoria.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(cboxCategoria.Text) ||
                cboxCategoria.Text.StartsWith("Seleccione"))
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (cmbUbicacion.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(cmbUbicacion.Text) ||
                cmbUbicacion.Text.StartsWith("Seleccione"))
            {
                MessageBox.Show("Seleccione una ubicación.");
                return;
            }

            if (nudCantidadTotal.Value <= 0)
            {
                MessageBox.Show("La cantidad total debe ser mayor que cero.");
                return;
            }

            if (cmbEstado.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(cmbEstado.Text) ||
                cmbEstado.Text.StartsWith("Seleccione"))
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            // GUARDAR EL LIBRO EN SQL SERVER

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"INSERT INTO Libros
                 (ISBN, Titulo, Autor, Editorial, AnioPublicacion,
                  Categoria, Ubicacion, CantidadTotal, Disponibles, Estado)
                  VALUES
                 (@ISBN, @Titulo, @Autor, @Editorial, @AnioPublicacion,
                  @Categoria, @Ubicacion, @CantidadTotal, @Disponibles, @Estado)";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue("@ISBN", txtISbn.Text.Trim());
                comando.Parameters.AddWithValue("@Titulo", txtTituloLibro.Text.Trim());
                comando.Parameters.AddWithValue("@Autor", txtAutor.Text.Trim());
                comando.Parameters.AddWithValue("@Editorial", txtEditorial.Text.Trim());

                comando.Parameters.AddWithValue(
                    "@AnioPublicacion",
                    (int)nudAñoDePublicacion.Value
                );

                comando.Parameters.AddWithValue(
                    "@Categoria",
                    cboxCategoria.Text
                );

                comando.Parameters.AddWithValue(
                    "@Ubicacion",
                    cmbUbicacion.Text
                );

                comando.Parameters.AddWithValue(
                    "@CantidadTotal",
                    (int)nudCantidadTotal.Value
                );

                comando.Parameters.AddWithValue(
                    "@Disponibles",
                    (int)nudCantidadTotal.Value
                );

                comando.Parameters.AddWithValue(
                    "@Estado",
                    cmbEstado.Text
                );

                cn.Open();
                comando.ExecuteNonQuery();
                CargarLibros();
                LimpiarCampos();

                MessageBox.Show(
                    "Libro registrado correctamente.",
                    "El Rincón del Saber",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el libro.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dtgvLibrosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dtgvLibrosRegistrados.Rows[e.RowIndex];

            if (fila.IsNewRow || fila.Cells["IdLibro"].Value == null)
                return;

            idLibroSeleccionado = Convert.ToInt32(fila.Cells["IdLibro"].Value);

            txtISbn.Text = fila.Cells["ISBN"].Value?.ToString() ?? "";
            txtTituloLibro.Text = fila.Cells["Titulo"].Value?.ToString() ?? "";
            txtAutor.Text = fila.Cells["Autor"].Value?.ToString() ?? "";
            txtEditorial.Text = fila.Cells["Editorial"].Value?.ToString() ?? "";

            nudAñoDePublicacion.Value =
                Convert.ToDecimal(fila.Cells["AnioPublicacion"].Value);

            cboxCategoria.Text = fila.Cells["Categoria"].Value?.ToString() ?? "";
            cmbUbicacion.Text = fila.Cells["Ubicacion"].Value?.ToString() ?? "";

            nudCantidadTotal.Value =
                Convert.ToDecimal(fila.Cells["CantidadTotal"].Value);

            txtDisponibles.Text = fila.Cells["Disponibles"].Value?.ToString() ?? "";

            cmbEstado.Text = fila.Cells["Estado"].Value?.ToString() ?? "";
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show("Primero seleccione un libro de la tabla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtISbn.Text) ||
                string.IsNullOrWhiteSpace(txtTituloLibro.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Complete el ISBN, título y autor.");
                return;
            }

            if (nudAñoDePublicacion.Value <= 0 ||
                nudCantidadTotal.Value <= 0 ||
                cboxCategoria.Text.StartsWith("Seleccione") ||
                cmbUbicacion.Text.StartsWith("Seleccione") ||
                cmbEstado.Text.StartsWith("Seleccione"))
            {
                MessageBox.Show("Verifique los datos del libro.");
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"UPDATE Libros SET
                        ISBN = @ISBN,
                        Titulo = @Titulo,
                        Autor = @Autor,
                        Editorial = @Editorial,
                        AnioPublicacion = @AnioPublicacion,
                        Categoria = @Categoria,
                        Ubicacion = @Ubicacion,
                        CantidadTotal = @CantidadTotal,
                        Disponibles = @Disponibles,
                        Estado = @Estado
                        WHERE IdLibro = @IdLibro";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                int cantidadAnterior = 0;
                int disponiblesAnteriores = 0;

                cn.Open();

                using (SqlCommand obtener = new SqlCommand(
                    "SELECT CantidadTotal, Disponibles FROM Libros WHERE IdLibro = @IdLibro", cn))
                {
                    obtener.Parameters.AddWithValue("@IdLibro", idLibroSeleccionado);

                    using SqlDataReader lector = obtener.ExecuteReader();

                    if (!lector.Read())
                    {
                        MessageBox.Show("El libro seleccionado ya no existe.");
                        return;
                    }

                    cantidadAnterior = lector.GetInt32(0);
                    disponiblesAnteriores = lector.GetInt32(1);
                }

                int nuevaCantidad = (int)nudCantidadTotal.Value;
                int prestados = cantidadAnterior - disponiblesAnteriores;

                if (nuevaCantidad < prestados)
                {
                    MessageBox.Show(
                        "La cantidad total no puede ser menor que los libros prestados.");
                    return;
                }

                int nuevosDisponibles = nuevaCantidad - prestados;

                comando.Parameters.AddWithValue("@IdLibro", idLibroSeleccionado);
                comando.Parameters.AddWithValue("@ISBN", txtISbn.Text.Trim());
                comando.Parameters.AddWithValue("@Titulo", txtTituloLibro.Text.Trim());
                comando.Parameters.AddWithValue("@Autor", txtAutor.Text.Trim());
                comando.Parameters.AddWithValue("@Editorial", txtEditorial.Text.Trim());
                comando.Parameters.AddWithValue("@AnioPublicacion",
                    (int)nudAñoDePublicacion.Value);
                comando.Parameters.AddWithValue("@Categoria", cboxCategoria.Text);
                comando.Parameters.AddWithValue("@Ubicacion", cmbUbicacion.Text);
                comando.Parameters.AddWithValue("@CantidadTotal", nuevaCantidad);
                comando.Parameters.AddWithValue("@Disponibles", nuevosDisponibles);
                comando.Parameters.AddWithValue("@Estado", cmbEstado.Text);

                comando.ExecuteNonQuery();

                txtDisponibles.Text = nuevosDisponibles.ToString();

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "El Rincón del Saber",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar el libro.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show(
                    "Primero seleccione un libro de la tabla.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este libro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = "DELETE FROM Libros WHERE IdLibro = @IdLibro";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue("@IdLibro", idLibroSeleccionado);

                cn.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(
                        "Libro eliminado correctamente.",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarLibros();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el libro seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el libro.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarLibroLupa.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarLibros();
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT IdLibro, ISBN, Titulo, Autor,
                        Editorial, AnioPublicacion, Categoria,
                        Ubicacion, CantidadTotal, Disponibles, Estado
                        FROM Libros
                        WHERE Titulo LIKE @Busqueda
                           OR Autor LIKE @Busqueda
                           OR ISBN LIKE @Busqueda
                        ORDER BY IdLibro DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                adaptador.SelectCommand.Parameters.AddWithValue(
                    "@Busqueda", "%" + busqueda + "%");

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dtgvLibrosRegistrados.DataSource = tabla;
                idLibroSeleccionado = 0;

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron libros con ese criterio.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtBuscarLibroLupa.Clear();

            CargarLibros();
        }
    }
}
