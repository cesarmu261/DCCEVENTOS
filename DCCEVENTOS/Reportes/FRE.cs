﻿using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
using Coneccion;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Data.Common;
using System.Data.SqlClient;

namespace DCCEVENTOS.Reportes
{
    public partial class FRE : Form
    {
        Conecciones con;
        private int VALOR;
        public FRE(int VALOR)
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

            DataSet1TableAdapters.sp_DetalleEventoTableAdapter tableAdapter = new DataSet1TableAdapters.sp_DetalleEventoTableAdapter();
            DataSet1TableAdapters.sp_EventosTableAdapter tableAdapter1 = new DataSet1TableAdapters.sp_EventosTableAdapter();

            coneccion = new SqlConnection(con.ObtenerConeccion("FRE"));
            tableAdapter.Connection = (SqlConnection)coneccion;
            tableAdapter1.Connection = (SqlConnection)coneccion;

            //int VALOR;
            //VALOR = Cod_Evento;
            // Llenar el DataSet con datos desde la fuente de datos
            tableAdapter1.Fill(dataSet.sp_Eventos, VALOR);
            tableAdapter.Fill(dataSet.sp_DetalleEvento, VALOR);
            //reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataSet.Tables["sp_DetalleEvento"]);
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet2", dataSet.Tables["sp_Eventos"]);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.ReportEmbeddedResource = "DCCEVENTOS.Reportes.Report1.rdlc";
            reportViewer1.RefreshReport();

        }
    }
}
