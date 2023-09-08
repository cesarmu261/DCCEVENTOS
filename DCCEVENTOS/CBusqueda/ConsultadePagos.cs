using DatosManejo;
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
    public partial class ConsultadePagos : Form
    {
        DataTable table = new DataTable();
        NPago nPago;
        public ConsultadePagos()
        {
            InitializeComponent();
            nPago = new NPago();
        }
        private void CargarInformacion()
        {
            table = nPago.ObtenerPago();
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void BTNBus_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string SSCod;
            DataSet dataSet = new DataSet();

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                SSCod = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                NPago.SSCod = Convert.ToInt32(SSCod);

                base.Close();
            }
        }
    }
}
