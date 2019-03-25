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
            frm_AgregarVehiculo objAgregarVehiculo = new frm_AgregarVehiculo(1,1);
            objAgregarVehiculo.ShowDialog();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (txt_direccion.Text != "" && txt_nombre.Text != "" && mtx_apertura.Text != "" && mtx_cierre.Text != "" && mtx_Telefono.Text != "" && mtx_Cajones.Text != "")
            {
                Sucursal_BO sucursal = new Sucursal_BO();
                sucursal.Nombre = txt_nombre.Text;
                sucursal.Direccion = txt_direccion.Text;
                sucursal.Horario_apaertura = mtx_apertura.Text;
                sucursal.Horario_cierre = mtx_cierre.Text;
                sucursal.Numerotelefonico = mtx_Telefono.Text;
                sucursal.Cantidad_Cajones = int.Parse(mtx_Cajones.Text);
                Sucursal_DAO sucursal_nube = new Sucursal_DAO();
                int respuesta = sucursal_nube.Guardar_Datos(sucursal);
                if(respuesta == 0)
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente de nuevo en un momento");
                    ERROR.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog EXITO = new frm_pruebaDialog();
                    EXITO.ShowDialog();
                }
            }
            else
            {
                frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Verifique llenar los campos");
                ERROR.ShowDialog();
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsLetter(e.KeyChar) permite cualquier caracter entre la a y la z tanto mayusculas como minusculas
            //IsWhiteSpace permite espacio en blanco.
            //'\b' permite poder eliminar caracteres con BackSpace
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar=='"' )
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }
    }
}
