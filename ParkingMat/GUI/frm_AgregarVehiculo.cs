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

        private int sucursal, cajon, Id_cliente, Estado, id_tipo,costo,hora_inicial,hora_final;
        private String nombre_cliente = "", matricla = "";


        public int Sucursal { get => Sucursal1; set => Sucursal1 = value; }
        public int Cajon { get => Cajon1; set => Cajon1 = value; }
        public int Id_cliente1 { get => Id_cliente2; set => Id_cliente2 = value; }
        public int Estado1 { get => Estado2; set => Estado2 = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Matricla { get => matricla; set => matricla = value; }
        public int Sucursal1 { get => sucursal; set => sucursal = value; }
        public int Cajon1 { get => cajon; set => cajon = value; }
        public int Id_cliente2 { get => Id_cliente; set => Id_cliente = value; }
        public int Estado2 { get => Estado; set => Estado = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Hora_inicial { get => hora_inicial; set => hora_inicial = value; }
        public int Hora_final { get => hora_final; set => hora_final = value; }

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
        public frm_AgregarVehiculo(int id_sucursal, int numero_cajon, int id_cliente, String nombre, int estado)
        {
            Sucursal = id_sucursal;
            Cajon = numero_cajon;
            InitializeComponent();
            Estado1 = estado;
            Id_cliente1 = id_cliente;
            Nombre_cliente = nombre;
            button1.Visible = false;
            label4.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            mtx_numero.Text = Cajon.ToString();
            if(mtx_entrada.Text == "")
            {
                mtx_entrada.Text= DateTime.Now.ToString("hhmm");
            }
            else
            {
                try
                {
                    Cajones_DAO vehiculos = new Cajones_DAO();
                    mtx_entrada.Text = vehiculos.hora_inicio(Sucursal, Cajon);
                    mtx_salida.Text = DateTime.Now.ToString("hhmm");
                    txt_matricula.Text = vehiculos.matricula(Sucursal, Cajon);
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
            if (Estado1 == 1)
            {
                if (txt_matricula.Text != "" && cmb_tipo_vehiculo.Text != "Seleccione")
                {
                    Cajones_BO nuevo = new Cajones_BO();
                    Cajones_DAO crear = new Cajones_DAO();
                    nuevo.Id_sucursal = Sucursal;
                    nuevo.Lugar1 = Cajon;
                    nuevo.Hora_inicio1 = "Hora entrada:"+mtx_salida.Text;
                    int guardar;
                    nuevo.Matricula1 =txt_matricula.Text;
                    nuevo.Tipo_vehiculo = cmb_tipo_vehiculo.SelectedIndex + 1;
                    try
                    {
                        nuevo.Hora_final1 = "Hora salida:" + mtx_entrada.Text;
                        nuevo.Estado_cajon = 2;
                        guardar = crear.Actualizar_Datos(nuevo);
                        if (guardar == 0)
                        {
                            nuevo.Hora_final1 = "Hora salida: --:--";
                            nuevo.Estado_cajon = 1;
                            guardar = crear.Guardar_Datos(nuevo);
                            if (guardar == 0)
                            {
                                frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                                ERROR.ShowDialog();
                            }
                        }
                        else
                        {
                            if (guardar != 0)
                            {
                                String hini = mtx_salida.Text.Substring(0, 2);
                                String hfin = mtx_entrada.Text.Substring(0, 2);
                                int x = int.Parse(hini);
                                int y = int.Parse(hfin);
                                if (x > 12)
                                {
                                    x = x - y + 12; //
                                }
                                else if(x-y==0){

                                }
                                else
                                {
                                    x = x - y;//en estos 2 se genera el costo , x es el costo por usar el aparcamiento 
                                              // necesito que se habra un dialogo o puedas brincar a recibos y se active el recibo por el vehiculo 
                                }
                                frm_AdminRecibos cobrar = new frm_AdminRecibos();
                                cobrar.cobrar_temporal(x,true,sucursal);
                                cobrar.ShowDialog();

                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        nuevo.Hora_final1 = "Hora salida: --:--";
                        nuevo.Estado_cajon = 1;
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
                        id_tipo = cmb_tipo_vehiculo.SelectedIndex + 1;
                        this.Close();

                    }
                }
                else
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("LLene todos los campos");
                    ERROR.ShowDialog();
                }
            }
            else
            {
                if (txt_matricula.Text != "" && cmb_tipo_vehiculo.Text != "Seleccione")
                {
                    Cajones_BO nuevo = new Cajones_BO();
                    Cajones_DAO crear = new Cajones_DAO();
                    nuevo.Id_sucursal = Sucursal;
                    nuevo.Lugar1 = Cajon;
                    nuevo.Hora_inicio1 = mtx_salida.Text;
                    int guardar;
                    nuevo.Hora_final1 = "Espacio Recerbado a nombre de:";
                    nuevo.Matricula1 = Nombre_cliente;
                    nuevo.Tipo_vehiculo = cmb_tipo_vehiculo.SelectedIndex + 1;
                    //este metodo guarda, pero para un cliente que sea pensionado
                    try
                    {

                        nuevo.Estado_cajon = 3;
                        guardar = crear.Guardar_Datos(nuevo);
                        if (guardar == 0)
                        {
                            frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                            ERROR.ShowDialog();
                        }
                        else
                        {
                            frm_pruebaDialog exito = new frm_pruebaDialog();
                            id_tipo = cmb_tipo_vehiculo.SelectedIndex + 1;
                            this.Close();

                        }

                    }
                    catch (Exception ex)
                    {
                        guardar = 0;
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
}
