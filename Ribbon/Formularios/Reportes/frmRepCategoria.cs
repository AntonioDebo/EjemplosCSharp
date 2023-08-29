using Ribbon.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ribbon.Formularios.Reportes
{
    public partial class frmRepCategoria : Form
    {
        Categoria categoria = new Categoria();
        public frmRepCategoria()
        {
            InitializeComponent();
            dgvCategorias.DataSource = categoria.lista();
        }
    }
}
