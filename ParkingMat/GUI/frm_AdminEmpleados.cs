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
using ParkingMat.BO;
using ParkingMat.DAO;
using System.IO;

namespace ParkingMat.GUI
{
    public partial class frm_AdminEmpleados : Form
    {
        Empleado_DAO ejecutar = new Empleado_DAO();
        Empleado_BO datos = new Empleado_BO();
        private string imagen_bytes = "";
        public frm_AdminEmpleados()
        {
            InitializeComponent();
            rbx_Matutino.Checked = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (mtx_Sueldo.Text!=""&& txt_apellido1.Text != "" && txt_apellido2.Text != "" && txt_nombre.Text != "" && cbx_Cargo.Text != "Seleccione" &&  txt_correo.Text != "" && txt_contraseña.Text !="")
            {
                Empleado_DAO crear = new Empleado_DAO();
                Sucursal_DAO verificar = new Sucursal_DAO();
                Empleado_BO nuevo = new Empleado_BO();
                nuevo.Nombre = txt_nombre.Text;
                nuevo.Apellido_11 = txt_apellido1.Text;
                nuevo.Apellido_21 = txt_apellido2.Text;
                byte[] imgbytes = Convertir_Imagen_Bytes(pictureBox1.Image);
                nuevo.Imagen = Convert.ToBase64String(imgbytes);
                nuevo.Salario_Base = int.Parse(mtx_Sueldo.Text);
                if (rbx_Matutino.Checked) {
                    nuevo.Horario_Trabajo1 = rbx_Matutino.Text;
                }
                else
                {
                    nuevo.Horario_Trabajo1 = rbx_Vespertino.Text;
                }
               
                nuevo.Correo_Electronico1 = txt_correo.Text;
                nuevo.Clave_Sesion1 = txt_contraseña.Text;
                nuevo.Fecha_nacimiento = dtp_nacimiento.Text.ToString();
                try
                {
                    nuevo.Puesto = verificar.Asignar_Puesto(cbx_Cargo.Text);
                }
                catch (Exception ex)
                {
                   frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                int guardar = crear.Guardar_Datos(nuevo);// aqui se salva al empleado
                if (guardar ==0)
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    Limpiar_campos();
                    dgv_Empleados.DataSource = ejecutar.tabla_empleado();

                }
            }
            else
            {
                frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("llene todos los campos");
                ERROR.ShowDialog();
            }
            imagen_bytes ="";
        }

        Sucursal_DAO suc = new Sucursal_DAO();
        ArrayList sucursal = new ArrayList();

        private void frm_AdminEmpleados_Load(object sender, EventArgs e)
        {
            dgv_Empleados.DataSource = ejecutar.tabla_empleado();
            Cargar();
        }


        //Metodo para mostrar las sucursales
        private void Cargar()
        {
           
            sucursal = suc.lista_Puestos();
            for (int i = 0; i < sucursal.Count; i++)
            {
               cbx_Cargo.Items.Add(sucursal[i].ToString());
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void txt_apellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void txt_apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// parece que este se puede eliminar
         
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(datos.Id_Empleado==0)
            {
                string texto="No se ha seleccionado a un empleado";
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG(texto);
                error.ShowDialog();
            }
            else
            {
                ejecutar.Eliminar_Datos(datos);
                frm_pruebaDialog exto = new frm_pruebaDialog();
                exto.ShowDialog();
                dgv_Empleados.DataSource = ejecutar.tabla_empleado();
                Cargar();
                Limpiar_campos();

            }

        }
        private int id_empleado = 0,idsucu=1;
    
        private void dgv_Empleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                int Fila = e.RowIndex;
                datos.Id_Empleado = Convert.ToInt32(dgv_Empleados.Rows[Fila].Cells["id_Empleado"].Value.ToString().TrimEnd());
                try
                {
                    byte[] imagenbyte = Convert.FromBase64String(ejecutar.imagen_empleado(datos.Id_Empleado));
                    pictureBox1.Image = Convertir_Bytes_Imagen(imagenbyte);
                }
                catch
                {

                }
                txt_nombre.Text = dgv_Empleados.Rows[Fila].Cells["Nombre_Empleado"].Value.ToString();
                txt_apellido1.Text = dgv_Empleados.Rows[Fila].Cells["Apellido_1_Empleado"].Value.ToString();
                txt_apellido2.Text = dgv_Empleados.Rows[Fila].Cells["Apellido_2_Empleado"].Value.ToString();
                txt_correo.Text = dgv_Empleados.Rows[Fila].Cells["Correo_Electronico"].Value.ToString();
                txt_contraseña.Text = dgv_Empleados.Rows[Fila].Cells["Clave_Sesion"].Value.ToString();
                mtx_Sueldo.Text = dgv_Empleados.Rows[Fila].Cells["Salario_Base"].Value.ToString();
                dtp_nacimiento.Text = dgv_Empleados.Rows[Fila].Cells["Fecha_Nacimiento"].Value.ToString();
                //TURNO CON UN IF PERO NO HAY TIEMPO XD
                //cbx_Cargo.Text = dgv_Empleados.Rows[Fila].Cells["Puesto"].Value.ToString();
                datos.Id_Empleado = Convert.ToInt32(dgv_Empleados.Rows[Fila].Cells["id_Empleado"].Value.ToString().TrimEnd());
                idsucu = Convert.ToInt32(dgv_Empleados.Rows[Fila].Cells["id_Sucursal"].Value.ToString().TrimEnd());
            id_empleado = datos.Id_Empleado;
            
            }
            catch
            {

            }
            
        }

        public void Limpiar_campos()
        {
            datos.Id_Empleado =0;
            txt_nombre.Clear();
            txt_apellido1.Clear();
            txt_apellido2.Clear();
            txt_correo.Clear();
            txt_contraseña.Clear();
            mtx_Sueldo.Clear();
            dtp_nacimiento.ResetText();
            cbx_Cargo.SelectedValue = 0;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (mtx_Sueldo.Text != "" && txt_apellido1.Text != "" && txt_apellido2.Text != "" && txt_nombre.Text != "" && cbx_Cargo.Text != "Seleccione"  && txt_correo.Text != "" && txt_contraseña.Text != "")
            {
                Empleado_DAO crear = new Empleado_DAO();
                Sucursal_DAO verificar = new Sucursal_DAO();
                Empleado_BO nuevo = new Empleado_BO();
                nuevo.Nombre = txt_nombre.Text;
                nuevo.Apellido_11 = txt_apellido1.Text;
                nuevo.Apellido_21 = txt_apellido2.Text;
                nuevo.Salario_Base = int.Parse(mtx_Sueldo.Text);
                nuevo.Id_Empleado = id_empleado;
                nuevo.Id_sucursal = idsucu;
                try
                {
                    byte[] imgbytes = Convertir_Imagen_Bytes(user);
                    nuevo.Imagen= Convert.ToBase64String(imgbytes);
                }
                catch
                {

                }
                if (rbx_Matutino.Checked)
                {
                    nuevo.Horario_Trabajo1 = rbx_Matutino.Text;
                }
                else
                {
                    nuevo.Horario_Trabajo1 = rbx_Vespertino.Text;
                }
                nuevo.Correo_Electronico1 = txt_correo.Text;
                nuevo.Clave_Sesion1 = txt_contraseña.Text;
                nuevo.Fecha_nacimiento = dtp_nacimiento.Text.ToString();

                try
                {
                    nuevo.Puesto = verificar.Asignar_Puesto(cbx_Cargo.Text);
                }
                catch (Exception ex)
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                int guardar = crear.Actualizar_Datos(nuevo);
                if (guardar == 0)
                {
                    frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("Intente nuevamente");
                    ERROR.ShowDialog();
                }
                else
                {
                    frm_pruebaDialog exito = new frm_pruebaDialog();
                    exito.ShowDialog();
                    Limpiar_campos();
                    dgv_Empleados.DataSource = ejecutar.tabla_empleado();

                }
            }
            else
            {
                frm_ERROR_DIALOG ERROR = new frm_ERROR_DIALOG("llene todos los campos");
                ERROR.ShowDialog();
            }
        }
        private Image user;

        private void btn_Img_Examinar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                    user = pictureBox1.Image;
                } 
            }
            catch 
            {
                frm_ERROR_DIALOG error = new frm_ERROR_DIALOG("Procura que sea una imagen");
                error.ShowDialog();
            }
        }
        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

    
        public static Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }
    }
    
}
