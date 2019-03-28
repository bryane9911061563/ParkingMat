namespace ParkingMat.GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtx_apertura = new System.Windows.Forms.MaskedTextBox();
            this.mtx_cierre = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtx_Cajones = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtx_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_sucursales = new System.Windows.Forms.DataGridView();
            this.id_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_Cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Telefonico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Cajones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora de apertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora de cierre:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(235, 56);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(360, 29);
            this.txt_direccion.TabIndex = 6;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección de la sucursal:";
            // 
            // mtx_apertura
            // 
            this.mtx_apertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_apertura.Location = new System.Drawing.Point(233, 127);
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
            this.mtx_cierre.Location = new System.Drawing.Point(457, 127);
            this.mtx_cierre.Mask = "00:00";
            this.mtx_cierre.Name = "mtx_cierre";
            this.mtx_cierre.Size = new System.Drawing.Size(64, 29);
            this.mtx_cierre.TabIndex = 8;
            this.mtx_cierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtx_cierre.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mtx_Cajones);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mtx_Telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtx_cierre);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.mtx_apertura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(34, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 233);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion general";
            // 
            // mtx_Cajones
            // 
            this.mtx_Cajones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_Cajones.Location = new System.Drawing.Point(233, 197);
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
            this.label7.Location = new System.Drawing.Point(39, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero de cajones:";
            // 
            // mtx_Telefono
            // 
            this.mtx_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_Telefono.Location = new System.Drawing.Point(233, 162);
            this.mtx_Telefono.Mask = "(999)000-0000";
            this.mtx_Telefono.Name = "mtx_Telefono";
            this.mtx_Telefono.Size = new System.Drawing.Size(163, 29);
            this.mtx_Telefono.TabIndex = 13;
            this.mtx_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número telefónico:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 563);
            this.panel1.TabIndex = 10;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.AllowDrop = true;
            this.bunifuFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 7;
            this.bunifuFlatButton3.ButtonText = "Eliminar";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(19, 389);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(155, 48);
            this.bunifuFlatButton3.TabIndex = 15;
            this.bunifuFlatButton3.Text = "Eliminar";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.AllowDrop = true;
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Nuevo";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(182, 389);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(155, 48);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "Nuevo";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.AllowDrop = true;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "Actualizar";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(345, 389);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(155, 48);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Actualizar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Cerrar.AllowDrop = true;
            this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cerrar.BorderRadius = 7;
            this.btn_Cerrar.ButtonText = "Agregar";
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
            this.btn_Cerrar.Location = new System.Drawing.Point(508, 389);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Cerrar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cerrar.selected = false;
            this.btn_Cerrar.Size = new System.Drawing.Size(155, 48);
            this.btn_Cerrar.TabIndex = 12;
            this.btn_Cerrar.Text = "Agregar";
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.btn_Cerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 61);
            this.label5.TabIndex = 10;
            this.label5.Text = "Admin. sucursales";
            // 
            // dgv_sucursales
            // 
            this.dgv_sucursales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Sucursal,
            this.Nombre_Sucursal,
            this.Direccion_Sucursal,
            this.Horario_Apertura,
            this.Horario_Cierre,
            this.Numero_Telefonico,
            this.Cantidad_Cajones});
            this.dgv_sucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sucursales.Location = new System.Drawing.Point(683, 0);
            this.dgv_sucursales.Name = "dgv_sucursales";
            this.dgv_sucursales.Size = new System.Drawing.Size(683, 563);
            this.dgv_sucursales.TabIndex = 11;
            this.dgv_sucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sucursales_CellContentClick);
            // 
            // id_Sucursal
            // 
            this.id_Sucursal.DataPropertyName = "id_Sucursal";
            this.id_Sucursal.HeaderText = "Codigo";
            this.id_Sucursal.Name = "id_Sucursal";
            // 
            // Nombre_Sucursal
            // 
            this.Nombre_Sucursal.DataPropertyName = "Nombre_Sucursal";
            this.Nombre_Sucursal.HeaderText = "Sucursal";
            this.Nombre_Sucursal.Name = "Nombre_Sucursal";
            // 
            // Direccion_Sucursal
            // 
            this.Direccion_Sucursal.DataPropertyName = "Direccion_Sucursal";
            this.Direccion_Sucursal.HeaderText = "Dirección";
            this.Direccion_Sucursal.Name = "Direccion_Sucursal";
            // 
            // Horario_Apertura
            // 
            this.Horario_Apertura.DataPropertyName = "Horario_Apertura";
            this.Horario_Apertura.HeaderText = "Hora de apertura";
            this.Horario_Apertura.Name = "Horario_Apertura";
            // 
            // Horario_Cierre
            // 
            this.Horario_Cierre.DataPropertyName = "Horario_Cierre";
            this.Horario_Cierre.HeaderText = "Hora de cierre";
            this.Horario_Cierre.Name = "Horario_Cierre";
            // 
            // Numero_Telefonico
            // 
            this.Numero_Telefonico.DataPropertyName = "Numero_Telefonico";
            this.Numero_Telefonico.HeaderText = "Telefono";
            this.Numero_Telefonico.Name = "Numero_Telefonico";
            // 
            // Cantidad_Cajones
            // 
            this.Cantidad_Cajones.DataPropertyName = "Cantidad_Cajones";
            this.Cantidad_Cajones.HeaderText = "Capacidad";
            this.Cantidad_Cajones.Name = "Cantidad_Cajones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tarifa por hora:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(235, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 29);
            this.textBox1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "$";
            // 
            // frm_AdminSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 563);
            this.Controls.Add(this.dgv_sucursales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminSucursales";
            this.Text = "frm_AdminSucursales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtx_apertura;
        private System.Windows.Forms.MaskedTextBox mtx_cierre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtx_Cajones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtx_Telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_sucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_Cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Telefonico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Cajones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}