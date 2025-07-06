using CasetaDeVigilancia.src.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDeVigilancia.src.Pruebas
{
    public partial class frmPruebaConexion : Form
    {
        public frmPruebaConexion()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentamos abrir y cerrar la conexión
                using (var conn = DbHelper.GetConnection())
                {
                    // Si llegamos aquí, la conexión se abrió correctamente
                }
                MessageBox.Show("¡Conexión ADO.NET exitosa!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Si hay error, lo mostramos
                MessageBox.Show("Error al conectar: " + ex.Message, "Error de Conexión",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
