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
using Bunifu.Framework.UI;

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
        BunifuFlatButton[] Vehiculo_Botton;

        public int Cajon_seleccionado { get => cajon_seleccionado; set => cajon_seleccionado = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }

        // public int Sucursal1 { get => Sucursal; set => Sucursal = value; }
        private void frm_ParkingEmpleado_Load(object sender, EventArgs e)
        {
            int cantidad = cajon.Cajones_por_Sucursal(Sucursal1);//el parametro a recibir es el id del sucursal
            cajones_lista = cajon.info_Cajones(Sucursal1);
            //MessageBox.Show(cantidad.ToString());
            Vehiculo_Botton = new BunifuFlatButton[cantidad];
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
                    int cajon_id = 0;
                    bool ocupado = false;
                    // Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#000");
                    

                    if (cajones_lista.Count < 1)
                    {
                        Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#32cd32");
                        Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#00ff00");
                        Vehiculo_Botton[contador].Text = "Hora Inicial: --:-- \nMatricula: ------\nHora Final --:-- ";
                    }
                    for (int z = 0; z < cajones_lista.Count; z++)
                    {
                        String[] info = cajones_lista[z].ToString().Split('|');
                        if (info[0] == "ocupado" && int.Parse(info[4].ToString()) - 1 == contador)
                        {
                            Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#dc143c");
                            Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#db7093");
                            Vehiculo_Botton[contador].Text = info[2].ToString() + "\n Matricula: " + info[6].ToString() + "\nHora Final: --:--";
                            estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                            cajon_id = int.Parse(info[5].ToString());
                            ocupado = true;
                            break;
                        }
                        else if (info[0] == "recerbado" && int.Parse(info[4].ToString()) - 1 == contador)
                        {
                            Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#ffa500");
                            Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#ff8c00");
                            cajon_id = int.Parse(info[5].ToString());
                            String nombre = cajon.nombre(cajon_id);
                            Vehiculo_Botton[contador].Text = "Espacio recerbado";// a nombre de: " + nombre + "\nPlacas: " + info[6].ToString();
                            ocupado = true;
                            break;
                        }
                        else
                        {

                            Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#32cd32");
                            Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#00ff00");
                            Vehiculo_Botton[contador].Text = "Hora Inicial: --:-- \nMatricula: ------\nHora Final --:-- ";
                            ocupado = false;
                            cajon_id = int.Parse(info[5].ToString());
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

        private void txt_Placas_TextChanged(object sender, EventArgs e)
        {
            int count=0, posision_x = 0 , posision_y=0;
            if (txt_Placas.Text != "")
            {
                for (int x = 0; x < Vehiculo_Botton.Count(); x++)
                {
                    for (int y = 0; x < Vehiculo_Botton.Count(); y++)
                    {

                        if (Vehiculo_Botton[count].Text.Contains("Matricula: " + txt_Placas.Text))
                        {
                            Vehiculo_Botton[count].Visible = true;
                            Vehiculo_Botton[count].Top = posision_y * 115;
                            Vehiculo_Botton[count].Left = posision_x * 265;
                            posision_x = posision_x + 1;
                            if(posision_x >= 5)
                            {
                                posision_x = 0;
                                posision_y = posision_y + 1;
                            }

                        }
                        else
                        {
                            Vehiculo_Botton[count].Visible = false;
                        }
                        count = count + 1;
                        if (count >= cantidad1)
                        {
                            x = cantidad1 + 1;
                            y = cantidad1 + 1;
                        }
                    }
                }
            }
            else
            {
                for (int y = 0; y < Vehiculo_Botton.Count(); y++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                            Vehiculo_Botton[count].Visible = true;
                            Vehiculo_Botton[count].Top = y * 115;
                            Vehiculo_Botton[count].Left = x * 265;
                        count = count + 1;
                        if (count >= cantidad1)
                        {
                            x = cantidad1 + 1;
                            y = cantidad1 + 1;
                        }
                    }
                }
            }
        }

        private void Mostrar_Cajones(int cantidad)
        {
           

            int contador = 0;
            for (int y = 0; y < cantidad; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Vehiculo_Botton[contador] = new BunifuFlatButton();
                    Vehiculo_Botton[contador].Visible = true;
                    Vehiculo_Botton[contador].Height = 110;
                    Vehiculo_Botton[contador].Width = 260;
                    Vehiculo_Botton[contador].Top = y * 115;
                    Vehiculo_Botton[contador].Left = x * 265;
                    Vehiculo_Botton[contador].BorderRadius = 7;
                    Vehiculo_Botton[contador].Iconimage = Image.FromFile("..\\..\\bin\\debug\\Car_52px.png");
                    Vehiculo_Botton[contador].Text = "Hora Inicial: --:-- \nHora Final --:-- \nMatricula: ------";

                    /*recuerda que si el boonton va a tener }
                daots, estos tienen que crearse en el espacio de creacion del boton
                (este texto verde) pero antes de delagar el boton
                    aprentemente este ciclo for es el create de el boton*/
                    String estado ="";
                    int lugar = contador+1;
                    int cajon_id = 0;
                    bool ocupado = false;

                    if (cajones_lista.Count < 1)
                    {
                        Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#32cd32");
                        Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#00ff00");
                        Vehiculo_Botton[contador].Text = "Hora Inicial: --:-- \nMatricula: ------\nHora Final --:-- ";
                    }
                    for (int z = 0; z < cajones_lista.Count; z++)
                    {
                        String[] info = cajones_lista[z].ToString().Split('|');
                        if (info[0] == "ocupado" && int.Parse(info[4].ToString()) - 1 == contador)
                        {
                            Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#dc143c");
                            Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#db7093");
                            Vehiculo_Botton[contador].Text = info[2].ToString() + "\n Matricula: " + info[6].ToString() + "\nHora Final: --:--";
                            cajon_id = int.Parse(info[5].ToString());

                            break;
                        }
                        else if (info[0] == "recerbado" && int.Parse(info[4].ToString()) - 1 == contador)
                        {
                            Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#ffa500");
                            Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#ff8c00");
                            cajon_id = int.Parse(info[5].ToString());
                            String nombre=cajon.nombre(cajon_id);
                            Vehiculo_Botton[contador].Text = "Espacio recerbado ";// a nombre de: "+nombre+"\nPlacas: "+ info[6].ToString();
                            ocupado = true;
                            break;
                        }
                        else
                        {

                            Vehiculo_Botton[contador].Normalcolor = System.Drawing.ColorTranslator.FromHtml("#32cd32");
                            Vehiculo_Botton[contador].OnHovercolor = System.Drawing.ColorTranslator.FromHtml("#00ff00");
                            Vehiculo_Botton[contador].Text = "Hora Inicial: --:-- \nMatricula: ------\nHora Final --:-- ";
                            cajon_id = int.Parse(info[5].ToString());
                        }

                    }

                    Vehiculo_Botton[contador].Click += delegate { if (!ocupado) { frm_AgregarVehiculo vehiculo = new frm_AgregarVehiculo(Sucursal1, lugar, 1, "", estado_cajon, cajon_id); vehiculo.ShowDialog(); if (estado_cajon == 3) { Cajon_seleccionado = cajon_id; Matricula = vehiculo.Matricla; tipo_vehiculo = vehiculo.Id_tipo; this.Close(); }; actualizar(); } else { frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("intente otro espacio"); error.ShowDialog(); } };
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
