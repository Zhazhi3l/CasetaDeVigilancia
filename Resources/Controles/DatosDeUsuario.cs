using CasetaDeVigilancia.src.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDeVigilancia.Resources.Controles
{
    public partial class DatosDeUsuario : UserControl
    {
        public event EventHandler EdicionFinalizada;
        private int? residenteID = null;
        private bool esEdicion = false;

        public DatosDeUsuario()
        {
            InitializeComponent();
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (!validarCasillas()) return;

            if (UsuarioYaExiste(txtUsuario.Text.Trim(), residenteID))
            {
                MessageBox.Show("Este nombre de usuario ya está en uso. Por favor elige otro.",
                                "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql;
                SqlParameter[] parametros;

                if (esEdicion && residenteID != null)
                {
                    // UPDATE
                    sql = @"
                        UPDATE Residente SET
                            Nombre = @nombre,
                            ApellidoPaterno = @apellidopaterno,
                            ApellidoMaterno = @apellidomaterno,
                            NumeroCasa = @numerocasa,
                            Calle = @calle,
                            Telefono = @telefono,
                            Correo = @correo,
                            Usuario = @usuario,
                            Password = @password
                        WHERE ResidenteID = @id";

                    parametros = new[]
                    {
                        new SqlParameter("@nombre",             txtNombres.Text.Trim()),
                        new SqlParameter("@apellidopaterno",    txtApllPat.Text.Trim()),
                        new SqlParameter("@apellidomaterno",    txtApllMat.Text.Trim()),
                        new SqlParameter("@numerocasa",         nudNumeroCalle.Value),
                        new SqlParameter("@calle",              txtCalle.Text.Trim()),
                        new SqlParameter("@telefono",           txtNumTel.Text.Trim()),
                        new SqlParameter("@correo",             txtCorreo.Text.Trim()),
                        new SqlParameter("@usuario",            txtUsuario.Text.Trim()),
                        new SqlParameter("@password",           txtContrasena.Text.Trim()),
                        new SqlParameter("@id",                 residenteID)
                    };
                }
                else
                {
                    // INSERT
                    sql = @"
                        INSERT INTO Residente 
                            (Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Password,
                             NumeroCasa, Calle, Telefono, Correo)
                        VALUES
                            (@nombre, @apellidopaterno, @apellidomaterno, @usuario, @password,
                             @numerocasa, @calle, @telefono, @correo)";

                    parametros = new[]
                    {
                        new SqlParameter("@nombre",             txtNombres.Text.Trim()),
                        new SqlParameter("@apellidopaterno",    txtApllPat.Text.Trim()),
                        new SqlParameter("@apellidomaterno",    txtApllMat.Text.Trim()),
                        new SqlParameter("@usuario",            txtUsuario.Text.Trim()),
                        new SqlParameter("@password",           txtContrasena.Text.Trim()),
                        new SqlParameter("@numerocasa",         nudNumeroCalle.Value),
                        new SqlParameter("@calle",              txtCalle.Text.Trim()),
                        new SqlParameter("@telefono",           txtNumTel.Text.Trim()),
                        new SqlParameter("@correo",             txtCorreo.Text.Trim())
                    };
                }

                int filas = DbHelper.ExecuteNonQuery(sql, parametros);
                string msg = esEdicion ? "¡Residente actualizado correctamente!" : "¡Residente registrado correctamente!";
                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EdicionFinalizada?.Invoke(this, EventArgs.Empty);

                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioYaExiste(string nuevoUsuario, int? actualID = null)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM Residente 
                WHERE Usuario = @usuario
                AND (@id IS NULL OR ResidenteID != @id)"; // Ignora el mismo usuario en edición

            var parametros = new[]
            {
                new SqlParameter("@usuario", nuevoUsuario),
                new SqlParameter("@id", actualID ?? (object)DBNull.Value)
            };

            int conteo = Convert.ToInt32(DbHelper.ExecuteScalar(sql, parametros));
            return conteo > 0;
        }


        private void limpiarCampos()
        {
            txtNombres.Clear();
            txtApllPat.Clear();
            txtApllMat.Clear();
            nudNumeroCalle.Value = 0;
            txtCalle.Clear();
            txtNumTel.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
        }

        private bool validarCasillas()
        {
            StringBuilder errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtNombres.Text.Trim()))
                errores.AppendLine("El campo 'Nombres' es obligatorio.");
            if (txtNombres.Text.Trim().Length < 3)
                errores.AppendLine("El nombre debe ser mayor a 2 caracteres.");
            if (string.IsNullOrWhiteSpace(txtApllPat.Text.Trim()))
                errores.AppendLine("El campo 'Apellido Paterno' es obligatorio.");
            if (txtApllPat.Text.Trim().Length < 3)
                errores.AppendLine("El 'Apellido Paterno' debe ser mayor a 2 caracteres.");
            if (string.IsNullOrWhiteSpace(txtApllMat.Text.Trim()))
                errores.AppendLine("El campo 'Apellido Materno' es obligatorio.");
            if (txtApllMat.Text.Trim().Length < 3)
                errores.AppendLine("El 'Apellido Materno' debe ser mayor a 2 caracteres.");
            if (nudNumeroCalle.Value == 0 || nudNumeroCalle.Value > 1000)
                errores.AppendLine("El campo 'Número de Casa' debe ser mayor a 0 y menor a 1000.");
            if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()))
                errores.AppendLine("El campo 'Calle' es obligatorio.");
            if (txtCalle.Text.Trim().Length < 3)
                errores.AppendLine("La 'Calle' debe ser mayor a 2 caracteres.");
            if (string.IsNullOrWhiteSpace(txtNumTel.Text.Trim()))
                errores.AppendLine("El campo 'Teléfono' es obligatorio.");
            else if (txtNumTel.Text.Trim().Length != 10)
                errores.AppendLine("El número de teléfono debe tener exactamente 10 dígitos.");
            if (string.IsNullOrWhiteSpace(txtCorreo.Text.Trim()))
                errores.AppendLine("El campo 'Correo' es obligatorio.");
            else if (!txtCorreo.Text.Trim().Contains("@") || !txtCorreo.Text.Trim().Contains("."))
                errores.AppendLine("El correo electrónico no es válido.");
            if (string.IsNullOrWhiteSpace(txtUsuario.Text.Trim()))
                errores.AppendLine("El campo 'Usuario' no puede estar vacío.");
            else if (txtUsuario.Text.Trim().Length < 3)
                errores.AppendLine("El campo 'Usuario' debe ser mayor a dos caracteres.");
            if (string.IsNullOrWhiteSpace(txtContrasena.Text.Trim()))
                errores.AppendLine("El campo 'Contraseña' no puede estar vacío.");
            if (txtContrasena.Text.Trim().Length > 0 && txtContrasena.Text.Trim().Length < 8)
                errores.AppendLine("La contraseña debe ser de al menos 8 caracteres.");

            if (errores.Length > 0)
            {
                MessageBox.Show(errores.ToString(), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void InicializarParaEdicion(DataRow fila)
        {
            esEdicion = true;
            residenteID = Convert.ToInt32(fila["ResidenteID"]);

            txtNombres.Text = fila["Nombre"].ToString();
            txtApllPat.Text = fila["ApellidoPaterno"].ToString();
            txtApllMat.Text = fila["ApellidoMaterno"].ToString();
            nudNumeroCalle.Value = Convert.ToDecimal(fila["NumeroCasa"]);
            txtCalle.Text = fila["Calle"].ToString();
            txtNumTel.Text = fila["Telefono"].ToString();
            txtCorreo.Text = fila["Correo"].ToString();
            txtUsuario.Text = fila["Usuario"].ToString();
        }


    }
}
