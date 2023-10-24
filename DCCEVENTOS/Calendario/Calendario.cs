using Datos;
using DatosManejo;
using DCCEVENTOS.Reportes;
using Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Negocio;
using System.Data;
using System.Globalization;


namespace DCCEVENTOS.Calendario
{
    public partial class Calendario : Form
    {
        public static int mes_estat;
        public static int an_estat;
        int mes, an;
        NEventos nevento;
        DataTable table;
        public Calendario()
        {
            InitializeComponent();
            nevento = new NEventos();
        }
        private void display()
        {

            DateTime now = DateTime.Now;

            mes_estat = now.Month;
            an_estat = now.Year;
            string nombredemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes_estat);

            Lbfecha.Text = nombredemes + " " + an_estat;
            DateTime iniciodemes = new DateTime(an_estat, mes_estat, 1);

            int dia = DateTime.DaysInMonth(an_estat, mes_estat);
            //converit el inicio de mes a entero 
            int diadelasemana = Convert.ToInt32(iniciodemes.DayOfWeek.ToString("D")) + 1;

            for (int i = 1; i < diadelasemana; i++)
            {
                UserControlBlanco dias = new UserControlBlanco();
                Contenedordia.Controls.Add(dias);
            }

            for (int i = 1; i <= dia; i++)
            {
                UserControlDias dias = new UserControlDias();
                dias.dias(i);
                Contenedordia.Controls.Add(dias);
            }

        }
        private void Calendario_Load(object sender, EventArgs e)
        {
            display();
            fecha(an_estat, mes_estat);
        }


        public void fecha(int an, int mes)
        {
            DTGEventos.DataSource = null;
            //DateTime iniciodemes = new DateTime(an_estat, mes_estat, 1);
            //DateTime FINdemes = new DateTime(an_estat, (mes_estat) + 1, 1);
            DateTime iniciodemes = new DateTime(an, mes, 1);
            int ano = an;
            int mesadelentado = (mes) + 1;
            if (mesadelentado > 12)
            {
                mesadelentado = 1;
                ano++;
            }
            if (mesadelentado < 1)
            {
                mesadelentado = 12;
                ano--;
            }
            DateTime FINdemes = new DateTime(ano, mesadelentado, 1);
            table = nevento.Obtener2(iniciodemes, FINdemes);
            DTGEventos.DataSource = table;
            DTGEventos.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Contenedordia.Controls.Clear();
            mes_estat++;

            if (mes_estat > 12)
            {
                mes_estat = 1;
                an_estat++;
            }

            string nombredemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes_estat);
            Lbfecha.Text = nombredemes + " " + an_estat;
            DateTime iniciodemes = new DateTime(an_estat, mes_estat, 1);

            int dia = DateTime.DaysInMonth(an_estat, mes_estat);
            int diadelasemana = Convert.ToInt32(iniciodemes.DayOfWeek.ToString("D")) + 1;

            for (int i = 1; i < diadelasemana; i++)
            {
                UserControlBlanco dias = new UserControlBlanco();
                Contenedordia.Controls.Add(dias);
            }

            for (int i = 1; i <= dia; i++)
            {
                UserControlDias dias = new UserControlDias();
                dias.dias(i);
                Contenedordia.Controls.Add(dias);
            }
            fecha(an_estat, mes_estat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contenedordia.Controls.Clear();
            mes_estat--;

            if (mes_estat < 1) // Verifica si el mes es menor que 1 (enero)
            {
                mes_estat = 12; // Establece el mes a 12 (diciembre)
                an_estat--;     // Resta 1 al año
            }

            string nombredemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes_estat);
            Lbfecha.Text = nombredemes + " " + an_estat;
            DateTime iniciodemes = new DateTime(an_estat, mes_estat, 1);

            int dia = DateTime.DaysInMonth(an_estat, mes_estat);
            int diadelasemana = Convert.ToInt32(iniciodemes.DayOfWeek.ToString("D")) + 1;

            for (int i = 1; i < diadelasemana; i++)
            {
                UserControlBlanco dias = new UserControlBlanco();
                Contenedordia.Controls.Add(dias);
            }

            for (int i = 1; i <= dia; i++)
            {
                UserControlDias dias = new UserControlDias();
                dias.dias(i);
                Contenedordia.Controls.Add(dias);
            }
            fecha(an_estat, mes_estat);
        }

        string SSCod;
        private void DTGEventos_DoubleClick(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            if (DTGEventos.CurrentRow.Index >= 0)
            {
                SSCod = DTGEventos.SelectedRows[0].Cells[0].Value.ToString();
                int cod = Convert.ToInt32(SSCod);
                FRE rE = new FRE(cod);
                //rE.Cod_Evento = cod;
                rE.Show();
            }
        }
    }
}
