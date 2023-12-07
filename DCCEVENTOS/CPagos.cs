using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using Entidades;
using InfoCompartidaCaps;
using Negocio;
using System.Data;
using System.Data.Odbc;
namespace DCCEVENTOS
{
    public partial class CPagos : Form
    {
        NComprobante nComprobante;
        NTrans nTrans;
        NTipoPago ntipoPago;
        NEstado nestado;
        NEventos nevento;
        NEventoDetalle neventod;
        NPago Npago;
        NFacturacion Nfacturacion;
        public CPagos()
        {
            InitializeComponent();
            nComprobante = new NComprobante();
            nTrans = new NTrans();
            ntipoPago = new NTipoPago();
            nevento = new NEventos();
            neventod = new NEventoDetalle();
            nestado = new NEstado();
            Npago = new NPago();
            Nfacturacion = new NFacturacion();
            CargarInformacion();
        }
        public void Nuevo()
        {
            toolStripGuardar.Enabled = true;
            toolStripButton1.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton2.Enabled = false;
            CBComprante.Enabled = false;
            CBPago.Enabled = false;
            TBReferencia.Enabled = false;
            TBRecibo.Enabled = false;
            TBObservacionesPago.Enabled = false;
            CBTransaccion.Enabled = false;
            MontoaCobrar.Enabled = false;
            TBFolio.Text = string.Empty;
            TBEvento.Text = string.Empty;
            CBTransaccion.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            TBObservacion.Text = string.Empty;
            TBClientes.Text = string.Empty;
            TBDescripcion.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            CBComprante.SelectedIndex = 0;
            CBPago.SelectedIndex = 0;
            TBReferencia.Text = string.Empty;
            TBRecibo.Text = string.Empty;
            TBObservacionesPago.Text = string.Empty;
            MontoaCobrar.Text = string.Empty;
            dataGridView1.DataSource = 0;
            DTGDetalleEvento.DataSource = 0;
            label27.Text = string.Empty;
            CostoEvento.Text = string.Empty;
            MontoPagado.Text = "0";
            MontoaCobrar.Text = "0";
            SaldoPendiente.Text = "0";
            SaldoaFavor.Text = "0";
            Penalizacion.Text = "0";
            SaldoActual.Text = string.Empty;
            panel1.Visible = false;
            label29.Text = string.Empty;
            textBox1.Text = string.Empty;
            activar();
            CargarInformacion();
        }
        decimal? resultado;
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
            decimal sumatoriaPenalizacion = 0;
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
                else if (categoria.ToUpper() == "GARANTIA")
                {
                    sumatoriaGarantia += precioTotalDescuento;
                }
                else if (categoria.ToUpper() == "PENALIZACION")
                {
                    sumatoriaPenalizacion += precioTotalDescuento;
                }
            }
            //decimal resultadoFinal = sumatoriaIngresos - sumatoriaEgresos;
            decimal resultadoFinal = sumatoriaIngresos;
            if (List.Count == 0) // La lista está vacía
            {
                resultado = resultadoFinal;
                CostoEvento.Text = resultadoFinal.ToString("N2");
                MontoPagado.Text = (0.00).ToString();
                //SaldoPendiente.Text = (0.00).ToString();
                SaldoPendiente.Text = resultadoFinal.ToString("N2");
                MontoaCobrar.Text = (0.00).ToString();
                SaldoaFavor.Text = (0.00).ToString();
                //SaldoaFavor.Text = sumatoriaGarantia.ToString();
                Penalizacion.Text = sumatoriaPenalizacion.ToString("N2");
                TBIva.Text = (0.00).ToString();
                SaldoActual.Text = (0.00).ToString();
            }
            else
            {
                resultado = resultadoFinal;
                decimal? resultados = resultado;
                decimal? montos = monto;
                decimal? restagarantia;
                decimal? sumagarantia;
                foreach (var t in List)
                {
                    if (codeve == t.CodEvento && t.CodEstado == "A")
                    {
                        switch (t.CodTipoTransaccion)
                        {
                            case 1: // Anticipo,
                                resultados = resultados - t.Montoapagar;
                                montos = montos + t.Montoapagar;
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = resultados + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                resultado -= montos; // Resta el monto del anticipo
                                MontoPagado.Text = montos.ToString();  // Actualiza el monto pagado
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString();
                                Penalizacion.Text = sumatoriaPenalizacion.ToString();
                                break;
                            case 2: // Abono
                                resultados = resultados - t.Montoapagar;
                                montos = montos + t.Montoapagar;
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = resultados + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                resultado -= montos; // Resta el monto del anticipo
                                MontoPagado.Text = montos.ToString();  // Actualiza el monto pagado
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString();
                                Penalizacion.Text = sumatoriaPenalizacion.ToString();
                                break;

                            case 3: // Liquidación Total
                                resultados = resultados - t.Montoapagar;
                                montos = montos + t.Montoapagar;
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = resultados + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                resultado = montos; // Seteamos el monto a cobrar como saldo pendiente
                                MontoPagado.Text = montos.ToString();  // Actualiza el monto pagado
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString();
                                Penalizacion.Text = sumatoriaPenalizacion.ToString();
                                break;
                            case 4: // Garantía
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = montos + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                MontoPagado.Text = montos.ToString();
                                label27.Text = "PAGADO";
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString(); // Actualiza el saldo pendiente
                                SaldoaFavor.Text = 5000.ToString("N2");
                                Penalizacion.Text = sumatoriaPenalizacion.ToString();
                                break;
                            case 5: // GASTOS
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = montos + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                MontoPagado.Text = montos.ToString();
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString(); // Actualiza el saldo pendiente
                                Penalizacion.Text = sumatoriaPenalizacion.ToString("N2");
                                break;
                            case 6: // Devoluciones
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = montos + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                MontoPagado.Text = montos.ToString();
                                label29.Text = "DEVOLUCION DE GARANTIA";
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString(); // Actualiza el saldo pendiente
                                Penalizacion.Text = sumatoriaPenalizacion.ToString("N2");
                                break;
                            default://Por Defecto
                                resultados = resultados - t.Montoapagar;
                                montos = montos + t.Montoapagar;
                                restagarantia = montos - sumatoriaGarantia;
                                sumagarantia = resultados + sumatoriaGarantia;
                                CostoEvento.Text = resultadoFinal.ToString("N2");
                                resultado -= montos; // Resta el monto del anticipo
                                MontoPagado.Text = montos.ToString();  // Actualiza el monto pagado
                                SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString();
                                Penalizacion.Text = sumatoriaPenalizacion.ToString("N2");
                                break;
                        }
                    }
                    else
                    {
                        resultados = resultados - t.Montoapagar;
                        montos = montos + t.Montoapagar;
                        restagarantia = montos - sumatoriaGarantia;
                        sumagarantia = resultados + sumatoriaGarantia;
                        CostoEvento.Text = resultadoFinal.ToString("N2");
                        resultado -= montos; // Resta el monto del anticipo
                        MontoPagado.Text = montos.ToString();  // Actualiza el monto pagado
                        SaldoPendiente.Text = (resultados > 0 ? resultados : 0).ToString();
                        Penalizacion.Text = sumatoriaPenalizacion.ToString("N2");
                    }
                }
            }
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
        public void bloquear()
        {
            TBFolio.Enabled = false;
            TBEvento.Enabled = false;
            CBTransaccion.Enabled = false;
            CBEstado.Enabled = false;
            TBObservacion.Enabled = false;
            dateTimePicker3.Enabled = false;
            TBClientes.Enabled = false;
            TBDescripcion.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            CBComprante.Enabled = false;
            CBPago.Enabled = false;
            TBReferencia.Enabled = false;
            TBRecibo.Enabled = false;
            TBObservacionesPago.Enabled = false;
            MontoaCobrar.Enabled = false;
            CostoEvento.Enabled = false;
            MontoPagado.Enabled = false;
            MontoaCobrar.Enabled = false;
            SaldoPendiente.Enabled = false;
            SaldoaFavor.Enabled = false;
            Penalizacion.Enabled = false;
            SaldoActual.Enabled = false;
            panel1.Visible = false;
            textBox1.Enabled = false;
        }
        public void activar()
        {
            TBFolio.Enabled = true;
            TBEvento.Enabled = true;
            CBEstado.Enabled = true;
            TBObservacion.Enabled = true;
            TBClientes.Enabled = true;
            TBDescripcion.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        public void Buscar()
        {
            toolStripButton1.Enabled = true;
            toolStripGuardar.Enabled = false;
            ConsultadePagoDesc consulta = new ConsultadePagoDesc();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEvePago> List = new DMPagos(contexto).Obtener(NPago.SSCod);
            foreach (var Entidades in List)
            {
                TBFolio.Text = Convert.ToString(NPago.SSCod);
                TBEvento.Text = Convert.ToString(Entidades.CodEvento);
                CargarEvento();
                toolStripButton3.Enabled = false;
                toolStripButton2.Enabled = true;
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
                Calculos();
                TBReferencia.Text = Entidades.Referencia;
                TBRecibo.Text = Entidades.Recibo.ToString();
                TBObservacionesPago.Text = Entidades.Observacionpago;
                MontoaCobrar.Text = Entidades.Montoapagar.ToString();
                //CalculosBus();
                bloquear();
                CalculosdePago();
                if (CBComprante.SelectedIndex == 1)
                {
                    decimal factiva, facttotal, factsubtotal, costototalevento;
                    facttotal = Convert.ToDecimal(textBox1.Text);
                    costototalevento = Convert.ToDecimal(CostoEvento.Text);
                    factiva = (costototalevento) * Convert.ToDecimal(0.16);
                    TBIva.Text = factiva.ToString("N2");
                    factsubtotal = facttotal - factiva;
                    TBSubtotal.Text = factsubtotal.ToString("N2");
                    panel1.Visible = true;
                }
                else
                {
                    return;
                }
            }
        }
        public void ModificarRegistro()
        {
            try
            {
                SaEvePago pago = new SaEvePago();
                pago.CodPagos = NPago.SSCod;
                pago.CodEvento = Convert.ToInt32(TBEvento.Text);
                pago.CodTipoTransaccion = nTrans.ObtenerDescripcionesCod(CBTransaccion.SelectedItem.ToString());
                pago.FechaDePago = dateTimePicker1.Value;
                pago.FechaDeFactura = dateTimePicker2.Value;
                pago.CodEstado = nestado.ObtenerDescripcionesCod("INACTIVO");
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
                pago.Montoacobrar = Convert.ToDecimal(MontoaCobrar.Text);
                //pago.Montoapagar = Convert.ToDecimal(textBox1.Text);
                if (textBox1.Text == "")
                {
                    pago.Montoapagar = null;
                }
                else
                {
                    pago.Montoapagar = Convert.ToDecimal(textBox1.Text);
                }
                InfoCompartidaCapas rModificar = Npago.Modificar(pago);
                if (!String.IsNullOrEmpty(rModificar.error))
                {
                    MessageBox.Show(rModificar.error);
                }
                else
                {
                    int cod = Convert.ToInt32(Npago.ObtenerDescripcionesCod());
                    Recibo rE = new Recibo(cod);
                    rE.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al devolcuion de pago");
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
        private void CargarEvento()
        {
            try
            {
                System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+$");
                if (!er.Match(TBEvento.Text).Success)
                {
                    label22.Visible = true;
                    this.label22.Text = "El campo debe ser un número entero positivo";
                }
                else
                {
                    toolStripButton3.Enabled = true;
                    label22.Visible = false;
                    MontoaCobrar.Enabled = true;

                    CBComprante.Enabled = true;
                    CBPago.Enabled = true;
                    TBReferencia.Enabled = true;
                    TBRecibo.Enabled = true;
                    TBObservacionesPago.Enabled = true;
                    CBTransaccion.Enabled = true;
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
                        dateTimePicker3.Value = t.Fecha.Value;
                    }
                    CargarDTG();
                    DTG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR A CARGAR EVENTO");
            }
        }
        public void AgregarInformacion()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TBClientes.Text) || string.IsNullOrWhiteSpace(TBDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(MontoaCobrar.Text) || string.IsNullOrWhiteSpace(SaldoActual.Text) ||
                    string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return;
                }
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
                //pago.Montoapagar = Convert.ToDecimal(MontoaPagar.Text);
                pago.Montoacobrar = Convert.ToDecimal(MontoaCobrar.Text);
                if (TBSubtotal.Text == "")
                {
                    pago.Recibo = null;
                }
                else
                {
                    pago.Subtotal = Convert.ToDecimal(TBSubtotal.Text);
                }
                if (TBIva.Text == "")
                {
                    pago.Recibo = null;
                }
                else
                {
                    pago.Ivaevento = Convert.ToDecimal(TBIva.Text);
                }
                if (textBox1.Text == "")
                {
                    pago.Recibo = null;
                }
                else
                {
                    pago.Montoapagar = Convert.ToDecimal(textBox1.Text);
                }

                InfoCompartidaCapas rGuardar = Npago.Guardar(pago);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    int cod = Convert.ToInt32(Npago.ObtenerDescripcionesCod());
                    Recibo rE = new Recibo(cod);
                    rE.Show();
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
            System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+$");
            if (!er.Match(TBEvento.Text).Success)
            {
                this.label22.Text = "El campo debe ser un número entero positivo";
                label22.Visible = true;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                    label22.Visible = false;
                    CargarEvento();
                    Calculos();
                }
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
        public void CalculosFactura()
        {
            try
            {
                TBSubtotal.Text = MontoaCobrar.Text;
                decimal factiva, facttotal, factsubtotal, costototalevento;
                factsubtotal = Convert.ToDecimal(TBSubtotal.Text);
                costototalevento = Convert.ToDecimal(CostoEvento.Text);
                factiva = (costototalevento) * Convert.ToDecimal(0.16);
                TBIva.Text = factiva.ToString("N2");

                facttotal = factsubtotal + factiva;
                textBox1.Text = facttotal.ToString("N2");
            }
            catch
            {
                MessageBox.Show("Porfavor ingrese el monto total a pagar");
            }
        }
        public void CalculosdePago()
        {
            if (string.IsNullOrWhiteSpace(MontoaCobrar.Text))
            {
                MontoaCobrar.Text = 0.ToString();
                return;
            }

            decimal resultado = Convert.ToDecimal(CostoEvento.Text);
            decimal monto = Convert.ToDecimal(MontoaCobrar.Text);

            if (CBComprante.SelectedIndex == 1 || CBTransaccion.SelectedIndex == 0)
            {
                decimal saldoPendiente = Convert.ToDecimal(SaldoPendiente.Text);
                decimal restamonto = saldoPendiente == 0 ? resultado - monto : saldoPendiente - monto;
                SaldoActual.Text = restamonto.ToString("N2");
                textBox1.Text = monto.ToString("N2");
            }
            else if (CBComprante.SelectedIndex == 1 || CBTransaccion.SelectedIndex == 1)
            {
                decimal saldoPendiente = Convert.ToDecimal(SaldoPendiente.Text);
                decimal restamonto = saldoPendiente == 0 ? resultado - monto : saldoPendiente - monto;
                SaldoActual.Text = restamonto.ToString("N2");
                textBox1.Text = monto.ToString("N2");
            }
            else if (CBTransaccion.SelectedIndex == 1 || CBTransaccion.SelectedIndex == 2)
            {
                SaldoActual.Text = (0.00).ToString("N2");
                textBox1.Text = monto.ToString("N2");
            }
            else if (CBTransaccion.SelectedIndex == 1 || CBTransaccion.SelectedIndex == 3)
            {
                SaldoActual.Text = SaldoPendiente.Text;
                textBox1.Text = monto.ToString("N2");
            }
            else if (CBTransaccion.SelectedIndex == 1 || CBTransaccion.SelectedIndex == 4)
            {
                SaldoActual.Text = (0.00).ToString("N2");
                textBox1.Text = monto.ToString("N2");
            }
            else if (CBTransaccion.SelectedIndex == 1 || CBTransaccion.SelectedIndex == 5)
            {
                SaldoActual.Text = (0.00).ToString("N2");
                textBox1.Text = monto.ToString("N2");
            }
        }
        private void MontoaCobrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("^\\+?\\d+\\.\\d+$");
            System.Text.RegularExpressions.Regex er2 = new System.Text.RegularExpressions.Regex("^\\+?\\d+$");
            if (!er.Match(MontoaCobrar.Text).Success && !er2.Match(MontoaCobrar.Text).Success)
            {
                this.label28.Text = "El campo debe ser un número entero";
                label28.Visible = true;
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                    label28.Visible = false;
                    CalculosdePago();
                }
            }
        }
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (CBComprante.SelectedIndex == 0)
            {
                AgregarInformacion();
                Nuevo();
            }
            else if (CBComprante.SelectedIndex == 1)
            {
                AgregarInformacion();
                int cod = Convert.ToInt32(Npago.ObtenerDescripcionesCod());
                Factura rE = new Factura(cod);
                rE.Show();
            }
        }
        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            Nuevo();
            Buscar();
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
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(TBFolio.Text);
                Recibo rE = new Recibo(cod);
                rE.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POR FAVOR PRIMERO BUSQUE UN PAGO");
            }
        }
        public void ObtenerTipoPago()
        {
            MetododePago form = new MetododePago();
            form.ShowDialog();
        }
        private void facturaElectroniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerTipoPago();
                Nfacturacion.GenerarFactura(TBClientes.Text, TBIva.Text, CostoEvento.Text);
                if (!Nfacturacion.ContinuarEjecucion)
                {
                    MessageBox.Show("Por favor ingresa el cliente en facturacion y modificar el codigo tercero en clientes eventos.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Factura Electronica almacenada.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CBComprante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (CBComprante.SelectedIndex == 0)
                {
                    MontoaCobrar.Text = (0.00).ToString();
                }
                else if (CBComprante.SelectedIndex == 1)
                {
                    MontoaCobrar.Text = SaldoPendiente.Text;
                    MontoaCobrar.Enabled = false;
                    panel1.Visible = true;
                    CBTransaccion.SelectedIndex = 2;
                    CBTransaccion.Enabled = false;

                    CalculosFactura();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor seleccione primero el evento");
            }
        }
        private void CBTransaccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CBTransaccion.SelectedIndex == 2)
            {
                MontoaCobrar.Text = SaldoPendiente.Text;
                CalculosdePago();
            }
            else if (CBTransaccion.SelectedIndex == 3)
            {
                MontoaCobrar.Text = (5000).ToString("N2");
                MontoaCobrar.Enabled = false;
                CalculosdePago();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DateTime selectedDate = dateTimePicker3.Value.Date;
            DateTime startDate = selectedDate.Date;
            int cod = 0;
            List<SaEvento> list = new List<SaEvento>();
            list = nevento.ObtenerFechas(startDate, cod);
            foreach (SaEvento datos in list)
            {
                if (startDate == datos.Fecha)
                {
                    TBEvento.Text = Convert.ToString(datos.CodEvento);
                    CargarEvento();
                    Calculos();
                }
            }
        }
        public void RealizarDevolucion(int codigoEvento, decimal montoPenalizacion)
        {
            try
            {
                SaEvePago devolucion = new SaEvePago();
                devolucion.CodEvento = codigoEvento;
                devolucion.CodTipoTransaccion = nTrans.ObtenerDescripcionesCod(CBTransaccion.SelectedItem.ToString());
                devolucion.FechaDePago = DateTime.Now;
                devolucion.FechaDeFactura = DateTime.Now;
                devolucion.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                devolucion.Observacion = "DEVOLUCION DE GARANTIA";
                // Asigna el código del comprobante y del pago según tus necesidades
                devolucion.CodComprobante = nComprobante.ObtenerDescripcionesCod(CBComprante.SelectedItem.ToString());
                devolucion.CodPago = ntipoPago.ObtenerDescripcionesCod(CBPago.SelectedItem.ToString());
                devolucion.Referencia = "DEVOLUCION DE GARANTIA";
                devolucion.Observacionpago = "DEVOLUCION DE GARANTIA";
                devolucion.Montoacobrar = Convert.ToDecimal(SaldoaFavor.Text);
                devolucion.Penalizacion = Convert.ToDecimal(Penalizacion.Text);
                devolucion.Montoapagar = Convert.ToDecimal(montoPenalizacion.ToString("N2"));
                // Guarda la devolución en la base de datos
                InfoCompartidaCapas rGuardar = Npago.Guardar(devolucion);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
                else
                {
                    MessageBox.Show("SE REALIZO CORRECTAMENTE LA DEVOLUCION");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL HACER LA DEVOLUCION");
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (SaldoPendiente.Text != 0.ToString() || string.IsNullOrWhiteSpace(SaldoaFavor.Text))
            {
                MessageBox.Show("EL EVENTO DEBE DE ESTAR FINIQUITADO");
            }
            else
            {
                CBTransaccion.SelectedIndex = 5;
                int cod = Convert.ToInt32(TBEvento.Text);
                decimal pen = Convert.ToDecimal(Penalizacion.Text);
                decimal garantia = Convert.ToDecimal(SaldoaFavor.Text);
                decimal resstagarantia = garantia - pen;
                RealizarDevolucion(cod, resstagarantia);
                int cods = Convert.ToInt32(Npago.ObtenerDescripcionesCod());
                Devolucion rE = new Devolucion(cods);
                rE.Show();
                Nuevo();
            }
        }
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CBPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CBPago.SelectedIndex == 0)
            {
                // Obtener la fuente de datos actual
                object[] pago = nTrans.ObtenerDescripciones();
                // Crear una nueva lista para la fuente de datos modificada
                List<object> nuevaFuente = new List<object>(pago);
                // Remover el elemento "DEVOLUCIONES" de la lista
                nuevaFuente.Remove("DEVOLUCIONES");
                // Establecer la nueva fuente de datos
                CBTransaccion.DataSource = nuevaFuente.ToArray();
                // Refrescar el ComboBox
                CBTransaccion.Refresh();
            }
            else if (CBPago.SelectedIndex == 1)
            {
                object[] pago = nTrans.ObtenerDescripciones();
                // Crear una nueva lista para la fuente de datos modificada
                List<object> nuevaFuente = new List<object>(pago);
                // Remover el elemento "DEVOLUCIONES" de la lista
                nuevaFuente.Remove("DEVOLUCIONES");
                // Establecer la nueva fuente de datos
                CBTransaccion.DataSource = nuevaFuente.ToArray();
                // Refrescar el ComboBox
                CBTransaccion.Refresh();

            }
        }
    }
}