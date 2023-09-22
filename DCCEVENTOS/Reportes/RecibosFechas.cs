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
    public partial class RecibosFechas : Form
    {
        Conecciones con;
        private int VALOR;
        private DateTime valores, valores2;
        public RecibosFechas(DateTime selectedDate, DateTime findate)
        {
            InitializeComponent();
            con = new Conecciones();
            this.valores = selectedDate;
            this.valores2 = findate;
        }
        public int Cod_Evento;
        private DbConnection coneccion;

        private void RecibosFechas_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            DataSet1TableAdapters.sp_recibosFechasTableAdapter tableAdapter = new DataSet1TableAdapters.sp_recibosFechasTableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("RecibosFechas"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            //foreach (int valor in valores)
            //{
            tableAdapter.Fill(dataSet.sp_recibosFechas, valores, valores2);
            // Agregar los datos a las fuentes de datos
            ReportDataSource reportDataSources = new ReportDataSource("DataSet1", dataSet.Tables["sp_recibosFechas"]);
            //}
            // Asignar las fuentes de datos al ReportViewer1
            reportViewer1.LocalReport.DataSources.Add(reportDataSources);

            // Refrescar el informe después de agregar todos los conjuntos de datos
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report4.rdlc";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}