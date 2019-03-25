using System;
using System.Collections;
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
    
    public partial class frm_AdminPensionados : Form
    {
        Pensionados_BO objPenBO = new Pensionados_BO();
        Pensionados_DAO objPenDAO = new Pensionados_DAO();
        public frm_AdminPensionados()
        {
            InitializeComponent();
            dgv_pensionados.DataSource = objPenDAO.Mostrar_pensionados();
        }

        //Mostrar pensionados
        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string mensaje_error="Error al guardar los datos";
            objPenBO.Nombre_pensionado = txt_nombre.Text;
            objPenBO.Apellido_p_pensionado = txt_apellido_p.Text;
            objPenBO.Apellido_m_pensionado = txt_apellido_m.Text;
            objPenBO.Fecha_nac_pensionado = DateTime.Parse(dtp_fecha_nac.Text);
            objPenBO.Fecha_registro_pensionado = DateTime.Parse(dtp_fecha_reg.Text);
            objPenBO.Fecha_vencimiento_pensionado = DateTime.Parse(dtp_fecha_ven.Text);

            if (objPenDAO.Guardar_pensionado(objPenBO) == 0)
            {
                frm_ERROR_DIALOG frmError = new frm_ERROR_DIALOG(mensaje_error);
                frmError.ShowDialog();
            }
            else
            {
                frm_pruebaDialog frmExito = new frm_pruebaDialog();
                frmExito.ShowDialog();
                dgv_pensionados.DataSource = objPenDAO.Mostrar_pensionados();

            }
        }

        private void dgv_pensionados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila= e.RowIndex; ;
            txt_nombre.Text = dgv_pensionados.Rows[Fila].Cells["nombre"].Value.ToString();
            txt_apellido_p.Text = dgv_pensionados.Rows[Fila].Cells["apellido_m"].Value.ToString();
            txt_apellido_m.Text = dgv_pensionados.Rows[Fila].Cells["apellido_p"].Value.ToString();
            dtp_fecha_nac.Text = dgv_pensionados.Rows[Fila].Cells["fecha_nac"].Value.ToString();
            dtp_fecha_reg.Text = dgv_pensionados.Rows[Fila].Cells["fecha_registro"].Value.ToString();
            dtp_fecha_ven.Text = dgv_pensionados.Rows[Fila].Cells["fecha_vencimiento"].Value.ToString();
            objPenBO.Id_pensionado=Convert.ToInt32( dgv_pensionados.Rows[Fila].Cells["id_pensionado"]);
            MessageBox.Show(objPenBO.Id_pensionado.ToString());



        }
    }
}
