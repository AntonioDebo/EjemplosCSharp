using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlantillasForm
{
    public partial class frmProveedores : PlantillasForm.FormTemplate.frmTemplate
    {
        public frmProveedores(string windowTitle)
        {
            InitializeComponent();
            lblTitle.Text = windowTitle;
        }
    }
}
