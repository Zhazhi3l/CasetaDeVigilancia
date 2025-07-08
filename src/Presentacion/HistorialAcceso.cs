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

namespace CasetaDeVigilancia.src.Presentacion
{
    public partial class frmHistorialAcceso : Form
    {
        public frmHistorialAcceso()
        {
            InitializeComponent();
            Image original = Properties.Resources.flecha_izquierda; Image redimensionada = new Bitmap(original, new Size(20, 20)); btnRegresar.Image = redimensionada; btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;

            // Caragmos los combos de tipo de usuario y tipo de acceso
            cmbTipoUsuario.Items.AddRange(new[] { "Todos", "Residente", "Invitado" });
            cmbTipoAcceso.Items.AddRange(new[] { "Todos", "Entradas", "Salidas" });
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistorialAcceso_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.SelectedIndex = 0;  // "Todos"
            cmbTipoAcceso.SelectedIndex = 0;   // "Todos"
            dtpFechaFiltro.Enabled = chkFiltrarFecha.Checked;
            _ = CargarHistorialFiltradoAsync();
        }

        /**
         * Método asíncrono que carga la lista de residentes desde la base de datos
         * y la muestra en el DataGridView.
         * Se deshabilitó ya que fue un borrador.
         
        private async Task CargarHistorialCompleto()
        {
            // Definir la consulta SQL
            string sql = @"
                SELECT
                    h.FechaEntrada,
                    h.FechaSalida,
                    ISNULL(r.Nombre + ' ' + r.ApellidoPaterno + ' ' + r.ApellidoMaterno,
                           i.Nombre + ' ' + i.ApellidoPaterno + ' ' + i.ApellidoMaterno) AS NombreCompleto,
                    CASE
                        WHEN h.ResidenteID IS NOT NULL THEN 'Residente'
                        WHEN h.InvitadoID IS NOT NULL THEN 'Invitado'
                        ELSE 'Desconocido'
                    END AS TipoUsuario,
                    ISNULL(CAST(h.ResidenteID AS NVARCHAR), CAST(h.InvitadoID AS NVARCHAR)) AS IDUsuario,
                    h.HistorialID
                FROM Historial h
                LEFT JOIN Residente r ON h.ResidenteID = r.ResidenteID
                LEFT JOIN Invitado i ON h.InvitadoID = i.InvitadoID
                ORDER BY h.FechaEntrada DESC;
            ";

            // Ejecutar la consulta en un hilo de fondo para no bloquear la UI
            DataTable dt = await Task.Run(() => DbHelper.ExecuteQuery(sql));

            // Asignar el resultado al DataGridView en el hilo de la UI
            if (dgvTablaAccesos.InvokeRequired)
            {
                dgvTablaAccesos.Invoke(new Action(() => dgvTablaAccesos.DataSource = dt));
            }
            else
            {
                dgvTablaAccesos.DataSource = dt;
            }
        }
        */

        private async Task CargarHistorialFiltradoAsync()
        {
            var filtros = new List<string>();
            var parametros = new List<SqlParameter>();

            string sqlBase = @"
                SELECT
                    h.HistorialID,
                    h.FechaEntrada,
                    h.FechaSalida,
                    ISNULL(r.Nombre + ' ' + r.ApellidoPaterno + ' ' + r.ApellidoMaterno,
                           i.Nombre + ' ' + i.ApellidoPaterno + ' ' + i.ApellidoMaterno) AS NombreCompleto,
                    CASE
                        WHEN h.ResidenteID IS NOT NULL THEN 'Residente'
                        WHEN h.InvitadoID IS NOT NULL THEN 'Invitado'
                        ELSE 'Desconocido'
                    END AS TipoUsuario,
                    ISNULL(CAST(h.ResidenteID AS NVARCHAR), CAST(h.InvitadoID AS NVARCHAR)) AS IDUsuario
                FROM Historial h
                LEFT JOIN Residente r ON r.ResidenteID = h.ResidenteID
                LEFT JOIN Invitado i ON i.InvitadoID = h.InvitadoID
            ";

            // Filtro por tipo de usuario
            string tipoUsuario = cmbTipoUsuario.SelectedItem?.ToString();
            if (tipoUsuario == "Residente")
                filtros.Add("h.ResidenteID IS NOT NULL");
            else if (tipoUsuario == "Invitado")
                filtros.Add("h.InvitadoID IS NOT NULL");

            // Filtro por fecha (si CheckBox está marcado)
            if (chkFiltrarFecha.Checked)
            {
                filtros.Add("CAST(h.FechaEntrada AS DATE) = @fecha");
                parametros.Add(new SqlParameter("@fecha", dtpFechaFiltro.Value.Date));
            }

            // Filtro por tipo de acceso
            string tipoAcceso = cmbTipoAcceso.SelectedItem?.ToString();
            if (tipoAcceso == "Entradas")
                filtros.Add("h.FechaEntrada IS NOT NULL"); // Entrada con o sin salida
            else if (tipoAcceso == "Salidas")
                filtros.Add("h.FechaSalida IS NOT NULL"); // Solo salidas confirmadas

            // Armar cláusula WHERE
            string where = filtros.Count > 0 ? " WHERE " + string.Join(" AND ", filtros) : "";
            string sqlFinal = sqlBase + where + " ORDER BY h.FechaEntrada DESC";

            // Ejecutar y mostrar resultados
            try
            {
                DataTable dt = await Task.Run(() => DbHelper.ExecuteQuery(sqlFinal, parametros.ToArray()));
                dgvTablaAccesos.Invoke(new MethodInvoker(() => dgvTablaAccesos.DataSource = dt));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            await CargarHistorialFiltradoAsync();
        }

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltrarFecha.Checked)
            {
                // Si el checkbox está marcado, mostrar el filtro de fecha
                dtpFechaFiltro.Enabled = true;
            }
            else
            {
                // Si no, ocultarlo y limpiar la selección
                dtpFechaFiltro.Enabled = false;
                dtpFechaFiltro.Value = DateTime.Now;
            }
        }

        private async void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            cmbTipoUsuario.SelectedIndex = 0;
            cmbTipoAcceso.SelectedIndex = 0;
            chkFiltrarFecha.Checked = false;
            dtpFechaFiltro.Value = DateTime.Now;

            await CargarHistorialFiltradoAsync();
        }
    }
}
