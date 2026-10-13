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
    public partial class FrmDevolucionDeLibros : Form
    {
        public FrmDevolucionDeLibros()
        {
            InitializeComponent();

            dgvPrestamosRegistrados.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            cmbEstadoPrestamoInformacion.Items.Clear();

            cmbEstadoPrestamoInformacion.Items.Add("Prestado");
            cmbEstadoPrestamoInformacion.Items.Add("Devuelto");
            cmbEstadoPrestamoInformacion.Items.Add("Anulado");

            cmbEstadoPrestamoInformacion.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbEstadoPrestamoInformacion.Enabled = false;
            CargarPrestamos();

            cbEstadoDeLibroDevolucion.Items.Clear();

            cbEstadoDeLibroDevolucion.Items.Add("Bueno");
            cbEstadoDeLibroDevolucion.Items.Add("Dañado");

            cbEstadoDeLibroDevolucion.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbEstadoDeLibroDevolucion.SelectedIndex = -1;
        }


        private void LimpiarCampos()
        {
            // Limpiar búsqueda
            txtCodigoDePrestamo.Clear();

            // Limpiar información del préstamo
            txtCodigoDePrestamoInformacion.Clear();
            txtUsuarioInformacion.Clear();
            txtLibroInformacion.Clear();

            // Restablecer fechas
            dtpFechaPrestamoInformacion.Value = DateTime.Today;
            dtpFechaDevolucionInformacion.Value = DateTime.Today;

            // Limpiar estados
            cmbEstadoPrestamoInformacion.SelectedIndex = -1;
            cbEstadoDeLibroDevolucion.SelectedIndex = -1;

            // Limpiar observaciones
            txtObservacionesDevolucion.Clear();

            // Limpiar buscador de la tabla
            txtBuscarPrestamosLupa.Clear();

            // Mostrar nuevamente los préstamos pendientes
            CargarPrestamos();

            // Quitar selección de la tabla
            dgvPrestamosRegistrados.ClearSelection();

            // Colocar cursor en el buscador
            txtCodigoDePrestamo.Focus();
        }

        private void CargarPrestamos()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"
            SELECT
                p.IdPrestamo,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaPrestamo,
                p.FechaDevolucionPrevista,
                p.FechaDevolucionReal,
                p.Estado
            FROM Prestamos p
            INNER JOIN Usuarios u
                ON p.IdUsuario = u.IdUsuario
            INNER JOIN Libros l
                ON p.IdLibro = l.IdLibro
            WHERE p.Estado = 'Prestado'
            ORDER BY p.IdPrestamo DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvPrestamosRegistrados.AutoGenerateColumns = true;
                dgvPrestamosRegistrados.DataSource = tabla;

                dgvPrestamosRegistrados.ReadOnly = true;

                dgvPrestamosRegistrados.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvPrestamosRegistrados.MultiSelect = false;

                dgvPrestamosRegistrados.AllowUserToAddRows = false;

                dgvPrestamosRegistrados.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los préstamos:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPrestamoLupa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigoDePrestamo.Text.Trim(), out int idPrestamo)
                || idPrestamo <= 0)
            {
                MessageBox.Show(
                    "Ingresa un código de préstamo válido.",
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
            SELECT
                p.IdPrestamo,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaPrestamo,
                p.FechaDevolucionPrevista,
                p.Estado
            FROM Prestamos p
            INNER JOIN Usuarios u
                ON p.IdUsuario = u.IdUsuario
            INNER JOIN Libros l
                ON p.IdLibro = l.IdLibro
            WHERE p.IdPrestamo = @IdPrestamo
              AND p.Estado = 'Prestado'";

                using SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);

                using SqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    txtCodigoDePrestamoInformacion.Text =
                        lector["IdPrestamo"].ToString();

                    txtUsuarioInformacion.Text =
                        lector["Usuario"].ToString();

                    txtLibroInformacion.Text =
                        lector["Libro"].ToString();

                    dtpFechaPrestamoInformacion.Value =
                        Convert.ToDateTime(lector["FechaPrestamo"]);

                    dtpFechaDevolucionInformacion.Value =
                        Convert.ToDateTime(lector["FechaDevolucionPrevista"]);

                    cmbEstadoPrestamoInformacion.SelectedItem =
                        lector["Estado"].ToString();
                }
                else
                {
                    txtCodigoDePrestamoInformacion.Clear();
                    txtUsuarioInformacion.Clear();
                    txtLibroInformacion.Clear();

                    cmbEstadoPrestamoInformacion.SelectedIndex = -1;

                    MessageBox.Show(
                        "No se encontró un préstamo activo con ese código.",
                        "Préstamo no disponible",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el préstamo:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(
                    txtCodigoDePrestamoInformacion.Text.Trim(),
                    out int idPrestamo) || idPrestamo <= 0)
            {
                MessageBox.Show(
                    "Primero debes seleccionar un préstamo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cbEstadoDeLibroDevolucion.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona el estado físico del libro.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string estadoLibro =
              cbEstadoDeLibroDevolucion.SelectedItem?.ToString() ?? "";

            string observaciones =
                txtObservacionesDevolucion.Text.Trim();

            if (observaciones.Length > 500)
            {
                MessageBox.Show(
                    "Las observaciones no pueden superar 500 caracteres.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Deseas registrar esta devolución?",
                "Confirmar devolución",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();
                cn.Open();

                using SqlTransaction transaccion = cn.BeginTransaction();

                try
                {
                    int idLibro;
                    string estadoPrestamo;

                    // 1. Consultar el préstamo y bloquearlo
                    string consulta = @"
            SELECT IdLibro, Estado
            FROM Prestamos WITH (UPDLOCK, HOLDLOCK)
            WHERE IdPrestamo = @IdPrestamo";

                    using (SqlCommand cmd = new SqlCommand(
                        consulta, cn, transaccion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@IdPrestamo", idPrestamo);

                        using SqlDataReader lector = cmd.ExecuteReader();

                        if (!lector.Read())
                            throw new Exception(
                                "El préstamo no existe.");

                        idLibro = Convert.ToInt32(lector["IdLibro"]);
                        estadoPrestamo = lector["Estado"].ToString()!;
                    }

                    // 2. Verificar que esté pendiente
                    if (estadoPrestamo != "Prestado")
                    {
                        throw new Exception(
                            "Este préstamo ya fue devuelto o anulado.");
                    }

                    // 3. Registrar la devolución
                    string actualizarPrestamo = @"
            UPDATE Prestamos
            SET Estado = 'Devuelto',
                FechaDevolucionReal = @FechaDevolucion,
                EstadoLibroDevolucion = @EstadoLibro,
                Observaciones = @Observaciones
            WHERE IdPrestamo = @IdPrestamo
              AND Estado = 'Prestado'";

                    using (SqlCommand cmd = new SqlCommand(
                        actualizarPrestamo, cn, transaccion))
                    {
                        cmd.Parameters.AddWithValue(
                            "@FechaDevolucion", DateTime.Today);

                        cmd.Parameters.AddWithValue(
                            "@EstadoLibro", estadoLibro);

                        cmd.Parameters.AddWithValue(
                            "@Observaciones",
                            string.IsNullOrWhiteSpace(observaciones)
                                ? DBNull.Value
                                : observaciones);

                        cmd.Parameters.AddWithValue(
                            "@IdPrestamo", idPrestamo);

                        if (cmd.ExecuteNonQuery() != 1)
                            throw new Exception(
                                "No se pudo actualizar el préstamo.");
                    }

                    // 4. Actualizar inventario solo si está bueno
                    if (estadoLibro == "Bueno")
                    {
                        string actualizarLibro = @"
                UPDATE Libros
                SET Disponibles = Disponibles + 1
                WHERE IdLibro = @IdLibro
                  AND Disponibles < CantidadTotal";

                        using SqlCommand cmd = new SqlCommand(
                            actualizarLibro, cn, transaccion);

                        cmd.Parameters.AddWithValue(
                            "@IdLibro", idLibro);

                        if (cmd.ExecuteNonQuery() != 1)
                        {
                            throw new Exception(
                                "No se pudo actualizar la disponibilidad del libro.");
                        }
                    }

                    // 5. Confirmar todos los cambios
                    transaccion.Commit();

                    MessageBox.Show(
                        "¡Devolución registrada correctamente!",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // 6. Actualizar la tabla
                    CargarPrestamos();

                    // Limpiar los campos
                    txtCodigoDePrestamo.Clear();
                    txtCodigoDePrestamoInformacion.Clear();
                    txtUsuarioInformacion.Clear();
                    txtLibroInformacion.Clear();

                    dtpFechaPrestamoInformacion.Value = DateTime.Today;
                    dtpFechaDevolucionInformacion.Value = DateTime.Today;

                    cmbEstadoPrestamoInformacion.SelectedIndex = -1;
                    cbEstadoDeLibroDevolucion.SelectedIndex = -1;
                    txtObservacionesDevolucion.Clear();
                }
                catch
                {
                    transaccion.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar la devolución:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnLimpiarDevolucion_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarDevolucion_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is frmMenu menu)
            {
                menu.MostrarInicio();
            }
        }

        private void ptbxLupita_Click(object sender, EventArgs e)
        {

            string busqueda = txtBuscarPrestamosLupa.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarPrestamos();
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"
                 SELECT
                 p.IdPrestamo,
                 CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                  l.Titulo AS Libro,
                  p.FechaPrestamo,
                  p.FechaDevolucionPrevista,
                  p.FechaDevolucionReal,
                  p.Estado
                  FROM Prestamos p
                  INNER JOIN Usuarios u
                  ON p.IdUsuario = u.IdUsuario
                  INNER JOIN Libros l
                  ON p.IdLibro = l.IdLibro
                  WHERE p.Estado = 'Prestado'
                  AND (
                  CAST(p.IdPrestamo AS VARCHAR(20)) LIKE @Busqueda
                  OR CONCAT(u.Nombre, ' ', u.Apellido) LIKE @Busqueda
                  OR l.Titulo LIKE @Busqueda
                  OR l.Autor LIKE @Busqueda
                  OR l.ISBN LIKE @Busqueda
                   )
                 ORDER BY p.IdPrestamo DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                adaptador.SelectCommand.Parameters.AddWithValue(
                    "@Busqueda", "%" + busqueda + "%");

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvPrestamosRegistrados.DataSource = tabla;
                dgvPrestamosRegistrados.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron préstamos pendientes con ese criterio.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar préstamos:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void dgvPrestamosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvPrestamosRegistrados.Rows[e.RowIndex];

            // Código del préstamo
            string codigo =
                fila.Cells["IdPrestamo"].Value?.ToString() ?? "";

            txtCodigoDePrestamo.Text = codigo;
            txtCodigoDePrestamoInformacion.Text = codigo;

            // Usuario
            txtUsuarioInformacion.Text =
                fila.Cells["Usuario"].Value?.ToString() ?? "";

            // Libro
            txtLibroInformacion.Text =
                fila.Cells["Libro"].Value?.ToString() ?? "";

            // Fecha del préstamo
            dtpFechaPrestamoInformacion.Value =
                Convert.ToDateTime(
                    fila.Cells["FechaPrestamo"].Value);

            // Fecha prevista de devolución
            dtpFechaDevolucionInformacion.Value =
                Convert.ToDateTime(
                    fila.Cells["FechaDevolucionPrevista"].Value);

            // Estado del préstamo
            cmbEstadoPrestamoInformacion.SelectedItem =
                fila.Cells["Estado"].Value?.ToString();

            // Preparar datos de devolución
            cbEstadoDeLibroDevolucion.SelectedIndex = -1;
            txtObservacionesDevolucion.Clear();

        }
    }
}
