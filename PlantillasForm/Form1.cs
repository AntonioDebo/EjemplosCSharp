using PlantillasForm.FormTemplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillasForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentas Clientes = new frmVentas("Ventas");
            Clientes.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProveedores Proveedores  = new frmProveedores("Proveedores");
            Proveedores.ShowDialog();
        }
    }
}
