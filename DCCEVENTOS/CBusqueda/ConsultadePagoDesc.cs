using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsultadePagoDesc : Form
    {
        private NEventos nevento;
        private NEventoDetalle neventod;
        private NPago npago;

        private bool tablaCargada = false;

        public ConsultadePagoDesc()
        {
            InitializeComponent();
            nevento = new NEventos();
            neventod = new NEventoDetalle();
            npago = new NPago();
        }
        DataTable table, table2;

        public void CargarInfomacion()
        {
            table = nevento.Obtener3(0, TBDescripcion.Text);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                CargarInfomacion();
                button5.Enabled = true;
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void TBDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CargarInfomacion();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();

            //if (DTGEventos.CurrentRow.Index >= 0)
            //{
            //    SSCod = DTGEventos.SelectedRows[0].Cells[0].Value.ToString();
            //    int cod = Convert.ToInt32(SSCod);
            //    table = npago.ObtenerPagoTodos(cod);
            //    DTGDetalles.DataSource = table;
            //    DTGDetalles.Refresh();
            //}
            //button2.Enabled = true;
        }
    }
}
