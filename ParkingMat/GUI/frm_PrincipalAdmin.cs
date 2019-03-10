using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMat.GUI
{
    public partial class frm_PrincipalAdmin : Form
    {

        public frm_PrincipalAdmin()
        {
            InitializeComponent();


            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            AbrirFormularios<frm_AdminSucursales>();
        }

        private void frm_PrincipalAdmin_Load(object sender, EventArgs e)
        {

        }
        //Metodo para ejecutar formularios dentro del panel
        public void AbrirFormularios<MiForm>() where MiForm:Form, new()
        {
            Form formulario;
            formulario = pnl_centro.Controls.OfType<MiForm>().FirstOrDefault();

            if(formulario==null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnl_centro.Controls.Add(formulario);
                pnl_centro.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }

        }
        

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_SalirDialog objSalir = new frm_SalirDialog();
            objSalir.ShowDialog();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_vermasCars_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_AdminSucursales>();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
        //    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

        //    //base.OnPaint(e);
        //    //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        //}

    }
}
