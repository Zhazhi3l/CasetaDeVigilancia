using CasetaDeVigilancia.src.Datos;
using CasetaDeVigilancia.src.Presentacion.AdministrarResidentes;
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
    public partial class frmAdminUsuarios : Form
    {
        public frmAdminUsuarios()
        {
            InitializeComponent();
            Image original = Properties.Resources.flecha_izquierda; Image redimensionada = new Bitmap(original, new Size(20, 20)); btnRegresar.Image = redimensionada; btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminUsuarios_Load(object sender, EventArgs e)
        {
            CargarResidentesAsync();
        }

        private async Task CargarResidentesAsync()
        {
            string sql = @"
                SELECT 
                    ResidenteID,
                    Nombre,
                    ApellidoPaterno,
                    ApellidoMaterno,
                    Usuario,
                    Correo,
                    NumeroCasa,
                    Calle,
                    Telefono,
                    FechaRegistro
                FROM Residente
                ORDER BY FechaRegistro DESC;
            ";

            DataTable dt = await Task.Run(() => DbHelper.ExecuteQuery(sql));

            dgvTablaResidentes.Invoke(new MethodInvoker(() =>
            {
                dgvTablaResidentes.DataSource = dt;
                dgvTablaResidentes.ClearSelection();

                //  Opcional: ocultar columnas sensibles o estéticas
                if (dgvTablaResidentes.Columns.Contains("ResidenteID"))
                    dgvTablaResidentes.Columns["ResidenteID"].Visible = false;

                // Opcional: renombrar encabezados
                dgvTablaResidentes.Columns["Nombre"].HeaderText = "Nombre(s)";
                dgvTablaResidentes.Columns["ApellidoPaterno"].HeaderText = "Apellido Paterno";
                dgvTablaResidentes.Columns["ApellidoMaterno"].HeaderText = "Apellido Materno";
                dgvTablaResidentes.Columns["NumeroCasa"].HeaderText = "# Casa";
                dgvTablaResidentes.Columns["FechaRegistro"].DefaultCellStyle.Format = "g";
            }));
        }

        private async void btnEliminarResidente_Click(object sender, EventArgs e)
        {
            if (dgvTablaResidentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un residente para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = dgvTablaResidentes.SelectedRows[0];
            int residenteID = Convert.ToInt32(fila.Cells["ResidenteID"].Value);
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string apellido = fila.Cells["ApellidoPaterno"].Value.ToString();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Seguro que quieres eliminar a {nombre} {apellido}?" +
                "\nEsto eliminará también a sus invitados e historial.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                string sql = "DELETE FROM Residente WHERE ResidenteID = @id";
                DbHelper.ExecuteNonQuery(sql, new SqlParameter("@id", residenteID));

                MessageBox.Show("Residente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarResidentesAsync(); // Recargar lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar residente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditarResidente_Click(object sender, EventArgs e)
        {
            // Validar que haya una fila activa
            if (dgvTablaResidentes.CurrentRow == null || dgvTablaResidentes.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor selecciona un residente antes de editar.", "Selección requerida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int filaIndex = dgvTablaResidentes.CurrentRow.Index;
            DataTable tabla = dgvTablaResidentes.DataSource as DataTable;

            if (tabla == null || filaIndex >= tabla.Rows.Count)
            {
                MessageBox.Show("No se pudo obtener la información del residente.", "Error de datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmEditarResidente frm = new frmEditarResidente(filaIndex, tabla);
            frm.FormClosed += (s, args) => _ = CargarResidentesAsync();
            frm.ShowDialog();
        }
    }
}
