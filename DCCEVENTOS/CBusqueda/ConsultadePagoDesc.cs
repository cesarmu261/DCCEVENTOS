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


        public ConsultadePagoDesc()
        {
            InitializeComponent();
            nevento = new NEventos();
            neventod = new NEventoDetalle();
            npago = new NPago();
        }
        DataTable table, table2;

        public void CargarDes()
        {
            table = nevento.Obtener3(0, TBDescripcion.Text);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
        private void CargarPagos()
        {
            table2 = npago.ObtenerPagoTodos(NEventos.SSCod);
            dataGridView2.DataSource = table2;
            dataGridView2.Refresh();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CargarDes();

        }

        private void TBDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CargarDes();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            string SSCodcon, SSDescon, SScan;

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                SSCodcon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                NEventos.SSCod = Convert.ToInt32(SSCodcon);

            }
            CargarPagos();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string SSCod;
            DataSet dataSet = new DataSet();

            if (dataGridView2.CurrentRow.Index >= 0)
            {
                SSCod = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                NPago.SSCod = Convert.ToInt32(SSCod);
                base.Close();
            }
        }
    }
}
