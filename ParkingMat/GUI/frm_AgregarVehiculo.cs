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
    public partial class frm_AgregarVehiculo : Form
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
        private int sucursal, cajon;
        public frm_AgregarVehiculo(int id_sucursal, int numero_cajon)
        {
            sucursal = id_sucursal;
            cajon = numero_cajon;
            InitializeComponent();
            button1.Visible = false;
            label4.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_AgregarVehiculo_Load(object sender, EventArgs e)
        {
            cargar();
            mtx_numero.Text = cajon.ToString();
            if(mtx_entrada.Text == "")
            {
                mtx_entrada.Text= DateTime.Now.ToString("hhmm");
            }
            else
            {
                try
                {
                    Cajones_DAO vehiculos = new Cajones_DAO();
                    mtx_entrada.Text = vehiculos.hora_inicio(sucursal, cajon);
                    mtx_salida.Text = DateTime.Now.ToString("hhmm");
                    txt_matricula.Text = vehiculos.matricula(sucursal, cajon);
                }
                catch(Exception ex) {
                }
               
            }
        }
        private void cargar()
        {
            ArrayList tipos = new ArrayList();
            Cajones_DAO vehiculos = new Cajones_DAO();
            tipos = vehiculos.lista_tipos();
            for(int x =0; x< tipos.Count; x++)
            {
                cmb_tipo_vehiculo.Items.Add(tipos[x].ToString());
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txt_matricula.Text != "" && cmb_tipo_vehiculo.Text != "Seleccione")
            {
                Cajones_BO nuevo = new Cajones_BO();
                Cajones_DAO crear = new Cajones_DAO();
                nuevo.Id_sucursal = sucursal;
                nuevo.Lugar1 = cajon;
                nuevo.Hora_inicio1 = mtx_salida.Text;
                int guardar;
                nuevo.Hora_final1 = mtx_entrada.Text;
                nuevo.Matricula1 = txt_matricula.Text;
                nuevo.Tipo_vehiculo = cmb_tipo_vehiculo.SelectedIndex+1;
                try { 
                    guardar = crear.Actualizar_Datos(nuevo);

                }
                catch(Exception ex)
                {
                    guardar = crear.Guardar_Datos(nuevo);
                }
                if (guardar == 0)
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("LLene todos los campos");
                ERROR.ShowDialog();
            }
        }
    }
}
