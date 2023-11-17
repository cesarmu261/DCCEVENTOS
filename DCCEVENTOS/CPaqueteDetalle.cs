using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Negocio;
using System.Data;
using System.Drawing;

namespace DCCEVENTOS
{
    public partial class CPaqueteDetalle : Form
    {
        private DataTable tablaconceptos;
        private NConceptos nconceptos;
        private NPaquete npaquete;
        private NEstado nestado;
        private NPaDetalle nPaDetalle;
        private Concepto concepto;
        private bool EsActualizacion;
        public CPaqueteDetalle()
        {
            InitializeComponent();
            tablaconceptos = new DataTable();
            nconceptos = new NConceptos();
            npaquete = new NPaquete();
            nestado = new NEstado();
            nPaDetalle = new NPaDetalle();
            concepto = new Concepto();
            Cargainformacion();
        }
        public void DTG()
        {
            try
            {
                foreach (Concepto concepto in Concepto.listaConceptos)
                {
                    if (!DatoExisteEnDataGridView(concepto.SSCodcon))
                    {
                        int index1 = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index1].Cells["Codigo"].Value = concepto.SSCodcon;
                        dataGridView1.Rows[index1].Cells["Descripcion"].Value = concepto.SSDescon;
                        dataGridView1.Rows[index1].Cells["Cantidad"].Value = concepto.SScantidad;
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUEDEN REPETIR MISMOS CONCEPTOS");
            }
        }
        private void Nuevo()
        {
            Coddp.Text = Convert.ToString(nPaDetalle.ObtenerDescripcionesCod()); ;
            CBPaquete.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            //dataGridView1.DataSource = string.Empty;
            dataGridView1.Rows.Clear();
            toolStripGuardar.Enabled = true;
            toolStripButton1.Enabled = false;

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }
        private void Buscar()
        {
            try
            {
                EventosContext context = new EventosContext();
               //linea comentada debiodo que a partir de ahora se va poder buscar por paquete si da eror coregguir y checar base de datos
                //List<SaEvePaqueteDetalle> List = new DMPaDetalle(context).Obtener(0, NPaquete.SSCod, NPaquete.SSCod);
                List<SaEvePaqueteDetalle> List = new DMPaDetalle(context).Obtener(0, 0, NPaquete.SSCod);
                foreach (var datos in List)
                {
                    codigosDetalle.Add(datos.CodDetallepaq);
                    // Resto del código...
                    Coddp.Text = Convert.ToString(datos.CodDp);
                    //CBPaquete.Text = Convert.ToString(datos.CodPaquete);
                    string valorDeseado = nestado.ObtenerDescripcione(datos.CodEstado); // Valor que deseas seleccionar
                    int indice = CBEstado.FindStringExact(valorDeseado);
                    if (indice != -1)
                    {
                        CBEstado.SelectedIndex = indice; // Establecer el índice seleccionado
                    }
                    //tablas conceptos con cantidades 
                    EventosContext contexto = new EventosContext();
                    List<SaEveConcepto> conceptosList = new DMConceptos(contexto).Obtener((int)datos.CodConceptos);
                    foreach (SaEveConcepto concepto in conceptosList)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = datos.CodConceptos;
                        row.Cells[1].Value = concepto.DesConceptos;
                        row.Cells[2].Value = concepto.Cantidad;
                        dataGridView1.Rows.Add(row);
                    }
                    string Vp = npaquete.ObtenerDescripcione(datos.CodPaquete);
                    int icp = CBPaquete.FindStringExact(Vp);
                    if (icp != -1)
                    {
                        CBPaquete.SelectedIndex = icp;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEBIO OCURRIR ALGO EN BUSCAR");
            }
        }
        private bool DatoExisteEnDataGridView(string dato)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == dato)
                {
                    return true;
                }
            }
            return false;
        }
        public void Cargainformacion()
        {
            Object[] paquete = npaquete.ObtenerDescripciones();
            if (paquete.Length > 0)
            {
                CBPaquete.DataSource = paquete;
                CBPaquete.Refresh();
            }
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            Coddp.Text = Convert.ToString(nPaDetalle.ObtenerDescripcionesCod());

        }
        private List<int> codigosDetalle = new List<int>();
        //private void ModificarRegistro()
        //{
        //    int columnaIndex = 0; // Índice de la columna que deseas recorrer
        //    int ultimaFilaIndex = dataGridView1.Rows.Count - 1;
        //    for (int filaIndex = 0; filaIndex <= ultimaFilaIndex; filaIndex++)
        //    {
        //        DataGridViewCell celda = dataGridView1[columnaIndex, filaIndex];
        //        if (celda.Value != null)
        //        {
        //            string valor = celda.Value.ToString();
        //            SaEvePaqueteDetalle concepto = new SaEvePaqueteDetalle();
        //            concepto.CodDp = Convert.ToInt32(Coddp.Text);
        //            concepto.CodPaquete = (int?)npaquete.ObtenerDescripcionesCod(CBPaquete.SelectedItem.ToString());
        //            concepto.CodConceptos = Convert.ToInt32(valor);
        //            concepto.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
        //            InfoCompartidaCapas rGuardar = nPaDetalle.Modificar(concepto);
        //            if (!String.IsNullOrEmpty(rGuardar.error))
        //            {
        //                MessageBox.Show(rGuardar.error);
        //            }
        //        }
        //    }
        //}
        public void Eliminar()
        {
            try
            {
                string SSCod;
                SSCod = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SaEvePaqueteDetalle concepto = new SaEvePaqueteDetalle();
                EventosContext context = new EventosContext();
                concepto.CodDp = Convert.ToInt32(Coddp.Text);
                concepto.CodPaquete = (int?)npaquete.ObtenerDescripcionesCod(CBPaquete.SelectedItem.ToString());
                concepto.CodConceptos = Convert.ToInt32(SSCod);
                concepto.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                //List<SaEvePaqueteDetalle> list = new DMPaDetalle(context).Obtener(0, (int)concepto.CodDp, (int)concepto.CodPaquete, (int)concepto.CodConceptos, concepto.CodEstado);
                //foreach (SaEvePaqueteDetalle dat in list)
                //{
                //    concepto.CodDetallepaq = dat.CodDetallepaq;
                //}
                List<SaEvePaqueteDetalle> list = new DMPaDetalle(context).Obtener(
                coddp: (int)concepto.CodDp,
                codpaquete: (int)concepto.CodPaquete,
                codconceptos: (int)concepto.CodConceptos,
                codestado: concepto.CodEstado);
                if (list.Count > 0)
                {
                    concepto.CodDetallepaq = list[0].CodDetallepaq;
                }
                else
                {
                    MessageBox.Show("No se encontró el registro a eliminar.");
                    return; // No hay nada que eliminar, así que sal del método
                }
                InfoCompartidaCapas rGuardar = nPaDetalle.Eliminar(concepto);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("OCURRIO ALGO EN ELIMINAR EL REGISTRO");
            }
        }
        private void AgregarRegistro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Coddp.Text) || string.IsNullOrWhiteSpace(CBPaquete.Text)
                    || string.IsNullOrWhiteSpace(CBEstado.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }

                int columnaIndex = 0;
                int ultimaFilaIndex = dataGridView1.Rows.Count ;
                for (int filaIndex = 0; filaIndex < ultimaFilaIndex; filaIndex++)
                {
                    DataGridViewCell celda = dataGridView1[columnaIndex, filaIndex];
                    if (celda.Value != null)
                    {
                        string valor = celda.Value.ToString();
                        SaEvePaqueteDetalle concepto = new SaEvePaqueteDetalle();
                        concepto.CodDp = Convert.ToInt32(Coddp.Text);
                        concepto.CodPaquete = (int?)npaquete.ObtenerDescripcionesCod(CBPaquete.SelectedItem.ToString());
                        concepto.CodConceptos = Convert.ToInt32(valor);
                        concepto.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                        bool existeRegistro = nPaDetalle.ExisteRegistro(concepto);
                        if (!existeRegistro)
                        {
                            InfoCompartidaCapas rGuardar = nPaDetalle.Guardar(concepto);
                            if (!String.IsNullOrEmpty(rGuardar.error))
                            {
                                MessageBox.Show(rGuardar.error);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("OCURRIO ALGO EN AGREGAR EL REGISTRO");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaConceptosagrupados form = new ConsultaConceptosagrupados();
            form.ShowDialog();
            DTG();
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
            AgregarRegistro();
            Nuevo();
        }
        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Nuevo();
            ConsultadePaquete consulta = new ConsultadePaquete();
            consulta.ShowDialog();
            Buscar();
            toolStripButton1.Enabled = true;
            toolStripGuardar.Enabled = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
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
            AgregarRegistro();
            Nuevo();
        }
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
            ConsultadePaquete consulta = new ConsultadePaquete();
            consulta.ShowDialog();
            Buscar();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Eliminar();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    int rowIndex = dataGridView1.SelectedRows[i].Index;

                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    int rowIndex = dataGridView1.SelectedRows[i].Index;

                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
        }
    }
}
