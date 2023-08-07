using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using Entidades;
using InfoCompartidaCaps;
using Negocio;
using System.Data;

namespace DCCEVENTOS
{
    public partial class CConcepto : Form
    {
        private DataTable tablaconceptos = new DataTable();
        private NConceptos nconceptos;
        private NPorcentaje nporcentaje;
        private NEstado nestado;
        private NCategoria ncategoria;
        public CConcepto()
        {
            InitializeComponent();
            nconceptos = new NConceptos();
            nporcentaje = new NPorcentaje();
            nestado = new NEstado();
            ncategoria = new NCategoria();
            CargarInformacion();
        }
        private void calculos()
        {
            try
            {
                decimal cantidad, importe, subtotal, iva, total;
                cantidad = Convert.ToDecimal(TBCantidad.Text);
                importe = Convert.ToDecimal(textBox2.Text);
                //subtotal = Convert.ToDecimal(TbPrecio.Text);
                iva = Convert.ToDecimal(textBox1.Text);
                //total = Convert.ToDecimal(TbTotal.Text);

                subtotal = importe * cantidad;
                iva = subtotal * iva;
                total = subtotal + iva;
                TbPrecio.Text = String.Format("{0:0.00}", subtotal);
                TbIVA.Text = String.Format("{0:0.00}", iva);
                TbTotal.Text = String.Format("{0:0.00}", total);
            }
            catch (Exception e)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA hacer claculos");
            }
        }

        private void CargarInformacion()
        {
            tablaconceptos = nconceptos.ObtenerConceptos();
            conceptosexistentes.DataSource = tablaconceptos;
            conceptosexistentes.Refresh();
            Object[] categoria = ncategoria.ObtenerDescripciones();
            if (categoria.Length > 0)
            {
                CBCodCat.DataSource = categoria;
                CBCodCat.Refresh();
            }
            Object[] estado = nestado.ObtenerDescripciones();
            if (estado.Length > 0)
            {
                CBEstado.DataSource = estado;
                CBEstado.Refresh();
            }
            Object[] porcentaje = nporcentaje.ObtenerDescripciones();
            if (porcentaje.Length > 0)
            {
                CBCodPor.DataSource = porcentaje;
                CBCodPor.Refresh();
            }
        }
        private void AgregarRegistro()
        {
            try
            {
                // Verificar si los campos anteriores están completados
                if (string.IsNullOrWhiteSpace(CBCodCat.Text) || string.IsNullOrWhiteSpace(TbDes.Text)
                    || string.IsNullOrWhiteSpace(TBCantidad.Text) || string.IsNullOrWhiteSpace(TbPrecio.Text)
                    || string.IsNullOrWhiteSpace(TbTotal.Text) || string.IsNullOrWhiteSpace(CBEstado.Text)
                    || string.IsNullOrWhiteSpace(CBCodPor.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                decimal importe = Convert.ToDecimal(textBox2.Text);
                textBox2.Text = String.Format("{0:0.00}", importe);

                // Si todos los campos están completos, proceder con la creación del objeto concepto y su guardado
                SaEveConcepto concepto = new SaEveConcepto();
                concepto.CodCategoria = (int?)ncategoria.ObtenerDescripcionesCod(CBCodCat.SelectedItem.ToString());
                concepto.DesConceptos = TbDes.Text;
                concepto.Cantidad = Convert.ToInt32(TBCantidad.Text);
                concepto.CostosConceptos = Convert.ToDecimal(textBox2.Text);
                concepto.Costoprecio = Convert.ToDecimal(TbTotal.Text);
                concepto.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
                concepto.CodPorcentaje = (int?)nporcentaje.ObtenerDescripcionesCod(CBCodPor.SelectedItem.ToString());
                concepto.Porciento = Convert.ToDecimal(textBox1.Text);

                InfoCompartidaCapas rGuardar = nconceptos.Guardar(concepto);
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
        private void Nuevo()
        {
            CBCodCat.SelectedIndex = 0;
            TbDes.Text = string.Empty;
            TBCantidad.Text = Convert.ToString(1);
            textBox2.Text = string.Empty;
            TbPrecio.Text = string.Empty;
            TbTotal.Text = string.Empty;
            TbIVA.Text = string.Empty;
            CBEstado.SelectedIndex = 0;
            CBCodPor.SelectedIndex = 0;
            textBox1.Text = string.Empty;
            toolStripGuardar.Enabled = true;
            CargarInformacion();
        }
        private void Buscar()
        {
            toolStripGuardar.Enabled = false;
            ConsultadeConceptos consulta = new ConsultadeConceptos();
            consulta.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveConcepto> conceptosList = new DMConceptos(contexto).Obtener(NConceptos.SSCod);
            foreach (var concepto in conceptosList)
            {
                //CBCodCat.Text = concepto.CodCategoria.ToString();
                string valorcate = ncategoria.ObtenerDescripcione(concepto.CodCategoria); // Valor que deseas seleccionar
                int ic = CBCodCat.FindStringExact(valorcate);
                if (ic != -1)
                {
                    CBCodCat.SelectedIndex = ic; // Establecer el índice seleccionado
                }
                TbDes.Text = concepto.DesConceptos.ToString();
                TBCantidad.Text = concepto.Cantidad.ToString();
                textBox2.Text = concepto.CostosConceptos.ToString();
                calculos();
                TbTotal.Text = concepto.Costoprecio.ToString();

                string valorDeseado = nestado.ObtenerDescripcione(concepto.CodEstado); // Valor que deseas seleccionar
                int indice = CBEstado.FindStringExact(valorDeseado);
                if (indice != -1)
                {
                    CBEstado.SelectedIndex = indice; // Establecer el índice seleccionado
                }

                string valorpo = nporcentaje.ObtenerDescripcione(concepto.CodPorcentaje); // Valor que deseas seleccionar
                int ip = CBCodPor.FindStringExact(valorcate);
                if (ip != -1)
                {
                    CBCodPor.SelectedIndex = ic; // Establecer el índice seleccionado
                }
                textBox1.Text = concepto.Porciento.ToString();
            }
        }
        private void ModificarRegistro()
        {
            // Verificar si los campos anteriores están completados
            if (string.IsNullOrWhiteSpace(CBCodCat.Text) || string.IsNullOrWhiteSpace(TbDes.Text)
                || string.IsNullOrWhiteSpace(TBCantidad.Text) || string.IsNullOrWhiteSpace(TbPrecio.Text)
                || string.IsNullOrWhiteSpace(TbTotal.Text) || string.IsNullOrWhiteSpace(CBEstado.Text)
                || string.IsNullOrWhiteSpace(CBCodPor.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                return; // Salir del método sin agregar el registro
            }
            SaEveConcepto concepto = new SaEveConcepto();
            concepto.CodConceptos = (int)NConceptos.SSCod;
            concepto.CodCategoria = (int?)ncategoria.ObtenerDescripcionesCod(CBCodCat.SelectedItem.ToString());
            concepto.DesConceptos = TbDes.Text;
            concepto.Cantidad = Convert.ToInt32(TBCantidad.Text);
            concepto.CostosConceptos = Convert.ToDecimal(textBox2.Text);
            concepto.Costoprecio = Convert.ToDecimal(TbTotal.Text);
            concepto.CodEstado = nestado.ObtenerDescripcionesCod(CBEstado.SelectedItem.ToString());
            concepto.CodPorcentaje = (int?)nporcentaje.ObtenerDescripcionesCod(CBCodPor.SelectedItem.ToString());
            textBox1.Refresh();
            concepto.Porciento = Convert.ToDecimal(textBox1.Text);

            InfoCompartidaCapas rGuardar = nconceptos.Modificar(concepto);
            if (!String.IsNullOrEmpty(rGuardar.error))
            {
                MessageBox.Show(rGuardar.error);
            }
            CargarInformacion();
            toolStripGuardar.Enabled = true;
        }
        private void BTNAct_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }
        private void CBCodPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCodPor.SelectedIndex != null)
            {
                string selectedItem = Convert.ToString(nporcentaje.Obtenerporciento(CBCodPor.SelectedItem.ToString()));
                textBox1.Text = selectedItem;
                textBox1.Refresh();
            }
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
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                calculos();
            }
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

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

