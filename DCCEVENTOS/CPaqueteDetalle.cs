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



namespace DCCEVENTOS
{
    public partial class CPaqueteDetalle : Form
    {
        private DataTable tablaconceptos = new DataTable();
        private NConceptos nconceptos;
        public CPaqueteDetalle()
        {

            InitializeComponent();
            nconceptos = new NConceptos();
        }
        private void CargarInformacion(string ss)
        {
            tablaconceptos = nconceptos.ObtenerConceptos2(ss);
            PaqueteExistencia.DataSource = tablaconceptos;
        }
        private void CPaqueteDetalle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBusqueda.ConsultadeConceptos form = new CBusqueda.ConsultadeConceptos();
            form.ShowDialog();
            string ssCodcon = NConceptos.SSCodcon;
            textBox1.Text = ssCodcon;
            string t = textBox1.Text;


        }
    }
}
