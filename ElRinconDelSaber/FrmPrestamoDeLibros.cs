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
    public partial class FrmPrestamoDeLibros : Form
    {
        public FrmPrestamoDeLibros()
        {
            InitializeComponent();

            dgvPrestamosRegistrados.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            CargarUsuarios();
            CargarLibrosDisponibles();
            CargarPrestamos();

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(7);

            cmbEstadoPrestamo.Items.Clear();
            cmbEstadoPrestamo.Items.Add("Prestado");
            cmbEstadoPrestamo.Items.Add("Devuelto");
            cmbEstadoPrestamo.Items.Add("Anulado");
            cmbEstadoPrestamo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoPrestamo.SelectedItem = "Prestado";
            cmbEstadoPrestamo.Enabled = false;

            txtCodigoPrestamo.Clear();
            txtCodigoPrestamo.ReadOnly = true;
        }

        private void LimpiarCampos()
        {
            txtCodigoPrestamo.Clear();

            cboxUsuarioPrestamo.SelectedIndex = -1;
            cmbLibroPrestamo.SelectedIndex = -1;

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(7);

            cmbEstadoPrestamo.SelectedItem = "Prestado";

            txtObservaciones.Clear();

            dgvPrestamosRegistrados.ClearSelection();
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
                p.IdUsuario,
                p.IdLibro,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaPrestamo,
                p.FechaDevolucionPrevista,
                p.FechaDevolucionReal,
                p.Estado,
                p.Observaciones
                FROM Prestamos p
                INNER JOIN Usuarios u
                ON p.IdUsuario = u.IdUsuario
                INNER JOIN Libros l
                ON p.IdLibro = l.IdLibro
                ORDER BY p.IdPrestamo DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvPrestamosRegistrados.AutoGenerateColumns = true;
                dgvPrestamosRegistrados.DataSource = tabla;

                dgvPrestamosRegistrados.Columns["IdUsuario"]!.Visible = false;
                dgvPrestamosRegistrados.Columns["IdLibro"]!.Visible = false;

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
                    "Error al cargar los préstamos.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarLibrosDisponibles()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT IdLibro, Titulo
                            FROM Libros
                            WHERE Estado = 'Activo'
                            AND Disponibles > 0
                            ORDER BY Titulo";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                cmbLibroPrestamo.DataSource = tabla;
                cmbLibroPrestamo.DisplayMember = "Titulo";
                cmbLibroPrestamo.ValueMember = "IdLibro";

                cmbLibroPrestamo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros disponibles.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"SELECT IdUsuario,
                            CONCAT(Nombre, ' ', Apellido) AS NombreCompleto
                            FROM Usuarios
                            WHERE Estado = 1
                            ORDER BY Nombre, Apellido";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                cboxUsuarioPrestamo.DataSource = tabla;
                cboxUsuarioPrestamo.DisplayMember = "NombreCompleto";
                cboxUsuarioPrestamo.ValueMember = "IdUsuario";

                cboxUsuarioPrestamo.SelectedIndex = -1;
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

        private void btnUsuarioPrestamo_Click(object sender, EventArgs e)
        {
            using (FrmBuscarUsuario buscador = new FrmBuscarUsuario())
            {
                if (buscador.ShowDialog(this) == DialogResult.OK)
                {
                    cboxUsuarioPrestamo.SelectedValue =
                        buscador.IdUsuarioSeleccionado;
                }
            }
        }

        private void btnLibroPrestamo_Click(object sender, EventArgs e)
        {
            using (FrmBuscarLibro buscador = new FrmBuscarLibro())
            {
                if (buscador.ShowDialog(this) == DialogResult.OK)
                {
                    cmbLibroPrestamo.SelectedValue =
                        buscador.IdLibroSeleccionado;
                }
            }
        }

        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaDevolucion.Value =
            dtpFechaPrestamo.Value.Date.AddDays(7);
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            if (cboxUsuarioPrestamo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            if (cmbLibroPrestamo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro.");
                return;
            }

            if (dtpFechaDevolucion.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show(
                    "La fecha de devolución no puede ser anterior a la fecha del préstamo.");
                return;
            }

            if (txtObservaciones.Text.Trim().Length > 500)
            {
                MessageBox.Show(
                    "Las observaciones no pueden superar los 500 caracteres.");
                return;
            }

            try
            {
                int idUsuario = Convert.ToInt32(cboxUsuarioPrestamo.SelectedValue);
                int idLibro = Convert.ToInt32(cmbLibroPrestamo.SelectedValue);

                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();
                cn.Open();

                using SqlTransaction transaccion = cn.BeginTransaction();

                try
                {
                    // 1. Descontar un ejemplar disponible
                    string sqlActualizar = @"
                      UPDATE Libros
                      SET Disponibles = Disponibles - 1
                      WHERE IdLibro = @IdLibro
                      AND Disponibles > 0
                      AND Estado = 'Activo'";

                    using SqlCommand cmdActualizar =
                        new SqlCommand(sqlActualizar, cn, transaccion);

                    cmdActualizar.Parameters.AddWithValue("@IdLibro", idLibro);

                    int filas = cmdActualizar.ExecuteNonQuery();

                    if (filas == 0)
                    {
                        throw new Exception(
                            "El libro seleccionado no tiene ejemplares disponibles.");
                    }

                    // 2. Registrar el préstamo
                    string sqlPrestamo = @"
                      INSERT INTO Prestamos
                      (IdUsuario, IdLibro, FechaPrestamo,
                      FechaDevolucionPrevista, Estado, Observaciones)
                      OUTPUT INSERTED.IdPrestamo
                      VALUES
                      (@IdUsuario, @IdLibro, @FechaPrestamo,
                       @FechaDevolucion, 'Prestado', @Observaciones)";

                    using SqlCommand cmdPrestamo =
                        new SqlCommand(sqlPrestamo, cn, transaccion);

                    cmdPrestamo.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmdPrestamo.Parameters.AddWithValue("@IdLibro", idLibro);
                    cmdPrestamo.Parameters.AddWithValue(
                        "@FechaPrestamo", dtpFechaPrestamo.Value.Date);
                    cmdPrestamo.Parameters.AddWithValue(
                        "@FechaDevolucion", dtpFechaDevolucion.Value.Date);
                    cmdPrestamo.Parameters.AddWithValue(
                        "@Observaciones", txtObservaciones.Text.Trim());

                    int idPrestamo = Convert.ToInt32(cmdPrestamo.ExecuteScalar());

                    // 3. Confirmar los cambios
                    transaccion.Commit();

                    txtCodigoPrestamo.Text = idPrestamo.ToString();

                    MessageBox.Show(
                        "Préstamo registrado correctamente.\n" +
                        "Código del préstamo: " + idPrestamo,
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Actualizar libros disponibles
                    CargarLibrosDisponibles();
                    CargarPrestamos();
                    LimpiarCampos();
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
                    "No se pudo registrar el préstamo.\n\n" + ex.Message,
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
            txtCodigoPrestamo.Text =
                fila.Cells["IdPrestamo"].Value?.ToString() ?? "";

            // Usuario y libro
            cboxUsuarioPrestamo.SelectedValue =
                Convert.ToInt32(fila.Cells["IdUsuario"].Value);

            cmbLibroPrestamo.SelectedValue =
                Convert.ToInt32(fila.Cells["IdLibro"].Value);

            // Fechas
            dtpFechaPrestamo.Value =
                Convert.ToDateTime(fila.Cells["FechaPrestamo"].Value);

            dtpFechaDevolucion.Value =
                Convert.ToDateTime(fila.Cells["FechaDevolucionPrevista"].Value);

            // Estado
            cmbEstadoPrestamo.SelectedItem =
                fila.Cells["Estado"].Value?.ToString();

            // Observaciones
            txtObservaciones.Text =
                fila.Cells["Observaciones"].Value?.ToString() ?? "";
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un préstamo
            if (!int.TryParse(txtCodigoPrestamo.Text, out int idPrestamo))
            {
                MessageBox.Show("Seleccione un préstamo para editar.");
                return;
            }

            if (cboxUsuarioPrestamo.SelectedIndex == -1 ||
                cmbLibroPrestamo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario y un libro.");
                return;
            }

            if (dtpFechaDevolucion.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior.");
                return;
            }

            if (txtObservaciones.Text.Trim().Length > 500)
            {
                MessageBox.Show("Las observaciones no pueden superar 500 caracteres.");
                return;
            }

            try
            {
                int idUsuario = Convert.ToInt32(cboxUsuarioPrestamo.SelectedValue);
                int idLibroNuevo = Convert.ToInt32(cmbLibroPrestamo.SelectedValue);

                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();
                cn.Open();

                using SqlTransaction transaccion = cn.BeginTransaction();

                try
                {
                    // Obtener el libro original y bloquear el préstamo
                    string sqlOriginal = @"
            SELECT IdLibro, Estado
            FROM Prestamos WITH (UPDLOCK, HOLDLOCK)
            WHERE IdPrestamo = @IdPrestamo";

                    using SqlCommand cmdOriginal =
                        new SqlCommand(sqlOriginal, cn, transaccion);

                    cmdOriginal.Parameters.AddWithValue("@IdPrestamo", idPrestamo);

                    int idLibroAnterior;
                    string estadoActual;

                    using (SqlDataReader lector = cmdOriginal.ExecuteReader())
                    {
                        if (!lector.Read())
                            throw new Exception("El préstamo ya no existe.");

                        idLibroAnterior = lector.GetInt32(0);
                        estadoActual = lector.GetString(1);
                    }

                    if (estadoActual != "Prestado")
                    {
                        throw new Exception(
                            "No se puede editar un préstamo que ya fue devuelto.");
                    }

                    // Si cambió el libro, ajustar las existencias
                    if (idLibroAnterior != idLibroNuevo)
                    {
                        string sqlDevolver = @"
                          UPDATE Libros
                          SET Disponibles = Disponibles + 1
                          WHERE IdLibro = @IdLibro
                          AND Disponibles < CantidadTotal";

                        using SqlCommand cmdDevolver =
                            new SqlCommand(sqlDevolver, cn, transaccion);

                        cmdDevolver.Parameters.AddWithValue(
                            "@IdLibro", idLibroAnterior);

                        if (cmdDevolver.ExecuteNonQuery() != 1)
                            throw new Exception(
                                "No se pudo restaurar el ejemplar anterior.");

                        string sqlDescontar = @"
                          UPDATE Libros
                          SET Disponibles = Disponibles - 1
                          WHERE IdLibro = @IdLibro
                          AND Disponibles > 0
                          AND Estado = 'Activo'";

                        using SqlCommand cmdDescontar =
                            new SqlCommand(sqlDescontar, cn, transaccion);

                        cmdDescontar.Parameters.AddWithValue(
                            "@IdLibro", idLibroNuevo);

                        if (cmdDescontar.ExecuteNonQuery() != 1)
                            throw new Exception(
                                "El nuevo libro no tiene ejemplares disponibles.");
                    }

                    // Actualizar los datos del préstamo
                    string sqlEditar = @"
                      UPDATE Prestamos
                      SET IdUsuario = @IdUsuario,
                      IdLibro = @IdLibro,
                      FechaPrestamo = @FechaPrestamo,
                      FechaDevolucionPrevista = @FechaDevolucion,
                      Observaciones = @Observaciones
                      WHERE IdPrestamo = @IdPrestamo
                      AND Estado = 'Prestado'";

                    using SqlCommand cmdEditar =
                        new SqlCommand(sqlEditar, cn, transaccion);

                    cmdEditar.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmdEditar.Parameters.AddWithValue("@IdLibro", idLibroNuevo);
                    cmdEditar.Parameters.AddWithValue(
                        "@FechaPrestamo", dtpFechaPrestamo.Value.Date);
                    cmdEditar.Parameters.AddWithValue(
                        "@FechaDevolucion", dtpFechaDevolucion.Value.Date);
                    cmdEditar.Parameters.AddWithValue(
                        "@Observaciones", txtObservaciones.Text.Trim());
                    cmdEditar.Parameters.AddWithValue("@IdPrestamo", idPrestamo);

                    if (cmdEditar.ExecuteNonQuery() != 1)
                        throw new Exception("No se pudo actualizar el préstamo.");

                    transaccion.Commit();

                    MessageBox.Show(
                        "Préstamo actualizado correctamente.",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarPrestamos();
                    CargarLibrosDisponibles();
                    LimpiarCampos();
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
                    "Error al editar el préstamo.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un préstamo
            if (!int.TryParse(txtCodigoPrestamo.Text, out int idPrestamo))
            {
                MessageBox.Show("Seleccione un préstamo para anular.");
                return;
            }

            // Pedir confirmación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea anular este préstamo?\n" +
                "El ejemplar volverá a estar disponible.",
                "Confirmar anulación",
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
                    // 1. Consultar y bloquear el préstamo
                    string sqlConsultar = @"
                   SELECT IdLibro, Estado
                   FROM Prestamos WITH (UPDLOCK, HOLDLOCK)
                   WHERE IdPrestamo = @IdPrestamo";

                    int idLibro;
                    string estado;

                    using (SqlCommand cmdConsultar =
                        new SqlCommand(sqlConsultar, cn, transaccion))
                    {
                        cmdConsultar.Parameters.AddWithValue(
                            "@IdPrestamo", idPrestamo);

                        using SqlDataReader lector =
                            cmdConsultar.ExecuteReader();

                        if (!lector.Read())
                            throw new Exception("El préstamo no existe.");

                        idLibro = lector.GetInt32(0);
                        estado = lector.GetString(1);
                    }

                    // 2. Validar el estado
                    if (estado != "Prestado")
                    {
                        throw new Exception(
                            "Solo se pueden anular préstamos activos.");
                    }

                    // 3. Cambiar el estado a Anulado
                    string sqlAnular = @"
                     UPDATE Prestamos
                     SET Estado = 'Anulado'
                     WHERE IdPrestamo = @IdPrestamo
                     AND Estado = 'Prestado'";

                    using SqlCommand cmdAnular =
                        new SqlCommand(sqlAnular, cn, transaccion);

                    cmdAnular.Parameters.AddWithValue(
                        "@IdPrestamo", idPrestamo);

                    if (cmdAnular.ExecuteNonQuery() != 1)
                        throw new Exception("No se pudo anular el préstamo.");

                    // 4. Devolver el ejemplar al inventario
                    string sqlActualizar = @"
                     UPDATE Libros
                     SET Disponibles = Disponibles + 1
                     WHERE IdLibro = @IdLibro
                     AND Disponibles < CantidadTotal";

                    using SqlCommand cmdActualizar =
                        new SqlCommand(sqlActualizar, cn, transaccion);

                    cmdActualizar.Parameters.AddWithValue(
                        "@IdLibro", idLibro);

                    if (cmdActualizar.ExecuteNonQuery() != 1)
                        throw new Exception(
                            "No se pudo actualizar la disponibilidad.");

                    // 5. Confirmar ambos cambios
                    transaccion.Commit();

                    MessageBox.Show(
                        "Préstamo anulado correctamente.",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarPrestamos();
                    CargarLibrosDisponibles();
                    LimpiarCampos();
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
                    "Error al anular el préstamo.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarPrestamo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtBuscarPrestamosLupa.Clear();
            CargarPrestamos();
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
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
                   p.IdUsuario,
                   p.IdLibro,
                   CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                   l.Titulo AS Libro,
                   p.FechaPrestamo,
                   p.FechaDevolucionPrevista,
                   p.FechaDevolucionReal,
                   p.Estado,
                   p.Observaciones
                   FROM Prestamos p
                   INNER JOIN Usuarios u
                   ON p.IdUsuario = u.IdUsuario
                   INNER JOIN Libros l
                   ON p.IdLibro = l.IdLibro
                   WHERE
                   CAST(p.IdPrestamo AS VARCHAR(20)) LIKE @Busqueda
                   OR CONCAT(u.Nombre, ' ', u.Apellido) LIKE @Busqueda
                   OR l.Titulo LIKE @Busqueda
                   ORDER BY p.IdPrestamo DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                adaptador.SelectCommand.Parameters.AddWithValue(
                    "@Busqueda", "%" + busqueda + "%");

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvPrestamosRegistrados.DataSource = tabla;

                // Ocultar los identificadores internos
                dgvPrestamosRegistrados.Columns["IdUsuario"]!.Visible = false;
                dgvPrestamosRegistrados.Columns["IdLibro"]!.Visible = false;

                dgvPrestamosRegistrados.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron préstamos con ese criterio.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar préstamos.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void gbPrestamosRegistrados_Enter(object sender, EventArgs e)
        {

        }
    }
}
