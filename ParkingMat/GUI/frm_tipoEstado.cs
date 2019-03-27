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

    public partial class frm_tipoEstado : Form
    {
        Cls_tipo_estado_BO objBO = new Cls_tipo_estado_BO();
        Cls_tipo_estado_DAO objDAO = new Cls_tipo_estado_DAO();
        
        public frm_tipoEstado()
        {
            InitializeComponent();
            dgv_tipos_estados.DataSource = objDAO.Mostrar_tiposEstado();

        }

        public void LimpiarCampos()
        {
            objBO.Id_estado_cajon = 0;
            txt_nombre_tip_estado.Clear();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_tip_estado.Text != "")
            {
                objBO.Estado = txt_nombre_tip_estado.Text;
                if (objDAO.Agregar_tipoEstado(objBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Error al guardar");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();

                    LimpiarCampos();
                    dgv_tipos_estados.DataSource = objDAO.Mostrar_tiposEstado();

                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_tip_estado.Text == "")

            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un tipo de registro");
                error.ShowDialog();
            }
            else
            {
                objBO.Estado = txt_nombre_tip_estado.Text;
                if (objDAO.Actualizar_tipoRecibo(objBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("No se ha logrado actualizar el registro");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_tipos_estados.DataSource = objDAO.Mostrar_tiposEstado();
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_tip_estado.Text == "")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un registro");
                error.ShowDialog();


            }
            else
            {
                objBO.Estado = txt_nombre_tip_estado.Text;
                if (objDAO.Eliminar_tipoEstado(objBO) == 0)
                {
                    frm_ERROR_DIALOG error1 = new frm_ERROR_DIALOG("No se ha logrado eliminar el registro");
                    error1.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_tipos_estados.DataSource = objDAO.Mostrar_tiposEstado();

                }
            }
        }

        private void dgv_tipos_estados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;
            objBO.Id_estado_cajon = Convert.ToInt32(dgv_tipos_estados.Rows[Fila].Cells["id_estado_cajon"].Value.ToString().TrimEnd());
            txt_nombre_tip_estado.Text = dgv_tipos_estados.Rows[Fila].Cells["estado"].Value.ToString();
        }
    }
}
