using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMat.BO
{
    class Empleado_BO
    {
        private int id_Empleado = 0, salario_Base = 0,id_sucursal, puesto;
        private String nombre = "", Apellido_1 = "", Apellido_2 = "",Correo_Electronico="",Clave_Sesion="",Horario_Trabajo="";
        private DateTime fecha_nacimiento;

        public int Id_Empleado { get => id_Empleado; set => id_Empleado = value; }
        public int Salario_Base { get => salario_Base; set => salario_Base = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_11 { get => Apellido_1; set => Apellido_1 = value; }
        public string Apellido_21 { get => Apellido_2; set => Apellido_2 = value; }
        public string Correo_Electronico1 { get => Correo_Electronico; set => Correo_Electronico = value; }
        public string Clave_Sesion1 { get => Clave_Sesion; set => Clave_Sesion = value; }
        public string Horario_Trabajo1 { get => Horario_Trabajo; set => Horario_Trabajo = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
    }
}