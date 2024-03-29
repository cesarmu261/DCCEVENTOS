﻿using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using Negocio;
using System.Data;

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
            tablacategoria = ncategoria.ObtenerCategoria();
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
            ConsulatadeCategorias consulta = new ConsulatadeCategorias();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCategoriaimp> conceptosList = new DMCategoria(contexto).Obtener(NCategoria.SSCod);
            foreach (var concepto in conceptosList)
            {
                TbDes.Text = concepto.DesCategoria.ToString(); // Asigna el valor de la primera columna al textBox1
                string valorDeseado = nestado.ObtenerDescripcione(concepto.CodEstado); // Valor que deseas seleccionar

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
                SaEveCategoriaimp categoria = new SaEveCategoriaimp();
                categoria.CodCategoria = NCategoria.SSCod;
                categoria.DesCategoria = TbDes.Text;
                categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = ncategoria.Modificar(categoria);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE ACTUALIZO CORRECTAMENTE EL CATEGORIA");
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
                SaEveCategoriaimp categoria = new SaEveCategoriaimp();
                categoria.DesCategoria = TbDes.Text;
                categoria.CodEstado = nestado.ObtenerDescripcionesCod(CBESTADO.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = ncategoria.Guardar(categoria);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }

                else
                {
                    MessageBox.Show("SE GUARDO CORRECTAMENTE EL CATEGORIA");
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
