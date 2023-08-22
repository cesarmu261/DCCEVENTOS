using Negocio;
using System.Windows.Forms;
using DCCEVENTOS.Calendario;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Datos;
using DatosManejo;
using Entidades;
using System.Data;

namespace DCCEVENTOS.Calendario
{
    public partial class UserControlDias : UserControl
    {
        // 
        public static string dia_estat;
        NEventos NEventos;
        Calendario Calendario;
        public UserControlDias()
        {
            InitializeComponent();
            NEventos = new NEventos();
            Calendario = new Calendario();
        }
        public void dias(int numerodias)
        {
            Lbdia.Text = numerodias + "";
        }
        public void eventos(string evento)
        {
            label1.Text = evento ;
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void UserControlDias_Click(object sender, EventArgs e)
        {

            dia_estat = Lbdia.Text;
            //timer1.Start();
            CEventos form = new CEventos();
            form.Show();

        }
        EventosContext contexto = new EventosContext();
        //private void display()
        //{
        //    int dia = DateTime.DaysInMonth(Calendario.an_estat, Calendario.mes_estat);
        //    int mes = Calendario.mes_estat;
        //    int anio = Calendario.an_estat;

        //    DateTime fecha = new DateTime(anio, mes, dia);

        //    List<SaEvento> List = new DMEvento(contexto).Obtener(0, "", "", fecha);

        //    foreach (SaEvento ev in List)
        //    {
        //        label1.Text = ev.DesEvento; // Reemplazar "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
        //    }
        //}


        private void timer1_Tick(object sender, EventArgs e)
        {
            //display();
        }
    }
}
