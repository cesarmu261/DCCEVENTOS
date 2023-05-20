using DatosManejo;
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
    public partial class CPorcentaje : Form
    {
        private DataTable tablaporcentaje = new DataTable();
        private NPorcentaje nporcentaje;
        private NEstado nestado;
        public CPorcentaje()
        {
            InitializeComponent();
            nporcentaje = new NPorcentaje();
            nestado = new NEstado();
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            tablaporcentaje = nporcentaje.ObtenerPorcentajes();
            PorcentjesExistencia.DataSource = tablaporcentaje;
            PorcentjesExistencia.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBESTADO.DataSource = estado;
            CBESTADO.Refresh();

        }
        private void AgregarRegistro()
        {
            SaEvePorcentaje categoria = new SaEvePorcentaje();
            categoria.DesPorcentaje = TBDesPor.GetTextBox().Text;
            categoria.Porciento = Convert.ToDecimal(TBPorciento.GetTextBox().Text);
            categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

            InfoCompartidaCapas rGuardar = nporcentaje.Guardar(categoria);
            if (!String.IsNullOrEmpty(rGuardar.error))
            {
                MessageBox.Show(rGuardar.error);
            }
            CargarInformacion();
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void BTNAct_Click(object sender, EventArgs e)
        {
            InfoCompartidaCapas rGest = nporcentaje.GestionarDataTable(tablaporcentaje, (DataTable)PorcentjesExistencia.DataSource);
            if (!String.IsNullOrEmpty(rGest.error))
            {
                MessageBox.Show(rGest.error);
            }
        }
    }
}
