using DCCEVENTOS.CBusqueda;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using Negocio;
using System.Data;
using System.Windows.Forms;

namespace DCCEVENTOS
{

    public partial class CPrincipal : Form
    {
        DataTable table;
        private NEventos nevento;
        private Calendario.Calendario calendario;
        public static void CambiarMaysucula(TextBox textBox)
        {
            textBox.TextChanged += (sender, e) =>
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;

                textBox.Text = textBox.Text.ToUpper();

                textBox.SelectionStart = selectionStart;
                textBox.SelectionLength = selectionLength;
            };
        }
        //EnableAutoUpperCase(TbDes);
        public CPrincipal()
        {
            InitializeComponent();
            nevento = new NEventos();
            calendario = new Calendario.Calendario();

        }
        //public void fecha()
        //{
        //    DTGEventos.DataSource = null;
        //    DateTime iniciodemes = new DateTime(Calendario.Calendario.an_estat, Calendario.Calendario.mes_estat, 1);
        //    DateTime FINdemes = new DateTime(Calendario.Calendario.an_estat, (Calendario.Calendario.mes_estat) + 1, 1);
        //    table = nevento.Obtener2(iniciodemes, FINdemes);
        //    DTGEventos.DataSource = table;
        //    DTGEventos.Refresh();
        //}
        private void porcentajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPorcentaje form = new CPorcentaje();
            form.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCategoria form = new CCategoria();
            form.Show();
        }

        private void conceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CConcepto form = new CConcepto();
            form.Show();
        }

        private void paqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPaquete form = new CPaquete();
            form.Show();
        }

        private void paqueteDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPaqueteDetalle form = new CPaqueteDetalle();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CClientes form = new CClientes();
            form.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEventos form = new CEventos();
            form.Show();
        }

        private void CPrincipal_Load(object sender, EventArgs e)
        {
            Calendario.Calendario formSecundario = new Calendario.Calendario();
            formSecundario.TopLevel = false;
            formSecundario.FormBorderStyle = FormBorderStyle.None;
            formSecundario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formSecundario);
            formSecundario.Show();
        }

        private void reporteEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDeEventos form = new ConsultaDeEventos();
            form.Show();
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CSalones form = new CSalones();
            form.Show();
        }

        private void tipoDeTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTransacciones form = new CTransacciones();
            form.Show();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPagos form = new CPagos();
            form.Show();
        }

        private void comprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CComprobante form = new CComprobante();
            form.Show();
        }

        private void tipoDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTipodePago form = new CTipodePago();
            form.Show();
        }

        private void tipoDeCancelacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCancelaciones form = new CCancelaciones();
            form.Show();
        }

        private void consultaDePorcentajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPorcentaje form = new ConsultaPorcentaje();
            form.Show();
        }

        private void consultaDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsulatadeCategorias form = new ConsulatadeCategorias();
            form.Show();
        }

        private void consultaDeSalonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeSalones form = new ConsultadeSalones();
            form.Show();
        }

        private void consultaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTipoTrenasacciones form = new ConsultaTipoTrenasacciones();
            form.Show();
        }

        private void consultaDeTipoDeComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultadetipocomprobante form = new Consultadetipocomprobante();
            form.Show();
        }

        private void consultaDeTipoDeCancelacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeCancelaciones form = new ConsultadeCancelaciones();
            form.Show();
        }

        private void consultaDeTipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeTipoPago form = new ConsultadeTipoPago();
            form.Show();
        }

        private void consultaDeConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeConceptos form = new ConsultadeConceptos();
            form.Show();
        }

        private void consultaDePaqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadePaquete form = new ConsultadePaquete();
            form.Show();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.Show();

        }

        private void consultaDeTerceroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTerceros form = new ConsultaTerceros();
            form.Show();
        }

        private void consultaDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDeEventos form = new ConsultaDeEventos();
            form.Show();
        }
    }
}