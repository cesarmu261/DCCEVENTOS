using Datos;
using DatosManejo;
using DCCEVENTOS.CBusqueda;
using DCCEVENTOS.Reportes;
using Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCCEVENTOS.Reportes;

namespace DCCEVENTOS.CReporte
{
    public partial class Reportes : Form
    {
        DataTable table, table2;
        private NEventos nevento;
        private NEventoDetalle neventod;
        private NPago npago;
        private bool tablaCargada = false;
        public Reportes()
        {
            nevento = new NEventos();
            neventod = new NEventoDetalle();
            npago = new NPago();
            InitializeComponent();
        }
        private void Nuevo()
        {
            TBCod.Text = string.Empty;
            TBDescripcion.Text = string.Empty;
            TBClientes.Text = string.Empty;
            DTGDetalles.DataSource = null;
            label3.Text = string.Empty;
        }
        private void CargarEvento()
        {
            try
            {
                EventosContext contexto = new EventosContext();
                int cod = Convert.ToInt32(TBCod.Text);
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR A CARGAR EVENTO");
            }
        }
        public void BuscarEvento()
        {
            int caseValue = 0;
            if (!string.IsNullOrEmpty(TBCod.Text))
            {
                caseValue = 1;
            }
            else if (!string.IsNullOrEmpty(TBClientes.Text) || !string.IsNullOrEmpty(TBDescripcion.Text))
            {
                caseValue = 2;
            }

            switch (caseValue)
            {
                case 1:
                    SSCod = TBCod.Text;
                    int cod = Convert.ToInt32(SSCod);
                    table = npago.ObtenerPagoTodos(cod);
                    DTGDetalles.DataSource = table;
                    DTGDetalles.Refresh();
                    break;
                case 2:
                    SSCod = TBCod.Text;
                    int cod2 = Convert.ToInt32(SSCod);
                    table = npago.ObtenerPagoTodos(cod2);
                    DTGDetalles.DataSource = table;
                    DTGDetalles.Refresh();
                    break;
                default:
                    break;
            }

        }
        string SSCod;
        private void button1_Click(object sender, EventArgs e)
        {
            BuscarEvento();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultadeEventosClie form = new ConsultadeEventosClie();
            form.ShowDialog();
            TBCod.Text = Convert.ToString(NEventos.SSCod);
            CargarEvento();
        }
        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConsultadeEventosDes form = new ConsultadeEventosDes();
            form.ShowDialog();
            TBCod.Text = Convert.ToString(NEventos.SSCod);
            CargarEvento();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBCod.Text))
            {
                MessageBox.Show("POR FAVOR CONSULTE UN EVENTO VALIDO");
                return; // Salir del método sin agregar el registro
            }
            else
            {
                int cod = Convert.ToInt32(TBCod.Text);
                PRECA reportForm = new PRECA(cod);
                reportForm.Show();
            }
        }
        private void TBCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+$");
            if (!er.Match(TBCod.Text).Success)
            {
                this.label3.Text = "El campo debe ser un número entero positivo";
            }
            else
            {
                if (e.KeyChar == (char)13)
                {
                    this.label3.Text= string.Empty;
                    CargarEvento();
                    BuscarEvento();
                }
            }
        }
    }
}
