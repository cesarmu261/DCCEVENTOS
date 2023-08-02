using Datos;
using DatosManejo;
using Entidades;
using System.Globalization;

namespace DCCEVENTOS.Calendario
{
    public partial class Calendario : Form
    {
        public static int mes_estat;
        public static int an_estat;
        int mes, an;

        public Calendario()
        {
            InitializeComponent();
            
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
        //EventosContext contexto = new EventosContext();
        //private void display()
        //{
        //    DateTime now = DateTime.Now;

        //    mes_estat = now.Month;
        //    an_estat = now.Year;
        //    string nombredemes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes_estat);

        //    Lbfecha.Text = nombredemes + " " + an_estat;
        //    DateTime iniciodemes = new DateTime(an_estat, mes_estat, 1);

        //    int dia = DateTime.DaysInMonth(an_estat, mes_estat);
        //    //converit el inicio de mes a entero 
        //    int diadelasemana = Convert.ToInt32(iniciodemes.DayOfWeek.ToString("D")) + 1;

        //    for (int i = 1; i < diadelasemana; i++)
        //    {
        //        UserControlBlanco dias = new UserControlBlanco();
        //        Contenedordia.Controls.Add(dias);
        //    }

        //    List<SaEvento> listaEventos = new DMEvento(contexto).Obtener(0, 0, "", now); // Suponiendo que 'now' es la fecha actual.

        //    for (int i = 1; i <= dia; i++)
        //    {
        //        UserControlDias dias = new UserControlDias();
        //        dias.dias(i);
        //        Contenedordia.Controls.Add(dias);

        //        // Buscar eventos para este día específico
        //        DateTime fechaEvento = new DateTime(an_estat, mes_estat, i);
        //        SaEvento eventoEnEsteDia = listaEventos.Find(ev => ev.Fecha == fechaEvento.Date);
        //        if (eventoEnEsteDia != null)
        //        {
        //            // Mostrar la información del evento en el control de usuario
        //            dias.eventos((eventoEnEsteDia.DesEvento));
        //        }
        //    }
        //}

        private void Calendario_Load(object sender, EventArgs e)
        {
            display();
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
        }
    }
}
