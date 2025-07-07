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
    public partial class frmAccesoFraccionamiento : Form
    {
        private int invitadoID;
        private int residenteID;
        private bool esInvitado;

        public frmAccesoFraccionamiento()
        {
            InitializeComponent();
            // txtQrReader - Propiedades forzadas
            this.ActiveControl = txtQrReader;
            txtQrReader.TabStop = false;
            txtQrReader.Width = 1;
            txtQrReader.Height = 1;
            txtQrReader.ForeColor = this.BackColor;
            txtQrReader.BackColor = this.BackColor;

            Image original = Properties.Resources.flecha_izquierda; Image redimensionada = new Bitmap(original, new Size(20, 20)); btnRegresar.Image = redimensionada; btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEscanear_Click(object sender, EventArgs e)
        {
            string codigo = txtQrReader.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo)) return;

            btnEscanear.Enabled = false;
            await ProcesarQrAsync(codigo);
            btnEscanear.Enabled = true;
        }

        private async Task ProcesarQrAsync(string codigo)
        {
            // Reset de la interfaz
            LimpiarPaneles();
            try
            {
                if (!codigo.Contains("|"))
                {
                    MessageBox.Show("Formato de código QR inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] partes = codigo.Split('|');
                if (partes.Length != 2)
                {
                    MessageBox.Show("Código QR corrupto o mal formado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tipo = partes[0];
                if (!int.TryParse(partes[1], out int id))
                {
                    MessageBox.Show("ID inválido en el código QR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (tipo)
                {
                    case "INV":
                        await BuscarInvitadoPorID(id);
                        break;
                    case "RES":
                        await BuscarResidentePorID(id);
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario no reconocido en código QR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            finally
            {
                txtQrReader.Clear();
                txtQrReader.Enabled = true;
                this.ActiveControl = txtQrReader;
            }
        }

        /**
         * Muestra los datos del invitado en la interfaz.
         */
        private async Task BuscarResidentePorID(int id)
        {
            var result = await Task.Run(() => DbHelper.ExecuteQuery(@"
                SELECT ResidenteID, Nombre, ApellidoPaterno, ApellidoMaterno
                FROM Residente
                WHERE ResidenteID = @id", new SqlParameter("@id", id))
            );

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Residente no encontrado.", "QR Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = result.Rows[0];
            lblNombre.Text = row["Nombre"].ToString();
            lblApellPaterno.Text = row["ApellidoPaterno"].ToString();
            lblApellMaterno.Text = row["ApellidoMaterno"].ToString();
            lblIDResidente.Text = row["ResidenteID"].ToString();

            panelComun.Visible = true;
            panelResidente.Visible = true;
            residenteID = (int)row["ResidenteID"];
            esInvitado = false;

            btnEntrada.Enabled = true;
            btnSalida.Enabled = true;
        }

        /**
         * Muestra los datos del invitado en la interfaz.
         */
        private async Task BuscarInvitadoPorID(int id)
        {
            var result = await Task.Run(() => DbHelper.ExecuteQuery(@"
                SELECT i.InvitadoID, i.FechaVigencia, i.Estatus,
                       r.ResidenteID, r.Nombre, r.ApellidoPaterno, r.ApellidoMaterno
                FROM Invitado i
                JOIN Residente r ON r.ResidenteID = i.ResidenteID
                WHERE i.InvitadoID = @id", new SqlParameter("@id", id))
            );

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Invitado no encontrado.", "QR Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = result.Rows[0];
            lblNombre.Text = row["Nombre"].ToString();
            lblApellPaterno.Text = row["ApellidoPaterno"].ToString();
            lblApellMaterno.Text = row["ApellidoMaterno"].ToString();
            lblIDInvitado.Text = row["InvitadoID"].ToString();
            dtpVigencia.Value = (DateTime)row["FechaVigencia"];
            lblEstatus.Text = row["Estatus"].ToString();

            DateTime vigencia = (DateTime)row["FechaVigencia"];

            if (vigencia < DateTime.Now)
            {
                MessageBox.Show("Este código QR ya venció por fecha.", "QR caducado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panelComun.Visible = true;
            panelInvitado.Visible = true;

            panelResidente.Visible = true;
            lblIDResidente.Text = row["ResidenteID"].ToString();

            invitadoID = (int)row["InvitadoID"];
            residenteID = (int)row["ResidenteID"];
            esInvitado = true;

            ValidarAccesoInvitado();
        }

        /**
         * Valida el acceso del invitado según su estatus y fecha de vigencia.
         * Habilita o deshabilita los botones de entrada/salida según corresponda.
         */
        private void ValidarAccesoInvitado()
        {
            string estatus = lblEstatus.Text.ToUpper();

            switch (estatus)
            {
                case "PENDIENTE":
                    MessageBox.Show("Este código QR aún no ha sido activado.", "QR pendiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnEntrada.Enabled = false;
                    btnSalida.Enabled = false;
                    break;

                case "VENCIDO":
                    MessageBox.Show("Este QR ha vencido. No se permite el acceso.", "QR vencido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnEntrada.Enabled = false;
                    btnSalida.Enabled = false;
                    break;

                case "ACTIVO":
                    bool yaEntro = VerificarEntradaPreviaInvitado(invitadoID);
                    btnEntrada.Enabled = !yaEntro;
                    btnSalida.Enabled = yaEntro;
                    break;
            }
        }

        private bool VerificarEntradaPreviaInvitado(int invitadoID)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM Historial
                WHERE InvitadoID = @id AND FechaSalida IS NULL";

            SqlParameter param = new SqlParameter("@id", invitadoID);
            object result = DbHelper.ExecuteScalar(sql, param);

            return Convert.ToInt32(result) > 0;
        }

        private bool VerificarEntradaPreviaResidente(int ResidenteID)
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM Historial
                WHERE ResidenteID = @id AND FechaSalida IS NULL";

            SqlParameter param = new SqlParameter("@id", ResidenteID);
            object result = DbHelper.ExecuteScalar(sql, param);

            return Convert.ToInt32(result) > 0;
        }

        private void LimpiarPaneles()
        {
            lblNombre.Text = lblApellPaterno.Text = lblApellMaterno.Text =
            lblIDResidente.Text = lblIDInvitado.Text = lblEstatus.Text = "";

            panelComun.Visible = false;
            panelInvitado.Visible = false;
            panelResidente.Visible = false;

            btnEntrada.Enabled = false;
            btnSalida.Enabled = false;
        }

        private bool enProceso = false;

        private void txtQrReader_TextChanged(object sender, EventArgs e)
        {
            lblEsperaQr.Visible = false;
            txtQrReader.Enabled = false;
            string qr = txtQrReader.Text.Trim();
            lblAvisoQr.Visible = true;
            lblQrLeidoYEsperando.Visible = true;

            if (!string.IsNullOrWhiteSpace(qr))
            {
                btnEscanear.Enabled = true;
                _ = ProcesarQrAsync(qr);
                //btnEscanear.PerformClick(); // Simula clic automático al leer QR
            }
        }
    }
}
