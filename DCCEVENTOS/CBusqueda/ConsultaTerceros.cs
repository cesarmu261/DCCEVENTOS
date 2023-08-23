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
    public partial class ConsultaTerceros : Form
    {
        private DataTable tabla = new DataTable();
        NTercero ntercero;
        public ConsultaTerceros()
        {
            InitializeComponent();
            ntercero = new NTercero();
            CPrincipal.CambiarMaysucula(textBox1);
        }
        private void CargarInformacion()
        {
            tabla = ntercero.Obtener2(textBox1.Text);
            dataGridView1.DataSource = tabla;
            dataGridView1.Refresh();
        }
        private void BTNBus_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string SSCodcon, SSDescon, SScan;

            if (dataGridView1.CurrentRow.Index >= 0)
            {

                SSCodcon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SSDescon = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                NTercero.SSCodcon = SSCodcon;
                NTercero.SSDescon = SSDescon;
                NTercero.SSCod = Convert.ToInt32(SSCodcon);
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
