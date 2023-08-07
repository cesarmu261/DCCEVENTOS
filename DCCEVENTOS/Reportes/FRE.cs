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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCCEVENTOS.Reportes
{
    public partial class FRE : Form
    {
        public FRE()
        {
            InitializeComponent();
        }
        public int Cod_Evento;
        private void FRE_Load(object sender, EventArgs e)
        {
            //Reportes.DataSet1 dataSet = new Reportes.DataSet1();
            //Reportes.DataSet1TableAdapters.DataTable1TableAdapter tableAdapter = new Reportes.DataSet1TableAdapters.DataTable1TableAdapter();
            //int VALOR;
            //VALOR = Convert.ToInt32(1);
            //// Llenar el DataSet con datos desde la fuente de datos
            //tableAdapter.Fill(dataSet.DataTable1,VALOR);
            ////reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataSet.Tables["DataTable1"]);
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report1.rdlc";
            //reportViewer1.RefreshReport();
           

            DataSet1 dataSet = new DataSet1();
            DataSet1TableAdapters.sp_DetalleEventoTableAdapter tableAdapter = new DataSet1TableAdapters.sp_DetalleEventoTableAdapter();
            DataSet1TableAdapters.SaevenotsTableAdapter taadapter = new DataSet1TableAdapters.SaevenotsTableAdapter();
            int VALOR;
            VALOR = Cod_Evento;
            // Llenar el DataSet con datos desde la fuente de datos
            taadapter.Fill(dataSet.Saevenots, VALOR);
            tableAdapter.Fill(dataSet.sp_DetalleEvento, VALOR);
            //reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataSet.Tables["sp_DetalleEvento"]);
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet2", dataSet.Tables["Saevenots"]);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report1.rdlc";
            reportViewer1.RefreshReport();

        }
    }
}
