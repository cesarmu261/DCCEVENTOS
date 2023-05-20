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
    public partial class CPaquete : Form
    {
        private DataTable tablapaquete = new DataTable();
        private NPaquete npaquete;
        private NEstado nestado;
        public CPaquete()
        {
            InitializeComponent();
            npaquete = new NPaquete();
            nestado = new NEstado();
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            tablapaquete = npaquete.ObtenerPaquete();
            PaqueteExistencia.DataSource = tablapaquete;
            PaqueteExistencia.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBESTADO.DataSource = estado;
            CBESTADO.Refresh();

        }
        private void AgregarRegistro()
        {
            SaEvePaquete categoria = new SaEvePaquete();
            categoria.DesPaquete = TBDesPaq.GetTextBox().Text;
            categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

            InfoCompartidaCapas rGuardar = npaquete.Guardar(categoria);
            if (!String.IsNullOrEmpty(rGuardar.error))
            {
                MessageBox.Show(rGuardar.error);
            }
            CargarInformacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }
    }
}
