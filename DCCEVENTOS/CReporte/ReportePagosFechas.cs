using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCCEVENTOS.CReporte
{
    public partial class ReportePagosFechas : Form
    {
        DataTable table, table2;
        private NEventos nevento;
        private NEventoDetalle neventod;
        private NPago npago;
        private bool tablaCargada = false;
        public ReportePagosFechas()
        {
            nevento = new NEventos();
            neventod = new NEventoDetalle();
            npago = new NPago();
            InitializeComponent();
        }
        private void Nuevo()
        {
            //button2.Enabled = false;
            DTGDetalles.DataSource = null;
            //button1.Enabled = false;
            dateTimePicker3.Text = string.Empty;
            dateTimePicker4.Text = string.Empty;
        }
        public void fechapagos()
        {
            DateTime selectedDate = dateTimePicker4.Value.Date;
            //DateTime startDate = selectedDate.Date.AddDays(-1);
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker3.Value.Date;
            table = npago.ObtenerPagosFecha(startDate, FINALDATE);
            DTGDetalles.DataSource = table;
            DTGDetalles.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fechapagos();
            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker4.Value.Date;
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker3.Value.Date;
            DateTime finDate = FINALDATE.Date;
            RecibosFechas reportForm = new RecibosFechas(startDate, finDate);
            reportForm.Show();
        }
        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //public void fechaCancelaciones()
        //{
        //    DateTime selectedDate = dateTimePicker6.Value.Date;
        //    //DateTime startDate = selectedDate.Date.AddDays(-1);
        //    DateTime startDate = selectedDate.Date;
        //    DateTime FINALDATE = dateTimePicker5.Value.Date;
        //    table = npago.ObtenerCancelaciones(startDate, FINALDATE);
        //    DTGDetalles.DataSource = table;
        //    DTGDetalles.Refresh();
        //}
        //private void pictureBox6_Click(object sender, EventArgs e)
        //{
        //    fechaCancelaciones();
        //    button6.Enabled = true;
        //}
        //private void button6_Click(object sender, EventArgs e)
        //{
        //    DateTime selectedDate = dateTimePicker6.Value.Date;
        //    DateTime startDate = selectedDate.Date;
        //    DateTime FINALDATE = dateTimePicker5.Value.Date;
        //    DateTime finDate = FINALDATE.Date.AddDays(1);
        //    ReciboCancelaciones reportForm = new ReciboCancelaciones(startDate, finDate);
        //    reportForm.Show();
        //}
    }
}
