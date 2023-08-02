using Negocio;
using System.Data;

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsulatadeCategorias : Form
    {
        private DataTable tablascategorias = new DataTable();
        private NCategoria ncategoria;
        public ConsulatadeCategorias()
        {
            InitializeComponent();
            ncategoria = new NCategoria();
        }
        private void CargarInformacion()
        {
            tablascategorias = ncategoria.ObtenerCategoria(textBox1.Text);
            dataGridView1.DataSource = tablascategorias;
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

                NCategoria.SSCod = Convert.ToInt32(SSCod);

                base.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
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
