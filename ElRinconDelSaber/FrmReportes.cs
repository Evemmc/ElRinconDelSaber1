using ElRinconDelSaber.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ElRinconDelSaber
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();

            dgvResultadosDelReportes.AutoSizeColumnsMode =
             DataGridViewAutoSizeColumnsMode.Fill;

            cmbTipoDeReportes.Items.Clear();

            cmbTipoDeReportes.Items.Add("Préstamos realizados");
            cmbTipoDeReportes.Items.Add("Préstamos pendientes");
            cmbTipoDeReportes.Items.Add("Devoluciones realizadas");
            cmbTipoDeReportes.Items.Add("Préstamos anulados");
            cmbTipoDeReportes.Items.Add("Inventario de libros");

            cmbTipoDeReportes.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbTipoDeReportes.SelectedIndex = -1;


        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {

            if (cmbTipoDeReportes.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona un tipo de reporte.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaDesde = dtpFechaDesde.Value.Date;
            DateTime fechaHasta = dtpFechaHasta.Value.Date;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show(
                    "La fecha desde no puede ser mayor que la fecha hasta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string tipoReporte =
              cmbTipoDeReportes.SelectedItem?.ToString() ?? "";

            string consulta = "";

            switch (tipoReporte)
            {
                case "Préstamos realizados":
                    consulta = @"
            SELECT
                p.IdPrestamo AS Codigo,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaPrestamo,
                p.FechaDevolucionPrevista,
                p.Estado
            FROM Prestamos p
            INNER JOIN Usuarios u ON p.IdUsuario = u.IdUsuario
            INNER JOIN Libros l ON p.IdLibro = l.IdLibro
            WHERE p.FechaPrestamo >= @Desde
              AND p.FechaPrestamo < @HastaExclusiva
            ORDER BY p.FechaPrestamo DESC";
                    break;

                case "Préstamos pendientes":
                    consulta = @"
            SELECT
                p.IdPrestamo AS Codigo,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaPrestamo,
                p.FechaDevolucionPrevista,
                p.Estado
            FROM Prestamos p
            INNER JOIN Usuarios u ON p.IdUsuario = u.IdUsuario
            INNER JOIN Libros l ON p.IdLibro = l.IdLibro
            WHERE p.Estado = 'Prestado'
              AND p.FechaPrestamo >= @Desde
              AND p.FechaPrestamo < @HastaExclusiva
            ORDER BY p.FechaPrestamo DESC";
                    break;

                case "Devoluciones realizadas":
                    consulta = @"
            SELECT
                p.IdPrestamo AS Codigo,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaDevolucionReal,
                p.EstadoLibroDevolucion,
                p.Observaciones
            FROM Prestamos p
            INNER JOIN Usuarios u ON p.IdUsuario = u.IdUsuario
            INNER JOIN Libros l ON p.IdLibro = l.IdLibro
            WHERE p.Estado = 'Devuelto'
              AND p.FechaDevolucionReal >= @Desde
              AND p.FechaDevolucionReal < @HastaExclusiva
            ORDER BY p.FechaDevolucionReal DESC";
                    break;

                case "Préstamos anulados":
                    consulta = @"
            SELECT
                p.IdPrestamo AS Codigo,
                CONCAT(u.Nombre, ' ', u.Apellido) AS Usuario,
                l.Titulo AS Libro,
                p.FechaPrestamo,
                p.Estado
            FROM Prestamos p
            INNER JOIN Usuarios u ON p.IdUsuario = u.IdUsuario
            INNER JOIN Libros l ON p.IdLibro = l.IdLibro
            WHERE p.Estado = 'Anulado'
              AND p.FechaPrestamo >= @Desde
              AND p.FechaPrestamo < @HastaExclusiva
            ORDER BY p.FechaPrestamo DESC";
                    break;

                case "Inventario de libros":
                    consulta = @"
            SELECT
                IdLibro AS Codigo,
                ISBN,
                Titulo,
                Autor,
                CantidadTotal,
                Disponibles,
                Estado
            FROM Libros
            ORDER BY Titulo";
                    break;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                if (tipoReporte != "Inventario de libros")
                {
                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@Desde", fechaDesde);

                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@HastaExclusiva", fechaHasta.AddDays(1));
                }

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvResultadosDelReportes.AutoGenerateColumns = true;
                dgvResultadosDelReportes.DataSource = tabla;

                lblTotalRegistros.Text =
                  "Total de registros: " + tabla.Rows.Count;

                dgvResultadosDelReportes.ReadOnly = true;
                dgvResultadosDelReportes.AllowUserToAddRows = false;
                dgvResultadosDelReportes.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvResultadosDelReportes.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron registros para este reporte.",
                        "Resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {

            if (dgvResultadosDelReportes.DataSource == null ||
                dgvResultadosDelReportes.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Primero debes generar un reporte para exportarlo.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                guardar.Title = "Guardar reporte";
                guardar.FileName = "Reporte_ElRinconDelSaber.xlsx";

                if (guardar.ShowDialog() != DialogResult.OK)
                    return;

                using XLWorkbook libro = new XLWorkbook();

                var hoja = libro.Worksheets.Add("Reporte");

                int columnaExcel = 1;

                // Encabezados
                foreach (DataGridViewColumn columna in
                         dgvResultadosDelReportes.Columns)
                {
                    if (!columna.Visible)
                        continue;

                    hoja.Cell(1, columnaExcel).Value =
                        columna.HeaderText;

                    columnaExcel++;
                }

                // Datos
                int filaExcel = 2;

                foreach (DataGridViewRow fila in
                         dgvResultadosDelReportes.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    columnaExcel = 1;

                    foreach (DataGridViewColumn columna in
                             dgvResultadosDelReportes.Columns)
                    {
                        if (!columna.Visible)
                            continue;

                        object? valor =
                            fila.Cells[columna.Index].Value;

                        var celda = hoja.Cell(filaExcel, columnaExcel);

                        if (valor == null || valor == DBNull.Value)
                        {
                            celda.Value = "";
                        }
                        else if (valor is DateTime fecha)
                        {
                            celda.Value = fecha;
                            celda.Style.DateFormat.Format = "dd/MM/yyyy";
                        }
                        else if (valor is int numero)
                        {
                            celda.Value = numero;
                        }
                        else if (valor is decimal decimalValor)
                        {
                            celda.Value = decimalValor;
                        }
                        else
                        {
                            celda.Value = valor.ToString() ?? "";
                        }

                        columnaExcel++;
                    }

                    filaExcel++;
                }

                // Formato de los encabezados
                var encabezados = hoja.Range(
                    1, 1, 1, columnaExcel - 1);

                encabezados.Style.Font.Bold = true;
                encabezados.Style.Fill.BackgroundColor =
                    XLColor.DarkRed;
                encabezados.Style.Font.FontColor = XLColor.White;

                // Ajustar columnas al contenido
                hoja.Columns().AdjustToContents();

                // Guardar archivo
                libro.SaveAs(guardar.FileName);

                MessageBox.Show(
                    "¡Reporte exportado correctamente a Excel!",
                    "Exportación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al exportar el reporte:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
