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
    public partial class frm_ReportesEmpleado : Form
    {
        public frm_ReportesEmpleado()
        {
            InitializeComponent();
        }

        public void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_Contenedor.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnl_Contenedor.Controls.Add(formulario);
                pnl_Contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Puestos de empleados")
            {
                AbrirFormularios<frm_PuestosEmpleados>();
            }
            if (comboBox1.Text == "Motivos de recibo") 
            {
                AbrirFormularios<frm_AdmTiposRecibo>();
            }
            if (comboBox1.Text == "Tipos de Vehiculos")
            {
                AbrirFormularios<frm_tipoVehiculo>();
            }
            if (comboBox1.Text == "Estados de cajones")
            {
                AbrirFormularios<frm_tipoEstado>();
            }

        }
    }
}
