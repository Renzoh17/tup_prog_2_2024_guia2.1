using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Persona
    {
        public readonly string dni;
        public readonly string nombre;

        public Persona(string dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"{nombre}(dni: {dni})";
        }
    }
}
