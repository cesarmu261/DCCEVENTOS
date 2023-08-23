﻿using Negocio;
using System.Data;

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsultaPaqueteD : Form
    {
        private DataTable tablas = new DataTable();
        private NPaDetalle nPaDetalle;
        public ConsultaPaqueteD()
        {
            InitializeComponent();
            nPaDetalle = new NPaDetalle();
            CPrincipal.CambiarMaysucula(textBox1);
        }
        private void CargarInformacion()
        {
            tablas = nPaDetalle.ObtenerPaquete();
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

                NPaDetalle.SSCod = Convert.ToInt32(SSCod);

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
