using Coneccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DCCEVENTOS.Reportes
{
    public partial class Factura : Form
    {
        Conecciones con;
        private int VALOR;
        public Factura(int VALOR)
        {
            InitializeComponent();
            con = new Conecciones();
            this.VALOR = VALOR;
        }
        public int Cod_Evento;
        private DbConnection coneccion;
        private void Factura_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();

            DataSet1TableAdapters.sp_FACTURATableAdapter tableAdapter1 = new DataSet1TableAdapters.sp_FACTURATableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("Factura"));
            tableAdapter1.Connection = (SqlConnection)coneccion;


            tableAdapter1.Fill(dataSet.sp_FACTURA, VALOR);

            //reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", dataSet.Tables["sp_FACTURA"]);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report6.rdlc";

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            reportViewer1.RefreshReport();

        }
    }
}

