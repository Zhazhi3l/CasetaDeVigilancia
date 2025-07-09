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
            ReiniciarLecturaQR();
        }

        /**
         * Reinicia las etiquetas y prepara el txt como la primera vez.
         */
        private void ReiniciarLecturaQR()
        {
            txtQrReader.Clear();
            txtQrReader.Enabled = true;
            this.ActiveControl = txtQrReader;

            lblEsperaQr.Visible = true;
            lblAvisoQr.Visible = false;
            lblQrLeidoYEsperando.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Antes esto se hacía de forma manual con un botón, pero ahora se hace automáticamente al cambiar el texto del txtQrReader.
         * 
        private async void btnEscanear_Click(object sender, EventArgs e)
        {
            string codigo = txtQrReader.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo)) return;

            btnEscanear.Enabled = false;
            await ProcesarQrAsync(codigo);
            btnEscanear.Enabled = true;
        }
        */

        /**
         * Procesa de forma asíncrona el código QR.
         * Verifica el tipo de Usuario que se encuentra en el código QR.
         * Realiza una búsqueda por ID según el tipo de Usuario.
         */
        private async Task  ProcesarQrAsync(string codigo)
        {
            // Reset de la interfaz
            LimpiarPaneles();
            try
            {
                string[] partes = codigo.Split('$');
                if (partes.Length != 2)
                {
                    MessageBox.Show("El código QR tiene un formato inválido.", "QR no reconocido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tipo = partes[0].Trim().ToUpper();
                string idTexto = partes[1].Trim();

                if ((tipo != "RES" && tipo != "INV") || !int.TryParse(idTexto, out int id))
                {
                    MessageBox.Show($"El código QR no es válido. Revisa que sea del tipo RES$ID o INV$ID.", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ReiniciarLecturaQR();
            }
        }

        /**
         * Muestra los datos del invitado en la interfaz.
         */
        private async Task BuscarResidentePorID(int id)
        {
            // Deshabilitar la etiqueta de espera.
            lblQrLeidoYEsperando.Visible = false;

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
            lblNombre.Text = row["Nombre"].ToString().ToUpper();
            lblApellPaterno.Text = row["ApellidoPaterno"].ToString().ToUpper();
            lblApellMaterno.Text = row["ApellidoMaterno"].ToString().ToUpper();
            lblIDResidente.Text = row["ResidenteID"].ToString().ToUpper();

            panelComun.Visible = true;
            panelResidente.Visible = true;
            residenteID = (int)row["ResidenteID"];
            esInvitado = false;

            btnEntrada.Enabled = true;
            btnSalida.Enabled = true;

            lblQrLeidoYEsperando.Visible = false;
            lblAvisoQr.Visible = false;
            lblEsperaQr.Visible = false;
        }

        /**
         * Muestra los datos del invitado en la interfaz.
         */
        private async Task BuscarInvitadoPorID(int id)
        {
            // Deshabilitar la etiqueta de espera.
            lblQrLeidoYEsperando.Visible = false;

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
            DateTime vigencia = (DateTime)row["FechaVigencia"];
            if (vigencia < DateTime.Now)
            {
                MessageBox.Show("Este código QR ya venció por fecha.", "QR caducado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblEstatus.Text = row["Estatus"].ToString().ToUpper();
            lblNombre.Text = row["Nombre"].ToString().ToUpper();
            lblApellPaterno.Text = row["ApellidoPaterno"].ToString().ToUpper();
            lblApellMaterno.Text = row["ApellidoMaterno"].ToString().ToUpper();
            lblIDInvitado.Text = row["InvitadoID"].ToString().ToUpper();
            dtpVigencia.Value = (DateTime)row["FechaVigencia"];
            
            panelComun.Visible = true;
            panelInvitado.Visible = true;

            panelResidente.Visible = true;
            lblIDResidente.Text = row["ResidenteID"].ToString().ToUpper();

            invitadoID = (int)row["InvitadoID"];
            residenteID = (int)row["ResidenteID"];
            esInvitado = true;

            lblQrLeidoYEsperando.Visible = false;
            lblAvisoQr.Visible = false;
            lblEsperaQr.Visible = false;

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


        private async void txtQrReader_TextChanged(object sender, EventArgs e)
        {
            /*
            string qr = "";
            /*
            if (txtQrReader.Text.Trim().Contains("\n"))
            {
                MessageBox.
            }
            

            if (enProceso) return;

            //enProceso = true;
            //txtQrReader.Enabled = false;

            lblEsperaQr.Visible = false;
            lblAvisoQr.Visible = true;
            lblQrLeidoYEsperando.Visible = true;

            qr = txtQrReader.Text.Trim();

            if (!string.IsNullOrWhiteSpace(qr))
            {
                await ProcesarQrAsync(qr);
            }

            enProceso = false;
            */
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (esInvitado)
            {
                if (VerificarEntradaPreviaInvitado(invitadoID))
                {
                    MessageBox.Show("El invitado ya se encuentra dentro. No se puede registrar otra entrada.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertSql = @"
                    INSERT INTO Historial (FechaEntrada, ResidenteID, InvitadoID)
                    VALUES (GETDATE(), @residenteId, @invitadoId)";
                DbHelper.ExecuteNonQuery(insertSql,
                    new SqlParameter("@residenteId", residenteID),
                    new SqlParameter("@invitadoId", invitadoID)
                );

                // Cambia estatus del QR a 'Vencido' si es de un solo uso
                string updateSql = "UPDATE Invitado SET Estatus = @estatus WHERE InvitadoID = @id";
                DbHelper.ExecuteNonQuery(updateSql,
                    new SqlParameter("@estatus", "Vencido"),
                    new SqlParameter("@id", invitadoID));

                MessageBox.Show("Entrada de invitado registrada correctamente.", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (VerificarEntradaPreviaResidente(residenteID))
                {
                    MessageBox.Show("Este residente ya se encuentra dentro.", "Entrada duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertSql = @"INSERT INTO Historial (FechaEntrada, ResidenteID, InvitadoID) 
                    VALUES (GETDATE(), @residenteId, @invitadoId)";
                DbHelper.ExecuteNonQuery(insertSql,
                    new SqlParameter("@residenteId", residenteID),
                    new SqlParameter("@invitadoId", DBNull.Value));

                MessageBox.Show("Entrada de residente registrada correctamente.", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnEntrada.Enabled = false;
            btnSalida.Enabled = false;

            LimpiarPaneles();
            ReiniciarLecturaQR();

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (esInvitado)
            {
                if (!VerificarEntradaPreviaInvitado(invitadoID))
                {
                    MessageBox.Show("Este invitado no ha registrado entrada aún.", "Salida inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string updateSql = @"
                    UPDATE TOP (1) Historial
                    SET FechaSalida = GETDATE()
                    WHERE InvitadoID = @id AND FechaSalida IS NULL
                    ORDER BY FechaEntrada DESC";
                DbHelper.ExecuteNonQuery(updateSql, new SqlParameter("@id", invitadoID));

                MessageBox.Show("Salida de invitado registrada correctamente.", "Salida confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!VerificarEntradaPreviaResidente(residenteID))
                {
                    MessageBox.Show("Este residente aún no ha entrado.", "Salida inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string updateSql = @"
                    UPDATE TOP (1) Historial
                    SET FechaSalida = GETDATE()
                    WHERE ResidenteID = @id AND FechaSalida IS NULL
                    ORDER BY FechaEntrada DESC";
                DbHelper.ExecuteNonQuery(updateSql, new SqlParameter("@id", residenteID));

                MessageBox.Show("Salida de residente registrada correctamente.", "Salida confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnEntrada.Enabled = false;
            btnSalida.Enabled = false;

            LimpiarPaneles();
            ReiniciarLecturaQR();
        }

        /**
         * Como el Lector de qr da un enter cuando termina, se usa este evento para procesar el código QR.
         */
        private async void txtQrReader_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                lblEsperaQr.Visible = false;
                lblAvisoQr.Visible = true;
                lblQrLeidoYEsperando.Visible = true;

                string qr = txtQrReader.Text.Trim();

                if (!string.IsNullOrWhiteSpace(qr))
                {
                    await ProcesarQrAsync(qr);
                }
            }
        }
    }
}
