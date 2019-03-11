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
    public partial class frm_AdminSucursales : Form
    {
        public frm_AdminSucursales()
        {
            InitializeComponent();
        }

        private void btn_vervehiculo_Click(object sender, EventArgs e)
        {
            frmAdminVehiculo objVehiculo = new frmAdminVehiculo();
            objVehiculo.ShowDialog();
        }

        private void btn_agregarvehiculo_Click(object sender, EventArgs e)
        {
            frm_AgregarVehiculo objAgregarVehiculo = new frm_AgregarVehiculo();
            objAgregarVehiculo.ShowDialog();
        }
    }
}
