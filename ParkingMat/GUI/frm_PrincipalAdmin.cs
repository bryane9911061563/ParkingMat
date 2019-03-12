using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingMat.BO;

namespace ParkingMat.GUI
{
    public partial class frm_PrincipalAdmin : Form
    {
        Cls_AppRunning objRUnning = new Cls_AppRunning();

        public frm_PrincipalAdmin()
        {
            InitializeComponent();


            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            AbrirFormularios<frm_AdminSucursales>();
            lbl_inrunning.Text = "Admin. Sucursal";
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
            objRUnning.AppExecut1 = 1;
            pick_iconRunning.Image = Image.FromFile(objRUnning.CambiaFoto());
            lbl_inrunning.Text = "Admin. Sucursal";
            AbrirFormularios<frm_AdminSucursales>();

        }

        private void btn_adminEmpleados_Click(object sender, EventArgs e)
        {
            objRUnning.AppExecut1 = 2;
            pick_iconRunning.Image = Image.FromFile(objRUnning.CambiaFoto());
            lbl_inrunning.Text = "Admin. Empleados";

            AbrirFormularios<frm_AdminEmpleados>();
        }

        private void btn_adminPensionados_Click(object sender, EventArgs e)
        {
            objRUnning.AppExecut1 = 3;
            pick_iconRunning.Image = Image.FromFile(objRUnning.CambiaFoto());
            lbl_inrunning.Text = "Admin. Pensionados";

            AbrirFormularios<frm_AdminPensionados>();
        }

        private void btn_adminRecibos_Click(object sender, EventArgs e)
        {
            objRUnning.AppExecut1 = 4;
            pick_iconRunning.Image = Image.FromFile(objRUnning.CambiaFoto());
            lbl_inrunning.Text = "Admin. Recibos";

            AbrirFormularios<frm_AdminRecibos>();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            objRUnning.AppExecut1 = 5;
            pick_iconRunning.Image = Image.FromFile(objRUnning.CambiaFoto());
            lbl_inrunning.Text = "Admin. Reportes";
        }

        private void btn_vercajones_Click(object sender, EventArgs e)
        {
            AbrirFormularios<A_EjemploBotonCajon>();
        }

        private void pnl_tarjetaCoches_MouseHover(object sender, EventArgs e)
        {
            pnl_tarjetaCoches.BackColor = Color.Red;
        }
    }
}
