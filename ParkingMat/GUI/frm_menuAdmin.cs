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
    public partial class frm_menuAdmin : Form
    {
        int panelHeight;
        bool Hidden;

        public frm_menuAdmin()
        {
            InitializeComponent();
            panelHeight = pnl_top.Height;
            Hidden = false;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        //Metodo para abrir dentro del container
        public void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_centro.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
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

        private void btn_expandir_contraer_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hidden)
            {
                pnl_top.Height = pnl_top.Height + 20;

                btn_adminSucursalMinimal.Visible = false;
                btn_adminEmpleadosMinimal.Visible = false;
                btn_adminPensionadosMinimal.Visible = false;
                btn_adminRecibosminimal.Visible = false;
                btn_adminReportMinimal.Visible = false;

                btn_expandir_contraer2.Visible = false;
                btn_expandir_contraer.Visible = true;
                pnl_barratop.Height = 46;

                if (pnl_top.Height>=panelHeight)
                {
                    timer1.Stop();
                    Hidden = false;
                    

                    

                    this.Refresh();

                }
            }
            else
            {


                pnl_top.Height = pnl_top.Height - 20;
                

                btn_adminSucursalMinimal.Visible = true;
                btn_adminEmpleadosMinimal.Visible = true;
                btn_adminPensionadosMinimal.Visible = true;
                btn_adminRecibosminimal.Visible = true;
                btn_adminReportMinimal.Visible = true;

                btn_expandir_contraer.Visible = false;
                btn_expandir_contraer2.Visible = true;


                if (pnl_top.Height<=0)
                {
                    timer1.Stop();
                    pnl_barratop.Height = 95;


                    Hidden = true;

                    this.Refresh();
                }
            }
        }

        private void btn_expandir_contraer2_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            frm_SalirDialog salir = new frm_SalirDialog();
            salir.ShowDialog();
        }

        private void pnl_tarjetaCoches_MouseHover(object sender, EventArgs e)
        {
            pnl_tarjetaCoches.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void pnl_tarjetaEmpleados_MouseHover(object sender, EventArgs e)
        {
            pnl_tarjetaEmpleados.BackColor = Color.FromArgb(229, 229, 229);

        }

        private void pnl_tarjetaPensionados_MouseHover(object sender, EventArgs e)
        {
            pnl_tarjetaPensionados.BackColor = Color.FromArgb(229, 229, 229);

        }

        private void pnl_tarjetaRecibos_MouseHover(object sender, EventArgs e)
        {
            pnl_tarjetaRecibos.BackColor = Color.FromArgb(229, 229, 229);

        }

        private void pnl_tarjetaReportes_MouseHover(object sender, EventArgs e)
        {
            pnl_tarjetaReportes.BackColor = Color.FromArgb(229, 229, 229);

        }

        private void pnl_tarjetaCoches_MouseHover_1(object sender, EventArgs e)
        {
            pnl_tarjetaCoches.BackColor = Color.FromArgb(229, 229, 229);

        }

        private void pnl_tarjetaCoches_MouseLeave(object sender, EventArgs e)
        {
            pnl_tarjetaCoches.BackColor = Color.FromArgb(115, 194, 125);

        }

        private void pnl_tarjetaEmpleados_MouseLeave(object sender, EventArgs e)
        {
            pnl_tarjetaEmpleados.BackColor = Color.FromArgb(230, 142, 138);

        }

        private void pnl_tarjetaPensionados_MouseLeave(object sender, EventArgs e)
        {
            pnl_tarjetaPensionados.BackColor = Color.FromArgb(130, 172, 222);

        }

        private void pnl_tarjetaRecibos_MouseLeave(object sender, EventArgs e)
        {
            pnl_tarjetaRecibos.BackColor = Color.FromArgb(250, 235, 166);

        }

        private void pnl_tarjetaReportes_MouseLeave(object sender, EventArgs e)
        {
            pnl_tarjetaReportes.BackColor = Color.FromArgb(213, 186, 223);

        }

        private void pnl_tarjetaEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormularios<frm_AdminEmpleados>();
        }

        private void pnl_tarjetaPensionados_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormularios<frm_AdminPensionados>();
        }

        private void btn_adminEmpleadosMinimal_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_AdminEmpleados>();

        }

        private void btn_adminPensionadosMinimal_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_AdminPensionados>();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            frm_CerrarSesionDialog objDialogSesion = new frm_CerrarSesionDialog();

            objDialogSesion.ShowDialog();
        }

        private void btn_adminSucursalMinimal_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_AdminSucursales>();

        }

        private void btn_adminRecibosminimal_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_AdminRecibos>();

        }

        private void btn_adminReportMinimal_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frm_AdmiReportes>();
        }

        private void pnl_tarjetaCoches_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormularios<frm_AdminSucursales>();
        }

        private void pnl_tarjetaRecibos_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormularios<frm_AdminRecibos>();

        }

        private void pnl_tarjetaReportes_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirFormularios<frm_AdmiReportes>();

        }
    }
}
