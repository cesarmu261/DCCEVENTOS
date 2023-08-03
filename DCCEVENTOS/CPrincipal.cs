using DCCEVENTOS.CBusqueda;
using System.Windows.Forms;

namespace DCCEVENTOS
{
    public partial class CPrincipal : Form
    {
        public CPrincipal()
        {
            InitializeComponent();
        }
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
            DCCEVENTOS.Calendario.Calendario formSecundario = new DCCEVENTOS.Calendario.Calendario();
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
    }
}