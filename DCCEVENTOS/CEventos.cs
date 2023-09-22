using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Editar;
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
        private NCategoria nCategoria;
        private NSalones nsalones;
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
            nsalones = new NSalones();
            nestado = new NEstado();
            nevento = new NEventos();
            npaquete = new NPaquete();
            nPa = new NPaDetalle();
            neventod = new NEventoDetalle();
            ncliente = new NCliente();
            nCategoria = new NCategoria();
            Cargainformacion();

        }
        public void Cargainformacion()
        {
            int dia = Convert.ToInt32(Calendario.UserControlDias.dia_estat);
            int mes = Calendario.Calendario.mes_estat;
            int anio = Calendario.Calendario.an_estat;
            DateTime fecha;

            if (dia > 0 && mes > 0 && anio > 0)
            {
                fecha = new DateTime(anio, mes, dia);
            }
            else
            {
                fecha = DateTime.Now;
            }

            dateTimePicker1.Value = fecha;

            //dateTimePicker1.Text =  Calendario.UserControlDias.dia_estat + "/" + Calendario.Calendario.mes_esta + "/" + Calendario.Calendario.an_esta;
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            //Object[] paquete = npaquete.ObtenerDescripciones();
            //if (paquete.Length > 0)
            //{
            //    CBPaquete.DataSource = paquete;
            //    CBPaquete.Refresh();
            //}

            Object[] salones = nsalones.ObtenerDescripciones();
            if (salones.Length > 0)
            {
                CBSalones.DataSource = salones;
                CBSalones.Refresh();
            }
        }
        private void Nuevo()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            CBSalones.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            //dataGridView1.DataSource = string.Empty;
            CBPaquete.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            ConceptosPaquetes.Rows.Clear();
            ConceptosUni.Rows.Clear();
        }


        int codevento;
        public void AgregarInformacion()
        {
            //DataGridViewCell cell = ConceptosUni.Rows[0].Cells[0];
            //object cellValue = cell.Value;
            //if (string.IsNullOrWhiteSpace(CBSalones.Text) || string.IsNullOrWhiteSpace(textBox1.Text)
            //   || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
            //   || string.IsNullOrWhiteSpace(CBEstado.Text) || cellValue == null || cellValue.ToString().Trim() == "")
            //{
            //    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            //    return; // Salir del método sin agregar el registro
            //}

            SaEvento evento = new SaEvento();
            codevento = evento.CodEvento;
            evento.CodSalon = nsalones.ObtenerDescripcione(CBSalones.SelectedItem.ToString());
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
            //DataGridViewCell cell = ConceptosUni.Rows[0].Cells[0];
            //object cellValue = cell.Value;
            //if (string.IsNullOrWhiteSpace(CBSalones.Text) || string.IsNullOrWhiteSpace(textBox1.Text)
            //   || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
            //   || string.IsNullOrWhiteSpace(CBEstado.Text) || cellValue == null || cellValue.ToString().Trim() == "")
            //{
            //    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            //    return; // Salir del método sin agregar el registro
            //}
            int columnaIndex = 0; // Índice de la columna que deseas recorrer
            int columnaIndex1 = 1;
            int columnaIndex2 = 2;
            int columnaIndex3 = 3;
            int columnaIndex4 = 4;
            int columnaIndex5 = 5;
            int columnaIndex6 = 6;
            int columnaIndex7 = 7;
            int columnaIndex8 = 8;
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
                DataGridViewCell celda8 = ConceptosUni[columnaIndex8, filaIndex];
                if (celda.Value != null)
                {
                    string valor = celda.Value.ToString();
                    string valor1 = celda1.Value.ToString();
                    string valor2 = celda2.Value.ToString();
                    string valor3 = celda3.Value.ToString();
                    string? valor4 = celda4?.Value?.ToString();
                    string valor5 = celda5.Value.ToString();
                    string valor6 = celda6.Value.ToString();
                    string valor7 = celda7.Value.ToString();
                    string valor8 = celda8.Value.ToString();


                    SaEventoDetalle ev = new SaEventoDetalle();

                    //ev.CodEvento = neventod.ObtenerDescripcionesCod(NCliente.SSCodcon);
                    ev.CodEvento = neventod.ObtenerDescripcionesCod();
                    ev.CodConceptos = Convert.ToInt32(valor);
                    ev.Cantidad = Convert.ToInt32(valor2);
                    ev.CostosConcepto = Convert.ToDecimal(valor3);

                    if (string.IsNullOrEmpty(valor4))
                    {
                        ev.CodDetallepaq = null;
                    }
                    else
                    {
                        ev.CodDetallepaq = (int)npaquete.ObtenerDescripcionesCod(valor4);
                    }
                    ev.CodCategoria = (int?)nCategoria.ObtenerDescripcionesCod(valor5);
                    ev.Costoprecio = Convert.ToDecimal(valor6);
                    ev.Descuento = Convert.ToDecimal(valor7);
                    ev.CostoTotal = Convert.ToDecimal(valor8);

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
            label9.Text = string.Empty;
            DataTable dt = new DataTable();
            SaEvePaqueteDetalle pa = new SaEvePaqueteDetalle();
            pa.CodPaquete = (int?)npaquete.ObtenerDescripcionesCod(CBPaquete.SelectedItem.ToString());
            SaEveCategoriaimp CA = new SaEveCategoriaimp();
            EventosContext context = new EventosContext();
            List<SaEvePaqueteDetalle> List = new DMPaDetalle(context).Obtener(0, 0, pa.CodPaquete.Value);


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
                    ConceptosUni.Rows[index1].Cells["DTCostosc"].Value = concepto.CostosConceptos;
                    ConceptosUni.Rows[index1].Cells["Paquete"].Value = npaquete.ObtenerDescripcione(pa.CodPaquete.Value);
                    ConceptosUni.Rows[index1].Cells["Categoria"].Value = nCategoria.ObtenerDescripcione(concepto.CodCategoria);
                    ConceptosUni.Update();
                    ConceptosUni.Refresh();
                }
            }
            DTG();
        }
        decimal sumatoriaPrecioTotal = 0;
        decimal descuentototal = 0;

        public void DTG()
        {
            label9.Text = string.Empty;
            // Agregar la columna "Precio" a ConceptosUni
            if (!ConceptosUni.Columns.Contains("Precio"))
            {
                ConceptosUni.Columns.Add("Precio", "Precio");
            }
            if (!ConceptosUni.Columns.Contains("Descuento"))
            {
                ConceptosUni.Columns.Add("Descuento", "Descuento (%)");
            }
            if (!ConceptosUni.Columns.Contains("Precio Total"))
            {
                ConceptosUni.Columns.Add("Precio Total", "Precio Total");
            }
            using (var dbContext = new EventosContext())
            {
                decimal sumatoriaIngresos = 0;
                decimal sumatoriaEgresos = 0;

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

                        // Obtener el valor del porcentaje de descuento
                        decimal porcentajeDescuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        // Calcular el descuento
                        decimal descuento = precioTotal * (porcentajeDescuento / 100);
                        decimal descuentototal = precioTotal - descuento;
                        row.Cells["Precio Total"].Value = descuentototal;

                        // Obtener la categoría de la fila actual
                        string categoria = row.Cells["Categoria"].Value.ToString();

                        // Sumar al total correspondiente según la categoría
                        if (categoria.ToUpper() == "INGRESOS")
                        {
                            sumatoriaIngresos += descuentototal;
                        }
                        else if (categoria.ToUpper() == "EGRESOS")
                        {
                            sumatoriaEgresos += descuentototal;
                        }
                    }
                }
                label11.Text = sumatoriaIngresos.ToString();
                label12.Text = sumatoriaEgresos.ToString();
                // Restar las sumas de ingresos y egresos
                decimal resultadoFinal = sumatoriaIngresos - sumatoriaEgresos;
                label9.Text = resultadoFinal.ToString();
            }

            tablaCargada = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CBusqueda.ConsultadeConceptos form = new CBusqueda.ConsultadeConceptos();
            form.ShowDialog();

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
                ConceptosUni.Rows[index1].Cells["Categoria"].Value = NConceptos.SSCategoria;
                ConceptosUni.Rows[index1].Cells["DTCostosC"].Value = NConceptos.SSCostos;
                ConceptosUni.Update();
                ConceptosUni.Refresh();
            }

            DTG();
        }

        private void CalculosDatagrind()
        {
            using (var dbContext = new EventosContext())
            {
                decimal sumatoriaIngresos = 0;
                decimal sumatoriaEgresos = 0;
                decimal sumatoriaPrecioTotal = 0;
                foreach (DataGridViewRow row in ConceptosUni.Rows)
                {
                    int codigo = Convert.ToInt32(row.Cells["DTCodigo"].Value);
                    var precio = dbContext.SaEveConceptos.FirstOrDefault(p => p.CodConceptos == codigo);
                    var cantidadCellValue = row.Cells["DTCantida"].Value;
                    var descuentoCellValue = row.Cells["Descuento"].Value;

                    if (cantidadCellValue != null && decimal.TryParse(cantidadCellValue.ToString(), out decimal cantidad) &&
                        descuentoCellValue != null && decimal.TryParse(descuentoCellValue.ToString(), out decimal descuento))
                    {
                        //decimal costoPrecio = (decimal)precio.Costoprecio;
                        //row.Cells["Precio"].Value = costoPrecio;
                        decimal costoPrecio = Convert.ToDecimal(row.Cells["Precio"].Value); ;
                        row.Cells["Precio"].Value = costoPrecio.ToString("N2"); ;

                        decimal precioTotal = cantidad * costoPrecio;
                        decimal descuentoAplicado = precioTotal * (descuento / 100);
                        decimal precioTotalDescuento = precioTotal - descuentoAplicado;

                        row.Cells["Precio Total"].Value = precioTotalDescuento.ToString("N2");
                        //sumatoriaPrecioTotal += precioTotalDescuento;
                        // Obtener la categoría de la fila actual
                        string categoria = row.Cells["Categoria"].Value.ToString();

                        // Sumar al total correspondiente según la categoría
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
            }
        }


        private void ConceptosUni_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda modificada corresponde a la columna "Cantidad"
            if (tablaCargada && e.ColumnIndex == ConceptosUni.Columns["DTCantida"].Index && e.RowIndex >= 0)
            {
                CalculosDatagrind();
            }
            if (tablaCargada && e.ColumnIndex == ConceptosUni.Columns["Descuento"].Index && e.RowIndex >= 0)
            {
                CalculosDatagrind();
            }
            if (tablaCargada && e.ColumnIndex == ConceptosUni.Columns["Precio"].Index && e.RowIndex >= 0)
            {
                CalculosDatagrind();
            }
        }
        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                textBox1.Text = t.NomCliente.ToString();
            }
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                textBox1.Text = t.NomCliente.ToString();
            }
        }

        private void CBPaquete_DropDown(object sender, EventArgs e)
        {
            Object[] paquete = npaquete.ObtenerDescripciones();
            if (paquete.Length > 0)
            {
                CBPaquete.DataSource = paquete;
                CBPaquete.Refresh();
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = ConceptosUni.Rows[0].Cells[0];
            object cellValue = cell.Value;
            if (string.IsNullOrWhiteSpace(CBSalones.Text) || string.IsNullOrWhiteSpace(textBox1.Text)
               || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
               || string.IsNullOrWhiteSpace(CBEstado.Text) || cellValue == null || cellValue.ToString().Trim() == "")
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                return; // Salir del método sin agregar el registro
            }
            AgregarInformacion();
            AgregarInformaciondetalleeventos();
            Nuevo();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = ConceptosUni.Rows[0].Cells[0];
            object cellValue = cell.Value;
            if (string.IsNullOrWhiteSpace(CBSalones.Text) || string.IsNullOrWhiteSpace(textBox1.Text)
               || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
               || string.IsNullOrWhiteSpace(CBEstado.Text) || cellValue == null || cellValue.ToString().Trim() == "")
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                return; // Salir del método sin agregar el registro
            }
            AgregarInformacion();
            AgregarInformaciondetalleeventos();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                textBox1.Text = t.NomCliente.ToString();
            }
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CEventoEdit form = new CEventoEdit();
            form.Show();
        }
    }
}

