using Negocio;
using System.Data;

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
            string SSCodcon, SSDescon, SScan;
            DataSet dataSet = new DataSet();

            if (dataGridView1.CurrentRow.Index >= 0)
            {

                SSCodcon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SSDescon = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                SScan = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                NConceptos.SSCodcon = SSCodcon;
                NConceptos.SSDescon = SSDescon;
                NConceptos.SScantidad = SScan;
                NConceptos.SSCod = Convert.ToInt32(SSCodcon);
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
