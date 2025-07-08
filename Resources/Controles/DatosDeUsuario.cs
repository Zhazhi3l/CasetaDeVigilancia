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
        public DatosDeUsuario()
        {
            InitializeComponent();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (validarCasillas())
            {
                string sql = @"
                Select Residente
                    (Nombre, ApellidoPaterno, ApellidoMaterno,
                     NumeroCasa, Calle, Telefono, Correo, FechaRegistro)
                VALUES
                    (@nombre, @apellidopaterno, @apellidomaterno, @numerocasa, @calle, @telefono, @correo)";

                // Creación de parametros SQL
                var parametros = new[]
                {
                    new SqlParameter("@nombre",             txtNombres.Text.Trim()),
                    new SqlParameter("@apellidopaterno",    txtApllPat.Text.Trim()),
                    new SqlParameter("@apellidomaterno",    txtApllMat.Text.Trim()),
                    new SqlParameter("@numerocasa",         nudNumeroCalle.Value),
                    new SqlParameter("@calle",              txtCalle.Text.Trim()),
                    new SqlParameter("@telefono",           txtNumTel.Text.Trim()),
                    new SqlParameter("@correo",             txtCorreo.Text.Trim())
                };

                // Ejecutamos la consulta
                try
                {
                    // Ejecutamos INSERT:
                    int filas = DbHelper.ExecuteNonQuery(sql, parametros);
                    if (filas > 0)
                        MessageBox.Show("¡Residente registrado correctamente!");
                    else
                        MessageBox.Show("No se insertó ningún registro.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }

                limpiarCampos();
            }
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
    }
}
