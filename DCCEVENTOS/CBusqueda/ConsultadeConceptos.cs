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
    public partial class ConsultadeConceptos : Form
    {
        private DataTable tablaconceptos = new DataTable();
        private NConceptos nconceptos;
        public ConsultadeConceptos()
        {
            InitializeComponent();
            nconceptos = new NConceptos();
        }
        private void CargarInformacion()
        {
            tablaconceptos = nconceptos.ObtenerConceptos2(textBox1.Text);
            dataGridView1.DataSource = tablaconceptos;
            dataGridView1.Refresh();
        }
        private void BTNBus_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string SSCodcon;
            DataSet dataSet = new DataSet();
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                SSCodcon = dataGridView1.SelectedRows[0].Cells["DesConceptos"].Value.ToString();
                NConceptos.SSCodcon = SSCodcon;
                base.Close();
            }
        }
    }
}
