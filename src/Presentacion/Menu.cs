using CasetaDeVigilancia.src;
using CasetaDeVigilancia.src.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDeVigilancia
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            cargarImagBotones();
        }
        /**
         * Método para cargar las imágenes de los botones de la interfaz gráfica.
         */
        private void cargarImagBotones()
        {
            Image original = Properties.Resources.proteger;
            Image redimensionada = new Bitmap(original, new Size(32, 32));
            btnAcceder.Image = redimensionada;
            btnAcceder.ImageAlign = ContentAlignment.MiddleLeft;

            original = Properties.Resources.registro;
            redimensionada = new Bitmap(original, new Size(32, 32));
            btnRegistro.Image = redimensionada;
            btnRegistro.ImageAlign = ContentAlignment.MiddleLeft;

            original = Properties.Resources.historial_de_pedidos;
            redimensionada = new Bitmap(original, new Size(32, 32));
            btnHistorial.Image = redimensionada;
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;

            original = Properties.Resources.iniciar_sesion;
            redimensionada = new Bitmap(original, new Size(32, 32));
            btnSesionGuardia.Image = redimensionada;
            btnSesionGuardia.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistroResidentes vntResidentes = new frmRegistroResidentes();
            
            vntResidentes.ShowDialog();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            frmAccesoFraccionamiento accFracc = new frmAccesoFraccionamiento();
            
            accFracc.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialAcceso historial = new frmHistorialAcceso();
            historial.ShowDialog();
        }

        private void btnSesionGuardia_Click(object sender, EventArgs e)
        {
            frmAdminUsuarios administrarres = new frmAdminUsuarios();
            administrarres.ShowDialog();
        }
    }
}
