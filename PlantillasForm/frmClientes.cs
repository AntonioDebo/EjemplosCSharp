﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlantillasForm
{
    public partial class frmClientes : PlantillasForm.FormTemplate.frmTemplate
    {
        public frmClientes( string windowTitle)
        {
            InitializeComponent();
            lblTitle.Text = windowTitle;
        }
    }
}
