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
        private int Sucursal=0;
        public frm_ParkingEmpleado()
        {
            InitializeComponent();
           
        }

        //Sucursal_DAO id = new Sucursal_DAO();
        Cajones_DAO cajon = new Cajones_DAO();
        ArrayList cajones_lista = new ArrayList();

        private void frm_ParkingEmpleado_Load(object sender, EventArgs e)
        {
           int cantidad = cajon.Cajones_por_Sucursal(1);//el parametro a recibir es el id del sucursal
            cajones_lista = cajon.info_Cajones(1);
            MessageBox.Show(cajones_lista.Count.ToString());
            Mostrar_Cajones(cantidad);
        }

        private void Mostrar_Cajones(int cantidad)
        {
            Button[] Vehiculo_Botton = new Button[cantidad];

            int contador = 0, informacion_posicion =0;
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Vehiculo_Botton[contador] = new Button();
                    //Vehiculo_Botton[contador].Visible = true;
                    Vehiculo_Botton[contador].Height = 110;
                    Vehiculo_Botton[contador].Width = 270;
                    Vehiculo_Botton[contador].Top = y * 115;
                    Vehiculo_Botton[contador].Left = x * 275;
                    // recuerda que si el boonton va a tener }
                    //daots, estos tienen que crearse en el espacio de creacion del boton 
                    //(este texto verde ) pero antes de delagar el boton 
                    //aprentemente este ciclo for es el create de el boton
                    String estado;
                    /*if (cajones_lista[informacion_posicion].ToString() == "ocupado")
                    {
                        Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#b00");
                        estado = "El lugar se encuentra ocupado \n intenta otro por favor";
                    }
                    else
                    {
                        estado = "libre, puedes usarlo";
                        Vehiculo_Botton[contador].BackColor = System.Drawing.ColorTranslator.FromHtml("#0f0");
                    }*/
                    Vehiculo_Botton[contador].Text = cajones_lista[informacion_posicion].ToString();
                    Vehiculo_Botton[contador].Click += delegate { MessageBox.Show("" /*estado.ToString()*/); };
                    gbx_cajones.Controls.Add(Vehiculo_Botton[contador]);
                    contador = contador + 1;
                    informacion_posicion = informacion_posicion +2;

                    if (contador >= cantidad)
                    {
                        x = 11;
                        y = 11;
                    }
                    
                }
            }
        }

    }
}
