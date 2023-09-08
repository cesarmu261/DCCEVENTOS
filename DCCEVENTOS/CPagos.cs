using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Negocio;
using System.Data;


namespace DCCEVENTOS
{
    public partial class CPagos : Form
    {
        NComprobante nComprobante;
        NTrans nTrans;
        NTipoPago ntipoPago;
        NEstado nestado;
        NEventoDetalle neventod;
        NPago Npago;
        public CPagos()
        {
            InitializeComponent();
            nComprobante = new NComprobante();
            nTrans = new NTrans();
            ntipoPago = new NTipoPago();
            neventod = new NEventoDetalle();
            nestado = new NEstado();
            Npago = new NPago();
            CargarInformacion();
        }
        public void Nuevo()
        {
            //toolStripGuardar.Enabled = true;

            TBFolio.Text = string.Empty;
            TBEvento.Text = string.Empty;
            CBTransaccion.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            TBObservacion.Text = string.Empty;

            TBClientes.Text = string.Empty;
            TBDescripcion.Text = string.Empty;

            CBComprante.SelectedIndex = 0;
            CBPago.SelectedIndex = 0;
            TBReferencia.Text = string.Empty;
            TBRecibo.Text = string.Empty;
            TBObservacionesPago.Text = string.Empty;
            MontoaPagar.Text = string.Empty;
            dataGridView1.DataSource = 0;
            DTGDetalleEvento.DataSource = 0;

            CostoEvento.Text = string.Empty;
            MontoPagado.Text = "0";
            MontoaPagar.Text = "0";
            SaldoPendiente.Text = "0";
            CargarInformacion();
        }


        public void CargarInformacion()
        {
            Object[] descripcion = nComprobante.ObtenerDescripciones();
            CBComprante.DataSource = descripcion;
            CBComprante.Refresh();

            Object[] pago = ntipoPago.ObtenerDescripciones();
            CBPago.DataSource = pago;
            CBPago.Refresh();

            Object[] trans = nTrans.ObtenerDescripciones();
            CBTransaccion.DataSource = trans;
            CBTransaccion.Refresh();
            Object[] estado = nestado.ObtenerDescripciones();
            CBEstado.DataSource = estado;
            CBEstado.Refresh();


        }
        private void DTG()
        {
            DataTable table = new DataTable();
            table = Npago.ObtenerPago(Convert.ToInt32(TBEvento.Text));
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }
        public void Buscar()
        {
            toolStripGuardar.Enabled = false;
            ConsultadePagos consulta = new ConsultadePagos();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEvePago> List = new DMPagos(contexto).Obtener(NPago.SSCod);
            foreach (var Entidades in List)
            {
                TBFolio.Text = Convert.ToString(NPago.SSCod);
                TBEvento.Text = Convert.ToString(Entidades.CodEvento);
                CargarEvento();


                string valortrans = nTrans.ObtenerDescripcione(Entidades.CodTipoTransaccion); // Valor que deseas seleccionar

                int indicetra = CBTransaccion.FindStringExact(valortrans);
                if (indicetra != -1)
                {
                    CBTransaccion.SelectedIndex = indicetra; // Establecer el índice seleccionado
                }

                dateTimePicker1.Value = Entidades.FechaDePago;
                dateTimePicker2.Value = Entidades.FechaDeFactura;

                string valorDeseado = nestado.ObtenerDescripcione(Entidades.CodEstado); // Valor que deseas seleccionar

                int indice = CBEstado.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBEstado.SelectedIndex = indice; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3
                TBObservacion.Text = Entidades.Observacion;


                string valorcomp = nComprobante.ObtenerDescripcione(Entidades.CodComprobante); // Valor que deseas seleccionar

                int indicomp = CBComprante.FindStringExact(valorcomp);
                if (indicomp != -1)
                {
                    CBComprante.SelectedIndex = indicomp; // Establecer el índice seleccionado
                }
                string valorpago = ntipoPago.ObtenerDescripcione(Entidades.CodPago); // Valor que deseas seleccionar

                int indicepag = CBPago.FindStringExact(valorpago);
                if (indicepag != -1)
                {
                    CBPago.SelectedIndex = indicepag; // Establecer el índice seleccionado
                }
                TBReferencia.Text = Entidades.Referencia;
                TBRecibo.Text = Entidades.Recibo.ToString();
                TBObservacionesPago.Text = Entidades.Observacionpago;
                MontoaPagar.Text = Entidades.Montoapagar.ToString();
                CalculosBus();

            }

        }
        public void ModificarRegistro()
        {
            SaEvePago pago = new SaEvePago();
            pago.CodPagos = NPago.SSCod;
            pago.CodEvento = Convert.ToInt32(TBEvento.Text);
            pago.CodTipoTransaccion = nTrans.ObtenerDescripcionesCod(CBTransaccion.SelectedItem.ToString());
            pago.FechaDePago = dateTimePicker1.Value;
            pago.FechaDeFactura = dateTimePicker2.Value;
            pago.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
            pago.Observacion = TBObservacion.Text;

            pago.FechaDeCancelacion = DateTime.Now;

            pago.CodComprobante = nComprobante.ObtenerDescripcionesCod(CBComprante.SelectedItem.ToString());
            pago.CodPago = ntipoPago.ObtenerDescripcionesCod(CBPago.SelectedItem.ToString());
            pago.Referencia = TBReferencia.Text;
            if (TBRecibo.Text == "")
            {
                pago.Recibo = null;
            }
            else
            {
                pago.Recibo = Convert.ToInt32(TBRecibo.Text);
            }
            pago.Observacionpago = TBObservacionesPago.Text;
            pago.Montoapagar = Convert.ToDecimal(MontoaPagar.Text);
            InfoCompartidaCapas rModificar = Npago.Modificar(pago);
            if (!String.IsNullOrEmpty(rModificar.error))
            {
                MessageBox.Show(rModificar.error);
            }
        }
        public void CalculosBus()
        {
            int codeve = Convert.ToInt32(TBEvento.Text);
            EventosContext contexto = new EventosContext();
            List<SaEvePago> List = new DMPagos(contexto).Obtener(0, codeve);

            DataTable table = neventod.ObteneEventos2(codeve);
            decimal sumatoriaPrecioTotal = 0;
            decimal sumatoriaIngresos = 0;
            decimal sumatoriaEgresos = 0;
            foreach (DataRow row in table.Rows)
            {
                decimal precioTotalDescuento = Convert.ToDecimal(row["Precio Total"]);
                sumatoriaPrecioTotal += precioTotalDescuento;

                string categoria = row["Categoria"].ToString();
                if (categoria.ToLower() == "ingresos")
                {
                    sumatoriaIngresos += precioTotalDescuento;
                }
                else if (categoria.ToLower() == "egresos")
                {
                    sumatoriaEgresos += precioTotalDescuento;
                }
            }

            decimal resultadoFinal = sumatoriaIngresos - sumatoriaEgresos;
            if (List.Count >= 1)
            {

                resultado = resultadoFinal;

                decimal? resultados = resultado;
                decimal? montos = monto;

                foreach (var t in List)
                {
                    decimal? pagar = Convert.ToDecimal(MontoaPagar.Text);

                    resultados = resultados - t.Montoapagar;
                    montos = t.Montoapagar;
                    CostoEvento.Text = resultadoFinal.ToString();

                    if (pagar == t.Montoapagar)
                    {
                        break;
                    }
                    MontoPagado.Text = montos.ToString();
                    SaldoPendiente.Text = resultados.ToString();
                    SaldoaFavor.Text = "0.00";
                    Penalizacion.Text = "0.00";
                    Iva.Text = "0.00";
                    SaldoActual.Text = "0.00";

                    //decimal pagar = Convert.ToDecimal(MontoaPagar.Text);
                    //if (pagar == montos)
                    //{
                    //    break;
                    //}
                }
            }
        }
        private void CargarDTG()
        {
            DataTable table = new DataTable();
            int codeve = Convert.ToInt32(TBEvento.Text);
            table = neventod.ObtenePagoEventos2(codeve);
            DTGDetalleEvento.DataSource = table;
            DTGDetalleEvento.Refresh();
            DTGDetalleEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGDetalleEvento.MultiSelect = false;
            CBTransaccion.Enabled = true;

        }
        decimal resultado;
        decimal monto;
        public void Calculos()
        {
            int codeve = Convert.ToInt32(TBEvento.Text);
            EventosContext contexto = new EventosContext();
            List<SaEvePago> List = new DMPagos(contexto).Obtener(0, codeve);

            DataTable table = neventod.ObteneEventos2(codeve);
            decimal sumatoriaPrecioTotal = 0;
            decimal sumatoriaIngresos = 0;
            decimal sumatoriaEgresos = 0;
            decimal sumatoriaGarantia = 0;
            decimal sumatoriaSaldoPendiente = 0;
            foreach (DataRow row in table.Rows)
            {
                decimal precioTotalDescuento = Convert.ToDecimal(row["Precio Total"]);
                sumatoriaPrecioTotal += precioTotalDescuento;

                string categoria = row["Categoria"].ToString();
                if (categoria.ToUpper() == "INGRESOS")
                {
                    sumatoriaIngresos += precioTotalDescuento;
                }
                else if (categoria.ToUpper() == "EGRESOS")
                {
                    sumatoriaEgresos += precioTotalDescuento;
                }
                else if(categoria.ToUpper() == "GARANTIA")
                {
                    sumatoriaGarantia += sumatoriaGarantia;
                }
            }

            decimal resultadoFinal = sumatoriaIngresos - sumatoriaEgresos;
            if (List.Count == 0) // La lista está vacía
            {

                resultado = resultadoFinal;
                CostoEvento.Text = resultadoFinal.ToString();
                MontoPagado.Text = (0.00).ToString();
                SaldoPendiente.Text = (0.00).ToString();
                MontoaPagar.Text = (0.00).ToString();
                SaldoaFavor.Text = (0.00).ToString();
                Penalizacion.Text = (0.00).ToString();
                Iva.Text = (0.00).ToString();
                SaldoActual.Text = (0.00).ToString();
            }

            else
            {
                resultado = resultadoFinal;

                decimal? resultados = resultado;
                decimal? montos = monto;
                foreach (var t in List)
                {
                    if (codeve == t.CodEvento && t.CodEstado == "A")
                    {
                        resultados = resultados - t.Montoapagar;

                        montos = montos + t.Montoapagar;

                        CostoEvento.Text = resultadoFinal.ToString();
                        MontoPagado.Text = montos.ToString();
                        SaldoPendiente.Text = resultados.ToString();
                        MontoaPagar.Text = (0.00).ToString();
                        SaldoaFavor.Text = (0.00).ToString();
                        Penalizacion.Text = (0.00).ToString();
                        Iva.Text = (0.00).ToString();
                        SaldoActual.Text = (0.00).ToString();
                    }

                }
            }
        }
        public void CalculosdePago()
        {
            if (SaldoPendiente.Text == "0")
            {
                decimal restamonto = 0;
                decimal resultado = Convert.ToDecimal(CostoEvento.Text);
                decimal monto = Convert.ToDecimal(MontoaPagar.Text);
                restamonto = resultado - monto;
                //if (CBComprante.SelectedIndex == 0)
                //{
                //    decimal iva = 0;
                //    iva = restamonto * (decimal)0.16;

                //}
                SaldoActual.Text = restamonto.ToString();
            }
            else
            {
                decimal restamonto = 0;
                decimal resultado = Convert.ToDecimal(SaldoPendiente.Text);
                decimal monto = Convert.ToDecimal(MontoaPagar.Text);
                restamonto = resultado - monto;
                //if (CBComprante.SelectedIndex == 0)
                //{
                //    decimal iva = 0;
                //    iva = restamonto * (decimal)0.16;

                //}
                SaldoActual.Text = restamonto.ToString();
            }
        }
        private void CargarEvento()
        {
            System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+$");
            if (!er.Match(TBEvento.Text).Success)
            {
                label22.Visible = true;
                this.label22.Text = "El campo debe ser un número entero positivo o negativo";
            }
            else
            {
                label22.Visible = false;
                EventosContext contexto = new EventosContext();
                int cod = Convert.ToInt32(TBEvento.Text);
                List<SaEvento> List = new DMEvento(contexto).Obtener(cod);

                foreach (var t in List)
                {
                    List<SaEveCliente> List2 = new DMCliente(contexto).Obtener(Convert.ToInt32(t.CodCliente));
                    foreach (var t2 in List2)
                    {
                        TBClientes.Text = t2.NomCliente.ToString();
                    }
                    TBDescripcion.Text = t.DesEvento.ToString();


                }
                CargarDTG();
                DTG();

            }
        }
        public void AgregarInformacion()
        {
            try
            {
                // Verificar si los campos anteriores están completados
                if (string.IsNullOrWhiteSpace(TBClientes.Text) || string.IsNullOrWhiteSpace(TBDescripcion.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                //decimal importe = Convert.ToDecimal(textBox2.Text);
                //textBox2.Text = String.Format("{0:0.00}", importe);

                // Si todos los campos están completos, proceder con la creación del objeto concepto y su guardado
                SaEvePago pago = new SaEvePago();
                pago.CodEvento = Convert.ToInt32(TBEvento.Text);
                pago.CodTipoTransaccion = nTrans.ObtenerDescripcionesCod(CBTransaccion.SelectedItem.ToString());
                pago.FechaDePago = dateTimePicker1.Value;
                pago.FechaDeFactura = dateTimePicker2.Value;
                pago.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                pago.Observacion = TBObservacion.Text;

                pago.CodComprobante = nComprobante.ObtenerDescripcionesCod(CBComprante.SelectedItem.ToString());
                pago.CodPago = ntipoPago.ObtenerDescripcionesCod(CBPago.SelectedItem.ToString());
                pago.Referencia = TBReferencia.Text;
                if (TBRecibo.Text == "")
                {
                    pago.Recibo = null;
                }
                else
                {
                    pago.Recibo = Convert.ToInt32(TBRecibo.Text);
                }

                pago.Observacionpago = TBObservacionesPago.Text;
                pago.Montoapagar = Convert.ToDecimal(MontoaPagar.Text);

                InfoCompartidaCapas rGuardar = Npago.Guardar(pago);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConsultadeEventosDes form = new ConsultadeEventosDes();
            form.ShowDialog();
            TBEvento.Text = Convert.ToString(NEventos.SSCod);
            CargarEvento();
            Calculos();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CargarEvento();
                Calculos();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultadeEventosClie form = new ConsultadeEventosClie();
            form.ShowDialog();
            TBEvento.Text = Convert.ToString(NEventos.SSCod);
            CargarEvento();
            Calculos();
        }

        private void MontoaPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CalculosdePago();
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarInformacion();
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Nuevo();
            Buscar();
            CalculosdePago();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            Nuevo();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            CalculosdePago();
        }
    }
}
