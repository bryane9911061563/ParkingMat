using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingMat.DAO;
using ParkingMat.BO;

namespace ParkingMat.GUI
{
    public partial class frm_AdmTiposRecibo : Form
    {
        

        Cls_TipoRecibo_DAO objReciboDAO = new Cls_TipoRecibo_DAO();
        Cls_TipoRecibo_BO objReciboBO = new Cls_TipoRecibo_BO();
        
        public frm_AdmTiposRecibo()
        {
            InitializeComponent();
            dgv_tipos_recibos.DataSource= objReciboDAO.Mostrar_tiposRecibo();
        }
        public void LimpiarCampos()
        {
            txt_nombre_tip_recibo.Clear();
            objReciboBO.Id_tipRecibo = 0;
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {


            if (txt_nombre_tip_recibo.Text != "")
            {
                objReciboBO.Nombre_tipRecibo = txt_nombre_tip_recibo.Text;
                if (objReciboDAO.Agregar_tipoRecibo(objReciboBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Error al guardar");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();

                    LimpiarCampos();
                    dgv_tipos_recibos.DataSource = objReciboDAO.Mostrar_tiposRecibo();

                }
            }

            
        }

        private void dgv_tipos_recibos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(txt_nombre_tip_recibo.Text=="")
            
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un tipo de registro");
                error.ShowDialog();
            }
            else
            {
                objReciboBO.Nombre_tipRecibo = txt_nombre_tip_recibo.Text;
                if (objReciboDAO.Actualizar_tipoRecibo(objReciboBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("No se ha logrado actualizar el registro");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_tipos_recibos.DataSource= objReciboDAO.Mostrar_tiposRecibo();
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(txt_nombre_tip_recibo.Text=="")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un registro");
                error.ShowDialog();
                
                
            }
            else
            {
                objReciboBO.Nombre_tipRecibo = txt_nombre_tip_recibo.Text;
                if (objReciboDAO.Eliminar_tipoRecibo(objReciboBO) == 0)
                {
                    frm_ERROR_DIALOG error1 = new frm_ERROR_DIALOG("No se ha logrado eliminar el registro");
                    error1.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_tipos_recibos.DataSource = objReciboDAO.Mostrar_tiposRecibo();

                }
            }

        }

        private void dgv_tipos_recibos_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;
            objReciboBO.Id_tipRecibo = Convert.ToInt32(dgv_tipos_recibos.Rows[Fila].Cells["id_tipo_recibo"].Value.ToString().TrimEnd());
            txt_nombre_tip_recibo.Text = dgv_tipos_recibos.Rows[Fila].Cells["tipo_recibo"].Value.ToString();
        }
    }
}
