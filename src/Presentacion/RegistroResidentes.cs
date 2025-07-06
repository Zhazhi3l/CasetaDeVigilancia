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
            Image original = Properties.Resources.flecha_izquierda;Image redimensionada = new Bitmap(original, new Size(25, 25));btnRegresar.Image = redimensionada;btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                /*&& txtNumTel.TextLength<=10*/)
            {
                e.Handled = true;

            }
        }

        /**
         * Crea un nuevo residente en la base de datos.
         */
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
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
                        MessageBox.Show("Residente registrado correctamente.");
                    else
                        MessageBox.Show("No se insertó ningún registro.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }

                MessageBox.Show("Residente registrado");
                this.Close();
            }
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

            if (string.IsNullOrWhiteSpace(txtNombres.Text) || txtNombres.TextLength < 3)
                errores.AppendLine("El campo 'Nombres' es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtApllPat.Text) || txtApllPat.TextLength < 3)
                errores.AppendLine("El campo 'Apellido Paterno' es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtApllMat.Text) || txtApllMat.TextLength < 3)
                errores.AppendLine("El campo 'Apellido Materno' es obligatorio.");
            if (nudNumeroCalle.Value == 0)
                errores.AppendLine("El campo 'Número de Casa' debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(txtCalle.Text))
                errores.AppendLine("El campo 'Calle' es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtNumTel.Text))
                errores.AppendLine("El campo 'Teléfono' es obligatorio.");
            else if (txtNumTel.Text.Length != 10)
                errores.AppendLine("El número de teléfono debe tener exactamente 10 dígitos.");
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                errores.AppendLine("El campo 'Correo' es obligatorio.");
            else if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
                errores.AppendLine("El correo electrónico no es válido.");

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

    }
}
