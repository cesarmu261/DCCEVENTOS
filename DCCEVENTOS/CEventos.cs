using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.Identity.Client;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DCCEVENTOS
{
    public partial class CEventos : Form
    {
        private NConceptos nconceptos;
        private NEstado nestado;
        private NEventos nevento;
        private NPaquete npaquete;
        private NPaDetalle nPa;
        private NEventoDetalle neventod;
        private NCliente ncliente;

        private bool tablaCargada = false;
        public CEventos()
        {
            InitializeComponent();
            nestado = new NEstado();
            nevento = new NEventos();
            npaquete = new NPaquete();
            nPa = new NPaDetalle();
            neventod = new NEventoDetalle();
            ncliente = new NCliente();
            Cargainformacion();
        }
        public void Cargainformacion()
        {
            int dia = Convert.ToInt32(Calendario.UserControlDias.dia_estat);
            int mes = Calendario.Calendario.mes_estat;
            int anio = Calendario.Calendario.an_estat;

            DateTime fecha = new DateTime(anio, mes, dia);
            dateTimePicker1.Value = fecha;
            //dateTimePicker1.Text =  Calendario.UserControlDias.dia_estat + "/" + Calendario.Calendario.mes_esta + "/" + Calendario.Calendario.an_esta;
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            Object[] paquete = npaquete.ObtenerDescripciones();
            if (paquete.Length > 0)
            {
                CBPaquete.DataSource = paquete;
                CBPaquete.Refresh();
            }
        }
        int codevento;
        public void AgregarInformacion()
        {
            SaEvento evento = new SaEvento();
            codevento = evento.CodEvento;
            evento.CodCliente = ncliente.ObtenerDescripcione(textBox1.Text);
            evento.DesEvento = textBox2.Text;
            evento.Fecha = dateTimePicker1.Value;
            evento.Observaciones = textBox3.Text;
            evento.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
            InfoCompartidaCapas rGuardar = nevento.Guardar(evento);
            if (!String.IsNullOrEmpty(rGuardar.error))
            {
                MessageBox.Show(rGuardar.error);
            }
        }
        public void AgregarInformaciondetalleeventos()
        {
            int columnaIndex = 0; // Índice de la columna que deseas recorrer
            int columnaIndex1 = 1;
            int columnaIndex2 = 2;
            int columnaIndex3 = 3;
            int columnaIndex4 = 4;
            int columnaIndex5 = 5;
            int columnaIndex6 = 6;
            int columnaIndex7 = 7;
            int ultimaFilaIndex = ConceptosUni.Rows.Count - 1;
            for (int filaIndex = 0; filaIndex <= ultimaFilaIndex; filaIndex++)
            {
                DataGridViewCell celda = ConceptosUni[columnaIndex, filaIndex];
                DataGridViewCell celda1 = ConceptosUni[columnaIndex1, filaIndex];
                DataGridViewCell celda2 = ConceptosUni[columnaIndex2, filaIndex];
                DataGridViewCell celda3 = ConceptosUni[columnaIndex3, filaIndex];
                DataGridViewCell celda4 = ConceptosUni[columnaIndex4, filaIndex];
                DataGridViewCell celda5 = ConceptosUni[columnaIndex5, filaIndex];
                DataGridViewCell celda6 = ConceptosUni[columnaIndex6, filaIndex];
                DataGridViewCell celda7 = ConceptosUni[columnaIndex7, filaIndex];
                if (celda.Value != null)
                {
                    string valor = celda.Value.ToString();
                    string valor1 = celda1.Value.ToString();
                    string valor2 = celda2.Value.ToString();
                    string valor3 = celda3.Value.ToString();
                    string valor4 = celda4.Value.ToString();
                    string valor5 = celda5.Value.ToString();
                    string valor6 = celda6.Value.ToString();
                    string valor7 = celda7.Value.ToString();


                    SaEventoDetalle ev = new SaEventoDetalle();

                    //ev.CodEvento = neventod.ObtenerDescripcionesCod(NCliente.SSCodcon);
                    ev.CodEvento = neventod.ObtenerDescripcionesCod();
                    ev.CodConceptos = Convert.ToInt32(valor);
                    ev.CostosConcepto = Convert.ToDecimal(valor3);
                    ev.Cantidad = Convert.ToInt32(valor2);
                    ev.CodDetallepaq = Convert.ToInt32(valor4);
                    ev.Costoprecio = Convert.ToDecimal(valor5);
                    ev.Descuento = Convert.ToDecimal(valor6);
                    ev.CostoTotal = Convert.ToDecimal(valor7);

                    //bool existeRegistro = neventod.ExisteRegistro(ev);
                    //if (!existeRegistro)
                    //{
                    InfoCompartidaCapas rGuardar = neventod.Guardar(ev);
                    if (!String.IsNullOrEmpty(rGuardar.error))
                    {
                        MessageBox.Show(rGuardar.error);
                    }
                    //}
                }
            }

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarInformacion();
            AgregarInformaciondetalleeventos();
        }
        private void CBPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPaquete.SelectedIndex != null)
            {
                ConceptosPaquetes.Rows.Clear();
                ConceptosUni.Rows.Clear();

                DTGC();

            }
        }
        private List<int> codigosDetalle = new List<int>();
        public void DTGC()
        {
            DataTable dt = new DataTable();
            SaEvePaqueteDetalle pa = new SaEvePaqueteDetalle();
            pa.CodPaquete = (int?)npaquete.ObtenerDescripcionesCod(CBPaquete.SelectedItem.ToString());
            EventosContext context = new EventosContext();
            List<SaEvePaqueteDetalle> List = new DMPaDetalle(context).Obtener(0, 0, pa.CodPaquete.Value);
            //dt = nPa.Obtener(pa.CodPaquete.Value);
            // Remover la primera y última columna

            foreach (var datos in List)
            {
                //tablas conceptos con cantidades 
                DataGridViewRow row = new DataGridViewRow();
                EventosContext contexto = new EventosContext();
                List<SaEveConcepto> conceptosList = new DMConceptos(contexto).Obtener((int)datos.CodConceptos);
                foreach (SaEveConcepto concepto in conceptosList)
                {
                    row.CreateCells(ConceptosPaquetes);
                    row.Cells[0].Value = datos.CodConceptos;
                    row.Cells[1].Value = concepto.DesConceptos;
                    row.Cells[2].Value = concepto.Cantidad;
                    row.Cells[3].Value = concepto.Costoprecio;
                    ConceptosPaquetes.Rows.Add(row);


                    int index1 = ConceptosUni.Rows.Add();
                    ConceptosUni.Rows[index1].Cells["DTCodigo"].Value = datos.CodConceptos;
                    ConceptosUni.Rows[index1].Cells["DTDESCRIPCION"].Value = concepto.DesConceptos;
                    ConceptosUni.Rows[index1].Cells["DTCantida"].Value = 1;
                    ConceptosUni.Rows[index1].Cells["DTCostosc"].Value = concepto.Costoprecio;
                    ConceptosUni.Rows[index1].Cells["Paquete"].Value = pa.CodPaquete.Value;
                    ConceptosUni.Update();
                    ConceptosUni.Refresh();
                }
                //DTG();
            }
            DTG();

        }
        decimal sumatoriaPrecioTotal = 0;
        decimal descuentototal = 0;

        public void DTG()
        {
            // Agregar la columna "Precio" a ConceptosUni
            if (!ConceptosUni.Columns.Contains("Precio"))
            {
                ConceptosUni.Columns.Add("Precio", "Precio");
            }
            if (!ConceptosUni.Columns.Contains("Descuento"))
            {
                ConceptosUni.Columns.Add("Descuento", "Descuento");
            }
            if (!ConceptosUni.Columns.Contains("Precio Total"))
            {
                ConceptosUni.Columns.Add("Precio Total", "Precio Total");
            }
            //decimal sumatoriaPrecioTotal = 0;
            using (var dbContext = new EventosContext())
            {
                foreach (DataGridViewRow row in ConceptosUni.Rows)
                {
                    int codigo = Convert.ToInt32(row.Cells["DTCodigo"].Value);
                    var precio = dbContext.SaEveConceptos.FirstOrDefault(p => p.CodConceptos == codigo);
                    if (precio != null)
                    {
                        row.Cells["Precio"].Value = precio.Costoprecio;
                        row.Cells["Descuento"].Value = 0;
                        // Obtener el valor de cantidad y precio
                        decimal cantidad = Convert.ToDecimal(row.Cells["DTCantida"].Value);
                        decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio"].Value);
                        // Calcular el precio total
                        decimal precioTotal = cantidad * precioUnitario;
                        // Asignar el valor de precio total a la columna correspondiente
                        //row.Cells["Precio Total"].Value = precioTotal;

                        // Obtener el valor del porcentaje de descuento
                        decimal porcentajeDescuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        // Calcular el descuento
                        decimal descuento = precioTotal * (porcentajeDescuento / 100);
                        descuentototal = precioTotal - descuento;
                        // Asignar el valor de descuento a la columna correspondiente
                        //row.Cells["Descuento"].Value = descuento;
                        row.Cells["Precio Total"].Value = descuentototal;
                        sumatoriaPrecioTotal += descuentototal;
                    }
                    label9.Text = sumatoriaPrecioTotal.ToString();
                }
            }
            tablaCargada = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CBusqueda.ConsultadeConceptos form = new CBusqueda.ConsultadeConceptos();
            form.ShowDialog();

            // Check if a row with the same DTDESCRIPCION already exists
            bool rowExists = false;
            foreach (DataGridViewRow row in ConceptosUni.Rows)
            {
                if (row.Cells["DTDESCRIPCION"].Value != null &&
                    row.Cells["DTDESCRIPCION"].Value.ToString() == NConceptos.SSDescon)
                {
                    rowExists = true;
                    break;
                }
            }

            if (!rowExists)
            {
                int index1 = ConceptosUni.Rows.Add();
                ConceptosUni.Rows[index1].Cells["DTCodigo"].Value = NConceptos.SSCodcon;
                ConceptosUni.Rows[index1].Cells["DTDESCRIPCION"].Value = NConceptos.SSDescon;
                ConceptosUni.Rows[index1].Cells["DTCantida"].Value = NConceptos.SScantidad;
                ConceptosUni.Update();
                ConceptosUni.Refresh();
            }

            DTG();
        }
        private void ConceptosUni_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda modificada corresponde a la columna "Cantidad"
            if (tablaCargada && e.ColumnIndex == ConceptosUni.Columns["DTCantida"].Index && e.RowIndex >= 0)
            {
                using (var dbContext = new EventosContext())
                {
                    foreach (DataGridViewRow row in ConceptosUni.Rows)
                    {
                        int codigo = Convert.ToInt32(row.Cells["DTCodigo"].Value);
                        var precio = dbContext.SaEveConceptos.FirstOrDefault(p => p.CodConceptos == codigo);
                        var cantidadCellValue = row.Cells["DTCantida"].Value;
                        var descuentoCellValue = row.Cells["Descuento"].Value;

                        if (cantidadCellValue != null && decimal.TryParse(cantidadCellValue.ToString(), out decimal cantidad) &&
                            descuentoCellValue != null && decimal.TryParse(descuentoCellValue.ToString(), out decimal descuento))
                        {
                            decimal costoPrecio = (decimal)precio.Costoprecio;
                            row.Cells["Precio"].Value = costoPrecio;

                            decimal precioTotal = cantidad * costoPrecio;
                            decimal descuentoAplicado = precioTotal * (descuento / 100);
                            decimal precioTotalDescuento = precioTotal - descuentoAplicado;

                            row.Cells["Precio Total"].Value = precioTotalDescuento;
                            sumatoriaPrecioTotal += precioTotalDescuento;
                        }
                        label9.Text = sumatoriaPrecioTotal.ToString();
                    }
                }
            }
            if (tablaCargada && e.ColumnIndex == ConceptosUni.Columns["Descuento"].Index && e.RowIndex >= 0)
            {
                using (var dbContext = new EventosContext())
                {
                    foreach (DataGridViewRow row in ConceptosUni.Rows)
                    {
                        int codigo = Convert.ToInt32(row.Cells["DTCodigo"].Value);
                        var precio = dbContext.SaEveConceptos.FirstOrDefault(p => p.CodConceptos == codigo);
                        var cantidadCellValue = row.Cells["DTCantida"].Value;
                        var descuentoCellValue = row.Cells["Descuento"].Value;

                        if (cantidadCellValue != null && decimal.TryParse(cantidadCellValue.ToString(), out decimal cantidad) &&
                            descuentoCellValue != null && decimal.TryParse(descuentoCellValue.ToString(), out decimal descuento))
                        {
                            decimal costoPrecio = (decimal)precio.Costoprecio;
                            row.Cells["Precio"].Value = costoPrecio;

                            decimal precioTotal = cantidad * costoPrecio;
                            decimal descuentoAplicado = precioTotal * (descuento / 100);
                            decimal precioTotalDescuento = precioTotal - descuentoAplicado;

                            row.Cells["Precio Total"].Value = precioTotalDescuento;
                            sumatoriaPrecioTotal += precioTotalDescuento;
                        }
                        label9.Text = sumatoriaPrecioTotal.ToString();
                    }
                }
            }
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NTercero.SSCod);
            foreach (var t in List)
            {
                textBox1.Text = t.NomCliente.ToString();
            }
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            ConsultaDeEventos form = new ConsultaDeEventos();
            form.ShowDialog();
        }
    }
}

