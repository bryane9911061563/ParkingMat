namespace ParkingMat.GUI
{
    partial class frm_CerrarSesionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CerrarSesionDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cerrar_Sesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_BarraEstado = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Cerrar_Sesion);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 232);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Se realizara el reporte del turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Está seguro que desea cerrar sesión?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Activecolor = System.Drawing.Color.White;
            this.btn_Cancelar.AllowDrop = true;
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancelar.BorderRadius = 7;
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.Iconimage = null;
            this.btn_Cancelar.Iconimage_right = null;
            this.btn_Cancelar.Iconimage_right_Selected = null;
            this.btn_Cancelar.Iconimage_Selected = null;
            this.btn_Cancelar.IconMarginLeft = 0;
            this.btn_Cancelar.IconMarginRight = 0;
            this.btn_Cancelar.IconRightVisible = true;
            this.btn_Cancelar.IconRightZoom = 0D;
            this.btn_Cancelar.IconVisible = true;
            this.btn_Cancelar.IconZoom = 90D;
            this.btn_Cancelar.IsTab = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(95, 159);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Normalcolor = System.Drawing.Color.White;
            this.btn_Cancelar.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_Cancelar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.selected = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(179, 48);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cerrar_Sesion
            // 
            this.btn_Cerrar_Sesion.Activecolor = System.Drawing.Color.Crimson;
            this.btn_Cerrar_Sesion.AllowDrop = true;
            this.btn_Cerrar_Sesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cerrar_Sesion.BackColor = System.Drawing.Color.Crimson;
            this.btn_Cerrar_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cerrar_Sesion.BorderRadius = 7;
            this.btn_Cerrar_Sesion.ButtonText = "Cerrar sesión";
            this.btn_Cerrar_Sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar_Sesion.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cerrar_Sesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cerrar_Sesion.Iconimage = null;
            this.btn_Cerrar_Sesion.Iconimage_right = null;
            this.btn_Cerrar_Sesion.Iconimage_right_Selected = null;
            this.btn_Cerrar_Sesion.Iconimage_Selected = null;
            this.btn_Cerrar_Sesion.IconMarginLeft = 0;
            this.btn_Cerrar_Sesion.IconMarginRight = 0;
            this.btn_Cerrar_Sesion.IconRightVisible = true;
            this.btn_Cerrar_Sesion.IconRightZoom = 0D;
            this.btn_Cerrar_Sesion.IconVisible = true;
            this.btn_Cerrar_Sesion.IconZoom = 90D;
            this.btn_Cerrar_Sesion.IsTab = false;
            this.btn_Cerrar_Sesion.Location = new System.Drawing.Point(297, 159);
            this.btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
            this.btn_Cerrar_Sesion.Normalcolor = System.Drawing.Color.Crimson;
            this.btn_Cerrar_Sesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cerrar_Sesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Cerrar_Sesion.selected = false;
            this.btn_Cerrar_Sesion.Size = new System.Drawing.Size(179, 48);
            this.btn_Cerrar_Sesion.TabIndex = 4;
            this.btn_Cerrar_Sesion.Text = "Cerrar sesión";
            this.btn_Cerrar_Sesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cerrar_Sesion.Textcolor = System.Drawing.Color.White;
            this.btn_Cerrar_Sesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar_Sesion.Click += new System.EventHandler(this.btn_Cerrar_Sesion_Click);
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
            this.pnl_BarraEstado.Size = new System.Drawing.Size(569, 31);
            this.pnl_BarraEstado.TabIndex = 8;
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
            this.btn_cerrar.Location = new System.Drawing.Point(541, 1);
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
            // frm_CerrarSesionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_BarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CerrarSesionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CerrarSesionDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_BarraEstado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cerrar_Sesion;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BarraEstado;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cerrar;
    }
}