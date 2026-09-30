using ElRinconDelSaber.Datos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ElRinconDelSaber
{
    public partial class FrmGestionDeUsuarios : Form
    {
        public FrmGestionDeUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void lblidUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cboxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FrmGestionDeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"
            SELECT 
                U.IdUsuario AS ID,
                U.Nombre,
                U.Apellido,
                U.Usuario,
                R.NombreRol AS Rol,
                CASE 
                    WHEN U.Estado = 1 THEN 'Activo'
                    ELSE 'Inactivo'
                END AS Estado,
                U.FechaRegistro AS [Fecha de registro]
            FROM Usuarios U
            INNER JOIN Roles R ON U.IdRol = R.IdRol
            ORDER BY U.IdUsuario DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvUsuarios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message
                );
            }
        }

        private void LimpiarCampos()
        {
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();

            cboxRol.SelectedIndex = 0;
            cboxEstado.SelectedIndex = 0;

            dateTimePicker1.Value = DateTime.Now;

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Esta parte valida los campos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido.");
                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese la contraseña.");
                txtContraseña.Focus();
                return;
            }

            if (cboxRol.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un rol.");
                return;
            }

            if (cboxEstado.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"INSERT INTO Usuarios
                            (Nombre, Apellido, Usuario, Contrasena, IdRol, Estado)
                            VALUES
                            (@Nombre, @Apellido, @Usuario, @Contrasena, @IdRol, @Estado)";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                comando.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                comando.Parameters.AddWithValue("@Contrasena", txtContraseña.Text);

                comando.Parameters.AddWithValue("@IdRol", cboxRol.SelectedIndex);

                bool estado = cboxEstado.SelectedItem?.ToString() == "Activo";
                comando.Parameters.AddWithValue("@Estado", estado);

                cn.Open();
                comando.ExecuteNonQuery();

                CargarUsuarios();
                LimpiarCampos();

                MessageBox.Show(
                    "Usuario registrado correctamente.",
                    "El Rincón del Saber",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el usuario.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                txtIdUsuario.Text = fila.Cells["ID"].Value?.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value?.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value?.ToString();

                cboxRol.Text = fila.Cells["Rol"].Value?.ToString();
                cboxEstado.Text = fila.Cells["Estado"].Value?.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Aqui se verifica que se haya seleccionado un usuario
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show(
                    "Seleccione un usuario de la tabla para editar.",
                    "El Rincón del Saber",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validarrr camposss
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido.");
                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre de usuario.");
                txtUsuario.Focus();
                return;
            }

            if (cboxRol.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un rol.");
                return;
            }

            if (cboxEstado.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"
            UPDATE Usuarios
            SET Nombre = @Nombre,
                Apellido = @Apellido,
                Usuario = @Usuario,
                IdRol = @IdRol,
                Estado = @Estado
            WHERE IdUsuario = @IdUsuario";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                comando.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim());
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                comando.Parameters.AddWithValue("@IdRol", cboxRol.SelectedIndex);

                bool estado = cboxEstado.SelectedItem?.ToString() == "Activo";
                comando.Parameters.AddWithValue("@Estado", estado);

                comando.Parameters.AddWithValue(
                    "@IdUsuario",
                    Convert.ToInt32(txtIdUsuario.Text)
                );

                cn.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    CargarUsuarios();
                    LimpiarCampos();

                    MessageBox.Show(
                        "Usuario actualizado correctamente.",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el usuario:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show(
                    "Seleccione un usuario de la tabla para eliminar.",
                    "El Rincón del Saber",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta =
                    "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                using SqlCommand comando = new SqlCommand(consulta, cn);

                comando.Parameters.AddWithValue(
                    "@IdUsuario",
                    Convert.ToInt32(txtIdUsuario.Text)
                );

                cn.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    CargarUsuarios();
                    LimpiarCampos();

                    MessageBox.Show(
                        "Usuario eliminado correctamente.",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el usuario:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();

                using SqlConnection cn = conexion.ObtenerConexion();

                string consulta = @"
            SELECT 
                U.IdUsuario AS ID,
                U.Nombre,
                U.Apellido,
                U.Usuario,
                R.NombreRol AS Rol,
                CASE
                    WHEN U.Estado = 1 THEN 'Activo'
                    ELSE 'Inactivo'
                END AS Estado,
                U.FechaRegistro AS [Fecha de registro]
            FROM Usuarios U
            INNER JOIN Roles R ON U.IdRol = R.IdRol
            WHERE U.Usuario LIKE @Usuario
            ORDER BY U.IdUsuario DESC";

                using SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                adaptador.SelectCommand.Parameters.AddWithValue(
                    "@Usuario",
                    "%" + txtUsuario.Text.Trim() + "%"
                );

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvUsuarios.DataSource = tabla;

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron usuarios con ese nombre de usuario.",
                        "El Rincón del Saber",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el usuario:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }


}
