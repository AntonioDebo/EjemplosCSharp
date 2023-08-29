using Ribbon.Clases;
using Ribbon.Formularios.Catalogos;
using Ribbon.Formularios.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ribbon
{
    public partial class Form1 : RibbonForm
    {
        SQLCnx SQL = new SQLCnx();
        public Form1()
        {
            InitializeComponent();
        }

        private void rbnBtnInvProductos_Click(object sender, EventArgs e)
        {
            SQL.getDataTable("SELECT * FROM Categorias");
        }

        private void rbnBtnRepArtInventario_Click(object sender, EventArgs e)
        {
            frmInvetario frm = (frmInvetario)Application.OpenForms["frmInventario"];
            if (frm == null)
            {
                frm = new frmInvetario();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void rbnBtnProdCategorias_Click(object sender, EventArgs e)
        {
             
            frmCategoria frm = new frmCategoria();
            frm.Show();
        }

        private void rbnBtnProdSubCategorias_Click(object sender, EventArgs e)
        {
            frmSubCategoria frmsubcategoria = new frmSubCategoria();
            frmsubcategoria.ShowDialog();
        }
    }
}
