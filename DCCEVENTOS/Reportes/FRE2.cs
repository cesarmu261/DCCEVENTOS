using Coneccion;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
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

namespace DCCEVENTOS.Reportes
{
    public partial class FRE2 : Form
    {
        Conecciones con;

        private DateTime valores, valores2;

        private int VALOR;
        public FRE2(DateTime selectedDate, DateTime findate)
        {
            InitializeComponent();
            con = new Conecciones();
            this.valores = selectedDate;
            this.valores2 = findate;
        }
        public int Cod_Evento;
        private DbConnection coneccion;

        private void FRE2_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            DataSet1TableAdapters.sp_DetalleEvento2TableAdapter tableAdapter = new DataSet1TableAdapters.sp_DetalleEvento2TableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("FRE2"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            //foreach (int valor in valores)
            //{
            tableAdapter.Fill(dataSet.sp_DetalleEvento2, valores, valores2);
            // Agregar los datos a las fuentes de datos
            ReportDataSource reportDataSources = new ReportDataSource("DataSet1", dataSet.Tables["sp_DetalleEvento2"]);
            //}
            // Asignar las fuentes de datos al ReportViewer1
            reportViewer1.LocalReport.DataSources.Add(reportDataSources);

            // Refrescar el informe después de agregar todos los conjuntos de datos
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report2.rdlc";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}
