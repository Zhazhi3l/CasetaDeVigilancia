using CasetaDeVigilancia.src.Datos;
using CasetaDeVigilancia.src.Datos.Datos.Modelos;
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

namespace CasetaDeVigilancia.src
{
    public partial class frmRegistroResidentes : Form
    {
        public frmRegistroResidentes()
        {
            InitializeComponent();
            this.Load += frmRegistroResidentes_Load;
            Image original = Properties.Resources.flecha_izquierda;Image redimensionada = new Bitmap(original, new Size(20, 20));btnRegresar.Image = redimensionada;btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Crea un nuevo residente en la base de datos.
         */
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (ResidenteYaExiste(txtNombres.Text, txtApllPat.Text, txtApllMat.Text)) /*, (int)nudNumeroCalle.Value)*/ // Comentado porque no se determina aún si habitan más personas en la misma casa.
            {
                MessageBox.Show("Este residente ya está registrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preparamos SQL parametrizado para evitar inyecciones SQL
            if (validarCasillas())
            {
                string sql = @"
                INSERT INTO Residente
                    (Nombre, ApellidoPaterno, ApellidoMaterno,
                     NumeroCasa, Calle, Telefono, Correo, FechaRegistro)
                VALUES
                    (@nombre, @apellidopaterno, @apellidomaterno, @numerocasa, @calle, @telefono, @correo, @fecharegistro)";

                // Creación de parametros SQL
                var parametros = new[]
                {
                    new SqlParameter("@nombre",             txtNombres.Text),
                    new SqlParameter("@apellidopaterno",    txtApllPat.Text),
                    new SqlParameter("@apellidomaterno",    txtApllMat.Text),
                    new SqlParameter("@numerocasa",         nudNumeroCalle.Value),
                    new SqlParameter("@calle",              txtCalle.Text),
                    new SqlParameter("@telefono",           txtNumTel.Text),
                    new SqlParameter("@correo",             txtCorreo.Text),
                    new SqlParameter("@fecharegistro",      DateTime.Now)
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
                this.Close();
            }
        }

        /**
         * Método que verifica si un residente ya existe en la base de datos.
         * Retorna true si el residente ya existe, false en caso contrario.
         * 
         * @param nombre Nombre del residente.
         * @param apPat Apellido paterno del residente.
         * @param apMat Apellido materno del residente.
         * @param numeroCasa Número de casa del residente (actualmente comentado).
         */
        private bool ResidenteYaExiste(string nombre, string apPat, string apMat) /*, int numeroCasa*/ // Comentado porque no se determina aún si habitan más personas en la misma casa.
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM Residente
                WHERE 
                    Nombre = @nombre AND 
                    ApellidoPaterno = @apPat AND 
                    ApellidoMaterno = @apMat AND";
            /*NumeroCasa = @numeroCasa"*/ // Comentado porque no se determina aún si habitan más personas en la misma casa.

            SqlParameter[] parametros = {
                new SqlParameter("@nombre", nombre),
                new SqlParameter("@apPat", apPat),
                new SqlParameter("@apMat", apMat),
                /*new SqlParameter("@numeroCasa", numeroCasa),*/ // Comentado porque no se determina aún si habitan más personas en la misma casa.
            };

            object resultado = DbHelper.ExecuteScalar(sql, parametros);
            return Convert.ToInt32(resultado) > 0;
        }


        /**         
         * Método que limpia los campos del formulario de registro de residentes.
         */
        private void limpiarCampos()
        {
            txtNombres.Clear();
            txtApllPat.Clear();
            txtApllMat.Clear();
            nudNumeroCalle.Value = 0;
            txtCalle.Clear();
            txtNumTel.Clear();
            txtCorreo.Clear();
        }

        /**
         * Método que valida los campos del formulario de registro de residentes.
         * Retorna true si todos los campos son válidos, false en caso contrario.
         */
        private bool validarCasillas()
        {
            StringBuilder errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
                errores.AppendLine("El campo 'Nombres' es obligatorio.");
            if (txtNombres.TextLength < 3)
                errores.AppendLine("El nombre debe ser mayor a 2 caracteres.");
            if (string.IsNullOrWhiteSpace(txtApllPat.Text))
                errores.AppendLine("El campo 'Apellido Paterno' es obligatorio.");
            if (txtApllPat.TextLength < 3)
                errores.AppendLine("El 'Apellido Paterno' debe ser mayor a 2 caracteres.");
            if (string.IsNullOrWhiteSpace(txtApllMat.Text))
                errores.AppendLine("El campo 'Apellido Materno' es obligatorio.");
            if (txtApllMat.TextLength < 3)
                errores.AppendLine("El 'Apellido Materno' debe ser mayor a 2 caracteres.");
            if (nudNumeroCalle.Value == 0 || nudNumeroCalle.Value > 1000)
                errores.AppendLine("El campo 'Número de Casa' debe ser mayor a 0 y menor a 1000.");
            if (string.IsNullOrWhiteSpace(txtCalle.Text))
                errores.AppendLine("El campo 'Calle' es obligatorio.");
            if (txtCalle.TextLength < 3)
                errores.AppendLine("La 'Calle' debe ser mayor a 2 caracteres.");
            if (string.IsNullOrWhiteSpace(txtNumTel.Text))
                errores.AppendLine("El campo 'Teléfono' es obligatorio.");
            else if (txtNumTel.Text.Length != 10)
                errores.AppendLine("El número de teléfono debe tener exactamente 10 dígitos.");
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                errores.AppendLine("El campo 'Correo' es obligatorio.");
            else if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                errores.AppendLine("El correo electrónico no es válido.");
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                errores.AppendLine("El campo 'Usuario' no puede estar vacío.");
            else if (txtUsuario.TextLength < 3)
                errores.AppendLine("El campo 'Usuario' debe ser mayor a dos caracteres.");
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                errores.AppendLine("El campo 'Contraseña' no puede estar vacío.");
            if (txtContrasena.TextLength > 0 && txtContrasena.TextLength < 8)
                errores.AppendLine("La contraseña debe ser de al menos 8 caracteres.");                

            if (errores.Length > 0)
            {
                MessageBox.Show(errores.ToString(), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /**
         * Evento que se ejecuta al cargar el formulario de registro de residentes.
         * Carga la lista de residentes en el DataGridView.
         */
        private void frmRegistroResidentes_Load(object sender, EventArgs e)
        {
            CargarResidentesAsync();
        }

        /**
         * Método asíncrono que carga la lista de residentes desde la base de datos
         * y la muestra en el DataGridView.
         */
        private async Task CargarResidentesAsync()
        {
            // Definir la consulta SQL
            string sql = @"
                SELECT
                    ResidenteID,
                    Nombre,
                    ApellidoPaterno,
                    ApellidoMaterno,
                    NumeroCasa,
                    Calle,
                    Telefono,
                    Correo,
                    FechaRegistro
                FROM Residente";

            // Ejecutar la consulta en un hilo de fondo para no bloquear la UI
            DataTable dt = await Task.Run(() => DbHelper.ExecuteQuery(sql));

            // Asignar el resultado al DataGridView en el hilo de la UI
            if (dgvListaResidentes.InvokeRequired)
            {
                dgvListaResidentes.Invoke(new Action(() => dgvListaResidentes.DataSource = dt));
            }
            else
            {
                dgvListaResidentes.DataSource = dt;
            }
        }

        private void txtNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
