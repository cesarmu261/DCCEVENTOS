using Coneccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;

namespace DCCEVENTOS.Reportes
{
    public partial class Devolucion : Form
    {
        Conecciones con;
        private int VALOR;
        public Devolucion(int VALOR)
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
            DataSet1TableAdapters.sp_devolucionTableAdapter tableAdapter1 = new DataSet1TableAdapters.sp_devolucionTableAdapter();
            coneccion = new SqlConnection(con.ObtenerConeccion("Devolucion"));
            tableAdapter1.Connection = (SqlConnection)coneccion;
            tableAdapter1.Fill(dataSet.sp_devolucion, VALOR);

            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", dataSet.Tables["sp_devolucion"]);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report7.rdlc";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}

