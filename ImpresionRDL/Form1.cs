using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpresionRDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Lista = new ObservableCollection<Class1>();
            Lista.Add(new Class1 { id = 1, Descripcion = "UNO" });
            Lista.Add(new Class1 { id = 2, Descripcion = "DOS" });
            Lista.Add(new Class1 { id = 2, Descripcion = "TRES" });

            this.reportViewer1.LocalReport.ReportPath = "Info.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet1", Lista);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();

        }
    }
}
