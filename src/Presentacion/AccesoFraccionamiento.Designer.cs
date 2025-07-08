namespace CasetaDeVigilancia.src
{
    partial class frmAccesoFraccionamiento
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblAvisoQr = new System.Windows.Forms.Label();
            this.txtQrReader = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelInvitado = new System.Windows.Forms.Panel();
            this.dtpVigencia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblIDInvitado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResidente = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIDResidente = new System.Windows.Forms.Label();
            this.panelComun = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellMaterno = new System.Windows.Forms.Label();
            this.lblApellPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEsperaQr = new System.Windows.Forms.Label();
            this.lblQrLeidoYEsperando = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelInvitado.SuspendLayout();
            this.panelResidente.SuspendLayout();
            this.panelComun.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panel1.TabIndex = 5;
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
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 370);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.txtQrReader);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 308);
            this.panel6.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblAvisoQr);
            this.panel9.Location = new System.Drawing.Point(577, 135);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 61);
            this.panel9.TabIndex = 15;
            // 
            // lblAvisoQr
            // 
            this.lblAvisoQr.AutoSize = true;
            this.lblAvisoQr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoQr.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAvisoQr.Location = new System.Drawing.Point(15, 14);
            this.lblAvisoQr.Name = "lblAvisoQr";
            this.lblAvisoQr.Size = new System.Drawing.Size(170, 28);
            this.lblAvisoQr.TabIndex = 1;
            this.lblAvisoQr.Text = "¡Código QR leído!";
            this.lblAvisoQr.Visible = false;
            // 
            // txtQrReader
            // 
            this.txtQrReader.Location = new System.Drawing.Point(781, 283);
            this.txtQrReader.Name = "txtQrReader";
            this.txtQrReader.Size = new System.Drawing.Size(16, 22);
            this.txtQrReader.TabIndex = 14;
            this.txtQrReader.TextChanged += new System.EventHandler(this.txtQrReader_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelInvitado);
            this.groupBox1.Controls.Add(this.panelResidente);
            this.groupBox1.Controls.Add(this.panelComun);
            this.groupBox1.Controls.Add(this.lblEsperaQr);
            this.groupBox1.Controls.Add(this.lblQrLeidoYEsperando);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // panelInvitado
            // 
            this.panelInvitado.Controls.Add(this.dtpVigencia);
            this.panelInvitado.Controls.Add(this.label6);
            this.panelInvitado.Controls.Add(this.lblEstatus);
            this.panelInvitado.Controls.Add(this.lblIDInvitado);
            this.panelInvitado.Controls.Add(this.label5);
            this.panelInvitado.Controls.Add(this.label2);
            this.panelInvitado.Location = new System.Drawing.Point(6, 135);
            this.panelInvitado.Name = "panelInvitado";
            this.panelInvitado.Size = new System.Drawing.Size(364, 86);
            this.panelInvitado.TabIndex = 16;
            this.panelInvitado.Visible = false;
            // 
            // dtpVigencia
            // 
            this.dtpVigencia.Enabled = false;
            this.dtpVigencia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigencia.Location = new System.Drawing.Point(11, 33);
            this.dtpVigencia.Name = "dtpVigencia";
            this.dtpVigencia.Size = new System.Drawing.Size(146, 25);
            this.dtpVigencia.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID del Invitado";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.Location = new System.Drawing.Point(164, 33);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(49, 17);
            this.lblEstatus.TabIndex = 4;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblIDInvitado
            // 
            this.lblIDInvitado.AutoSize = true;
            this.lblIDInvitado.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDInvitado.Location = new System.Drawing.Point(234, 33);
            this.lblIDInvitado.Name = "lblIDInvitado";
            this.lblIDInvitado.Size = new System.Drawing.Size(92, 17);
            this.lblIDInvitado.TabIndex = 6;
            this.lblIDInvitado.Text = "ID del invitado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Vigencia";
            // 
            // panelResidente
            // 
            this.panelResidente.Controls.Add(this.label7);
            this.panelResidente.Controls.Add(this.lblIDResidente);
            this.panelResidente.Location = new System.Drawing.Point(338, 29);
            this.panelResidente.Name = "panelResidente";
            this.panelResidente.Size = new System.Drawing.Size(200, 100);
            this.panelResidente.TabIndex = 15;
            this.panelResidente.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID del Residente";
            // 
            // lblIDResidente
            // 
            this.lblIDResidente.AutoSize = true;
            this.lblIDResidente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDResidente.Location = new System.Drawing.Point(9, 31);
            this.lblIDResidente.Name = "lblIDResidente";
            this.lblIDResidente.Size = new System.Drawing.Size(100, 17);
            this.lblIDResidente.TabIndex = 5;
            this.lblIDResidente.Text = "ID del residente";
            // 
            // panelComun
            // 
            this.panelComun.Controls.Add(this.label4);
            this.panelComun.Controls.Add(this.label3);
            this.panelComun.Controls.Add(this.label1);
            this.panelComun.Controls.Add(this.lblApellMaterno);
            this.panelComun.Controls.Add(this.lblApellPaterno);
            this.panelComun.Controls.Add(this.lblNombre);
            this.panelComun.Location = new System.Drawing.Point(6, 29);
            this.panelComun.Name = "panelComun";
            this.panelComun.Size = new System.Drawing.Size(333, 100);
            this.panelComun.TabIndex = 14;
            this.panelComun.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido Materno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // lblApellMaterno
            // 
            this.lblApellMaterno.AutoSize = true;
            this.lblApellMaterno.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellMaterno.Location = new System.Drawing.Point(156, 75);
            this.lblApellMaterno.Name = "lblApellMaterno";
            this.lblApellMaterno.Size = new System.Drawing.Size(109, 17);
            this.lblApellMaterno.TabIndex = 13;
            this.lblApellMaterno.Text = "Apellido materno";
            // 
            // lblApellPaterno
            // 
            this.lblApellPaterno.AutoSize = true;
            this.lblApellPaterno.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellPaterno.Location = new System.Drawing.Point(8, 75);
            this.lblApellPaterno.Name = "lblApellPaterno";
            this.lblApellPaterno.Size = new System.Drawing.Size(106, 17);
            this.lblApellPaterno.TabIndex = 12;
            this.lblApellPaterno.Text = "Apellido paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEsperaQr
            // 
            this.lblEsperaQr.AutoSize = true;
            this.lblEsperaQr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEsperaQr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaQr.Location = new System.Drawing.Point(3, 26);
            this.lblEsperaQr.Name = "lblEsperaQr";
            this.lblEsperaQr.Size = new System.Drawing.Size(374, 41);
            this.lblEsperaQr.TabIndex = 17;
            this.lblEsperaQr.Text = "Esperando lectura del QR...";
            this.lblEsperaQr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQrLeidoYEsperando
            // 
            this.lblQrLeidoYEsperando.AutoSize = true;
            this.lblQrLeidoYEsperando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQrLeidoYEsperando.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQrLeidoYEsperando.Location = new System.Drawing.Point(3, 26);
            this.lblQrLeidoYEsperando.Name = "lblQrLeidoYEsperando";
            this.lblQrLeidoYEsperando.Size = new System.Drawing.Size(318, 41);
            this.lblQrLeidoYEsperando.TabIndex = 18;
            this.lblQrLeidoYEsperando.Text = "Cargando la consulta...";
            this.lblQrLeidoYEsperando.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 308);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 62);
            this.panel5.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSalida);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(414, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(386, 62);
            this.panel8.TabIndex = 1;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalida.Enabled = false;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalida.Location = new System.Drawing.Point(0, 0);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(386, 62);
            this.btnSalida.TabIndex = 1;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEntrada);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(387, 62);
            this.panel7.TabIndex = 0;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntrada.Enabled = false;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(387, 62);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // frmAccesoFraccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAccesoFraccionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Fraccionamiento";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelInvitado.ResumeLayout(false);
            this.panelInvitado.PerformLayout();
            this.panelResidente.ResumeLayout(false);
            this.panelResidente.PerformLayout();
            this.panelComun.ResumeLayout(false);
            this.panelComun.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIDInvitado;
        private System.Windows.Forms.Label lblIDResidente;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtQrReader;
        private System.Windows.Forms.Panel panelComun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApellMaterno;
        private System.Windows.Forms.Label lblApellPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelInvitado;
        private System.Windows.Forms.Panel panelResidente;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblAvisoQr;
        private System.Windows.Forms.DateTimePicker dtpVigencia;
        private System.Windows.Forms.Label lblEsperaQr;
        private System.Windows.Forms.Label lblQrLeidoYEsperando;
    }
}