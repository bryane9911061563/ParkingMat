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
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

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
            int Fila = e.RowIndex;
            objReciboBO.Id_tipRecibo = Convert.ToInt32(dgv_tipos_recibos.Rows[Fila].Cells["id_tiporecibo"].Value.ToString().TrimEnd());
            txt_nombre_tip_recibo.Text = dgv_tipos_recibos.Rows[Fila].Cells["nombre_tiporecibo"].Value.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(txt_nombre_tip_recibo.Text!="")
            
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un tipo de recibo");
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
            if(txt_nombre_tip_recibo.Text!="")
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Seleccione un tipo de recibo");
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
    }
}
