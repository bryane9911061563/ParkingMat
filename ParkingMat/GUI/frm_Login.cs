using ParkingMat.BO;
using ParkingMat.DAO;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if(txt_correo.Text=="Correo electrónico")
            {
                txt_correo.Text = "";
                txt_correo.ForeColor = Color.Black;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (txt_correo.Text == "")
            {
                txt_correo.Text = "Correo electrónico";
                txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_contrase_Enter(object sender, EventArgs e)
        {
            if (txt_contrase.Text == "Contraseña")
            {
                txt_contrase.Text = "";
                txt_contrase.ForeColor = Color.Black;
                txt_contrase.isPassword = true;
            }
        }

        private void txt_contrase_Leave(object sender, EventArgs e)
        {
            if (txt_contrase.Text == "")
            {
                txt_contrase.Text = "Contraseña";
                txt_contrase.ForeColor = Color.LightGray;
                txt_contrase.isPassword = false;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            Jefe_BO jefe = new Jefe_BO();
            Empleado_BO empleado = new Empleado_BO();


            if (jefe.Nombre==txt_correo.Text && jefe.Clave==txt_contrase.Text) {
                frm_MenuSelectSucursales obj = new frm_MenuSelectSucursales();
                obj.Show();
                this.Hide();
            }
            else
            {
                Empleado_DAO verificar = new Empleado_DAO();

                int sucursal = verificar.Iniciar_Sesion(txt_correo.Text, txt_contrase.Text);
                if (sucursal>=0)
                {
                    Cls_Static_UsuarioRunningThisMoment Sucursal = new Cls_Static_UsuarioRunningThisMoment();
                    Cls_Static_UsuarioRunningThisMoment.id_Sucursal = sucursal;

                    frm_MenuEmpleado objMenu = new frm_MenuEmpleado(sucursal);
                    objMenu.Show();
                    this.Hide();
                }
                else
                {
                    pick_USNOVALID.Visible = true;
                    lbl_USNOVALID.Visible = true;
                }
            }
        }
    }
}
