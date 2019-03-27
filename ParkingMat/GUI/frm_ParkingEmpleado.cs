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
        private int Sucursal1=1,estado_cajon=1;
        private int cantidad1;
        private int cajon_seleccionado, tipo_vehiculo;
        private String matricula = "";
        public frm_ParkingEmpleado(int sucu,int estado)
        {
            InitializeComponent();
            Sucursal1 = sucu;
            estado_cajon = estado;

        }

        Sucursal_DAO id = new Sucursal_DAO();
        Cajones_DAO cajon = new Cajones_DAO();
        ArrayList cajones_lista = new ArrayList();
        Button[] Vehiculo_Botton;

        public int Cajon_seleccionado { get => cajon_seleccionado; set => cajon_seleccionado = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }

        // public int Sucursal1 { get => Sucursal; set => Sucursal = value; }
        private void frm_ParkingEmpleado_Load(object sender, EventArgs e)
        {
            int cantidad = cajon.Cajones_por_Sucursal(Sucursal1);//el parametro a recibir es el id del sucursal
            cajones_lista = cajon.info_Cajones(Sucursal1);
            //MessageBox.Show(cantidad.ToString());
            Vehiculo_Botton = new Button[cantidad];
            Mostrar_Cajones(cantidad);
            cantidad1 = cantidad;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void actualizar()
        {
            cajones_lista = cajon.info_Cajones(Sucursal1);
            int contador = 0;
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {

                    String estado = "";
                    int lugar = contador + 1;
                    // Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#000");
                    if (cajones_lista.Count < 1)
                    {
                        Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#73c27d");
                    }
                    for (int z = 0; z < cajones_lista.Count; z++)
                    {
                        String[] info = cajones_lista[z].ToString().Split('|');
                        if (info[0] == "ocupado" && int.Parse(info[4].ToString()) - 1 == contador)
                        {
                            Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#e68e8a");
                            Vehiculo_Botton[contador].Text = info[2].ToString();
                            estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                            break;
                        }
                        else if (info[0] == "recerbado" && int.Parse(info[4].ToString()) - 1 == contador)
                        {
                            Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#fffae2");
                            Vehiculo_Botton[contador].Text = info[2].ToString() + "-" + info[3].ToString();
                            estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                            break;
                        }
                        else
                        {
                            Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#73c27d");
                        }

                    }

                    contador = contador + 1;
                    if (contador >= cantidad1)
                    {
                        x = cantidad1 + 1;
                        y = cantidad1 + 1;
                    }
                }

            }
            this.Refresh();
        }
        private void Mostrar_Cajones(int cantidad)
        {
           

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
                    int cajon_id =0;
                   
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
                                cajon_id = int.Parse(info[5].ToString());

                            break;
                            }
                            else if(info[0] == "recerbado" && int.Parse(info[4].ToString()) - 1 == contador)
                            {
                                Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#fffae2");
                                Vehiculo_Botton[contador].Text = info[2].ToString()+"-"+ info[3].ToString();
                                estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                                cajon_id = int.Parse(info[5].ToString());
                                break;
                            }
                            else
                            {
                                Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#73c27d");
                                cajon_id = int.Parse(info[5].ToString());
                            }
                           
                        }

                    Vehiculo_Botton[contador].Click += delegate {/* MessageBox.Show(lugar.ToString()); };/*/frm_AgregarVehiculo vehiculo = new frm_AgregarVehiculo(Sucursal1,lugar,1,"", estado_cajon); vehiculo.ShowDialog(); if (estado_cajon==3) { Cajon_seleccionado = cajon_id; Matricula = vehiculo.Matricla; tipo_vehiculo = vehiculo.Id_tipo; this.Close(); }; actualizar(); };
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
