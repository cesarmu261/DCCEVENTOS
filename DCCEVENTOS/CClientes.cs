using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.VisualBasic;
using Negocio;

namespace DCCEVENTOS
{
    public partial class CClientes : Form
    {
        private NEstado nestado;
        private NRegimen nregimen;
        private NCliente nCliente;
        public CClientes()
        {
            InitializeComponent();
            nestado = new NEstado();
            nCliente = new NCliente();
            nregimen = new NRegimen();
            Cargainformacion();
        }
        public void Cargainformacion()
        {
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            Object[] regimen = nregimen.ObtenerDescripciones();
            if (regimen.Length > 0)
            {
                comboBox1.DataSource = regimen;
                comboBox1.Refresh();
            }
        }
        private void Nuevo()
        {
            TbCodter.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
            Cargainformacion();
            toolStripButton1.Enabled = true;
        }

        public void AgregarInformacion()
        {
            try
            {
                // Verificar si los campos anteriores están completados
                if (string.IsNullOrWhiteSpace(TbCodter.Text) || string.IsNullOrWhiteSpace(textBox1.Text)
                    || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                    || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text)
                    || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text)
                    || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text)
                    || string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox11.Text)
                    || string.IsNullOrWhiteSpace(textBox12.Text) || string.IsNullOrWhiteSpace(CBEstado.Text)
                    || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEveCliente cliente = new SaEveCliente();
                cliente.CodTercero = TbCodter.Text;
                cliente.NomCliente = textBox1.Text;
                cliente.Domicilio = textBox2.Text;
                cliente.Poblacion = textBox3.Text;
                cliente.Cp = textBox4.Text;
                cliente.Telefono = textBox5.Text;
                cliente.Celular = textBox6.Text;
                cliente.Correo = textBox7.Text;
                cliente.RazonSocial = textBox8.Text;
                cliente.Rfc = textBox9.Text;
                cliente.DomicioFiscal = textBox10.Text;
                cliente.PoblacionFiscal = textBox11.Text;
                cliente.CpFiscal = textBox12.Text;
                cliente.FecNacimiento = dateTimePicker1.Value;
                cliente.FecRegistro = DateAndTime.Now;
                cliente.CodRegimenfiscal = nregimen.ObtenerDescripcionesCod(comboBox1.SelectedItem.ToString());
                cliente.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nCliente.Guardar(cliente);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }

        }
        public void ModificarInformacion()
        {
            try
            {
                // Verificar si los campos anteriores están completados
                if (string.IsNullOrWhiteSpace(TbCodter.Text) || string.IsNullOrWhiteSpace(textBox1.Text)
                    || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                    || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text)
                    || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text)
                    || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text)
                    || string.IsNullOrWhiteSpace(textBox10.Text) || string.IsNullOrWhiteSpace(textBox11.Text)
                    || string.IsNullOrWhiteSpace(textBox12.Text) || string.IsNullOrWhiteSpace(CBEstado.Text)
                    || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                SaEveCliente cliente = new SaEveCliente();
                cliente.CodCliente = NTercero.SSCod;
                cliente.CodTercero = TbCodter.Text;
                cliente.NomCliente = textBox1.Text;
                cliente.Domicilio = textBox2.Text;
                cliente.Poblacion = textBox3.Text;
                cliente.Cp = textBox4.Text;
                cliente.Telefono = textBox5.Text;
                cliente.Celular = textBox6.Text;
                cliente.Correo = textBox7.Text;
                cliente.RazonSocial = textBox8.Text;
                cliente.Rfc = textBox9.Text;
                cliente.DomicioFiscal = textBox10.Text;
                cliente.PoblacionFiscal = textBox11.Text;
                cliente.CpFiscal = textBox12.Text;
                cliente.FecNacimiento = dateTimePicker1.Value;
                cliente.FecRegistro = DateAndTime.Now;
                cliente.CodRegimenfiscal = nregimen.ObtenerDescripcionesCod(comboBox1.SelectedItem.ToString());
                cliente.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());

                InfoCompartidaCapas rGuardar = nCliente.Modificar(cliente);
                if (!String.IsNullOrEmpty(rGuardar.error))
                {
                    MessageBox.Show(rGuardar.error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }

        }
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            AgregarInformacion();
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            ConsultaTerceros form = new ConsultaTerceros();
            form.ShowDialog();
            CuotasV100Context contexto = new CuotasV100Context();
            List<SaTercero> List = new DMTercero(contexto).Obtener(NTercero.SSCodcon);
            foreach (var t in List)
            {
                TbCodter.Text = t.CodTercero.ToString();
                textBox1.Text = t.NomTercero.ToString();
                textBox2.Text = t.Domicilio.ToString();
                textBox3.Text = t.Poblacion.ToString();
                textBox4.Text = t.Cp.ToString();
                textBox5.Text = t.Telefono.ToString();
                textBox6.Text = t.Celular.ToString();
                textBox7.Text = t.Correo.ToString();
                textBox8.Text = t.RazonSocial.ToString();
                textBox9.Text = t.Rfc.ToString();
                textBox10.Text = t.DomicioFiscal.ToString();
                textBox11.Text = t.PoblacionFiscal.ToString();
                textBox12.Text = t.CpFiscal.ToString();
                dateTimePicker1.Text = t.FecNacimiento.ToString();

                string valorregimen = nregimen.ObtenerDescripcione(t.Extra04); // Valor que deseas seleccionar

                int ir = comboBox1.FindStringExact(valorregimen);
                if (ir != -1)
                {
                    comboBox1.SelectedIndex = ir; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3

                string valorDeseado = nestado.ObtenerDescripcione(t.CodEstado); // Valor que deseas seleccionar

                int indice = CBEstado.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBEstado.SelectedIndex = indice; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3
                toolStripButton1.Enabled = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = true;
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NTercero.SSCod);
            foreach (var t in List)
            {
                TbCodter.Text = t.CodTercero.ToString();
                textBox1.Text = t.NomCliente.ToString();
                textBox2.Text = t.Domicilio.ToString();
                textBox3.Text = t.Poblacion.ToString();
                textBox4.Text = t.Cp.ToString();
                textBox5.Text = t.Telefono.ToString();
                textBox6.Text = t.Celular.ToString();
                textBox7.Text = t.Correo.ToString();
                textBox8.Text = t.RazonSocial.ToString();
                textBox9.Text = t.Rfc.ToString();
                textBox10.Text = t.DomicioFiscal.ToString();
                textBox11.Text = t.PoblacionFiscal.ToString();
                textBox12.Text = t.CpFiscal.ToString();
                dateTimePicker1.Text = t.FecNacimiento.ToString();

                string valorregimen = nregimen.ObtenerDescripcione(t.CodRegimenfiscal); // Valor que deseas seleccionar

                int ir = comboBox1.FindStringExact(valorregimen);
                if (ir != -1)
                {
                    comboBox1.SelectedIndex = ir; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3

                string valorDeseado = nestado.ObtenerDescripcione(t.CodEstado); // Valor que deseas seleccionar

                int indice = CBEstado.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBEstado.SelectedIndex = indice; // Establecer el índice seleccionado
                }  // Asigna el valor de la tercera columna al textBox3
            }
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ModificarInformacion();
            Nuevo();
        }
    }
}
