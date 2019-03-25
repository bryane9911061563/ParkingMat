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
    public partial class frm_ParkingEmpleado : Form
    {
        private int Sucursal1=1;
        public frm_ParkingEmpleado()
        {
            InitializeComponent();
        }

        Sucursal_DAO id = new Sucursal_DAO();
        Cajones_DAO cajon = new Cajones_DAO();
        ArrayList cajones_lista = new ArrayList();

       // public int Sucursal1 { get => Sucursal; set => Sucursal = value; }
        private void frm_ParkingEmpleado_Load(object sender, EventArgs e)
        {
            int cantidad = cajon.Cajones_por_Sucursal(Sucursal1);//el parametro a recibir es el id del sucursal
            cajones_lista = cajon.info_Cajones(Sucursal1);
            //MessageBox.Show(cantidad.ToString());
            Mostrar_Cajones(cantidad);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_Cajones(int cantidad)
        {
            Button[] Vehiculo_Botton = new Button[cantidad];

            int contador = 0;
            for (int y = 0; y < cantidad; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Vehiculo_Botton[contador] = new Button();
                    Vehiculo_Botton[contador].Visible = true;
                    Vehiculo_Botton[contador].Height = 110;
                    Vehiculo_Botton[contador].Width = 260;
                    Vehiculo_Botton[contador].Top = y * 115;
                    Vehiculo_Botton[contador].Left = x * 265;
                    /*recuerda que si el boonton va a tener }
                daots, estos tienen que crearse en el espacio de creacion del boton
                (este texto verde) pero antes de delagar el boton
                    aprentemente este ciclo for es el create de el boton*/
                    String estado="";
                    int lugar = contador+1;
                   
                    if (cajones_lista.Count < 1)
                    {
                        Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#73c27d");
                    }
                    for (int z = 0; z<cajones_lista.Count ;z++)
                        {
                        String[] info = cajones_lista[z].ToString().Split('|');
                            if (info[0] == "ocupado"  && int.Parse(info[4].ToString())-1 == contador)
                            {
                                Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#e68e8a");
                                Vehiculo_Botton[contador].Text = info[2].ToString();
                                estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                            break;
                            }
                            else if(info[0] == "recerbado" && int.Parse(info[4].ToString()) - 1 == contador)
                            {
                                Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#e68e8a");
                                Vehiculo_Botton[contador].Text = info[2].ToString()+"-"+ info[3].ToString();
                                estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                            }
                            else
                            {
                                Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#73c27d");
                            }
                           
                        }

                    Vehiculo_Botton[contador].Click += delegate {/* MessageBox.Show(lugar.ToString()); };/*/frm_AgregarVehiculo vehiculo = new frm_AgregarVehiculo(1,lugar); vehiculo.Show(); };
                    pnl_cajones.Controls.Remove(Vehiculo_Botton[contador]);
                    pnl_cajones.Controls.Add(Vehiculo_Botton[contador]);
                    contador = contador + 1;
                    if (contador >= cantidad)
                    {
                        x = cantidad+1;
                        y = cantidad + 1;
                    }
     
                }
            }
        }

        private void gbx_cajones_Enter(object sender, EventArgs e)
        {

        }
    }
}
