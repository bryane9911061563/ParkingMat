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
    public partial class frm_PuestosEmpleados : Form
    {
        Cls_PuestoEmpleado_BO objPuestoBO = new Cls_PuestoEmpleado_BO();
        Cls_PuestoEmpleado_DAO objPuestoDAO = new Cls_PuestoEmpleado_DAO();

        public frm_PuestosEmpleados()
        {
            InitializeComponent();
            dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();
        }
        public void LimpiarCampos()
        {
            txt_nombre_puesto.Clear();
            objPuestoBO.Id_puestoempleado = 0;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(txt_nombre_puesto.Text!="")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Campos vacios");
                error.ShowDialog();
            }
            else
            {
                objPuestoBO.Nombre_puestoempleado = txt_nombre_puesto.Text;
                if(objPuestoDAO.Agregar_Puesto(objPuestoBO)==0)
                {
                    frm_ERROR_DIALOG errorr = new frm_ERROR_DIALOG("No se ha logrado guardar el registro");
                    errorr.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();
                    LimpiarCampos();

                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_puesto.Text == "")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Campos vacios");
                error.ShowDialog();
            }
            else
            {
                objPuestoBO.Nombre_puestoempleado = txt_nombre_puesto.Text;
                if (objPuestoDAO.Actualizar_Puesto(objPuestoBO) == 0)
                {
                    frm_ERROR_DIALOG errorr = new frm_ERROR_DIALOG("No se ha logrado actualizar el registro");
                    errorr.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();
                    LimpiarCampos();

                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_puesto.Text == "")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Campos vacios");
                error.ShowDialog();
            }
            else
            {
                objPuestoBO.Nombre_puestoempleado = txt_nombre_puesto.Text;
                if (objPuestoDAO.Eliminar_Puesto(objPuestoBO) == 0)
                {
                    frm_ERROR_DIALOG errorr = new frm_ERROR_DIALOG("No se ha logrado eliminar el registro");
                    errorr.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();
                    LimpiarCampos();

                }
            }
        }



        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            if (txt_nombre_puesto.Text != "")
            {
                objPuestoBO.Nombre_puestoempleado = txt_nombre_puesto.Text;
                if (objPuestoDAO.Agregar_Puesto(objPuestoBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Error al guardar");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();

                    LimpiarCampos();
                    dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();

                }
            }
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            if (txt_nombre_puesto.Text == "")

            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un tipo puesto de empleado");
                error.ShowDialog();
            }
            else
            {
                objPuestoBO.Nombre_puestoempleado = txt_nombre_puesto.Text;
                if (objPuestoDAO.Actualizar_Puesto(objPuestoBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("No se ha logrado actualizar el registro");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();
                }
            }
        }

        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (txt_nombre_puesto.Text == "")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un puesto");
                error.ShowDialog();


            }
            else
            {
                objPuestoBO.Nombre_puestoempleado = txt_nombre_puesto.Text;
                if (objPuestoDAO.Eliminar_Puesto(objPuestoBO) == 0)
                {
                    frm_ERROR_DIALOG error1 = new frm_ERROR_DIALOG("No se ha logrado eliminar");

                    error1.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_puestos_empleados.DataSource = objPuestoDAO.MostrarPuestos();

                }
            }
        }

        private void dgv_puestos_empleados_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;
            objPuestoBO.Id_puestoempleado = Convert.ToInt32(dgv_puestos_empleados.Rows[Fila].Cells["id_puesto"].Value.ToString().TrimEnd());
            txt_nombre_puesto.Text = dgv_puestos_empleados.Rows[Fila].Cells["Puesto"].Value.ToString();

        }
    }
}
