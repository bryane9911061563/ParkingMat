using ParkingMat.BO;
using ParkingMat.DAO;
using System;
using System.Collections;
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
    public partial class frm_AdminEmpleados : Form
    {
        public frm_AdminEmpleados()
        {
            InitializeComponent();
            rbx_Matutino.Checked = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (mtx_Sueldo.Text!=""&& txt_apellido1.Text != "" && txt_apellido2.Text != "" && txt_nombre.Text != "" && cbx_Cargo.Text != "Seleccione" && cbx_Sucursal.Text != "Seleccione" && txt_correo.Text != "" && txt_contraseña.Text !="")
            {
                Empleado_DAO crear = new Empleado_DAO();
                Sucursal_DAO verificar = new Sucursal_DAO();
                Empleado_BO nuevo = new Empleado_BO();
                nuevo.Nombre = txt_nombre.Text;
                nuevo.Apellido_11 = txt_apellido1.Text;
                nuevo.Apellido_21 = txt_apellido2.Text;
                nuevo.Salario_Base = int.Parse(mtx_Sueldo.Text);
                if (rbx_Matutino.Checked) {
                    nuevo.Horario_Trabajo1 = rbx_Matutino.Text;
                }
                else
                {
                    nuevo.Horario_Trabajo1 = rbx_Vespertino.Text;
                }
                nuevo.Puesto = cbx_Cargo.Text;
                nuevo.Correo_Electronico1 = txt_correo.Text;
                nuevo.Clave_Sesion1 = txt_contraseña.Text;
                try
                {
                    nuevo.Id_sucursal = verificar.Asignar_Sucursal(cbx_Sucursal.Text);
                }
                catch (Exception ex)
                {
                   frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                int guardar = crear.Guardar_Datos(nuevo);
                if (guardar ==0)
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                }
            }
            else
            {
                frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("llene todos los campos");
                ERROR.ShowDialog();
            }
        }

        Sucursal_DAO suc = new Sucursal_DAO();
        ArrayList sucursal = new ArrayList();

        private void frm_AdminEmpleados_Load(object sender, EventArgs e)
        {
            Cargar();
        }


        private void Cargar()
        {
            sucursal = suc.lista_Sucursales();
            for (int i = 0; i < sucursal.Count; i++)
            {
                cbx_Sucursal.Items.Add(sucursal[i].ToString());
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void txt_apellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void txt_apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
