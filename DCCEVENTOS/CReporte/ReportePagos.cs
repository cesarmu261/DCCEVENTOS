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
    public partial class ReportePagos : Form
    {
        DataTable table, table2;
        private NEventos nevento;
        private NEventoDetalle neventod;
        private NPago npago;

        private bool tablaCargada = false;
        public ReportePagos()
        {
            InitializeComponent();

            nevento = new NEventos();
            neventod = new NEventoDetalle();
            npago = new NPago();

        }
        private void Nuevo()
        {
            TBDescripcion.Text = string.Empty;
            TBClientes.Text = string.Empty;
            DTGEventos.DataSource = null;
            button2.Enabled = false;

            DTGDetalles.DataSource = null;
            button1.Enabled = false;
            button6.Enabled = false;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            dateTimePicker3.Text = string.Empty;
            dateTimePicker4.Text = string.Empty;
            dateTimePicker5.Text = string.Empty;
            dateTimePicker6.Text = string.Empty;
        }

        public void fecha()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker2.Value.Date;
            table = nevento.Obtener2(startDate, FINALDATE);
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();

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
        public void fechaCancelaciones()
        {
            DateTime selectedDate = dateTimePicker6.Value.Date;
            //DateTime startDate = selectedDate.Date.AddDays(-1);
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker5.Value.Date;
            table = npago.ObtenerCancelaciones(startDate, FINALDATE);
            DTGDetalles.DataSource = table;
            DTGDetalles.Refresh();

        }
        public void cliente()
        {
            table = nevento.Obtener3(NTercero.SSCod, "");
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();
        }
        public void descripcion()
        {
            table = nevento.Obtener3(0, TBDescripcion.Text);
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                fecha();
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBClientes.Text))
            {
                cliente();
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                TBClientes.Text = t.NomCliente.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                descripcion();
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }
        string SSCod;
        private void DTGEventos_DoubleClick(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            if (DTGEventos.CurrentRow.Index >= 0)
            {
                SSCod = DTGEventos.SelectedRows[0].Cells[0].Value.ToString();
                int cod = Convert.ToInt32(SSCod);
                table = npago.ObtenerPagoTodos(cod);
                DTGDetalles.DataSource = table;
                DTGDetalles.Refresh();
            }
            button2.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dateTimePicker4.Text))
            {
                fechapagos();
                button1.Enabled = true;
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
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

        private void DTGDetalles_DoubleClick(object sender, EventArgs e)
        {
            string SSCod;
            DataSet dataSet = new DataSet();

            if (DTGDetalles.CurrentRow.Index >= 0)
            {
                SSCod = DTGDetalles.SelectedRows[0].Cells[0].Value.ToString();
                int cod = Convert.ToInt32(SSCod);
                Recibo rE = new Recibo(cod);
                rE.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            fechaCancelaciones();
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker6.Value.Date;
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker5.Value.Date;
            DateTime finDate = FINALDATE.Date;
            ReciboCancelaciones reportForm = new ReciboCancelaciones(startDate, finDate);
            reportForm.Show();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                if (e.KeyChar == (char)13)
                {
                    descripcion();
                }
            }
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                TBClientes.Text = t.NomCliente.ToString();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
