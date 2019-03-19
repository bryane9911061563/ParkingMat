﻿namespace ParkingMat.GUI
{
    partial class frm_AdminSucursales
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
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.btn_agregarvehiculo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_vervehiculo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtx_apertura = new System.Windows.Forms.MaskedTextBox();
            this.mtx_cierre = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtx_Cajones = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mtx_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.pnl_contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_contenedor.Controls.Add(this.btn_agregarvehiculo);
            this.pnl_contenedor.Controls.Add(this.btn_vervehiculo);
            this.pnl_contenedor.Controls.Add(this.label5);
            this.pnl_contenedor.Controls.Add(this.comboBox1);
            this.pnl_contenedor.Controls.Add(this.panel1);
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_contenedor.Location = new System.Drawing.Point(0, 238);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1366, 325);
            this.pnl_contenedor.TabIndex = 0;
            // 
            // btn_agregarvehiculo
            // 
            this.btn_agregarvehiculo.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_agregarvehiculo.AllowDrop = true;
            this.btn_agregarvehiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_agregarvehiculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_agregarvehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarvehiculo.BorderRadius = 7;
            this.btn_agregarvehiculo.ButtonText = "Agregar vehiculo";
            this.btn_agregarvehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarvehiculo.DisabledColor = System.Drawing.Color.White;
            this.btn_agregarvehiculo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_agregarvehiculo.Iconimage = null;
            this.btn_agregarvehiculo.Iconimage_right = null;
            this.btn_agregarvehiculo.Iconimage_right_Selected = null;
            this.btn_agregarvehiculo.Iconimage_Selected = null;
            this.btn_agregarvehiculo.IconMarginLeft = 0;
            this.btn_agregarvehiculo.IconMarginRight = 0;
            this.btn_agregarvehiculo.IconRightVisible = true;
            this.btn_agregarvehiculo.IconRightZoom = 0D;
            this.btn_agregarvehiculo.IconVisible = true;
            this.btn_agregarvehiculo.IconZoom = 90D;
            this.btn_agregarvehiculo.IsTab = false;
            this.btn_agregarvehiculo.Location = new System.Drawing.Point(377, 10);
            this.btn_agregarvehiculo.Name = "btn_agregarvehiculo";
            this.btn_agregarvehiculo.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_agregarvehiculo.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarvehiculo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_agregarvehiculo.selected = false;
            this.btn_agregarvehiculo.Size = new System.Drawing.Size(179, 33);
            this.btn_agregarvehiculo.TabIndex = 14;
            this.btn_agregarvehiculo.Text = "Agregar vehiculo";
            this.btn_agregarvehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_agregarvehiculo.Textcolor = System.Drawing.Color.White;
            this.btn_agregarvehiculo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarvehiculo.Click += new System.EventHandler(this.btn_agregarvehiculo_Click);
            // 
            // btn_vervehiculo
            // 
            this.btn_vervehiculo.Location = new System.Drawing.Point(821, 15);
            this.btn_vervehiculo.Name = "btn_vervehiculo";
            this.btn_vervehiculo.Size = new System.Drawing.Size(174, 23);
            this.btn_vervehiculo.TabIndex = 13;
            this.btn_vervehiculo.Text = "ejemplo administrar vehiculo";
            this.btn_vervehiculo.UseVisualStyleBackColor = true;
            this.btn_vervehiculo.Click += new System.EventHandler(this.btn_vervehiculo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sección:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O"});
            this.comboBox1.Location = new System.Drawing.Point(666, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Seleccione";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 276);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1366, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la sucursal:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(235, 14);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(360, 29);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora de apertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora de cierre:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(840, 14);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(360, 29);
            this.txt_direccion.TabIndex = 6;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección de la sucursal:";
            // 
            // mtx_apertura
            // 
            this.mtx_apertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_apertura.Location = new System.Drawing.Point(342, 56);
            this.mtx_apertura.Mask = "00:00";
            this.mtx_apertura.Name = "mtx_apertura";
            this.mtx_apertura.Size = new System.Drawing.Size(64, 29);
            this.mtx_apertura.TabIndex = 7;
            this.mtx_apertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtx_apertura.ValidatingType = typeof(System.DateTime);
            // 
            // mtx_cierre
            // 
            this.mtx_cierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_cierre.Location = new System.Drawing.Point(566, 56);
            this.mtx_cierre.Mask = "00:00";
            this.mtx_cierre.Name = "mtx_cierre";
            this.mtx_cierre.Size = new System.Drawing.Size(64, 29);
            this.mtx_cierre.TabIndex = 8;
            this.mtx_cierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtx_cierre.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtx_Cajones);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtx_Telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.btn_Cerrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtx_cierre);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.mtx_apertura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(82, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 169);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion general";
            // 
            // mtx_Cajones
            // 
            this.mtx_Cajones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_Cajones.Location = new System.Drawing.Point(410, 110);
            this.mtx_Cajones.Mask = "99999";
            this.mtx_Cajones.Name = "mtx_Cajones";
            this.mtx_Cajones.Size = new System.Drawing.Size(46, 29);
            this.mtx_Cajones.TabIndex = 15;
            this.mtx_Cajones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtx_Cajones.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cajones que dispone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(700, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número telefónico:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.AllowDrop = true;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Cancelar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(428, 102);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(179, 48);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "Cancelar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Cerrar.AllowDrop = true;
            this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cerrar.BorderRadius = 7;
            this.btn_Cerrar.ButtonText = "Guardar cambios";
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.DisabledColor = System.Drawing.Color.White;
            this.btn_Cerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Iconimage = null;
            this.btn_Cerrar.Iconimage_right = null;
            this.btn_Cerrar.Iconimage_right_Selected = null;
            this.btn_Cerrar.Iconimage_Selected = null;
            this.btn_Cerrar.IconMarginLeft = 0;
            this.btn_Cerrar.IconMarginRight = 0;
            this.btn_Cerrar.IconRightVisible = true;
            this.btn_Cerrar.IconRightZoom = 0D;
            this.btn_Cerrar.IconVisible = true;
            this.btn_Cerrar.IconZoom = 90D;
            this.btn_Cerrar.IsTab = false;
            this.btn_Cerrar.Location = new System.Drawing.Point(613, 102);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Cerrar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cerrar.selected = false;
            this.btn_Cerrar.Size = new System.Drawing.Size(179, 48);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Guardar cambios";
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.btn_Cerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // mtx_Telefono
            // 
            this.mtx_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_Telefono.Location = new System.Drawing.Point(880, 56);
            this.mtx_Telefono.Mask = "(999)000-0000";
            this.mtx_Telefono.Name = "mtx_Telefono";
            this.mtx_Telefono.Size = new System.Drawing.Size(163, 29);
            this.mtx_Telefono.TabIndex = 13;
            this.mtx_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_AdminSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminSucursales";
            this.Text = "frm_AdminSucursales";
            this.pnl_contenedor.ResumeLayout(false);
            this.pnl_contenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtx_apertura;
        private System.Windows.Forms.MaskedTextBox mtx_cierre;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_vervehiculo;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_agregarvehiculo;
        private System.Windows.Forms.MaskedTextBox mtx_Cajones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtx_Telefono;
    }
}