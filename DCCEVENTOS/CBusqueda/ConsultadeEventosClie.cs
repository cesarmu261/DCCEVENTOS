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
    public partial class ConsultadeEventosClie : Form
    {
        private DataTable tabla = new DataTable();
        private NEventos nevento;
        private NCliente ncliente;
        public ConsultadeEventosClie()
        {
            InitializeComponent();
            ncliente = new NCliente();
            nevento = new NEventos();
        }
        private void CargarCliente()
        {
            tabla = ncliente.Obtener2(textBox1.Text);
            dataGridView1.DataSource = tabla;
            dataGridView1.Refresh();
        }

        private void CargarEvento()
        {
            tabla = nevento.Obtener3(NCliente.SSCod, "");
            dataGridView2.DataSource = tabla;
            dataGridView2.Refresh();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string SSCodcon, SSDescon, SScan;

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                SSCodcon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SSDescon = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                NCliente.SSCodcon = SSCodcon;
                NCliente.SSDescon = SSDescon;
                NCliente.SSCod = Convert.ToInt32(NCliente.SSCodcon);

            }
            CargarEvento();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CargarCliente();
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                string SSCod = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                NEventos.SSCod = Convert.ToInt32(SSCod);

                base.Close();
            }
        }

        private void BTNBus_Click(object sender, EventArgs e)
        {
            CargarCliente();
        }
    }
}
