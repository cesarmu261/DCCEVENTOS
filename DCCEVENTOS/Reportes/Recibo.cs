using Coneccion;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCCEVENTOS.Reportes
{
    public partial class Recibo : Form
    {
        Conecciones con;
        private int VALOR;

        public Recibo(int VALOR)
        {
            InitializeComponent();
            con = new Conecciones();
            this.VALOR = VALOR;
        }

        public int Cod_Evento;
        private DbConnection coneccion;
        private void FRE_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();

            DataSet1TableAdapters.sp_reciboTableAdapter tableAdapter1 = new DataSet1TableAdapters.sp_reciboTableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("Recibo"));
            tableAdapter1.Connection = (SqlConnection)coneccion;


            tableAdapter1.Fill(dataSet.sp_recibo,VALOR);

            //reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", dataSet.Tables["sp_recibo"]);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report3.rdlc";

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            reportViewer1.RefreshReport();

        }
    }
}

