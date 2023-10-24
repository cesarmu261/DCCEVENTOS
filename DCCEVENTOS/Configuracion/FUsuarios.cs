using Datos;
using DatosManejo;
using DCCEVENTOS.Configuracion.Consulta;
using DCCEVENTOS.Reportes;
using DCCEVENTOS.Usuario;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCCEVENTOS.Configuracion
{
    public partial class FUsuarios : Form
    {
        private DataTable table = new DataTable();
        private NRol nrol;
        private NUsuarios nusu;
        private NEstado nestado;
        private NPermisos nper;
        public FUsuarios()
        {
            InitializeComponent();
            nrol = new NRol();
            nper = new NPermisos();
            nestado = new NEstado();
            nusu = new NUsuarios();
            CargarInformacion();
        }
        private void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            TBNom.Text = string.Empty;
            TBApe.Text = string.Empty;
            TBUau.Text = string.Empty;
            TBCon.Text = string.Empty;
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            table = nusu.Obtener();
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
            Object[] rol = nrol.ObtenerDescripciones();
            CBRol.DataSource = rol;
            CBRol.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBEstado.DataSource = estado;
            CBEstado.Refresh();
        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            ConsultaUsuarios consulta = new ConsultaUsuarios();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();

            List<Entidades.Usuario> List = new DMUsuarios(contexto).Obtener(NUsuarios.SSCod);

            foreach (var datos in List)
            {
                TBNom.Text = datos.Nombres.ToString(); // Asigna el valor de la primera columna al textBox1
                TBApe.Text = datos.Apellidos.ToString();
                TBUau.Text = datos.Usuario1.ToString();
                TBCon.Text = datos.Clave.ToString();

                string valorDeseado2 = nrol.ObtenerDescripcione(datos.IdRol); // Valor que deseas seleccionar

                int indice2 = CBRol.FindStringExact(valorDeseado2);
                if (indice2 != -1)
                {
                    CBRol.SelectedIndex = indice2; // Establecer el índice seleccionado
                }
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
                if (string.IsNullOrWhiteSpace(TBNom.Text) || string.IsNullOrWhiteSpace(TBApe.Text)
                || string.IsNullOrWhiteSpace(TBUau.Text) || string.IsNullOrWhiteSpace(TBCon.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                Entidades.Usuario datos = new Entidades.Usuario();
                datos.IdUsuario = NUsuarios.SSCod;
                datos.Nombres = TBNom.Text;
                datos.Apellidos = TBApe.Text;
                datos.Usuario1 = TBUau.Text;
                datos.Clave = TBCon.Text;
                datos.IdRol = nrol.ObtenerDescripcionesCod(CBRol.SelectedItem.ToString());
                datos.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                InfoCompartidaCapas rGuardar = nusu.Modificar(datos);
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
                if (string.IsNullOrWhiteSpace(TBNom.Text) || string.IsNullOrWhiteSpace(TBApe.Text)
                || string.IsNullOrWhiteSpace(TBUau.Text) || string.IsNullOrWhiteSpace(TBCon.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                Entidades.Usuario datos = new Entidades.Usuario();
                datos.Nombres = TBNom.Text;
                datos.Apellidos = TBApe.Text;
                datos.Usuario1 = TBUau.Text;
                datos.Clave = TBCon.Text;
                datos.IdRol = nrol.ObtenerDescripcionesCod(CBRol.SelectedItem.ToString());
                datos.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                InfoCompartidaCapas rGuardar = nusu.Guardar(datos);
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

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
            Nuevo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();

        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
