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
            frm_PrincipalAdmin obj = new frm_PrincipalAdmin();
            obj.Show();
            this.Hide();
        }
    }
}
