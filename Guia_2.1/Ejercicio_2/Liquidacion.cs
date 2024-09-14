using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Liquidacion
    {
        public readonly int Año;
        public readonly int Mes;
        public readonly double MontoBasico;
        public double PorcAntiguedad
        {
            get
            {
                double p = (Año - empleado.AñoContratado) * 1.0 / 20 * 100;
                return p;
            }
        }
        public double MontoAntiguedad
        {
            get
            {
                return MontoBasico * PorcAntiguedad / 100d;
            }
        }
        public readonly double HorasExtras50;
        public double MontoExtras50
        {
            get
            {
                return MontoBasico / 40d * HorasExtras50;
            }
        }
        public readonly double HorasExtras100;
        public double MontoExtras100
        {
            get
            {
                return MontoBasico / 40d * HorasExtras100;
            }
        }
        public double Nominal
        {
            get
            {
                return MontoBasico + MontoAntiguedad + MontoExtras50 + MontoExtras100;
            }
        }
        public double PorcObraSocial;
        public double MontoObraSocial
        {
            get
            {
                return Nominal * 3d / 100;
            }
        }
        public double PorcJubilado;
        public double MontoJubilado
        {
            get
            {
                return Nominal * 18d / 100;
            }
        }
        public double PorcGremiales;
        public double MontoGremial
        {
            get
            {
                return Nominal * 1.5d / 100;
            }
        }
        public double Neto
        {
            get
            {
                return Nominal - Descuento;
            }
        }
        public double Descuento
        {
            get
            {
                return MontoObraSocial + MontoJubilado + MontoGremial;
            }
        }
        public double Productividad
        {
            get
            {
                return Neto * 30d / 100;
            }
        }
        public double ACobrar
        {
            get
            {
                return Neto + Productividad;
            }
        }
        public readonly Empleado empleado;
        
        public Liquidacion(Empleado empleado, int año, int mes)
        {
            this.empleado = empleado;
            Año = año;
            Mes = mes;
            MontoBasico = empleado.MontoBasicoNominal;
            HorasExtras50 = empleado.HorasExtras50;
            HorasExtras100 = empleado.HorasExtras100;
        }

        public string VerImpreso()
        {
            return $@"

Empleado {empleado.ApellidoNombre}
{"-".PadRight(85, '-')}
{"Concepto",30}{"Haberes",20}{"Descuentos",20}
{"Básico",30}{MontoBasico,20:f2}{" ",20}
{$"Antiguedad ({PorcAntiguedad})",30}{MontoAntiguedad,20:f2}{" ",20}
{$"Extras al 50% ({HorasExtras50})",30}{MontoExtras50,20:f2}{" ",20}
{$"Extras al 100$ ({HorasExtras100})",30}{MontoExtras100,20:f2}{" ",20}
{$"Obra Social ({PorcObraSocial}%)",30}{" ",20}{MontoObraSocial,20:f2}
{$"Jubilación ({PorcJubilado}%)",30}{" ",20}{MontoJubilado,20:f2}
{$"Ap. Gremiales ({PorcGremiales}%)",30}{" ",20}{MontoGremial,20:f2}
{$"Productividad",30}{Productividad,20:f2}{" ",20}
{"-".PadRight(85, '-')}
{"Totales",30}{Neto,20:f2}{Descuento,20:f2}{" ",20}
{"-".PadRight(85, '-')}
{" ",30}{"A Cobrar",20}{ACobrar,20:f2}
";     
        }
    }
}
