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
using ParkingMat.DAO;

namespace ParkingMat.GUI
{
    public partial class frm_MenuEmpleado : Form
    {

        Cls_ADMIN_DAO obAdminDAO = new Cls_ADMIN_DAO();
        frm_ParkingEmpleado park;
        frm_AdminPensionados pensionados;

        frm_AdminRecibos recivos;
        private int sucursal;
        public frm_MenuEmpleado(int sucu)
        {
            InitializeComponent();
            //Mostrar el numero de empleados

            // MessageBox.Show(obAdminDAO.num_Empleados().ToString());

            /*  lbl_NumEmpleados.Text = obAdminDAO.num_Empleados();

              panelHeight = pnl_top.Height;
              Hidden = false;*/
            sucursal = sucu;
            park = new frm_ParkingEmpleado(sucu,1);
            park.MdiParent = this;
            park.Show();

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
           // AbrirFormularios<frm_ParkingEmpleado>();

        }
        //Metodo para abrir un form dentro del contenedor
        public void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
           /* formulario = pnl_contenedor.Controls.OfType<MiForm>().FirstOrDefault();

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
            }*/

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
            btn_pensionados.Enabled = true;
            btn_recibos.Enabled = true;
            btn_parquimetro.Enabled = false;
            if (pensionados != null)
            {
                pensionados.Close();
            }
            if (recivos != null)
            {
                recivos.Close();
            }
            park = new frm_ParkingEmpleado(sucursal, 1);
            park.MdiParent = this;
            park.StartPosition = FormStartPosition.Manual;
            park.Location = new Point(0, 0);
            park.Width = this.Width;
            park.Show();

        }

        private void btn_vehiculos_Click(object sender, EventArgs e)
        {
           /* if (park != null)
            {
                park.Close();
            }
            if (pensionados != null)
            {
                pensionados.Close();
            }
            if (recivos != null)
            {
                recivos.Close();
            }
            btn_parquimetro.Enabled = true;
            btn_pensionados.Enabled = true;
            btn_recibos.Enabled = true;
            park.Close();
            //AbrirFormularios<frm_VehiculosEmpleado>();
            pnl_indicador.BackColor = Color.FromArgb(230, 142, 138);*/
               
        }

       

        private void btn_pensionados_Click(object sender, EventArgs e)
        {
            if (park != null)
            {
                park.Close();
            }
            if (recivos != null)
            {
                recivos.Close();
            }
            btn_parquimetro.Enabled = true;
            btn_recibos.Enabled = true;
            btn_pensionados.Enabled = false;
            pensionados = new frm_AdminPensionados();
            pensionados.MdiParent = this;
            pensionados.StartPosition = FormStartPosition.Manual;
            pensionados.Location = new Point(0, 0);
            pensionados.es_empleado();
            pensionados.Sucursal_id = sucursal;
            pensionados.Show();

            pnl_indicador.BackColor = Color.FromArgb(250, 235, 166);
           // AbrirFormularios<frm_AdminPensionados>();
            
        }

        private void btn_recibos_Click(object sender, EventArgs e)
        {
            if (park != null)
            {
                park.Close();
            }
            if (pensionados != null)
            {
                pensionados.Close();
            }
            btn_parquimetro.Enabled = true;
            btn_pensionados.Enabled = true;
            btn_recibos.Enabled = false;
            //AbrirFormularios<frm_ReportesEmpleado>();
            recivos = new frm_AdminRecibos();
            recivos.empleado(sucursal);
            recivos.MdiParent = this;
            recivos.StartPosition = FormStartPosition.Manual;
            recivos.Location = new Point(0, 0);
            recivos.Show();
            pnl_indicador.BackColor = Color.FromArgb(213, 186, 223);
            
        }

        private void tmr_Hora_Tick(object sender, EventArgs e)
        {
            CLs_TIempoActual tiempo = new CLs_TIempoActual();
            lbl_hora.Text = tiempo.HoraActualTimer();
        }
    }
}
