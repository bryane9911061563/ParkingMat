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
        Vehiculo_BO auto = new Vehiculo_BO();
        Pensionados_DAO objPenDAO = new Pensionados_DAO();
        Sucursal_DAO suc = new Sucursal_DAO();
        Vehiculos_DAO vehic = new Vehiculos_DAO();
        ArrayList sucursal = new ArrayList();
        private String matricula = "";
        private int id_cajon, id_vehiculo;
        private int sucursal_id=0;

        public int Sucursal_id { get => sucursal_id; set => sucursal_id = value; }

        public frm_AdminPensionados()
        {
            InitializeComponent();
            dgv_pensionados.DataSource = objPenDAO.Mostrar_pensionados();
            comboBox2.Visible = true;
            label10.Visible = true;
        }

        //Mostrar pensionados
        
        public void es_empleado()
        {
            comboBox2.Visible = false;
            label10.Visible = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string mensaje_error="Error al guardar los datos";
            objPenBO.Nombre_pensionado = txt_nombre.Text;
            objPenBO.Apellido_p_pensionado = txt_apellido_p.Text;
            objPenBO.Apellido_m_pensionado = txt_apellido_m.Text;
            objPenBO.Fecha_nac_pensionado = dtp_fecha_nac.Text;
            objPenBO.Fecha_registro_pensionado = dtp_fecha_reg.Text;
            objPenBO.Fecha_vencimiento_pensionado = dtp_fecha_ven.Text;
            objPenBO.Num_telefono_pensionado = mtxt_telefono.Text;
            objPenBO.Correo_pensionado = txt_nombre.Text;


            if (objPenDAO.Guardar_pensionado(objPenBO) == 0)
            {
                frm_ERROR_DIALOG frmError = new frm_ERROR_DIALOG(mensaje_error);
                frmError.ShowDialog();
            }
            else
            {
                /*try
                {*/
                    int x = objPenDAO.ultimo_agregado();
                    auto.Id_cajon = id_cajon;
                    auto.Id_cliente = x;
                    auto.Id_tipo = id_vehiculo;
                    auto.Placas = matricula;
                    vehic.Guardar_Datos(auto);
                /*}catch
                {
                    frm_ERROR_DIALOG frmError = new frm_ERROR_DIALOG(mensaje_error);
                    frmError.ShowDialog();
                }*/
                
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
            objPenBO.Id_pensionado=Convert.ToInt32( dgv_pensionados.Rows[Fila].Cells["id_pensionado"].Value.ToString());



        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (Sucursal_id > 0)
            {
                frm_ParkingEmpleado jefe = new frm_ParkingEmpleado(Sucursal_id, 3);
                jefe.ShowDialog();
                matricula=jefe.Matricula;
                id_cajon = jefe.Cajon_seleccionado;
                id_vehiculo = jefe.Tipo_vehiculo;
            }
            else
            {
                frm_ERROR_DIALOG erro = new frm_ERROR_DIALOG("selecciona una sucursal");
                erro.ShowDialog();
            }
        }

        private void frm_AdminPensionados_Load(object sender, EventArgs e)
        {
            sucursal = suc.lista_Sucursales();
            for (int i = 0; i < sucursal.Count; i++)
            {
                comboBox2.Items.Add(sucursal[i].ToString());
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (objPenBO.Id_pensionado == 0)
            {
                string texto = "No se ha seleccionado a un pensionado";
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG(texto);
                error.ShowDialog();
            }
            else
            {
                objPenDAO.Eliminar_pensionado(objPenBO);
                frm_pruebaDialog exto = new frm_pruebaDialog();
                exto.ShowDialog();
                dgv_pensionados.DataSource = objPenDAO.Mostrar_pensionados();
                

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sucursal_id = comboBox2.SelectedIndex+1;
        }
    }
}
