using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Usuario.Consulta;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCCEVENTOS.Usuario
{
    public partial class FMenus : Form
    {
        private DataTable table = new DataTable();
        private NMenu Nmenu;
        CPrincipal principal = new CPrincipal();
        public FMenus()
        {
            InitializeComponent();
            Nmenu = new NMenu();
            CargarInformacion();

        }
        private void AgregarRegistro(string item)
        {
            Menu datos = new Menu();
            datos.Nombre = item;
            datos.NombreFormulario = item;
            InfoCompartidaCapas rGuardar = Nmenu.Guardar(datos);
        }
        private void BorrarTodosLosRegistros()
        {
            using (var context = new EventosContext()) 
            {
                var registros = context.Menus.ToList();
                foreach (var registro in registros)
                {
                    context.Menus.Remove(registro);
                }
            context.SaveChanges();
            }
        }
        public void CopyMenuItemToTreeNode(ToolStripItem menuItem, TreeNodeCollection parentNodes)
        {
            TreeNode newNode = parentNodes.Add(menuItem.Text);
            newNode.Tag = menuItem;
            //AgregarRegistro(menuItem.Text);

            // Si el elemento del menú tiene subelementos, copia también esos subelementos
            if (menuItem is ToolStripMenuItem)
            {
                ToolStripMenuItem subMenu = (ToolStripMenuItem)menuItem;
                if (subMenu.HasDropDownItems)
                {
                    foreach (ToolStripItem subMenuItem in subMenu.DropDownItems)
                    {
                        CopyMenuItemToTreeNode(subMenuItem, newNode.Nodes);
                    }
                }
            }
        }
        public void CopyMenuToTreeView(ToolStripItemCollection menuItems, TreeNodeCollection treeNodes)
        {
            foreach (ToolStripItem menuItem in menuItems)
            {
                CopyMenuItemToTreeNode(menuItem, treeNodes);
            }
        }
        public void CopyMenuItemToTreeNode2(ToolStripItem menuItem, TreeNodeCollection parentNodes)
        {
            TreeNode newNode = parentNodes.Add(menuItem.Text);
            newNode.Tag = menuItem;
            AgregarRegistro(menuItem.Text);

            // Si el elemento del menú tiene subelementos, copia también esos subelementos
            if (menuItem is ToolStripMenuItem)
            {
                ToolStripMenuItem subMenu = (ToolStripMenuItem)menuItem;
                if (subMenu.HasDropDownItems)
                {
                    foreach (ToolStripItem subMenuItem in subMenu.DropDownItems)
                    {

                        CopyMenuItemToTreeNode2(subMenuItem, newNode.Nodes);
                    }
                }
            }
        }
        public void CopyMenuToTreeView2(ToolStripItemCollection menuItems, TreeNodeCollection treeNodes)
        {
            foreach (ToolStripItem menuItem in menuItems)
            {
                CopyMenuItemToTreeNode2(menuItem, treeNodes);
            }
        }
        private void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            TBNom.Text = string.Empty;
            TBNomFor.Text = string.Empty;
            treeView1.Nodes.Clear();
            CargarInformacion();
        }
        private void CargarInformacion()
        {
            table = Nmenu.Obtener();
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
            CopyMenuToTreeView(principal.menuStrip1.Items, treeView1.Nodes);
        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            ConsultaMenu consulta = new ConsultaMenu();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<Menu> List = new DMMenu(contexto).Obtener(NMenu.SSCod);
            foreach (var datos in List)
            {
                TBNom.Text = datos.Nombre.ToString();
                TBNomFor.Text = datos.NombreFormulario.ToString();
            }
        }
        private void ModificarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TBNom.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return;
                }
                Menu datos = new Menu();
                datos.IdMenu = NCategoria.SSCod;
                datos.Nombre = TBNom.Text;
                datos.Nombre = TBNomFor.Text;

                InfoCompartidaCapas rGuardar = Nmenu.Modificar(datos);
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
                if (string.IsNullOrWhiteSpace(TBNom.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                Menu datos = new Menu();
                datos.Nombre = TBNom.Text;
                datos.Nombre = TBNomFor.Text;

                InfoCompartidaCapas rGuardar = Nmenu.Guardar(datos);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //BorrarTodosLosRegistros();
            CopyMenuToTreeView2(principal.menuStrip1.Items, treeView1.Nodes);
            Nuevo();
        }
    }
}
