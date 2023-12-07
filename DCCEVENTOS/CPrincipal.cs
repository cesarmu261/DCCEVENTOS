using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Configuracion;
using DCCEVENTOS.CReporte;
using DCCEVENTOS.Usuario;
using Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using Negocio;
using System;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCCEVENTOS
{
    public partial class CPrincipal : Form
    {
        DataTable table;
        private NEventos nevento;
        private NMenu nmenu;
        private Calendario.Calendario calendario;
        public static int CodUsu = 0;
        public CPrincipal()
        {
            InitializeComponent();
            nevento = new NEventos();
            nmenu = new NMenu();
            calendario = new Calendario.Calendario();
            calendario.WindowState = FormWindowState.Maximized;
        }
        private void Centroimagen()
        {
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;
        }
        public List<Permiso> Permisos { get; set; }

        public void ActualizarMenu(ToolStripItemCollection items)
        {
            if (Permisos != null)
            {
                foreach (ToolStripMenuItem menuItem in items)
                {
                    if (menuItem is ToolStripMenuItem)
                    {
                        string nombreMenu = menuItem.Text;
                        int? men = nmenu.ObtenerDescripcionesCod(nombreMenu);
                        // Verificar si se obtuvo un código de menú válido
                        if (men.HasValue)
                        {
                            Permiso permiso = Permisos.FirstOrDefault(p => p.IdMenu == men.Value);

                            if (permiso != null)
                            {
                                //menuItem.Enabled = (bool)permiso.Activo;
                                menuItem.Visible = (bool)permiso.Activo;
                            }
                        }
                        // Llama a la función de manera recursiva para manejar los submenús.
                        ActualizarMenu(menuItem.DropDownItems);
                    }
                }
            }
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
            Calendario.Calendario formSecundario = new Calendario.Calendario();
            formSecundario.TopLevel = false;
            formSecundario.FormBorderStyle = FormBorderStyle.None;
            formSecundario.Dock = DockStyle.Fill;
            panel1.Controls.Add(formSecundario);
            formSecundario.Show();
            Centroimagen();
            cambiarUsuarioToolStripMenuItem_Click(sender, e);
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
        private void reportePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportePagos form = new ReportePagos();
            //form.Show();
            CReporte.Reportes form = new CReporte.Reportes();
            form.Show();
        }
        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMenus form = new FMenus();
            form.Show();
        }
        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRoles form = new FRoles();
            form.Show();
        }
        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPermisos form = new FPermisos();
            form.Show();
        }
        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FUsuarios form = new FUsuarios();
            form.Show();
        }
        private void cambiarContraseñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCambiarContrasena form = new FCambiarContrasena();
            form.Show();
        }
        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CInicio form = new CInicio();
            panel2.Visible = true;
            form.ShowDialog();
            if (NUsuarios.SSCod == 0)
            {
                Application.Exit();
            }
            else
            {
                Permisos = form.Permisos; // Asigna los permisos al formulario CPrincipal
                ActualizarMenu(menuStrip1.Items);
                panel2.Visible = false;
            }
        }

        private void reporteDePagosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePagosFechas form = new ReportePagosFechas();
            form.Show();
        }
    }
}