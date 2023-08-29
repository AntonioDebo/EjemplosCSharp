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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ribbon.Formularios.Catalogos
{
    public partial class frmSubCategoria : Form
    {
        Categoria categoria = new Categoria();
        public frmSubCategoria()
        {
            InitializeComponent();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtSubCategoria.Text != string.Empty)
            {
                SubCategoria subcategoria = new SubCategoria();
                subcategoria.idCategoria = (int)cmbCategoria.SelectedValue;
                subcategoria.subCategoria = txtSubCategoria.Text;
                subcategoria.idUsuario = 1;
                if (subcategoria.agregar(subcategoria)>0)
                {
                    MessageBox.Show("Sub Categoría agregada exitosamente.", "Agregar Sub Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubCategoria.Text = string.Empty;
                    txtSubCategoria.Focus();
                }
                else
                {
                    MessageBox.Show("Ocurrio una excepción al agregar la Sub Categoria.", "Agregar Sub Categoría", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtSubCategoria.Text = string.Empty;
                    txtSubCategoria.Focus();
                }               
            }
            else
            {
                MessageBox.Show("Debe de escribir el nombre de la Sub Categoría.", "Agregar Sub Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmSubCategoria_Load(object sender, EventArgs e)
        {
            llenaComboCategorias();
        }

        /// <summary>
        /// Llena de datos el Combo de las categorías.
        /// </summary>
        private void llenaComboCategorias()
        {
            cmbCategoria.DataSource = categoria.lista();
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "id";
            
        }
    }
}
