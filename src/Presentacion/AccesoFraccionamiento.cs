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
            txtCodigoQr.Focus();
            panelResidente.Visible = false;
            panelInvitado.Visible = false;
            Image original = Properties.Resources.flecha_izquierda; Image redimensionada = new Bitmap(original, new Size(20, 20)); btnRegresar.Image = redimensionada; btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoQr.Text.Trim();

            //Ocultamos etiquetas
            panelComun.Visible = panelResidente.Visible = panelInvitado.Visible = false;

            //Intento de buscar invitado
            var dtInv = DbHelper.ExecuteQuery(@"
                SELECT i.InvitadoID, i.FechaVigencia, i.Estatus,
                       u.UsuarioID AS ResidenteID, u.Nombre, u.ApellidoPaterno, u.ApellidoMaterno
                FROM Invitado i
                JOIN Usuario u ON u.UsuarioID = i.UsuarioID
                WHERE i.CodigoQr = @cod",
                new SqlParameter("@cod", codigo)
            );

            if (dtInv.Rows.Count > 0)
            {
                // Es invitado
                var row = dtInv.Rows[0];
                // Cargo datos comunes
                lblNombre.Text = row["Nombre"].ToString();
                lblApellPaterno.Text = row["ApellidoPaterno"].ToString();
                lblApellMaterno.Text = row["ApellidoMaterno"].ToString();
                panelComun.Visible = true;

                // Cargo datos de invitado
                lblIDInvitado.Text = row["InvitadoID"].ToString();
                dtpVigencia.Value = (DateTime)row["FechaVigencia"];
                lblEstatus.Text = row["Estatus"].ToString();
                panelInvitado.Visible = true;

                // Guardo estado 
                
                invitadoID = (int)row["InvitadoID"];
                residenteID = (int)row["ResidenteID"];
                esInvitado = true;
                return;
            }

            // 2) Si no hay invitado, buscamos un residente
            var dtRes = DbHelper.ExecuteQuery(@"
                SELECT UsuarioID, Nombre, ApellidoPaterno, ApellidoMaterno
                FROM Usuario
                WHERE CodigoQr = @cod",  // o WHERE UsuarioID=@cod
                        new SqlParameter("@cod", codigo)
            );
            
            if (dtRes.Rows.Count > 0)
            {
                var row = dtRes.Rows[0];
                // Cargo datos comunes
                lblNombre.Text = row["Nombre"].ToString();
                lblApellPaterno.Text = row["ApellidoPaterno"].ToString();
                lblApellMaterno.Text = row["ApellidoMaterno"].ToString();
                panelComun.Visible = true;

                // Cargo datos de residente
                lblIDResidente.Text = row["UsuarioID"].ToString();
                panelResidente.Visible = true;

                // Guardo estado
                residenteID = (int)row["UsuarioID"];
                esInvitado = false;
                return;
            }
        }
            

        private void txtCodigoQr_TextChanged(object sender, EventArgs e)
        {
            lblAvisoQr.Visible = true;
            btnEscanear.Enabled = true;
        }
    }
}
