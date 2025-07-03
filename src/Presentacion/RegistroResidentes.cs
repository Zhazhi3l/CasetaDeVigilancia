using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
