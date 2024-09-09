using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        DepartamientoVehicular DV = new DepartamientoVehicular();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistroPersona vtnRP = new FormRegistroPersona();
            Persona p;
            if (vtnRP.ShowDialog() == DialogResult.OK)
            {
                p = new Persona(vtnRP.tbDNI.Text, vtnRP.tbNombre.Text);
                lbUltimoReg.Items.Clear();
                lbUltimoReg.Items.Add(DV.RegistrarVehiculo(p));
            }
            vtnRP.Dispose();
        }

        private void btnListRegistros_Click(object sender, EventArgs e)
        {
            lbListRegistros.Items.Clear();
            for (int i = 0; i < DV.CantidadRegistros; i++)
            {
                lbListRegistros.Items.Add(DV.VerRegistro(i));   
            }
        }
    }
}
