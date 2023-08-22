using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using Coneccion;
using Microsoft.Reporting.WinForms;

namespace DCCEVENTOS.Reportes
{
    public partial class RESAL : Form
    {
        Conecciones con;
        private int valor;
        public RESAL(int salon)
        {
            InitializeComponent();
            con = new Conecciones();
            this.valor = salon;
        }
        private DbConnection coneccion;

        private void RESAL_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            DataSet1TableAdapters.sp_DetalleEventosalonTableAdapter tableAdapter = new DataSet1TableAdapters.sp_DetalleEventosalonTableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("RESAL"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            //foreach (int valor in valores)
            //{
            tableAdapter.Fill(dataSet.sp_DetalleEventosalon, valor);
            // Agregar los datos a las fuentes de datos
            ReportDataSource reportDataSources = new ReportDataSource("DataSet1", dataSet.Tables["sp_DetalleEventosalon"]);
            //}
            // Asignar las fuentes de datos al ReportViewer1
            reportViewer1.LocalReport.DataSources.Add(reportDataSources);

            // Refrescar el informe después de agregar todos los conjuntos de datos
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report2.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
