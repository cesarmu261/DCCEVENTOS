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
    public partial class MetododePago : Form
    {
        NTipoPago ntipoPago;
        NFacturacion nFacturacion;
        public MetododePago()
        {
            InitializeComponent();
            ntipoPago = new NTipoPago();
            nFacturacion = new NFacturacion();
        }
        public void CargarInformacion()
        {
            Object[] pago = ntipoPago.ObtenerDescripciones();
            comboBox1.DataSource = pago;
            comboBox1.Refresh();
        }
        private void MetododePago_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }
        private void BTNBus_Click(object sender, EventArgs e)
        {
            string valor = ntipoPago.Obtenerfac(comboBox1.Text);
            NFacturacion.tipoPago = valor;
            this.Close();
        }
    }
}
