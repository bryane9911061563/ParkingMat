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
    public partial class frm_MenuEmpleado : Form
    {
        public frm_MenuEmpleado()
        {
            InitializeComponent();
            btn_parquimetro.Height = 47;
            btn_parquimetro.Location = new Point(9, 54);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            frm_CerrarSesionDialog cerrarSesion = new frm_CerrarSesionDialog();
            cerrarSesion.ShowDialog();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_SalirDialog Salir = new frm_SalirDialog();
            Salir.ShowDialog();
        }

        //Cambio de color del indicador
        private void btn_parquimetro_Click(object sender, EventArgs e)
        {
            pnl_indicador.BackColor = Color.FromArgb(115, 194, 125);
            btn_parquimetro.Height = 47;
            btn_parquimetro.Location = new Point(9, 54);

            //vehiculos
            btn_vehiculos.Height = 37;
            btn_vehiculos.Location = new Point(277, 64);
            //Clientes
            btn_clientes.Height = 37;
            btn_clientes.Location = new Point(545, 64);
            //Pensionados
            btn_pensionados.Height = 37;
            btn_pensionados.Location = new Point(813, 64);
            //Recibos
            btn_recibos.Height = 37;
            btn_recibos.Location = new Point(1081, 64);
        }

        private void btn_vehiculos_Click(object sender, EventArgs e)
        {
            pnl_indicador.BackColor = Color.FromArgb(230, 142, 138);
            btn_vehiculos.Height = 47;
            btn_vehiculos.Location = new Point(277, 54);

            //parking
            btn_parquimetro.Height = 37;
            btn_parquimetro.Location = new Point(9, 64);
            //Clientes
            btn_clientes.Height = 37;
            btn_clientes.Location = new Point(545, 64);
            //Pensionados
            btn_pensionados.Height = 37;
            btn_pensionados.Location = new Point(813, 64);
            //Recibos
            btn_recibos.Height = 37;
            btn_recibos.Location = new Point(1081, 64);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            pnl_indicador.BackColor = Color.FromArgb(130, 172, 222);
            btn_clientes.Height = 47;
            btn_clientes.Location = new Point(545, 54);

            //vehiculos
            btn_vehiculos.Height = 37;
            btn_vehiculos.Location = new Point(277, 64);
            //parking
            btn_parquimetro.Height = 37;
            btn_parquimetro.Location = new Point(9, 64);

            //Pensionados
            btn_pensionados.Height = 37;
            btn_pensionados.Location = new Point(813, 64);
            //Recibos
            btn_recibos.Height = 37;
            btn_recibos.Location = new Point(1081, 64);
        }

        private void btn_pensionados_Click(object sender, EventArgs e)
        {
            pnl_indicador.BackColor = Color.FromArgb(250, 235, 166);
            btn_pensionados.Height = 47;
            btn_pensionados.Location = new Point(813, 54);

            //vehiculos
            btn_vehiculos.Height = 37;
            btn_vehiculos.Location = new Point(277, 64);
            //parking
            btn_parquimetro.Height = 37;
            btn_parquimetro.Location = new Point(9, 64);
            //Clientes
            btn_clientes.Height = 37;
            btn_clientes.Location = new Point(545, 64);

            //Recibos
            btn_recibos.Height = 37;
            btn_recibos.Location = new Point(1081, 64);
        }

        private void btn_recibos_Click(object sender, EventArgs e)
        {
            pnl_indicador.BackColor = Color.FromArgb(213, 186, 223);
            btn_recibos.Height = 47;
            btn_recibos.Location = new Point(1081, 54);

            //vehiculos
            btn_vehiculos.Height = 37;
            btn_vehiculos.Location = new Point(277, 64);
            //parking
            btn_parquimetro.Height = 37;
            btn_parquimetro.Location = new Point(9, 64);
            //Clientes
            btn_clientes.Height = 37;
            btn_clientes.Location = new Point(545, 64);
            //Pensionados
            btn_pensionados.Height = 37;
            btn_pensionados.Location = new Point(813, 64);
        }
    }
}
