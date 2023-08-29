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

namespace Ribbon.Formularios.Catalogos
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != string.Empty)
            {
                try
                {
                    Categoria categoria = new Categoria();
                    categoria.categoria = txtCategoria.Text;
                    categoria.idUsuario = 1;
                    if ( categoria.set(categoria) > 0){
                        MessageBox.Show("Categoría agregada exitosamente.", "Agregar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategoria.Text = string.Empty;
                        txtCategoria.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio una excepcion al guardar la Categoría");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe de esribir el nombre de la nueva Categría","Agregar Categoría",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtCategoria.Focus();
            }
            
        }
    }
}
