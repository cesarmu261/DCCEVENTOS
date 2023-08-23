using Negocio;
using System.Data;

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsultaPorcentaje : Form
    {
        private DataTable tablaconceptos = new DataTable();
        private NPorcentaje nPorcentaje;
        public ConsultaPorcentaje()
        {
            InitializeComponent();
            nPorcentaje = new NPorcentaje();
            CPrincipal.CambiarMaysucula(textBox1);
        }
        private void CargarInformacion()
        {
            tablaconceptos = nPorcentaje.ObtenerPorcentajes(textBox1.Text);
            dataGridView1.DataSource = tablaconceptos;
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

                NPorcentaje.SSCod = Convert.ToDecimal(SSCod);

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
