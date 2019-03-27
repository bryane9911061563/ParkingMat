namespace ParkingMat.GUI
{
    partial class frm_PuestosEmpleados
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
            this.btn_actualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre_puesto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_puestos_empleados = new System.Windows.Forms.DataGridView();
            this.id_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nombre_puesto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 163);
            this.panel1.TabIndex = 34;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Activecolor = System.Drawing.Color.White;
            this.btn_actualizar.AllowDrop = true;
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btn_actualizar.Location = new System.Drawing.Point(297, 86);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Normalcolor = System.Drawing.Color.White;
            this.btn_actualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_actualizar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.selected = false;
            this.btn_actualizar.Size = new System.Drawing.Size(120, 36);
            this.btn_actualizar.TabIndex = 39;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_actualizar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Activecolor = System.Drawing.Color.White;
            this.btn_Nuevo.AllowDrop = true;
            this.btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btn_Nuevo.Location = new System.Drawing.Point(169, 86);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Normalcolor = System.Drawing.Color.White;
            this.btn_Nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Nuevo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Nuevo.selected = false;
            this.btn_Nuevo.Size = new System.Drawing.Size(120, 36);
            this.btn_Nuevo.TabIndex = 38;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Nuevo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Nuevo.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click_1);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Activecolor = System.Drawing.Color.White;
            this.btn_Eliminar.AllowDrop = true;
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(41, 86);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Normalcolor = System.Drawing.Color.White;
            this.btn_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Eliminar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar.selected = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(120, 36);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Eliminar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.AllowDrop = true;
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btn_Agregar.Location = new System.Drawing.Point(425, 86);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btn_Agregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Agregar.selected = false;
            this.btn_Agregar.Size = new System.Drawing.Size(120, 36);
            this.btn_Agregar.TabIndex = 36;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Agregar.Textcolor = System.Drawing.Color.White;
            this.btn_Agregar.TextFont = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre:";
            // 
            // txt_nombre_puesto
            // 
            this.txt_nombre_puesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre_puesto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_puesto.Location = new System.Drawing.Point(227, 50);
            this.txt_nombre_puesto.Name = "txt_nombre_puesto";
            this.txt_nombre_puesto.Size = new System.Drawing.Size(220, 27);
            this.txt_nombre_puesto.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_puestos_empleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 196);
            this.panel2.TabIndex = 35;
            // 
            // dgv_puestos_empleados
            // 
            this.dgv_puestos_empleados.BackgroundColor = System.Drawing.Color.White;
            this.dgv_puestos_empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_puestos_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puestos_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_puesto,
            this.Puesto});
            this.dgv_puestos_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_puestos_empleados.Location = new System.Drawing.Point(0, 0);
            this.dgv_puestos_empleados.Name = "dgv_puestos_empleados";
            this.dgv_puestos_empleados.Size = new System.Drawing.Size(587, 196);
            this.dgv_puestos_empleados.TabIndex = 28;
            this.dgv_puestos_empleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_puestos_empleados_CellMouseClick_1);
            // 
            // id_puesto
            // 
            this.id_puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_puesto.DataPropertyName = "id_puesto";
            this.id_puesto.HeaderText = "Codigo";
            this.id_puesto.Name = "id_puesto";
            // 
            // Puesto
            // 
            this.Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puesto.DataPropertyName = "Puesto";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // frm_PuestosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PuestosEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PuestosEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_actualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre_puesto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_puestos_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
    }
}