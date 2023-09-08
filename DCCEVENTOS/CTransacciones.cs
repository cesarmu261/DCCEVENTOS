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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCCEVENTOS
{
    public partial class CTransacciones : Form
    {
        DataTable table;
        NTrans ntra;
        public CTransacciones()
        {
            InitializeComponent();
            table = new DataTable();
            ntra = new NTrans();
            CargarInformacion();
        }
        private void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            TbDes.Text = string.Empty;
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            table = ntra.Obtener();
            Existencia.DataSource = table;
            Existencia.Refresh();
        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            ConsultaTipoTrenasacciones consulta = new ConsultaTipoTrenasacciones();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEvTipoTransaccion> List = new DMTrans(contexto).Obtener(NTrans.SSCod);
            foreach (var salon in List)
            {
                TbDes.Text = salon.DesTipoTransaccion.ToString(); // Asigna el valor de la primera columna al textBox1
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
                SaEvTipoTransaccion tra = new SaEvTipoTransaccion();
                tra.CodTipoTransaccion = NTrans.SSCod;
                tra.DesTipoTransaccion = TbDes.Text;


                InfoCompartidaCapas rGuardar = ntra.Modificar(tra);
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
                if (string.IsNullOrWhiteSpace(TbDes.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEvTipoTransaccion tra = new SaEvTipoTransaccion();
                tra.DesTipoTransaccion = TbDes.Text;

                InfoCompartidaCapas rGuardar = ntra.Guardar(tra);
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
