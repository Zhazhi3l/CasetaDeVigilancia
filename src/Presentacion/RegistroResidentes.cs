﻿using CasetaDeVigilancia.src.Datos;
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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // Preparamos SQL parametrizado para evitar inyecciones SQL
            if (validarCasillas())
            {
                string sql = @"
                INSERT INTO Usuario
                    (Nombre, ApellidoPaterno, ApellidoMaterno,
                     NumeroCasa, Calle, Telefono, Correo, FechaRegistro)
                VALUES
                    (@nombre, @apellidopaterno, @appelidomaterno, @numerocasa, @calle, @telefono, @correo, @fechaReg)";

                // Creación de parametros SQL
                var parametros = new[]
                {
                    new SqlParameter("@nombre",             txtNombres.Text),
                    new SqlParameter("@apellidopaterno",    txtApllPat.Text),
                    new SqlParameter("@appelidomaterno",    txtApllMat.Text),
                    new SqlParameter("@numerocasa",         nudNumeroCalle.Value),
                    new SqlParameter("@calle",              txtCalle.Text),
                    new SqlParameter("@telefono",           txtNumTel.Text),
                    new SqlParameter("@correo",             txtCorreo.Text),
                    new SqlParameter("@fechaReg",           DateTime.Now)
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

        private void frmRegistroResidentes_Load(object sender, EventArgs e)
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
                FROM Usuario";
            // 2) Obtenemos un DataTable con los datos:
            DataTable dt = DbHelper.ExecuteQuery(sql);

            // 3) Asignamos al DataGridView:
            dgvListaResidentes.DataSource = dt;

            // 4) Ajustes estéticos (opcional):
            dgvListaResidentes.Columns["ResidenteID"].Visible = false;

        }
    }
}
