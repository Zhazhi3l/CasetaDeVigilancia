namespace CasetaDeVigilancia.src.Presentacion
{
    partial class frmAdminUsuarios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvTablaResidentes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarResidente = new System.Windows.Forms.Button();
            this.btnEliminarResidente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResidentes)).BeginInit();
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
            this.panel1.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 370);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvTablaResidentes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 370);
            this.panel5.TabIndex = 1;
            // 
            // dgvTablaResidentes
            // 
            this.dgvTablaResidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaResidentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaResidentes.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaResidentes.Name = "dgvTablaResidentes";
            this.dgvTablaResidentes.RowHeadersVisible = false;
            this.dgvTablaResidentes.RowHeadersWidth = 51;
            this.dgvTablaResidentes.RowTemplate.Height = 24;
            this.dgvTablaResidentes.Size = new System.Drawing.Size(600, 370);
            this.dgvTablaResidentes.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEditarResidente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminarResidente, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(600, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEditarResidente
            // 
            this.btnEditarResidente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditarResidente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarResidente.Enabled = false;
            this.btnEditarResidente.FlatAppearance.BorderSize = 0;
            this.btnEditarResidente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarResidente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarResidente.Location = new System.Drawing.Point(3, 3);
            this.btnEditarResidente.Name = "btnEditarResidente";
            this.btnEditarResidente.Size = new System.Drawing.Size(194, 179);
            this.btnEditarResidente.TabIndex = 0;
            this.btnEditarResidente.Text = "Editar\r\nResidente";
            this.btnEditarResidente.UseVisualStyleBackColor = false;
            this.btnEditarResidente.Click += new System.EventHandler(this.btnEditarResidente_Click);
            // 
            // btnEliminarResidente
            // 
            this.btnEliminarResidente.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarResidente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarResidente.Enabled = false;
            this.btnEliminarResidente.FlatAppearance.BorderSize = 0;
            this.btnEliminarResidente.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btnEliminarResidente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarResidente.Location = new System.Drawing.Point(3, 188);
            this.btnEliminarResidente.Name = "btnEliminarResidente";
            this.btnEliminarResidente.Size = new System.Drawing.Size(194, 179);
            this.btnEliminarResidente.TabIndex = 1;
            this.btnEliminarResidente.Text = "Eliminar\r\nResidente";
            this.btnEliminarResidente.UseVisualStyleBackColor = false;
            this.btnEliminarResidente.Click += new System.EventHandler(this.btnEliminarResidente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            // frmAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdminUsuarios";
            this.Text = "Administración de Residentes";
            this.Load += new System.EventHandler(this.frmAdminUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResidentes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTablaResidentes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditarResidente;
        private System.Windows.Forms.Button btnEliminarResidente;
    }
}