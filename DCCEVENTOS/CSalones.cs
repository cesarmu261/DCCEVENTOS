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
    public partial class CSalones : Form
    {
        private DataTable tablacategoria = new DataTable();
        private NSalones nsalones;
        private NEstado nestado;
        public CSalones()
        {
            InitializeComponent();
            nsalones = new NSalones();
            nestado = new NEstado();
            CargarInformacion();
        }
        private void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            toolStripButton1.Enabled = false;
            TbDes.Text = string.Empty;
            textBox1.Text = string.Empty;
            CBESTADO.SelectedIndex = 0;
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            tablacategoria = nsalones.Obtener();
            CategoriaExistencia.DataSource = tablacategoria;
            CategoriaExistencia.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBESTADO.DataSource = estado;
            CBESTADO.Refresh();

        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            toolStripButton1.Enabled = true;
            ConsultaTipoTrenasacciones consulta = new ConsultaTipoTrenasacciones();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEventoSalone> List = new DMSalones(contexto).Obtener(NSalones.SSCod);
            foreach (var salon in List)
            {
                TbDes.Text = salon.DesSalon.ToString(); // Asigna el valor de la primera columna al textBox1
                textBox1.Text = salon.DeslarSalon.ToString();
                string valorDeseado = nestado.ObtenerDescripcione(salon.CodEstado); // Valor que deseas seleccionar

                int indice = CBESTADO.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBESTADO.SelectedIndex = indice; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3
            }

        }
        private void ModificarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbDes.Text)
                       || string.IsNullOrWhiteSpace(CBESTADO.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEventoSalone salon = new SaEventoSalone();
                salon.CodSalon = NSalones.SSCod;
                salon.DesSalon = TbDes.Text;
                salon.DeslarSalon = textBox1.Text;
                salon.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nsalones.Modificar(salon);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL SALON");
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
                if (string.IsNullOrWhiteSpace(TbDes.Text)
                   || string.IsNullOrWhiteSpace(CBESTADO.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEventoSalone Salon = new SaEventoSalone();
                Salon.DesSalon = TbDes.Text;
                Salon.DeslarSalon = textBox1.Text;
                Salon.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nsalones.Guardar(Salon);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE GUARDO CORRECTAMENTE EL SALON");
                }
                CargarInformacion();
            }
            catch (Exception e)
            {

                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }
        }
        private void BTNAgre_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            Nuevo();
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

