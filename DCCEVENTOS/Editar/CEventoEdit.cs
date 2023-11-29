using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DCCEVENTOS.Editar
{
    public partial class CEventoEdit : Form
    {
        private NConceptos nconceptos;
        private NCategoria nCategoria;
        private NSalones nsalones;
        private NEstado nestado;
        private NEventos nevento;
        private NPaquete npaquete;
        private NPaDetalle nPa;
        private NEventoDetalle neventod;
        private NCliente ncliente;
        public CEventoEdit()
        {
            InitializeComponent();
            nconceptos = new NConceptos();
            nsalones = new NSalones();
            nestado = new NEstado();
            nevento = new NEventos();
            npaquete = new NPaquete();
            nPa = new NPaDetalle();
            neventod = new NEventoDetalle();
            ncliente = new NCliente();
            nCategoria = new NCategoria();
            CargarInformacion();
        }
        public void CargarInformacion()
        {
            Object[] categoria = nCategoria.ObtenerDescripciones();
            if (categoria.Length > 0)
            {
                comboBox1.DataSource = categoria;
                comboBox1.Refresh();
            }
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            Object[] salones = nsalones.ObtenerDescripciones();
            if (salones.Length > 0)
            {
                CBSalones.DataSource = salones;
                CBSalones.Refresh();
            }
        }
        private void NuevoFormulario()
        {
            TBCod.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            CBSalones.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            DTGDetalles.DataSource = null;
            comboBox1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label9.Text = string.Empty;
            panel1.Visible = false;
        }
        private void Nuevo()
        {
            comboBox1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            panel1.Visible = false;
        }
        public void CargarDTG()
        {
            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            int codeve = Convert.ToInt32(TBCod.Text);
            table = neventod.ObteneEventos2(codeve);
            DTGDetalles.DataSource = table;
            DTGDetalles.Refresh();
            decimal sumatoriaPrecioTotal = 0;
            decimal sumatoriaIngresos = 0;
            decimal sumatoriaEgresos = 0;
            foreach (DataGridViewRow row in DTGDetalles.Rows)
            {
                decimal precioTotalDescuento = Convert.ToDecimal(row.Cells["Precio Total"].Value);
                sumatoriaPrecioTotal += precioTotalDescuento;

                string categoria = row.Cells["Categoria"].Value.ToString();
                if (categoria.ToLower() == "ingresos")
                {
                    sumatoriaIngresos += precioTotalDescuento;
                }
                else if (categoria.ToLower() == "egresos")
                {
                    sumatoriaEgresos += precioTotalDescuento;
                }
            }
            label11.Text = sumatoriaIngresos.ToString();
            label12.Text = sumatoriaEgresos.ToString();
            decimal resultadoFinal = sumatoriaIngresos - sumatoriaEgresos;
            label9.Text = resultadoFinal.ToString();
        }
        public void CargarEvento()
        {
            System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+$");
            if (!er.Match(TBCod.Text).Success)
            {
                label22.Visible = true;
                this.label22.Text = "El campo debe ser un número entero positivo o negativo";
            }
            else
            {
                label22.Visible = false;
                EventosContext contexto = new EventosContext();
                int cod = Convert.ToInt32(TBCod.Text);
                List<SaEvento> List = new DMEvento(contexto).Obtener(cod);
                foreach (var t in List)
                {
                    List<SaEveCliente> List2 = new DMCliente(contexto).Obtener(Convert.ToInt32(t.CodCliente));
                    foreach (var t2 in List2)
                    {
                        textBox1.Text = t2.NomCliente.ToString();
                    }
                    textBox2.Text = t.DesEvento.ToString();

                    CBSalones.Text = nsalones.ObtenerNombreTipoSalon((int)t.CodSalon);
                    string valorDeseado2 = nsalones.ObtenerDescripcioneCod(t.CodSalon);

                    int indice2 = CBSalones.FindStringExact(valorDeseado2);
                    if (indice2 != -1)
                    {
                        CBSalones.SelectedIndex = indice2;
                    }
                    dateTimePicker1.Value = (DateTime)t.Fecha;
                    textBox3.Text = t.Observaciones.ToString();

                    CBEstado.Text = nsalones.ObtenerNombreTipoestado(t.CodEstado);
                    string valorDeseado = nestado.ObtenerDescripcione(t.CodEstado);
                    int indice = CBEstado.FindStringExact(valorDeseado);
                    if (indice != -1)
                    {
                        CBEstado.SelectedIndex = indice;
                    }
                    CargarDTG();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CargarEvento();
        }
        private void DTGDetalles_DoubleClick(object sender, EventArgs e)
        {
            panel1.Visible = true;
            toolStripButton4.Enabled = true;
            toolStripButton2.Enabled =false;
            EventosContext contexto = new EventosContext();
            string SSCod = DTGDetalles.SelectedRows[0].Cells[0].Value.ToString();
            int cod = Convert.ToInt32(SSCod);
            List<SaEventoDetalle> List = new DMEventoDetalle(contexto).Obtener(cod);

            foreach (var t in List)
            {
                textBox4.Text = t.CodDetalles.ToString();
                textBox5.Text = t.CodEvento.ToString();
                textBox6.Text = npaquete.ObtenerDescripcione(t.CodDetallepaq);
                textBox7.Text = nconceptos.ObtenerDescripcione(t.CodConceptos);
                string valorcate = nCategoria.ObtenerDescripcione(t.CodCategoria);
                int ic = comboBox1.FindStringExact(valorcate);
                if (ic != -1)
                {
                    comboBox1.SelectedIndex = ic;
                }
                textBox8.Text = t.CostosConcepto.ToString();
                textBox9.Text = t.Costoprecio.ToString();
                textBox10.Text = t.Cantidad.ToString();
                textBox12.Text = t.Descuento.ToString();
                textBox13.Text = t.CostoTotal.ToString();
            }
        }
        public void ModificarRegistroEvento()
        {
            if (string.IsNullOrWhiteSpace(TBCod.Text) || string.IsNullOrWhiteSpace(textBox2.Text)
               || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("DEBE CARGAR TODOS LOS DATOS PARA EL REGISTRO");
                return; // Salir del método sin agregar el registro
            }
            SaEvento evento = new SaEvento();
            evento.CodEvento = Convert.ToInt32(TBCod.Text);
            evento.CodSalon = nsalones.ObtenerDescripcione(CBSalones.SelectedItem.ToString());
            evento.CodCliente = ncliente.ObtenerDescripcione(textBox1.Text);
            evento.DesEvento = textBox2.Text;
            evento.Fecha = dateTimePicker1.Value;
            evento.Observaciones = textBox3.Text;
            evento.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
            InfoCompartidaCapas rModificar = nevento.Modificar(evento);
            if (!String.IsNullOrEmpty(rModificar.error))
            {
                MessageBox.Show(rModificar.error);
            }
        }
        private void ModificarRegistro()
        {
            // Verificar si los campos anteriores están completados
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text)
                || string.IsNullOrWhiteSpace(textBox7.Text)
                || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text)
                || string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("DEBE CARGAR TODOS LOS DATOS PARA EL REGISTRO");
                return; 
            }
            EventosContext contexto = new EventosContext();
            DMEventoDetalle dm = new DMEventoDetalle(contexto);
            SaEventoDetalle evento = new SaEventoDetalle();
            evento.CodDetalles = Convert.ToInt32(textBox4.Text);
            evento.CodEvento = Convert.ToInt32(textBox5.Text);
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                evento.CodDetallepaq = null;
            }
            else
            {
                evento.CodDetallepaq = (int)npaquete.ObtenerDescripcionesCod(textBox6.Text);
            }
            evento.Cantidad = Convert.ToInt32(textBox10.Text);
            evento.CodConceptos = nconceptos.ObtenerDescripcionesCod(textBox7.Text);
            evento.CodCategoria = (int?)nCategoria.ObtenerDescripcionesCod(comboBox1.Text);
            evento.CostosConcepto = Convert.ToDecimal(textBox8.Text);
            evento.Costoprecio = Convert.ToDecimal(textBox9.Text);
            evento.Descuento = Convert.ToDecimal(textBox12.Text);
            evento.CostoTotal = Convert.ToDecimal(textBox13.Text);
            InfoCompartidaCapas rModificar = neventod.Modificar(evento);
            if (!String.IsNullOrEmpty(rModificar.error))
            {
                MessageBox.Show(rModificar.error);
            }
            CargarDTG();
        }
        public void EliminarRegistro()
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text)
                || string.IsNullOrWhiteSpace(textBox7.Text)
                || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text)
                || string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("DEBE SELLECIONAR PRIMERO EL CONCEPTO A EDITAR");
                return; 
            }
            EventosContext contexto = new EventosContext();
            DMEventoDetalle dm = new DMEventoDetalle(contexto);
            SaEventoDetalle evento = new SaEventoDetalle();
            evento.CodDetalles = Convert.ToInt32(textBox4.Text);
            evento.CodEvento = Convert.ToInt32(textBox5.Text);
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                evento.CodDetallepaq = null;
            }
            else
            {
                evento.CodDetallepaq = (int)npaquete.ObtenerDescripcionesCod(textBox6.Text);
            }
            evento.Cantidad = Convert.ToInt32(textBox10.Text);
            evento.CodConceptos = nconceptos.ObtenerDescripcionesCod(textBox7.Text);
            evento.CodCategoria = (int?)nCategoria.ObtenerDescripcionesCod(comboBox1.Text);
            evento.CostosConcepto = Convert.ToDecimal(textBox8.Text);
            evento.Costoprecio = Convert.ToDecimal(textBox9.Text);
            evento.Descuento = Convert.ToDecimal(textBox12.Text);
            evento.CostoTotal = Convert.ToDecimal(textBox13.Text);
            InfoCompartidaCapas rGEliminar = neventod.Eliminar(evento);
            if (!String.IsNullOrEmpty(rGEliminar.error))
            {
                MessageBox.Show(rGEliminar.error);
            }
            CargarDTG();
        }
        public void AgregarConceptos()
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text)
                || string.IsNullOrWhiteSpace(textBox7.Text)
                || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text)
                || string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                return; // Salir del método sin agregar el registro
            }
            bool rowExists = false;
            foreach (DataGridViewRow row in DTGDetalles.Rows)
            {
                if (row.Cells[3].Value != null &&
                    row.Cells[3].Value.ToString() == textBox7.Text)
                {
                    rowExists = true;
                    break;
                }
            }
            if (!rowExists)
            {
                SaEventoDetalle evento = new SaEventoDetalle();
                EventosContext contexto = new EventosContext();
                DMEventoDetalle dm = new DMEventoDetalle(contexto);
                evento.CodEvento = Convert.ToInt32(textBox5.Text);
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    evento.CodDetallepaq = null;
                }
                else
                {
                    evento.CodDetallepaq = (int)npaquete.ObtenerDescripcionesCod(textBox6.Text);
                }
                evento.Cantidad = Convert.ToInt32(textBox10.Text);
                evento.CodConceptos = nconceptos.ObtenerDescripcionesCod(textBox7.Text);
                evento.CodCategoria = (int?)nCategoria.ObtenerDescripcionesCod(comboBox1.Text);
                evento.CostosConcepto = Convert.ToDecimal(textBox8.Text);
                evento.Costoprecio = Convert.ToDecimal(textBox9.Text);
                evento.Descuento = Convert.ToDecimal(textBox12.Text);
                evento.CostoTotal = Convert.ToDecimal(textBox13.Text);
                InfoCompartidaCapas rGuardar = neventod.Guardar(evento);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
            }
            else
            {
                MessageBox.Show("NO SE PUEDEN AGRGAR DOS CONCEPTOS IGUALES");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            toolStripButton4.Enabled = false;
            toolStripButton2.Enabled = true;
            CBusqueda.ConsultadeConceptos form = new CBusqueda.ConsultadeConceptos();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveConcepto> List = new DMConceptos(contexto).Obtener((int)NConceptos.SSCod);
            foreach (var t in List)
            {
                textBox5.Text = TBCod.Text;
                textBox10.Text = "1";
                textBox12.Text = "0";
                comboBox1.Text = nCategoria.ObtenerDescripcione(t.CodCategoria.Value);
                textBox8.Text = t.CostosConceptos.ToString();
                textBox7.Text = t.DesConceptos;
                textBox9.Text = t.Costoprecio.ToString();
            }
        }
        public void Calculos()
        {
            try
            {
                decimal Cantidad, CostoPrecio, Descuento, CostoTotal;
                Cantidad = Convert.ToDecimal(textBox10.Text);
                CostoPrecio = Convert.ToDecimal(textBox9.Text);
                Descuento = Convert.ToDecimal(textBox12.Text);
                decimal Total = CostoPrecio * Cantidad;
                decimal Descuentototal = Total * (Descuento / 100);
                CostoTotal = Total - Descuentototal;
                textBox13.Text = CostoTotal.ToString("N2");
            }
            catch
            {
                MessageBox.Show("POR VAFOR INGRESE UN IMPORTE CORRECTO");
            }
        }
        private void TBCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CargarEvento();
            }
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Calculos();
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Visible = true;
            CBusqueda.ConsultadeConceptos form = new CBusqueda.ConsultadeConceptos();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveConcepto> List = new DMConceptos(contexto).Obtener((int)NConceptos.SSCod);
            foreach (var t in List)
            {
                textBox5.Text = TBCod.Text;
                textBox10.Text = t.Cantidad.ToString();
                comboBox1.Text = nCategoria.ObtenerDescripcione(t.CodCategoria.Value);
                textBox8.Text = t.CostosConceptos.ToString();
                textBox7.Text = t.DesConceptos;
                textBox9.Text = t.Costoprecio.ToString();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AgregarConceptos();
            Nuevo();
            CargarDTG();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            Nuevo();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
            Nuevo();
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ModificarRegistroEvento();
            NuevoFormulario();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            NuevoFormulario();
        }
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string SSCod = TBCod.Text;
            int cod = Convert.ToInt32(SSCod);
            FRE rE = new FRE(cod);
            rE.Cod_Evento = cod;
            rE.Show();
        }
        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            ConsultadeEventosClie form = new ConsultadeEventosClie();
            form.ShowDialog();
            TBCod.Text = Convert.ToString(NEventos.SSCod);
            CargarEvento();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultadeEventosDes form = new ConsultadeEventosDes();
            form.ShowDialog();
            TBCod.Text = Convert.ToString(NEventos.SSCod);
            CargarEvento();
        }
    }
}
