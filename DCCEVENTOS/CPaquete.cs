using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using Entidades;
using InfoCompartidaCaps;
using Negocio;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void ModificarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CBESTADO.Text) || string.IsNullOrWhiteSpace(TbDes.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEvePaquete categoria = new SaEvePaquete();
                categoria.CodPaquete = NPaquete.SSCod;
                categoria.DesPaquete = TbDes.Text;
                categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = npaquete.Modificar(categoria);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL PAQUETE");
                }
                CargarInformacion();
            }
            catch (Exception e)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA");
            }
            toolStripGuardar.Enabled = true;
        }
        private void Nuevo()
        {
            toolStripButton1.Enabled = false;
            toolStripGuardar.Enabled = true;
            TbDes.Text = string.Empty;
            CBESTADO.SelectedIndex = 0;
            CargarInformacion();
        }
        private void AgregarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CBESTADO.Text) || string.IsNullOrWhiteSpace(TbDes.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEvePaquete categoria = new SaEvePaquete();
                categoria.DesPaquete = TbDes.Text;
                categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = npaquete.Guardar(categoria);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE GUARDO CORRECTAMENTE EL PAQUETE");
                }
                CargarInformacion();
            }
            catch (Exception e)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS");
            }
        }
        private void Buscar()
        {
            toolStripGuardar.Enabled = false;
            toolStripButton1.Enabled = true;
            ConsultadePaquete consulta = new ConsultadePaquete();
            consulta.ShowDialog();
            EventosContext context = new EventosContext();
            List<SaEvePaquete> conceptosList = new DMPaquete(context).Obtener(NPaquete.SSCod);
            foreach (var concepto in conceptosList)
            {
                TbDes.Text = concepto.DesPaquete.ToString(); // Asigna el valor de la primera columna al textBox1
                string valorDeseado = nestado.ObtenerDescripcione(concepto.CodEstado); // Valor que deseas seleccionar
                int indice = CBESTADO.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBESTADO.SelectedIndex = indice; // Establecer el índice seleccionado
                }
            }
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
