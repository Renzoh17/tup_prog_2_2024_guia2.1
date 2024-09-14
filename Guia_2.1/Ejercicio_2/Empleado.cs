using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Empleado
    {
        public readonly int Dni;
        public readonly string Nombre;
        public readonly string Apellido;
        public readonly string ApellidoNombre;
        public readonly int AñoContratado;
        public double MontoBasicoNominal;
        public int HorasExtras50;
        public int HorasExtras100;

        public Empleado(int dni,string nombre, string apellido, int añoContratado)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            AñoContratado = añoContratado;
            ApellidoNombre = apellido + ", " + nombre;
        }
    }
}
