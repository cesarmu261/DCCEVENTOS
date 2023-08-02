using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using Entidades;
using InfoCompartidaCaps;
using Negocio;
using System.Data;

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
            try
            {
                if (string.IsNullOrWhiteSpace(TbDes.Text) || string.IsNullOrWhiteSpace(TbPor.Text)
                   || string.IsNullOrWhiteSpace(CBESTADO.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEvePorcentaje categoria = new SaEvePorcentaje();
                categoria.DesPorcentaje = TbDes.Text;
                categoria.Porciento = Convert.ToDecimal(TbPor.Text);
                categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nporcentaje.Guardar(categoria);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                CargarInformacion();
            }
            catch (Exception e)
            {

                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }
        }

        private void ModificarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbDes.Text) || string.IsNullOrWhiteSpace(TbPor.Text) 
                    || string.IsNullOrWhiteSpace(CBESTADO.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEvePorcentaje categoria = new SaEvePorcentaje();
                categoria.CodPorcentaje = (int)NPorcentaje.SSCod;
                categoria.DesPorcentaje = TbDes.Text;
                categoria.Porciento = Convert.ToDecimal(TbPor.Text);
                categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nporcentaje.Modificar(categoria);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                CargarInformacion();
            }
            catch (Exception e)
            {

                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }
        }
        private void Nuevo()
        {
            TbDes.Text = string.Empty;
            TbPor.Text = string.Empty;
            CBESTADO.SelectedIndex = 0;
            CargarInformacion();
        }
        private void Buscar()
        {
            ConsultaPorcentaje consultaPorcentaje = new ConsultaPorcentaje();
            consultaPorcentaje.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEvePorcentaje> conceptosList = new DMPorcentaje(contexto).Obtener(NPorcentaje.SSCod);
            foreach (var concepto in conceptosList)
            {
                TbDes.Text = concepto.DesPorcentaje.ToString(); // Asigna el valor de la primera columna al textBox1
                TbPor.Text = concepto.Porciento.ToString(); // Asigna el valor de la segunda columna al textBox2
                string valorDeseado = nestado.ObtenerDescripcione(concepto.CodEstado); // Valor que deseas seleccionar

                int indice = CBESTADO.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBESTADO.SelectedIndex = indice; // Establecer el índice seleccionado
                }

            }
        }
        private void BTAgregar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }
        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            Nuevo();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
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
