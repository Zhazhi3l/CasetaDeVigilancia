namespace CasetaDeVigilancia.src.Presentacion
{
    partial class frmHistorialAcceso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvTablaAccesos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoAcceso = new System.Windows.Forms.ComboBox();
            this.dtpFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReiniciarFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAccesos)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegresar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 40);
            this.panel3.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::CasetaDeVigilancia.Properties.Resources.flecha_izquierda;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(0, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 40);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvTablaAccesos);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 370);
            this.panel4.TabIndex = 8;
            // 
            // dgvTablaAccesos
            // 
            this.dgvTablaAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAccesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaAccesos.Location = new System.Drawing.Point(0, 77);
            this.dgvTablaAccesos.Name = "dgvTablaAccesos";
            this.dgvTablaAccesos.RowHeadersVisible = false;
            this.dgvTablaAccesos.RowHeadersWidth = 51;
            this.dgvTablaAccesos.RowTemplate.Height = 24;
            this.dgvTablaAccesos.Size = new System.Drawing.Size(800, 293);
            this.dgvTablaAccesos.TabIndex = 1;
            this.dgvTablaAccesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaAccesos_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MintCream;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cmbTipoAcceso);
            this.panel5.Controls.Add(this.dtpFechaFiltro);
            this.panel5.Controls.Add(this.chkFiltrarFecha);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cmbTipoUsuario);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 77);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(325, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filtrar por Tipo de Acceso:";
            // 
            // cmbTipoAcceso
            // 
            this.cmbTipoAcceso.FormattingEnabled = true;
            this.cmbTipoAcceso.Location = new System.Drawing.Point(325, 34);
            this.cmbTipoAcceso.Name = "cmbTipoAcceso";
            this.cmbTipoAcceso.Size = new System.Drawing.Size(208, 24);
            this.cmbTipoAcceso.TabIndex = 8;
            // 
            // dtpFechaFiltro
            // 
            this.dtpFechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFiltro.Location = new System.Drawing.Point(201, 36);
            this.dtpFechaFiltro.Name = "dtpFechaFiltro";
            this.dtpFechaFiltro.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaFiltro.TabIndex = 7;
            // 
            // chkFiltrarFecha
            // 
            this.chkFiltrarFecha.AutoSize = true;
            this.chkFiltrarFecha.Location = new System.Drawing.Point(177, 38);
            this.chkFiltrarFecha.Name = "chkFiltrarFecha";
            this.chkFiltrarFecha.Size = new System.Drawing.Size(18, 17);
            this.chkFiltrarFecha.TabIndex = 6;
            this.chkFiltrarFecha.UseVisualStyleBackColor = true;
            this.chkFiltrarFecha.CheckedChanged += new System.EventHandler(this.chkFiltrarFecha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(173, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar por Fecha:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnReiniciarFiltros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAplicarFiltro, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(677, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 77);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.BackColor = System.Drawing.Color.SlateGray;
            this.btnReiniciarFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReiniciarFiltros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReiniciarFiltros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReiniciarFiltros.Location = new System.Drawing.Point(3, 41);
            this.btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            this.btnReiniciarFiltros.Size = new System.Drawing.Size(117, 33);
            this.btnReiniciarFiltros.TabIndex = 1;
            this.btnReiniciarFiltros.Text = "Reinciar";
            this.btnReiniciarFiltros.UseVisualStyleBackColor = false;
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAplicarFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAplicarFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAplicarFiltro.Location = new System.Drawing.Point(3, 3);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(117, 32);
            this.btnAplicarFiltro.TabIndex = 0;
            this.btnAplicarFiltro.Text = "Aplicar";
            this.btnAplicarFiltro.UseVisualStyleBackColor = false;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por Usuario:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(3, 34);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(151, 24);
            this.cmbTipoUsuario.TabIndex = 2;
            // 
            // frmHistorialAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHistorialAcceso";
            this.Text = "Historial de accesos";
            this.Load += new System.EventHandler(this.frmHistorialAcceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAccesos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReiniciarFiltros;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.DataGridView dgvTablaAccesos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoAcceso;
        private System.Windows.Forms.DateTimePicker dtpFechaFiltro;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
    }
}