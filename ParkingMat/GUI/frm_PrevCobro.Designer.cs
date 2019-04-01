namespace ParkingMat.GUI
{
    partial class frm_PrevCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PrevCobro));
            this.pnl_BarraEstado = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_sucursal = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.btn_imprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_BarraEstado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BarraEstado
            // 
            this.pnl_BarraEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BarraEstado.BackgroundImage")));
            this.pnl_BarraEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BarraEstado.Controls.Add(this.btn_cerrar);
            this.pnl_BarraEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BarraEstado.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.pnl_BarraEstado.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnl_BarraEstado.GradientTopLeft = System.Drawing.Color.White;
            this.pnl_BarraEstado.GradientTopRight = System.Drawing.Color.White;
            this.pnl_BarraEstado.Location = new System.Drawing.Point(0, 0);
            this.pnl_BarraEstado.Name = "pnl_BarraEstado";
            this.pnl_BarraEstado.Quality = 10;
            this.pnl_BarraEstado.Size = new System.Drawing.Size(395, 31);
            this.pnl_BarraEstado.TabIndex = 7;
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
            this.btn_cerrar.Location = new System.Drawing.Point(367, 1);
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
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.lbl_tipo);
            this.panel1.Controls.Add(this.lbl_sucursal);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.lbl_no);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_costo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 489);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(133, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECIBO";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_BarraEstado;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "*********************************************************";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(22, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(22, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "*********************************************************";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_titulo.Location = new System.Drawing.Point(176, 218);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(51, 20);
            this.lbl_titulo.TabIndex = 6;
            this.lbl_titulo.Text = "[titulo]";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Location = new System.Drawing.Point(27, 245);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(337, 78);
            this.txt_descripcion.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(23, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Costo:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_costo.Location = new System.Drawing.Point(84, 343);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(56, 20);
            this.lbl_costo.TabIndex = 9;
            this.lbl_costo.Text = "[costo]";
            this.lbl_costo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(23, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "No:";
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_no.Location = new System.Drawing.Point(62, 87);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(40, 20);
            this.lbl_no.TabIndex = 11;
            this.lbl_no.Text = "[NO]";
            this.lbl_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_fecha.Location = new System.Drawing.Point(133, 113);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(51, 20);
            this.lbl_fecha.TabIndex = 12;
            this.lbl_fecha.Text = "[titulo]";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sucursal
            // 
            this.lbl_sucursal.AutoSize = true;
            this.lbl_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_sucursal.Location = new System.Drawing.Point(103, 141);
            this.lbl_sucursal.Name = "lbl_sucursal";
            this.lbl_sucursal.Size = new System.Drawing.Size(51, 20);
            this.lbl_sucursal.TabIndex = 13;
            this.lbl_sucursal.Text = "[titulo]";
            this.lbl_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_tipo.Location = new System.Drawing.Point(71, 170);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(51, 20);
            this.lbl_tipo.TabIndex = 14;
            this.lbl_tipo.Text = "[titulo]";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.AllowDrop = true;
            this.btn_imprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_imprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.BorderRadius = 7;
            this.btn_imprimir.ButtonText = "";
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.DisabledColor = System.Drawing.Color.White;
            this.btn_imprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_imprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Iconimage")));
            this.btn_imprimir.Iconimage_right = null;
            this.btn_imprimir.Iconimage_right_Selected = null;
            this.btn_imprimir.Iconimage_Selected = null;
            this.btn_imprimir.IconMarginLeft = 0;
            this.btn_imprimir.IconMarginRight = 0;
            this.btn_imprimir.IconRightVisible = true;
            this.btn_imprimir.IconRightZoom = 0D;
            this.btn_imprimir.IconVisible = true;
            this.btn_imprimir.IconZoom = 40D;
            this.btn_imprimir.IsTab = false;
            this.btn_imprimir.Location = new System.Drawing.Point(172, 413);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_imprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_imprimir.selected = false;
            this.btn_imprimir.Size = new System.Drawing.Size(50, 48);
            this.btn_imprimir.TabIndex = 46;
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_imprimir.Textcolor = System.Drawing.Color.White;
            this.btn_imprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btn_imprimir, "Imprimir");
            // 
            // frm_PrevCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_BarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PrevCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PrevCobro";
            this.pnl_BarraEstado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BarraEstado;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_sucursal;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_no;
        private Bunifu.Framework.UI.BunifuFlatButton btn_imprimir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}