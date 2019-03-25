namespace ParkingMat.GUI
{
    partial class frm_AdmTiposRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdmTiposRecibo));
            this.pnl_BarraEstado = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_actualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_tip_recibo = new System.Windows.Forms.TextBox();
            this.dgv_tipos_recibos = new System.Windows.Forms.DataGridView();
            this.id_tiporecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tiporecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_BarraEstado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipos_recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BarraEstado
            // 
            this.pnl_BarraEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BarraEstado.BackgroundImage")));
            this.pnl_BarraEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BarraEstado.Controls.Add(this.label1);
            this.pnl_BarraEstado.Controls.Add(this.btn_cerrar);
            this.pnl_BarraEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BarraEstado.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.pnl_BarraEstado.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnl_BarraEstado.GradientTopLeft = System.Drawing.Color.White;
            this.pnl_BarraEstado.GradientTopRight = System.Drawing.Color.White;
            this.pnl_BarraEstado.Location = new System.Drawing.Point(0, 0);
            this.pnl_BarraEstado.Name = "pnl_BarraEstado";
            this.pnl_BarraEstado.Quality = 10;
            this.pnl_BarraEstado.Size = new System.Drawing.Size(587, 31);
            this.pnl_BarraEstado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin. Tipos de recibos";
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
            this.btn_cerrar.Location = new System.Drawing.Point(559, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cerrar.selected = false;
            this.btn_cerrar.Size = new System.Drawing.Size(29, 29);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cerrar.Textcolor = System.Drawing.Color.White;
            this.btn_cerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nombre_tip_recibo);
            this.panel1.Controls.Add(this.dgv_tipos_recibos);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 328);
            this.panel1.TabIndex = 8;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Activecolor = System.Drawing.Color.White;
            this.btn_actualizar.AllowDrop = true;
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actualizar.BackColor = System.Drawing.Color.White;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.BorderRadius = 7;
            this.btn_actualizar.ButtonText = "Actualizar";
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_actualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_actualizar.Iconimage = null;
            this.btn_actualizar.Iconimage_right = null;
            this.btn_actualizar.Iconimage_right_Selected = null;
            this.btn_actualizar.Iconimage_Selected = null;
            this.btn_actualizar.IconMarginLeft = 0;
            this.btn_actualizar.IconMarginRight = 0;
            this.btn_actualizar.IconRightVisible = true;
            this.btn_actualizar.IconRightZoom = 0D;
            this.btn_actualizar.IconVisible = true;
            this.btn_actualizar.IconZoom = 90D;
            this.btn_actualizar.IsTab = false;
            this.btn_actualizar.Location = new System.Drawing.Point(298, 78);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Normalcolor = System.Drawing.Color.White;
            this.btn_actualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_actualizar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.selected = false;
            this.btn_actualizar.Size = new System.Drawing.Size(120, 36);
            this.btn_actualizar.TabIndex = 26;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_actualizar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Activecolor = System.Drawing.Color.White;
            this.btn_Nuevo.AllowDrop = true;
            this.btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Nuevo.BorderRadius = 7;
            this.btn_Nuevo.ButtonText = "Nuevo";
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Nuevo.Iconimage = null;
            this.btn_Nuevo.Iconimage_right = null;
            this.btn_Nuevo.Iconimage_right_Selected = null;
            this.btn_Nuevo.Iconimage_Selected = null;
            this.btn_Nuevo.IconMarginLeft = 0;
            this.btn_Nuevo.IconMarginRight = 0;
            this.btn_Nuevo.IconRightVisible = true;
            this.btn_Nuevo.IconRightZoom = 0D;
            this.btn_Nuevo.IconVisible = true;
            this.btn_Nuevo.IconZoom = 90D;
            this.btn_Nuevo.IsTab = false;
            this.btn_Nuevo.Location = new System.Drawing.Point(170, 78);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Normalcolor = System.Drawing.Color.White;
            this.btn_Nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Nuevo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Nuevo.selected = false;
            this.btn_Nuevo.Size = new System.Drawing.Size(120, 36);
            this.btn_Nuevo.TabIndex = 25;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Nuevo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Nuevo.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.White;
            this.btn_Eliminar.AllowDrop = true;
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.BorderRadius = 7;
            this.btn_Eliminar.ButtonText = "Eliminar";
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Iconimage = null;
            this.btn_Eliminar.Iconimage_right = null;
            this.btn_Eliminar.Iconimage_right_Selected = null;
            this.btn_Eliminar.Iconimage_Selected = null;
            this.btn_Eliminar.IconMarginLeft = 0;
            this.btn_Eliminar.IconMarginRight = 0;
            this.btn_Eliminar.IconRightVisible = true;
            this.btn_Eliminar.IconRightZoom = 0D;
            this.btn_Eliminar.IconVisible = true;
            this.btn_Eliminar.IconZoom = 90D;
            this.btn_Eliminar.IsTab = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(42, 78);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.White;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(120, 36);
            this.btn_Eliminar.TabIndex = 24;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.AllowDrop = true;
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Agregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.BorderRadius = 7;
            this.btn_Agregar.ButtonText = "Agregar";
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.DisabledColor = System.Drawing.Color.White;
            this.btn_Agregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Iconimage = null;
            this.btn_Agregar.Iconimage_right = null;
            this.btn_Agregar.Iconimage_right_Selected = null;
            this.btn_Agregar.Iconimage_Selected = null;
            this.btn_Agregar.IconMarginLeft = 0;
            this.btn_Agregar.IconMarginRight = 0;
            this.btn_Agregar.IconRightVisible = true;
            this.btn_Agregar.IconRightZoom = 0D;
            this.btn_Agregar.IconVisible = true;
            this.btn_Agregar.IconZoom = 90D;
            this.btn_Agregar.IsTab = false;
            this.btn_Agregar.Location = new System.Drawing.Point(426, 78);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Agregar.selected = false;
            this.btn_Agregar.Size = new System.Drawing.Size(120, 36);
            this.btn_Agregar.TabIndex = 23;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Agregar.Textcolor = System.Drawing.Color.White;
            this.btn_Agregar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txt_nombre_tip_recibo
            // 
            this.txt_nombre_tip_recibo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_tip_recibo.Location = new System.Drawing.Point(228, 28);
            this.txt_nombre_tip_recibo.Name = "txt_nombre_tip_recibo";
            this.txt_nombre_tip_recibo.Size = new System.Drawing.Size(220, 27);
            this.txt_nombre_tip_recibo.TabIndex = 1;
            // 
            // dgv_tipos_recibos
            // 
            this.dgv_tipos_recibos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tipos_recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipos_recibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tiporecibo,
            this.nombre_tiporecibo});
            this.dgv_tipos_recibos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_tipos_recibos.Location = new System.Drawing.Point(0, 131);
            this.dgv_tipos_recibos.Name = "dgv_tipos_recibos";
            this.dgv_tipos_recibos.Size = new System.Drawing.Size(588, 197);
            this.dgv_tipos_recibos.TabIndex = 0;
            this.dgv_tipos_recibos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tipos_recibos_CellMouseClick);
            // 
            // id_tiporecibo
            // 
            this.id_tiporecibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_tiporecibo.DataPropertyName = "id_tiporecibo";
            this.id_tiporecibo.HeaderText = "Codigo";
            this.id_tiporecibo.Name = "id_tiporecibo";
            // 
            // nombre_tiporecibo
            // 
            this.nombre_tiporecibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_tiporecibo.DataPropertyName = "nombre_tiporecibo";
            this.nombre_tiporecibo.HeaderText = "Nombre";
            this.nombre_tiporecibo.Name = "nombre_tiporecibo";
            // 
            // frm_AdmTiposRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_BarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdmTiposRecibo";
            this.Text = "frm_AdmTiposRecibo";
            this.pnl_BarraEstado.ResumeLayout(false);
            this.pnl_BarraEstado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipos_recibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BarraEstado;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tipos_recibos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre_tip_recibo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_actualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tiporecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tiporecibo;
    }
}