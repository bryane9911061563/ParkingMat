namespace ParkingMat.GUI
{
    partial class frm_ERROR_DIALOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ERROR_DIALOG));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pick_alert = new System.Windows.Forms.PictureBox();
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pick_alert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "No se ha logrado ejecutar la solicitud!!";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Salir.AllowDrop = true;
            this.btn_Salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.BorderRadius = 7;
            this.btn_Salir.ButtonText = "Aceptar";
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
            this.btn_Salir.IconZoom = 90D;
            this.btn_Salir.IsTab = false;
            this.btn_Salir.Location = new System.Drawing.Point(138, 173);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Salir.OnHovercolor = System.Drawing.Color.Red;
            this.btn_Salir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Salir.selected = false;
            this.btn_Salir.Size = new System.Drawing.Size(179, 45);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Aceptar";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salir.Textcolor = System.Drawing.Color.White;
            this.btn_Salir.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pick_alert
            // 
            this.pick_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pick_alert.Image = ((System.Drawing.Image)(resources.GetObject("pick_alert.Image")));
            this.pick_alert.Location = new System.Drawing.Point(0, 7);
            this.pick_alert.Name = "pick_alert";
            this.pick_alert.Size = new System.Drawing.Size(472, 124);
            this.pick_alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pick_alert.TabIndex = 7;
            this.pick_alert.TabStop = false;
            // 
            // icon_delay
            // 
            this.icon_delay.Enabled = true;
            this.icon_delay.Interval = 950;
            this.icon_delay.Tick += new System.EventHandler(this.icon_delay_Tick);
            // 
            // frm_ERROR_DIALOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(472, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pick_alert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ERROR_DIALOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ERROR_DIALOG";
            ((System.ComponentModel.ISupportInitialize)(this.pick_alert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Salir;
        private System.Windows.Forms.PictureBox pick_alert;
        private System.Windows.Forms.Timer icon_delay;
    }
}