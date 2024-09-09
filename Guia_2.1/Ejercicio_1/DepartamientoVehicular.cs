using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class DepartamientoVehicular
    {
        private int cantidadRegistros = 0;
        public int CantidadRegistros { get { return cantidadRegistros; } }
        ArrayList registros = new ArrayList();

        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            int serie;
            RegistroVehiculo RV = new RegistroVehiculo(GenerarPatente(out serie), propietario, serie);
            registros.Add(RV);
            cantidadRegistros++;
            return RV;
        }
        public RegistroVehiculo VerRegistro(int index)
        {
            return (RegistroVehiculo)registros[index];
        }
        private string GenerarPatente(out int serie)
        {
            Random rnd = new Random();
            char p1, p2;
            int pn = rnd.Next(0, 1000);
            serie = rnd.Next(0, 1000000000);
            p1 = (char)rnd.Next(65, 91);
            p2 = (char)rnd.Next(65, 91);
            string patente = $"{p1}{p2}{pn}";
            return patente;
        }
    }
}
