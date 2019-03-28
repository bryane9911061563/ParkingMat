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
    public partial class frm_MenuSelectSucursales : Form
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
        public frm_MenuSelectSucursales()
        {
            InitializeComponent();
            Cargar_sucursales();
        }

        Sucursal_DAO suc = new Sucursal_DAO();
        ArrayList sucursal = new ArrayList();

        private void Cargar_sucursales()
        {
            sucursal = suc.lista_Sucursales();
            for (int i = 0; i < sucursal.Count; i++)
            {
                cmb_sucursal_admin.Items.Add(sucursal[i].ToString());
            }
            //sucursal = suc.lista_Puestos();
            //for (int i = 0; i < sucursal.Count; i++)
            //{
            //    cmb_sucursal_admin.Items.Add(sucursal[i].ToString());
            //}
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.Show();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            

            Cls_Static_UsuarioRunningThisMoment.id_Sucursal = suc.Asignar_Sucursal(cmb_sucursal_admin.Text);
            frm_menuAdmin admin = new frm_menuAdmin();
            admin.Show();
            MessageBox.Show(suc.Mostrar_nombre_sucursal_seleccionada());
            this.Hide();
        }
    }
}
