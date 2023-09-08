using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
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
    public partial class ConsultadeEventosDes : Form
    {
        private DataTable table = new DataTable();
        private NEventos nevento;
        public ConsultadeEventosDes()
        {
            InitializeComponent();
            nevento = new NEventos();
            
        }
        private void CargarInformacion()
        {
            table = nevento.Obtener3(0, textBox1.Text);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void BTNBus_Click(object sender, EventArgs e)
        {
            
                CargarInformacion();
            
            
        }
        string SSCod;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            if (dataGridView1.CurrentRow.Index >= 0)
            {
                SSCod = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                NEventos.SSCod = Convert.ToInt32(SSCod);

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
