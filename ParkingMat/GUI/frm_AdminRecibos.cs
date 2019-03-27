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
    public partial class frm_AdminRecibos : Form
    {
        public frm_AdminRecibos()
        {
            InitializeComponent();
            //dtp_fecha.Text = DateTime.Today.ToString("dd/mm/yy");
        }
        Recibo_DAO recibo = new Recibo_DAO();
        Recibo_BO nuevo = new Recibo_BO();
        private int id_sucu=0, id_mot=0;
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (txt_costo.Text != "" && txt_motivo.Text !=""  && id_mot !=0 && id_sucu!=0)
            {
                nuevo.Motivo = txt_motivo.Text;
                nuevo.Id_sucu = id_sucu;
                nuevo.Id_tipo = id_mot;
                nuevo.Costo = int.Parse(txt_costo.Text);
                nuevo.Descripcion = txt_descripcion.Text;
                nuevo.Fecha_creacion = dtp_fecha.Value.Date;

                try
                {
                    recibo.Agregar_Recibo(nuevo);
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    txt_motivo.Text = "";
                    txt_descripcion.Text = "";
                    txt_costo.Text = "";
                    exito.ShowDialog();
                }
                catch
                {
                    frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("intente nuevamente ");
                    error.ShowDialog();
                }
            }
            else
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("llene todos los campos");
                error.ShowDialog();
            }

        }
        public void empleado (int id)
        {
            id_sucu = id;
            cmb_sucursales.Visible = false;
            label6.Visible = false;
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_mot = cmb_tipo.SelectedIndex + 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_sucu = cmb_sucursales.SelectedIndex + 1;
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
           bool a = int.TryParse(e.KeyChar.ToString(), out int result);
            if (e.KeyChar == '.' || e.KeyChar == ' ' ||!a && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void frm_AdminRecibos_Load(object sender, EventArgs e)
        {
            ArrayList tipos = new ArrayList();
            Recibo_DAO recibo = new Recibo_DAO();

            try
            {

                tipos = recibo.lista_tiposRecivo();
                for (int x = 0; x < tipos.Count; x++)
                {
                    cmb_tipo.Items.Add(tipos[x].ToString());
                }
                if (id_sucu <1)
                {
                    Sucursal_DAO sucu = new Sucursal_DAO();
                    tipos = sucu.lista_Sucursales();
                    for (int y = 0; y < tipos.Count; y++)
                    {
                        cmb_sucursales.Items.Add(tipos[y].ToString());
                    }


                }
            }
            catch 
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("inicie el programa de nuevo");
                error.ShowDialog();
            }

        }
    }
}
