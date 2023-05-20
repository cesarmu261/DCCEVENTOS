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
using Entidades;
using InfoCompartidaCaps;
using Negocio;

namespace DCCEVENTOS
{
    public partial class CCategoria : Form
    {

        private DataTable tablacategoria = new DataTable();
        private NCategoria ncategoria;
        private NEstado nestado;
        public CCategoria()
        {
            InitializeComponent();
            ncategoria = new NCategoria();
            nestado = new NEstado();
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            tablacategoria = ncategoria.ObtenerCategoria();
            CategoriaExistencia.DataSource = tablacategoria;
            CategoriaExistencia.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBESTADO.DataSource = estado;
            CBESTADO.Refresh();

        }
        private void AgregarRegistro()
        {
            SaEveCategoriaimp categoria = new SaEveCategoriaimp();
            categoria.DesCategoria = TBDESCAT.GetTextBox().Text;
            categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

            InfoCompartidaCapas rGuardar = ncategoria.Guardar(categoria);
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

        private void BTNAct_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            InfoCompartidaCapas rGest = ncategoria.GestionarDataTable(tablacategoria, (DataTable)CategoriaExistencia.DataSource);
            if (!String.IsNullOrEmpty(rGest.error))
            {
                MessageBox.Show(rGest.error);
            }
        }
    }
}
