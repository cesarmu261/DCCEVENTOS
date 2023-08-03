using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCCEVENTOS.Reportes
{
    public partial class FRE : Form
    {
        public FRE()
        {
            InitializeComponent();
        }

        private void FRE_Load(object sender, EventArgs e)
        {
            //Reportes.DataSet1 dataSet = new Reportes.DataSet1();
            //Reportes.DataSet1TableAdapters.SA_EVENTO_DETALLETableAdapter tableAdapter = new Reportes.DataSet1TableAdapters.SA_EVENTO_DETALLETableAdapter();
            //int VALOR;
            //VALOR = Convert.ToInt32(2);
            //// Llenar el DataSet con datos desde la fuente de datos
            //tableAdapter.Fill(dataSet.SA_EVENTO_DETALLE, VALOR);
            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataSet.Tables["SA_EVENTO_DETALLE"]);
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            //reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report1.rdlc";

            //reportViewer1.RefreshReport();

        }
    }
}
