﻿using System;
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
    public partial class frm_AdminEmpleados : Form
    {
        public frm_AdminEmpleados()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG();
            ERROR.ShowDialog();
        }
    }
}
