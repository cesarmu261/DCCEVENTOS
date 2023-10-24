using Entidades;
using Negocio;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsultadeConceptos : Form
    {
        private DataTable tablaconceptos = new DataTable();
        private NConceptos nconceptos;
        private CPaqueteDetalle cPaquete;
        private Concepto concepto;
        public ConsultadeConceptos()
        {
            InitializeComponent();
            nconceptos = new NConceptos();
            cPaquete = new CPaqueteDetalle();
            concepto = new Concepto();
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
            int? SSCategoria;
            decimal? ssCostosC;
            DataSet dataSet = new DataSet();

            if (dataGridView1.CurrentRow.Index >= 0)
            {

                SSCodcon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SSDescon = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                SScan = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                NConceptos.SSCodcon = SSCodcon;
                NConceptos.SSDescon = SSDescon;
                NConceptos.SScantidad = SScan;


                ssCostosC = nconceptos.ObtenerCostos(NConceptos.SSCod);
                NConceptos.SSCostos = Convert.ToString(ssCostosC);
                NConceptos.SSCod = Convert.ToInt32(SSCodcon);
                SSCategoria = nconceptos.Obtenercategoria(NConceptos.SSCod);
                NConceptos.SSCategoria = nconceptos.ObtenerNombreTipoCategoria(SSCategoria);
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


        private void button1_Click(object sender, EventArgs e)
        {
            int totalseleccion = dataGridView1.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells[0].Value)).Count();
            DialogResult dg;
            string SSCodcon, SSDescon, SScan;
            if (totalseleccion >= 1)
            {
                dg = MessageBox.Show("Desea selecionar los" + totalseleccion + "registros seleccionados", "Pregunta",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            SSCodcon = row.Cells[1].Value.ToString();
                            SSDescon = row.Cells[2].Value.ToString();
                            SScan = row.Cells[3].Value.ToString();

                            NConceptos.SSCodcon = SSCodcon;
                            NConceptos.SSDescon = SSDescon;
                            NConceptos.SScantidad = SScan;

                            Concepto nuevoConcepto = new Concepto
                            {
                                SSCodcon = SSCodcon,
                                SSDescon = SSDescon,
                                SScantidad = SScan
                            };

                            Concepto.listaConceptos.Add(nuevoConcepto);

                        }
                        base.Close();
                    }
                }
            }
        }
    }
}
