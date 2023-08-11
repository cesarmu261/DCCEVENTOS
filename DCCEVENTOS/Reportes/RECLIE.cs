using Coneccion;
using Microsoft.Reporting.WinForms;
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
    public partial class RECLIE : Form
    {

        Conecciones con;
        private int VALOR;
        public RECLIE(int CLIENTES)
        {
            InitializeComponent();
            con = new Conecciones();
            VALOR = CLIENTES;
        }
        private DbConnection coneccion;
        private void RECLIE_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            DataSet1TableAdapters.sp_DetalleEventoclientesTableAdapter tableAdapter = new DataSet1TableAdapters.sp_DetalleEventoclientesTableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("RECLIE"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            //foreach (int valor in valores)
            //{
            tableAdapter.Fill(dataSet.sp_DetalleEventoclientes, VALOR);
            // Agregar los datos a las fuentes de datos
            ReportDataSource reportDataSources = new ReportDataSource("DataSet1", dataSet.Tables["sp_DetalleEventoclientes"]);
            //}
            // Asignar las fuentes de datos al ReportViewer1
            reportViewer1.LocalReport.DataSources.Add(reportDataSources);

            // Refrescar el informe después de agregar todos los conjuntos de datos
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report2.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
