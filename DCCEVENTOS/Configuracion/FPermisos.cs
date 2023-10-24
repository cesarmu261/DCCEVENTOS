using Datos;
using DatosManejo;
using DCCEVENTOS.Reportes;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace DCCEVENTOS.Usuario
{
    public partial class FPermisos : Form
    {
        private DataTable table = new DataTable();
        private NMenu Nmenu;
        private NRol nrol;
        private NPermisos nper;

        public FPermisos()
        {
            InitializeComponent();
            Nmenu = new NMenu();
            nrol = new NRol();
            nper = new NPermisos();
            CargarInformacion();
        }
        private void Nuevo()
        {
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            CargarInformacion();
        }
        private void CargarInformacion()
        {

            Object[] estado = nrol.ObtenerDescripciones();
            comboBox1.DataSource = estado;
            comboBox1.Refresh();

        }
        private void ObtenerporRol()
        {
            table = nper.Obtener(nrol.ObtenerDescripcionesCod(comboBox1.SelectedItem.ToString()));
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
        private void AgregarRegistro()
        {
            table = Nmenu.Obtenerparapermisos();
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                try
                {
                    string valorColumna0 = fila.Cells[0].Value?.ToString();
                    //string valorColumna2 = fila.Cells[2].Value?.ToString();
                    Permiso datos = new Permiso();
                    datos.IdRol = nrol.ObtenerDescripcionesCod(comboBox1.SelectedItem.ToString());
                    datos.IdMenu = Nmenu.ObtenerDescripcionesCod(valorColumna0);
                    datos.Activo = true;
                    InfoCompartidaCapas rGuardar = nper.Guardar(datos);
                    if (!string.IsNullOrEmpty(rGuardar.error))
                    {
                        MessageBox.Show(rGuardar.error);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("OCURRIO ALGO EN AGREGAR EL REGISTRO");
                }
            }
        }
        private void ModificarRegistro()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                try
                {
                    //    DataGridViewCheckBoxCell checkBoxCell = fila.Cells[0] as DataGridViewCheckBoxCell;
                    //    bool valorColumna0 = (checkBoxCell != null && checkBoxCell.EditedFormattedValue != null) ? (bool)checkBoxCell.EditedFormattedValue : false;
                    //if (fila.Cells[1].Value != null)
                    //{
                    string valorColumna0 = fila.Cells[0].Value?.ToString();
                    string valorColumna1 = fila.Cells[1].Value?.ToString();
                    string valorColumna2 = fila.Cells[2].Value?.ToString();
                    Permiso datos = new Permiso();
                    datos.IdPermiso = Convert.ToInt32(valorColumna1);
                    datos.IdRol = nrol.ObtenerDescripcionesCod(comboBox1.SelectedItem.ToString());
                    datos.IdMenu = Nmenu.ObtenerDescripcionesCod(valorColumna2);
                    datos.Activo = Convert.ToBoolean(valorColumna0);

                    InfoCompartidaCapas rGuardar = nper.Modificar(datos);
                    if (!string.IsNullOrEmpty(rGuardar.error))
                    {
                        MessageBox.Show(rGuardar.error);
                    }
                    //}
                }
                catch (Exception e)
                {
                    MessageBox.Show("OCURRIÓ ALGO EN AGREGAR EL REGISTRO");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerporRol();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Nuevo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }
    }
}
