using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using DCCEVENTOS.Usuario.Consulta;
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

namespace DCCEVENTOS.Usuario
{
    public partial class FRoles : Form
    {
        private DataTable Table = new DataTable();
        private NRol nrol;
        private NEstado nestado;
        public FRoles()
        {
            InitializeComponent();
            nrol = new NRol();
            nestado = new NEstado();
            CargarInformacion();
        }
        private void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            TBDes.Text = string.Empty;
            CBEstado.SelectedIndex = 0;
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            Table = nrol.Obtener();
            dataGridView1.DataSource = Table;
            dataGridView1.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBEstado.DataSource = estado;
            CBEstado.Refresh();
        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            ConsultaRol consulta = new ConsultaRol();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<Rol> List = new DMRol(contexto).Obtener(NRol.SSCod);
            foreach (var datos in List)
            {
                TBDes.Text = datos.Nombre.ToString(); // Asigna el valor de la primera columna al textBox1
                string valorDeseado = nestado.ObtenerDescripcione(datos.CodEstado); // Valor que deseas seleccionar

                int indice = CBEstado.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBEstado.SelectedIndex = indice; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3
            }
        }
        private void ModificarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TBDes.Text)
                       || string.IsNullOrWhiteSpace(CBEstado.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                Rol datos = new Rol();
                datos.IdRol = NRol.SSCod;
                datos.Nombre = TBDes.Text;
                datos.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nrol.Modificar(datos);
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
            toolStripGuardar.Enabled = true;
        }

        private void AgregarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TBDes.Text)
                   || string.IsNullOrWhiteSpace(CBEstado.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                Rol datos = new Rol();
                datos.Nombre = TBDes.Text;
                datos.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nrol.Guardar(datos);
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

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
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

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
