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

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            FormRegistrarEmpleado vtnRE = new FormRegistrarEmpleado();
            if(vtnRE.ShowDialog() == DialogResult.OK)
            {
                empresa.RegistrarEmpleado(Convert.ToInt32(vtnRE.tbDNI.Text), vtnRE.tbApellido.Text, vtnRE.tbNombre.Text, Convert.ToInt32(vtnRE.tbAñoContratado.Text));
            }
            vtnRE.Dispose();
        }

        private void btnGenerarL_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(DateTime.Today.Month);
            int y = Convert.ToInt32(DateTime.Today.Year);
            empresa.GenerarLiquidaciones(m, y);
            MessageBox.Show("Se generaron las liquidaciones");
        }

        private void btnMostrarL_Click(object sender, EventArgs e)
        {
            FormIngresarFecha vtnIF = new FormIngresarFecha();
            tbMostrarL.Text = "";
            if (vtnIF.ShowDialog() == DialogResult.OK)
            {
                int j = 0;
                ArrayList l = empresa.ListarLiquidaciones(Convert.ToInt32(vtnIF.tbMes.Text), Convert.ToInt32(vtnIF.tbAño.Text), ref j);
                for (int i = 0; i < j; i++)
                {
                    tbMostrarL.Text += $"---{i + 1}" + ((Liquidacion)l[i]).VerImpreso();
                }
            }
            vtnIF.Dispose();
        }
    }
}
