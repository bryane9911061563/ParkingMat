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
    public partial class frm_MenuEmpleado : Form
    {


        public frm_MenuEmpleado(int sucu)
        {
            InitializeComponent();

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            AbrirFormularios<frm_ParkingEmpleado>();

        }
        //Metodo para abrir un form dentro del contenedor
        public void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_contenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnl_contenedor.Controls.Add(formulario);
                pnl_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }

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



        frm_ParkingEmpleado park = new frm_ParkingEmpleado();
        //Cambio de color del indicador
        private void btn_parquimetro_Click(object sender, EventArgs e)
        {
            //park.Sucursal1 = Sucursal;
            // park.Visible = true;
            // park.BackColor = Color.FromArgb(115, 194, 125);
            pnl_indicador.BackColor = Color.FromArgb(115, 194, 125);
            AbrirFormularios<frm_ParkingEmpleado>();


        }

        private void btn_vehiculos_Click(object sender, EventArgs e)
        {

            AbrirFormularios<frm_VehiculosEmpleado>();
            pnl_indicador.BackColor = Color.FromArgb(230, 142, 138);
               
        }

       

        private void btn_pensionados_Click(object sender, EventArgs e)
        {
            pnl_indicador.BackColor = Color.FromArgb(250, 235, 166);
            AbrirFormularios<frm_AdminPensionados>();
            
        }

        private void btn_recibos_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_ReportesEmpleado>();
            pnl_indicador.BackColor = Color.FromArgb(213, 186, 223);
            
        }

        private void tmr_Hora_Tick(object sender, EventArgs e)
        {
            CLs_TIempoActual tiempo = new CLs_TIempoActual();
            lbl_hora.Text = tiempo.HoraActualTimer();
        }
    }
}
