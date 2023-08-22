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
    public partial class REDES : Form
    {
        Conecciones con;
        private string VALOR;
        public REDES(string descripcion)
        {
            InitializeComponent();
            con = new Conecciones();
            this.VALOR = descripcion;
        }
        private DbConnection coneccion;
        private void REDES_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            DataSet1TableAdapters.sp_DetalleEventodescripcionTableAdapter tableAdapter = new DataSet1TableAdapters.sp_DetalleEventodescripcionTableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("REDES"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            //foreach (int valor in valores)
            //{
            tableAdapter.Fill(dataSet.sp_DetalleEventodescripcion, VALOR);
            // Agregar los datos a las fuentes de datos
            ReportDataSource reportDataSources = new ReportDataSource("DataSet1", dataSet.Tables["sp_DetalleEventodescripcion"]);
            //}
            // Asignar las fuentes de datos al ReportViewer1
            reportViewer1.LocalReport.DataSources.Add(reportDataSources);

            // Refrescar el informe después de agregar todos los conjuntos de datos
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report2.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
