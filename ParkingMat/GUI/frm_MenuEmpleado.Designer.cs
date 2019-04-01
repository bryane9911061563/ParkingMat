namespace ParkingMat.GUI
{
    partial class frm_MenuEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_id_Suc = new System.Windows.Forms.Label();
            this.lbl_nombre_us = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_indicador = new System.Windows.Forms.Panel();
            this.btn_recibos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_pensionados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_vehiculos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_parquimetro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tmr_Hora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_id_Suc);
            this.panel1.Controls.Add(this.lbl_nombre_us);
            this.panel1.Controls.Add(this.lbl_hora);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnl_indicador);
            this.panel1.Controls.Add(this.btn_recibos);
            this.panel1.Controls.Add(this.btn_pensionados);
            this.panel1.Controls.Add(this.btn_vehiculos);
            this.panel1.Controls.Add(this.btn_parquimetro);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 121);
            this.panel1.TabIndex = 0;
            // 
            // lbl_id_Suc
            // 
            this.lbl_id_Suc.AutoSize = true;
            this.lbl_id_Suc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_Suc.Location = new System.Drawing.Point(370, 16);
            this.lbl_id_Suc.Name = "lbl_id_Suc";
            this.lbl_id_Suc.Size = new System.Drawing.Size(159, 24);
            this.lbl_id_Suc.TabIndex = 37;
            this.lbl_id_Suc.Text = "Numero_sucursal";
            // 
            // lbl_nombre_us
            // 
            this.lbl_nombre_us.AutoSize = true;
            this.lbl_nombre_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_us.Location = new System.Drawing.Point(140, 16);
            this.lbl_nombre_us.Name = "lbl_nombre_us";
            this.lbl_nombre_us.Size = new System.Drawing.Size(148, 24);
            this.lbl_nombre_us.TabIndex = 36;
            this.lbl_nombre_us.Text = "nombre_usuario";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(674, 13);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(56, 24);
            this.lbl_hora.TabIndex = 35;
            this.lbl_hora.Text = "--:--.--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hora:";
            // 
            // pnl_indicador
            // 
            this.pnl_indicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(125)))));
            this.pnl_indicador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_indicador.Location = new System.Drawing.Point(0, 96);
            this.pnl_indicador.Name = "pnl_indicador";
            this.pnl_indicador.Size = new System.Drawing.Size(1380, 25);
            this.pnl_indicador.TabIndex = 0;
            // 
            // btn_recibos
            // 
            this.btn_recibos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btn_recibos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_recibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btn_recibos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_recibos.BorderRadius = 6;
            this.btn_recibos.ButtonText = "Recibos";
            this.btn_recibos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recibos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_recibos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_recibos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_recibos.Iconimage")));
            this.btn_recibos.Iconimage_right = null;
            this.btn_recibos.Iconimage_right_Selected = null;
            this.btn_recibos.Iconimage_Selected = null;
            this.btn_recibos.IconMarginLeft = 0;
            this.btn_recibos.IconMarginRight = 0;
            this.btn_recibos.IconRightVisible = true;
            this.btn_recibos.IconRightZoom = 0D;
            this.btn_recibos.IconVisible = true;
            this.btn_recibos.IconZoom = 45D;
            this.btn_recibos.IsTab = false;
            this.btn_recibos.Location = new System.Drawing.Point(896, 64);
            this.btn_recibos.Name = "btn_recibos";
            this.btn_recibos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btn_recibos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_recibos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_recibos.selected = false;
            this.btn_recibos.Size = new System.Drawing.Size(434, 37);
            this.btn_recibos.TabIndex = 33;
            this.btn_recibos.Text = "Recibos";
            this.btn_recibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recibos.Textcolor = System.Drawing.Color.White;
            this.btn_recibos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recibos.Click += new System.EventHandler(this.btn_recibos_Click);
            // 
            // btn_pensionados
            // 
            this.btn_pensionados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btn_pensionados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_pensionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btn_pensionados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pensionados.BorderRadius = 6;
            this.btn_pensionados.ButtonText = "Pensionados";
            this.btn_pensionados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pensionados.DisabledColor = System.Drawing.Color.Gray;
            this.btn_pensionados.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pensionados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_pensionados.Iconimage")));
            this.btn_pensionados.Iconimage_right = null;
            this.btn_pensionados.Iconimage_right_Selected = null;
            this.btn_pensionados.Iconimage_Selected = null;
            this.btn_pensionados.IconMarginLeft = 0;
            this.btn_pensionados.IconMarginRight = 0;
            this.btn_pensionados.IconRightVisible = true;
            this.btn_pensionados.IconRightZoom = 0D;
            this.btn_pensionados.IconVisible = true;
            this.btn_pensionados.IconZoom = 45D;
            this.btn_pensionados.IsTab = false;
            this.btn_pensionados.Location = new System.Drawing.Point(475, 64);
            this.btn_pensionados.Name = "btn_pensionados";
            this.btn_pensionados.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btn_pensionados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_pensionados.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_pensionados.selected = false;
            this.btn_pensionados.Size = new System.Drawing.Size(432, 37);
            this.btn_pensionados.TabIndex = 32;
            this.btn_pensionados.Text = "Pensionados";
            this.btn_pensionados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pensionados.Textcolor = System.Drawing.Color.White;
            this.btn_pensionados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pensionados.Click += new System.EventHandler(this.btn_pensionados_Click);
            // 
            // btn_vehiculos
            // 
            this.btn_vehiculos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(142)))), ((int)(((byte)(138)))));
            this.btn_vehiculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_vehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(142)))), ((int)(((byte)(138)))));
            this.btn_vehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vehiculos.BorderRadius = 6;
            this.btn_vehiculos.ButtonText = "Vehículos";
            this.btn_vehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vehiculos.DisabledColor = System.Drawing.Color.Gray;
            this.btn_vehiculos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_vehiculos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_vehiculos.Iconimage")));
            this.btn_vehiculos.Iconimage_right = null;
            this.btn_vehiculos.Iconimage_right_Selected = null;
            this.btn_vehiculos.Iconimage_Selected = null;
            this.btn_vehiculos.IconMarginLeft = 0;
            this.btn_vehiculos.IconMarginRight = 0;
            this.btn_vehiculos.IconRightVisible = true;
            this.btn_vehiculos.IconRightZoom = 0D;
            this.btn_vehiculos.IconVisible = true;
            this.btn_vehiculos.IconZoom = 45D;
            this.btn_vehiculos.IsTab = false;
            this.btn_vehiculos.Location = new System.Drawing.Point(757, 16);
            this.btn_vehiculos.Name = "btn_vehiculos";
            this.btn_vehiculos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(142)))), ((int)(((byte)(138)))));
            this.btn_vehiculos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_vehiculos.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_vehiculos.selected = false;
            this.btn_vehiculos.Size = new System.Drawing.Size(320, 37);
            this.btn_vehiculos.TabIndex = 30;
            this.btn_vehiculos.Text = "Vehículos";
            this.btn_vehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vehiculos.Textcolor = System.Drawing.Color.White;
            this.btn_vehiculos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehiculos.Visible = false;
            this.btn_vehiculos.Click += new System.EventHandler(this.btn_vehiculos_Click);
            // 
            // btn_parquimetro
            // 
            this.btn_parquimetro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(125)))));
            this.btn_parquimetro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_parquimetro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(125)))));
            this.btn_parquimetro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_parquimetro.BorderRadius = 6;
            this.btn_parquimetro.ButtonText = "Parquímetro";
            this.btn_parquimetro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_parquimetro.DisabledColor = System.Drawing.Color.Gray;
            this.btn_parquimetro.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_parquimetro.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_parquimetro.Iconimage")));
            this.btn_parquimetro.Iconimage_right = null;
            this.btn_parquimetro.Iconimage_right_Selected = null;
            this.btn_parquimetro.Iconimage_Selected = null;
            this.btn_parquimetro.IconMarginLeft = 0;
            this.btn_parquimetro.IconMarginRight = 0;
            this.btn_parquimetro.IconRightVisible = true;
            this.btn_parquimetro.IconRightZoom = 0D;
            this.btn_parquimetro.IconVisible = true;
            this.btn_parquimetro.IconZoom = 45D;
            this.btn_parquimetro.IsTab = false;
            this.btn_parquimetro.Location = new System.Drawing.Point(50, 64);
            this.btn_parquimetro.Name = "btn_parquimetro";
            this.btn_parquimetro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(125)))));
            this.btn_parquimetro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_parquimetro.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_parquimetro.selected = false;
            this.btn_parquimetro.Size = new System.Drawing.Size(454, 37);
            this.btn_parquimetro.TabIndex = 29;
            this.btn_parquimetro.Text = "Parquímetro";
            this.btn_parquimetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_parquimetro.Textcolor = System.Drawing.Color.White;
            this.btn_parquimetro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parquimetro.Click += new System.EventHandler(this.btn_parquimetro_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Activecolor = System.Drawing.SystemColors.Control;
            this.btn_Salir.AllowDrop = true;
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.BorderRadius = 7;
            this.btn_Salir.ButtonText = "Cerrar sesión";
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Salir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Salir.Iconimage = null;
            this.btn_Salir.Iconimage_right = null;
            this.btn_Salir.Iconimage_right_Selected = null;
            this.btn_Salir.Iconimage_Selected = null;
            this.btn_Salir.IconMarginLeft = 0;
            this.btn_Salir.IconMarginRight = 0;
            this.btn_Salir.IconRightVisible = true;
            this.btn_Salir.IconRightZoom = 0D;
            this.btn_Salir.IconVisible = true;
            this.btn_Salir.IconZoom = 35D;
            this.btn_Salir.IsTab = false;
            this.btn_Salir.Location = new System.Drawing.Point(1131, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Normalcolor = System.Drawing.SystemColors.Control;
            this.btn_Salir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Salir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Salir.selected = false;
            this.btn_Salir.Size = new System.Drawing.Size(179, 31);
            this.btn_Salir.TabIndex = 28;
            this.btn_Salir.Text = "Cerrar sesión";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salir.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimizar.BorderRadius = 0;
            this.btn_minimizar.ButtonText = "";
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_minimizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Iconimage")));
            this.btn_minimizar.Iconimage_right = null;
            this.btn_minimizar.Iconimage_right_Selected = null;
            this.btn_minimizar.Iconimage_Selected = null;
            this.btn_minimizar.IconMarginLeft = 0;
            this.btn_minimizar.IconMarginRight = 0;
            this.btn_minimizar.IconRightVisible = true;
            this.btn_minimizar.IconRightZoom = 0D;
            this.btn_minimizar.IconVisible = true;
            this.btn_minimizar.IconZoom = 35D;
            this.btn_minimizar.IsTab = false;
            this.btn_minimizar.Location = new System.Drawing.Point(1316, 1);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_minimizar.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_minimizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_minimizar.selected = false;
            this.btn_minimizar.Size = new System.Drawing.Size(29, 29);
            this.btn_minimizar.TabIndex = 27;
            this.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_minimizar.Textcolor = System.Drawing.Color.White;
            this.btn_minimizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Activecolor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.BorderRadius = 0;
            this.btn_cerrar.ButtonText = "";
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Iconimage")));
            this.btn_cerrar.Iconimage_right = null;
            this.btn_cerrar.Iconimage_right_Selected = null;
            this.btn_cerrar.Iconimage_Selected = null;
            this.btn_cerrar.IconMarginLeft = 0;
            this.btn_cerrar.IconMarginRight = 0;
            this.btn_cerrar.IconRightVisible = true;
            this.btn_cerrar.IconRightZoom = 0D;
            this.btn_cerrar.IconVisible = true;
            this.btn_cerrar.IconZoom = 50D;
            this.btn_cerrar.IsTab = false;
            this.btn_cerrar.Location = new System.Drawing.Point(1351, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cerrar.selected = false;
            this.btn_cerrar.Size = new System.Drawing.Size(29, 29);
            this.btn_cerrar.TabIndex = 26;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cerrar.Textcolor = System.Drawing.Color.White;
            this.btn_cerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(40, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "arkingMat";
            // 
            // tmr_Hora
            // 
            this.tmr_Hora.Enabled = true;
            this.tmr_Hora.Tick += new System.EventHandler(this.tmr_Hora_Tick);
            // 
            // frm_MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_MenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MenuEmpleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_indicador;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton btn_minimizar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_recibos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_pensionados;
        private Bunifu.Framework.UI.BunifuFlatButton btn_vehiculos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_parquimetro;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmr_Hora;
        private System.Windows.Forms.Label lbl_nombre_us;
        private System.Windows.Forms.Label lbl_id_Suc;
    }
}