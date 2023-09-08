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
    public partial class ConsultaTipoTrenasacciones : Form
    {
        private DataTable tablas = new DataTable();
        private NTrans ntra;
        public ConsultaTipoTrenasacciones()
        {
            InitializeComponent();
            ntra = new NTrans();
        }
        private void CargarInformacion()
        {
            tablas = ntra.Obtener(textBox1.Text);
            dataGridView1.DataSource = tablas;
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

                NTrans.SSCod = Convert.ToInt32(SSCod);

                base.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CargarInformacion();
            }
        }
    }
}

