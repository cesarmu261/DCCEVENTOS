using Datos;
using DatosManejo;
using DCCEVENTOS.Reportes;
using Entidades;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsultaDeEventos : Form
    {
        DataTable table;
        private NEventos nevento;
        private NEventoDetalle neventod;

        private bool tablaCargada = false;
        public ConsultaDeEventos()
        {
            InitializeComponent();
            nevento = new NEventos();
            neventod = new NEventoDetalle();
        }

        public void fecha()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime startDate = selectedDate.Date;

            table = nevento.Obtener2(startDate);
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();

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


        private void BTNBus_Click(object sender, EventArgs e)
        {
            descripcion();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime newDate = selectedDate.AddMonths(1);
            dateTimePicker2.Value = newDate;
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NTercero.SSCod);
            foreach (var t in List)
            {
                TBClientes.Text = t.NomCliente.ToString();
            }
        }

        private void DTGEventos_DoubleClick(object sender, EventArgs e)
        {
            string SSCod;
            DataSet dataSet = new DataSet();

            if (DTGEventos.CurrentRow.Index >= 0)
            {
                SSCod = DTGEventos.SelectedRows[0].Cells[0].Value.ToString();
                int cod = Convert.ToInt32(SSCod);
                table = neventod.ObteneEventos(cod);
                DTGDetalles.DataSource = table;
                DTGDetalles.Refresh();
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

        private void button2_Click(object sender, EventArgs e)
        {
            FRE rE = new FRE();

            rE.Show();
        }
    }
}
