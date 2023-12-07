using Coneccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using DCCEVENTOS.Reportes.DataSet1TableAdapters;

namespace DCCEVENTOS.Reportes
{
    public partial class PRECA : Form
    {
        private int VALOR;
        Conecciones con;
        public PRECA(int VALOR)
        {
            con = new Conecciones();
            this.VALOR = VALOR;
            InitializeComponent();
        }
        public int Cod_Evento;
        private DbConnection coneccion;
        public void FRE2_Load(object sender, EventArgs e)
        {
            DataSet1 dataSet = new DataSet1();
            sp_recibosporeventoTableAdapter tableAdapter = new sp_recibosporeventoTableAdapter();
            coneccion = new SqlConnection(con.ObtenerConeccion("ReciboCancelaciones"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            tableAdapter.Fill(dataSet.sp_recibosporevento, VALOR);
            ReportDataSource reportDataSources = new ReportDataSource("DataSet1", dataSet.Tables["sp_recibosporevento"]);
            reportViewer1.LocalReport.DataSources.Add(reportDataSources);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report8.rdlc";
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}

