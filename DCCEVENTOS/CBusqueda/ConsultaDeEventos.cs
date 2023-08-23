using Datos;
using DatosManejo;
using DCCEVENTOS.Reportes;
using Entidades;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCCEVENTOS.CBusqueda
{
    public partial class ConsultaDeEventos : Form
    {
        DataTable table;
        private NEventos nevento;
        private NSalones nsalones;
        private NEventoDetalle neventod;

        private bool tablaCargada = false;
        public ConsultaDeEventos()
        {
            InitializeComponent();
            nevento = new NEventos();
            neventod = new NEventoDetalle();
            nsalones = new NSalones();

            Object[] salones = nsalones.ObtenerDescripciones();
            if (salones.Length > 0)
            {
                CBSalones.DataSource = salones;
                CBSalones.Refresh();
            }
            CPrincipal.CambiarMaysucula(TBClientes);
            CPrincipal.CambiarMaysucula(TBDescripcion);
        }
        private void Nuevo()
        {
            TBDescripcion.Text = string.Empty;
            TBClientes.Text = string.Empty;
            DTGDetalles.DataSource = null;
            DTGEventos.DataSource = null;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            //DTGEventos.Rows.Clear();
            //DTGEventos.Rows.Clear();
        }

        public void fecha()
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker2.Value.Date;
            table = nevento.Obtener2(startDate, FINALDATE);
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();

        }
        public void cliente()
        {
            table = nevento.Obtener3(NTercero.SSCod, "");
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();
        }
        public void descripcion()
        {
            table = nevento.Obtener3(0, TBDescripcion.Text);
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();
        }
        public void Salones()
        {
            table = nevento.Obtener4(nsalones.ObtenerDescripcione(CBSalones.SelectedItem.ToString()));
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime newDate = selectedDate.AddMonths(1);
            dateTimePicker2.Value = newDate;
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                TBClientes.Text = t.NomCliente.ToString();
            }
        }
        string SSCod;
        private void DTGEventos_DoubleClick(object sender, EventArgs e)
        {

            DataSet dataSet = new DataSet();

            if (DTGEventos.CurrentRow.Index >= 0)
            {
                SSCod = DTGEventos.SelectedRows[0].Cells[0].Value.ToString();
                int cod = Convert.ToInt32(SSCod);
                table = neventod.ObteneEventos(cod);
                DTGDetalles.DataSource = table;
                DTGDetalles.Refresh();
            }
            button2.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultaClientes form = new ConsultaClientes();
            form.ShowDialog();
            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(NCliente.SSCod);
            foreach (var t in List)
            {
                TBClientes.Text = t.NomCliente.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SSCod = DTGEventos.SelectedRows[0].Cells[0].Value.ToString();
            int cod = Convert.ToInt32(SSCod);
            FRE rE = new FRE(cod);
            rE.Cod_Evento = cod;
            rE.Show();
        }

        private void toolStripNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private List<int> GetAllColumnValues()
        //{
        //    List<int> valores = new List<int>();

        //    foreach (DataGridViewRow row in DTGEventos.Rows)
        //    {
        //        if (!row.IsNewRow && row.Cells[0].Value != null)
        //        {
        //            int valor = Convert.ToInt32(row.Cells[0].Value);
        //            valores.Add(valor);
        //        }
        //    }

        //    return valores;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime startDate = selectedDate.Date;
            DateTime FINALDATE = dateTimePicker2.Value.Date;
            DateTime finDate = FINALDATE.Date;
            FRE2 reportForm = new FRE2(startDate, finDate);
            reportForm.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                fecha();
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBClientes.Text))
            {
                cliente();
                button4.Enabled = true;
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBDescripcion.Text))
            {
                descripcion();
                button5.Enabled = true;
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CBSalones.Text))
            {
                Salones();
                button6.Enabled = true;
            }

            else
            {
                MessageBox.Show("Debe ingresar al menos un valor para buscar.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            RECLIE reportForm = new RECLIE(NTercero.SSCod);
            reportForm.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            RESAL reportForm = new RESAL(nsalones.ObtenerDescripcione(CBSalones.SelectedItem.ToString()));
            reportForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            REDES reportForm = new REDES(TBDescripcion.Text);
            reportForm.Show();
        }
    }
}
