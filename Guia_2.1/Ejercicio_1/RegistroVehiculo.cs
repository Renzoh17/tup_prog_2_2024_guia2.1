using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class RegistroVehiculo
    {
        public readonly string Patente;
        public readonly string Serie;
        public Persona propietario;
        public RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            Patente = patente;
            this.propietario = propietario;
            Serie = serie.ToString();
        }
        public override string ToString()
        {
            return $"*{Patente}*{Serie}*{propietario}";
        }

    }
}
