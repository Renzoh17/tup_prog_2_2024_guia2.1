using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Empresa
    {
        public int AñoActual;
        ArrayList liquidaciones = new ArrayList();
        ArrayList empleados = new ArrayList();
        Empleado e;
        Random rnd = new Random();

        public Empleado RegistrarEmpleado(int dni, string apellido, string nombre, int añoContratado)
        {
            e = new Empleado(dni, nombre, apellido, añoContratado);
            empleados.Add(e);
            return e;
        }
        public void GenerarLiquidaciones(int mes, int año)
        {
            foreach (Object e in empleados)
            {
                if (e is Empleado)
                {
                    ((Empleado)e).MontoBasicoNominal = rnd.Next(100000, 1000000);
                    ((Empleado)e).HorasExtras50 = rnd.Next(20);
                    ((Empleado)e).HorasExtras100 = rnd.Next(20);
                    liquidaciones.Add(new Liquidacion((Empleado)e, año, mes));
                }
            }
        }
        public ArrayList ListarLiquidaciones(int mes, int año, ref int cantidad)
        {
            ArrayList l = new ArrayList();
            int m = DateTime.Today.Month;
            int y = DateTime.Today.Year;
            foreach(Object li in liquidaciones)
            {
                if (li is Liquidacion)
                {
                    if (((Liquidacion)li).Mes == m && ((Liquidacion)li).Año == y)
                    {
                        l.Add(li);
                        cantidad++;
                    }
                } 
            }
            return l;
        }
        public string MostrarReciboSueldo(int año, int mes, int dni)
        {
            foreach (Object l in liquidaciones)
            {
                if (l is Liquidacion)
                {
                    Liquidacion laux = l as Liquidacion;
                    if (laux.Año == año && laux.Mes == mes && laux.empleado.Dni == dni)
                        return laux.VerImpreso();
                }
            }
            return "No se encontro";
        }
    }
}
