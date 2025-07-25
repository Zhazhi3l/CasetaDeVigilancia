﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDeVigilancia.src.Presentacion.AdministrarResidentes
{
    public partial class frmEditarResidente : Form
    {
        private DataRow filaResidente;
        private int filaIndex;
        private DataTable tablaResidentes;

        public frmEditarResidente(int index, DataTable tabla)
        {
            InitializeComponent();
            Image original = Properties.Resources.flecha_izquierda; Image redimensionada = new Bitmap(original, new Size(20, 20)); btnRegresar.Image = redimensionada; btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            filaResidente = tabla.Rows[index];
        }

        private void datosDeUsuario1_Load(object sender, EventArgs e)
        {

        }

        private void frmEditarResidente_Load(object sender, EventArgs e)
        {
            // Inicializar el control con la fila seleccionada
            datosDeUsuario1.InicializarParaEdicion(filaResidente);

            // Escuchar el evento cuando el residente sea editado
            datosDeUsuario1.EdicionFinalizada += (s, args) =>
            {
                this.Close(); // Cierra el formulario cuando se edita con éxito
            };


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
