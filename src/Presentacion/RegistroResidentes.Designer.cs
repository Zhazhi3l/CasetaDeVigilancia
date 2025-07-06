namespace CasetaDeVigilancia.src
{
    partial class frmRegistroResidentes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.gbxDireccion = new System.Windows.Forms.GroupBox();
            this.nudNumeroCalle = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.gbxNombre = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApllMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApllPat = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListaResidentes = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCalle)).BeginInit();
            this.gbxNombre.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResidentes)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRegresar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 40);
            this.panel5.TabIndex = 0;
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
            this.btnRegresar.Size = new System.Drawing.Size(89, 40);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 391);
            this.panel3.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCrearUsuario);
            this.panel8.Controls.Add(this.groupBox2);
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Controls.Add(this.gbxDireccion);
            this.panel8.Controls.Add(this.gbxNombre);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(572, 391);
            this.panel8.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.MintCream;
            this.btnCrearUsuario.Location = new System.Drawing.Point(296, 329);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(242, 45);
            this.btnCrearUsuario.TabIndex = 11;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtContrasena);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Location = new System.Drawing.Point(296, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 131);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inicio de Sesión";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(6, 96);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(230, 22);
            this.txtContrasena.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(230, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumTel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Location = new System.Drawing.Point(34, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 152);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Número de teléfono";
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(6, 96);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(230, 22);
            this.txtNumTel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(6, 44);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(230, 22);
            this.txtCorreo.TabIndex = 0;
            // 
            // gbxDireccion
            // 
            this.gbxDireccion.Controls.Add(this.nudNumeroCalle);
            this.gbxDireccion.Controls.Add(this.label5);
            this.gbxDireccion.Controls.Add(this.label4);
            this.gbxDireccion.Controls.Add(this.txtCalle);
            this.gbxDireccion.Location = new System.Drawing.Point(296, 16);
            this.gbxDireccion.Name = "gbxDireccion";
            this.gbxDireccion.Size = new System.Drawing.Size(242, 150);
            this.gbxDireccion.TabIndex = 13;
            this.gbxDireccion.TabStop = false;
            this.gbxDireccion.Text = "Dirección";
            // 
            // nudNumeroCalle
            // 
            this.nudNumeroCalle.Location = new System.Drawing.Point(6, 100);
            this.nudNumeroCalle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumeroCalle.Name = "nudNumeroCalle";
            this.nudNumeroCalle.Size = new System.Drawing.Size(109, 22);
            this.nudNumeroCalle.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero de Casa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(6, 49);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(230, 22);
            this.txtCalle.TabIndex = 0;
            // 
            // gbxNombre
            // 
            this.gbxNombre.Controls.Add(this.label3);
            this.gbxNombre.Controls.Add(this.txtApllMat);
            this.gbxNombre.Controls.Add(this.label2);
            this.gbxNombre.Controls.Add(this.label1);
            this.gbxNombre.Controls.Add(this.txtApllPat);
            this.gbxNombre.Controls.Add(this.txtNombres);
            this.gbxNombre.Location = new System.Drawing.Point(34, 16);
            this.gbxNombre.Name = "gbxNombre";
            this.gbxNombre.Size = new System.Drawing.Size(242, 194);
            this.gbxNombre.TabIndex = 12;
            this.gbxNombre.TabStop = false;
            this.gbxNombre.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Materno";
            // 
            // txtApllMat
            // 
            this.txtApllMat.Location = new System.Drawing.Point(6, 153);
            this.txtApllMat.Name = "txtApllMat";
            this.txtApllMat.Size = new System.Drawing.Size(230, 22);
            this.txtApllMat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre(s)";
            // 
            // txtApllPat
            // 
            this.txtApllPat.Location = new System.Drawing.Point(6, 100);
            this.txtApllPat.Name = "txtApllPat";
            this.txtApllPat.Size = new System.Drawing.Size(230, 22);
            this.txtApllPat.TabIndex = 1;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(6, 49);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(230, 22);
            this.txtNombres.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvListaResidentes);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(572, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 391);
            this.panel4.TabIndex = 8;
            // 
            // dgvListaResidentes
            // 
            this.dgvListaResidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaResidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaResidentes.Location = new System.Drawing.Point(0, 59);
            this.dgvListaResidentes.Name = "dgvListaResidentes";
            this.dgvListaResidentes.RowHeadersWidth = 51;
            this.dgvListaResidentes.RowTemplate.Height = 24;
            this.dgvListaResidentes.Size = new System.Drawing.Size(228, 267);
            this.dgvListaResidentes.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 59);
            this.panel7.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lista de Residentes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 326);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 65);
            this.panel6.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.MintCream;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(228, 65);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRegistroResidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegistroResidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Residentes";
            this.Load += new System.EventHandler(this.frmRegistroResidentes_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDireccion.ResumeLayout(false);
            this.gbxDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCalle)).EndInit();
            this.gbxNombre.ResumeLayout(false);
            this.gbxNombre.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResidentes)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvListaResidentes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox gbxDireccion;
        private System.Windows.Forms.NumericUpDown nudNumeroCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.GroupBox gbxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApllMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApllPat;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label10;
    }
}