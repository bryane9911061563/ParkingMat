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
    public partial class frm_tipoVehiculo : Form
    {
        Cls_tipoVehiculo ObjtipVeBO = new Cls_tipoVehiculo();
        Cls_tipoVehiculoDAO ObjtipveDAO = new Cls_tipoVehiculoDAO();
        
        public frm_tipoVehiculo()
        {
            InitializeComponent();
            dgv_tipos_vehiculo.DataSource = ObjtipveDAO.Mostrar_tiposVehiculo();

        }

        public void LimpiarCampos()
        {
            ObjtipVeBO.Id_tipo_vehiculo = 0;
            txt_nombre_tip_vehiculo.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_tip_vehiculo.Text != "")
            {
                ObjtipVeBO.Tipo_vehiculo = txt_nombre_tip_vehiculo.Text;
                if (ObjtipveDAO.Agregar_tipoVehiculo(ObjtipVeBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Error al guardar");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();

                    LimpiarCampos();
                    dgv_tipos_vehiculo.DataSource = ObjtipveDAO.Mostrar_tiposVehiculo();

                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_tip_vehiculo.Text == "")

            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un tipo de registro");
                error.ShowDialog();
            }
            else
            {
                ObjtipVeBO.Tipo_vehiculo = txt_nombre_tip_vehiculo.Text;
                if (ObjtipveDAO.Actualizar_tipoRecibo(ObjtipVeBO) == 0)
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("No se ha logrado actualizar el registro");
                    error.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_tipos_vehiculo.DataSource = ObjtipveDAO.Mostrar_tiposVehiculo();
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_tip_vehiculo.Text == "")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un registro");
                error.ShowDialog();


            }
            else
            {
                ObjtipVeBO.Tipo_vehiculo = txt_nombre_tip_vehiculo.Text;
                if (ObjtipveDAO.Eliminar_tipoVehiculo(ObjtipVeBO) == 0)
                {
                    frm_ERROR_DIALOG error1 = new frm_ERROR_DIALOG("No se ha logrado eliminar el registro");
                    error1.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    LimpiarCampos();
                    dgv_tipos_vehiculo.DataSource = ObjtipveDAO.Mostrar_tiposVehiculo();

                }
            }
        }

        private void dgv_tipos_vehiculo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;
            ObjtipVeBO.Id_tipo_vehiculo = Convert.ToInt32(dgv_tipos_vehiculo.Rows[Fila].Cells["id_tipo_vehiculo"].Value.ToString().TrimEnd());
            txt_nombre_tip_vehiculo.Text = dgv_tipos_vehiculo.Rows[Fila].Cells["tipo_vehiculo"].Value.ToString();
        }
    }
}
