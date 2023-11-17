using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
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
    public partial class CComprobante : Form
    {
        DataTable table;
        NComprobante ncom;
        NEstado nestado;
        public CComprobante()
        {
            InitializeComponent();
            table = new DataTable();
            ncom = new NComprobante();
            nestado = new NEstado();
            CargarInformacion();
        }
        private void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            toolStripButton1.Enabled = false;
            TbDes.Text = string.Empty;
            CBESTADO.SelectedIndex = 0;
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            table = ncom.Obtener();
            Existencia.DataSource = table;
            Existencia.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBESTADO.DataSource = estado;
            CBESTADO.Refresh();
        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            toolStripButton1.Enabled = true;
            Consultadetipocomprobante consulta = new Consultadetipocomprobante();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveTipoComprobante> List = new DMComprobante(contexto).Obtener(NComprobante.SSCod);
            foreach (var entidad in List)
            {
                TbDes.Text = entidad.DesComprobante.ToString();
                string valorDeseado = nestado.ObtenerDescripcione(entidad.CodEstado); // Valor que deseas seleccionar

                int indice = CBESTADO.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBESTADO.SelectedIndex = indice; // Establecer el índice seleccionado
                }
            }
        }
        private void ModificarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbDes.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEveTipoComprobante comp = new SaEveTipoComprobante();
                comp.CodComprobante = NComprobante.SSCod;
                comp.DesComprobante = TbDes.Text;
                comp.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = ncom.Modificar(comp);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL TIPO COMPROBANTE");
                }
                CargarInformacion();
            }
            catch (Exception e)
            {

                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }
            toolStripGuardar.Enabled = true;
        }

        private void AgregarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbDes.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEveTipoComprobante comp = new SaEveTipoComprobante();
                comp.DesComprobante = TbDes.Text;
                comp.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = ncom.Guardar(comp);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE AGREGO CORRECTAMENTE EL TIPO DE COMPROBANTE");
                }
                CargarInformacion();
            }
            catch (Exception e)
            {

                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            Nuevo();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            Nuevo();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
