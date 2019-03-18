namespace ParkingMat.GUI
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pnl_centro = new System.Windows.Forms.Panel();
            this.pnl_fontLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_IniciarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_contrase = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_correo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_USNOVALID = new System.Windows.Forms.Label();
            this.pick_USNOVALID = new System.Windows.Forms.PictureBox();
            this.pnl_centro.SuspendLayout();
            this.pnl_fontLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_USNOVALID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_centro
            // 
            this.pnl_centro.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_centro.Controls.Add(this.pnl_fontLogin);
            this.pnl_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_centro.Location = new System.Drawing.Point(0, 0);
            this.pnl_centro.Name = "pnl_centro";
            this.pnl_centro.Size = new System.Drawing.Size(585, 587);
            this.pnl_centro.TabIndex = 0;
            // 
            // pnl_fontLogin
            // 
            this.pnl_fontLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_fontLogin.BackColor = System.Drawing.Color.White;
            this.pnl_fontLogin.Controls.Add(this.pick_USNOVALID);
            this.pnl_fontLogin.Controls.Add(this.lbl_USNOVALID);
            this.pnl_fontLogin.Controls.Add(this.pictureBox1);
            this.pnl_fontLogin.Controls.Add(this.label2);
            this.pnl_fontLogin.Controls.Add(this.label1);
            this.pnl_fontLogin.Controls.Add(this.btn_Cerrar);
            this.pnl_fontLogin.Controls.Add(this.btn_IniciarSesion);
            this.pnl_fontLogin.Controls.Add(this.txt_contrase);
            this.pnl_fontLogin.Controls.Add(this.txt_correo);
            this.pnl_fontLogin.Location = new System.Drawing.Point(50, 75);
            this.pnl_fontLogin.Name = "pnl_fontLogin";
            this.pnl_fontLogin.Size = new System.Drawing.Size(485, 437);
            this.pnl_fontLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(169, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iniciar sesión";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(172, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "arkingMat";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Activecolor = System.Drawing.Color.White;
            this.btn_Cerrar.AllowDrop = true;
            this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cerrar.BackColor = System.Drawing.Color.White;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cerrar.BorderRadius = 7;
            this.btn_Cerrar.ButtonText = "Cerrar";
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btn_Cerrar.Location = new System.Drawing.Point(60, 349);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Normalcolor = System.Drawing.Color.White;
            this.btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Cerrar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cerrar.selected = false;
            this.btn_Cerrar.Size = new System.Drawing.Size(179, 48);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cerrar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cerrar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btn_IniciarSesion.AllowDrop = true;
            this.btn_IniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btn_IniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IniciarSesion.BorderRadius = 7;
            this.btn_IniciarSesion.ButtonText = "Iniciar sesión";
            this.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IniciarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.btn_IniciarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_IniciarSesion.Iconimage = null;
            this.btn_IniciarSesion.Iconimage_right = null;
            this.btn_IniciarSesion.Iconimage_right_Selected = null;
            this.btn_IniciarSesion.Iconimage_Selected = null;
            this.btn_IniciarSesion.IconMarginLeft = 0;
            this.btn_IniciarSesion.IconMarginRight = 0;
            this.btn_IniciarSesion.IconRightVisible = true;
            this.btn_IniciarSesion.IconRightZoom = 0D;
            this.btn_IniciarSesion.IconVisible = true;
            this.btn_IniciarSesion.IconZoom = 90D;
            this.btn_IniciarSesion.IsTab = false;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(245, 349);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btn_IniciarSesion.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btn_IniciarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_IniciarSesion.selected = false;
            this.btn_IniciarSesion.Size = new System.Drawing.Size(179, 48);
            this.btn_IniciarSesion.TabIndex = 0;
            this.btn_IniciarSesion.Text = "Iniciar sesión";
            this.btn_IniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_IniciarSesion.Textcolor = System.Drawing.Color.White;
            this.btn_IniciarSesion.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // txt_contrase
            // 
            this.txt_contrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contrase.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.txt_contrase.BorderColorIdle = System.Drawing.Color.Gray;
            this.txt_contrase.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_contrase.BorderThickness = 2;
            this.txt_contrase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contrase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_contrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contrase.isPassword = false;
            this.txt_contrase.Location = new System.Drawing.Point(57, 248);
            this.txt_contrase.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contrase.Name = "txt_contrase";
            this.txt_contrase.Size = new System.Drawing.Size(370, 44);
            this.txt_contrase.TabIndex = 2;
            this.txt_contrase.Text = "Contraseña";
            this.txt_contrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_contrase.Enter += new System.EventHandler(this.txt_contrase_Enter);
            this.txt_contrase.Leave += new System.EventHandler(this.txt_contrase_Leave);
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_correo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.txt_correo.BorderColorIdle = System.Drawing.Color.Gray;
            this.txt_correo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_correo.BorderThickness = 2;
            this.txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo.isPassword = false;
            this.txt_correo.Location = new System.Drawing.Point(57, 175);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(370, 44);
            this.txt_correo.TabIndex = 1;
            this.txt_correo.Text = "Correo electrónico";
            this.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_correo.Enter += new System.EventHandler(this.txt_correo_Enter);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // login
            // 
            this.login.ElipseRadius = 25;
            this.login.TargetControl = this.pnl_fontLogin;
            // 
            // lbl_USNOVALID
            // 
            this.lbl_USNOVALID.AutoSize = true;
            this.lbl_USNOVALID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_USNOVALID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_USNOVALID.ForeColor = System.Drawing.Color.Red;
            this.lbl_USNOVALID.Location = new System.Drawing.Point(79, 296);
            this.lbl_USNOVALID.Name = "lbl_USNOVALID";
            this.lbl_USNOVALID.Size = new System.Drawing.Size(184, 16);
            this.lbl_USNOVALID.TabIndex = 6;
            this.lbl_USNOVALID.Text = "Usuario o contraseña no validos!";
            this.lbl_USNOVALID.Visible = false;
            // 
            // pick_USNOVALID
            // 
            this.pick_USNOVALID.Image = ((System.Drawing.Image)(resources.GetObject("pick_USNOVALID.Image")));
            this.pick_USNOVALID.Location = new System.Drawing.Point(57, 296);
            this.pick_USNOVALID.Name = "pick_USNOVALID";
            this.pick_USNOVALID.Size = new System.Drawing.Size(16, 16);
            this.pick_USNOVALID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pick_USNOVALID.TabIndex = 7;
            this.pick_USNOVALID.TabStop = false;
            this.pick_USNOVALID.Visible = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 587);
            this.Controls.Add(this.pnl_centro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.pnl_centro.ResumeLayout(false);
            this.pnl_fontLogin.ResumeLayout(false);
            this.pnl_fontLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pick_USNOVALID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_centro;
        private System.Windows.Forms.Panel pnl_fontLogin;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse login;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_contrase;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_correo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_IniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pick_USNOVALID;
        private System.Windows.Forms.Label lbl_USNOVALID;
    }
}