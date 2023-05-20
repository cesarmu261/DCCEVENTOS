using Entidades;
using InfoCompartidaCaps;
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
    public partial class CConcepto : Form
    {

        private DataTable tablaconceptos = new DataTable();
        private NConceptos nconceptos;
        private NPorcentaje nporcentaje;
        private NEstado nestado;
        private NCategoria ncategoria;
        public CConcepto()
        {
            InitializeComponent();
            nconceptos = new NConceptos();
            nporcentaje = new NPorcentaje();
            nestado = new NEstado();
            ncategoria = new NCategoria();
            CargarInformacion();

        }
        private void CargarInformacion()
        {
            tablaconceptos = nconceptos.ObtenerConceptos();
            conceptosexistentes.DataSource = tablaconceptos;
            conceptosexistentes.Refresh();
            Object[] categoria = ncategoria.ObtenerDescripciones();
            if (categoria.Length > 0)
            {
                CBCodCat.DataSource = categoria;
                CBCodCat.Refresh();
            }
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            Object[] porcentaje = nporcentaje.ObtenerDescripciones();
            if (porcentaje.Length > 0)
            {
                CBCodPor.DataSource = porcentaje;
                CBCodPor.Refresh();
            }

            textBox1.Text = Convert.ToString(nporcentaje.Obtenerporciento(CBCodPor.SelectedItem.ToString()));
        }
        private void AgregarRegistro()
        {
            SaEveConcepto concepto = new SaEveConcepto();
            concepto.CodCategoria = ncategoria.ObtenerDescripcionesCod(CBCodCat.SelectedItem.ToString());
            concepto.DesConceptos = TBDesCon.GetTextBox().Text;
            concepto.CostosConceptos = Convert.ToDecimal(TBCostosCon.GetTextBox().Text);
            concepto.Costoprecio = Convert.ToDecimal(TBCostosprecio.GetTextBox().Text);
            concepto.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
            concepto.CodPorcentaje = nporcentaje.ObtenerDescripcionesCod(CBCodPor.SelectedItem.ToString());
            concepto.Porciento = Convert.ToDecimal(textBox1.Text);

            InfoCompartidaCapas rGuardar = nconceptos.Guardar(concepto);
            if (!String.IsNullOrEmpty(rGuardar.error))
            {
                MessageBox.Show(rGuardar.error);
            }
            CargarInformacion();
        }
        private void BTNAgre_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BTNAct_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void CBCodPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(nporcentaje.Obtenerporciento(CBCodPor.SelectedItem.ToString()));
        }
    }
}
