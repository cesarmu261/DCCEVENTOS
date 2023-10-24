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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
        }
        public void dias(int numerodias)
        {
            Lbdia.Text = numerodias + "";
            //timer1.Start();
            display();
        }
        //public void eventos(string evento)
        //{
        //    label1.Text = evento;
        //}

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
        private void display()
        {
            int dia = Convert.ToInt32(Lbdia.Text);
            int mes = Calendario.mes_estat;
            int anio = Calendario.an_estat;

            if (anio >= DateTime.MinValue.Year && anio <= DateTime.MaxValue.Year &&
                mes >= 1 && mes <= 12 &&
                dia >= 1 && dia <= DateTime.DaysInMonth(anio, mes))
            {
                DateTime fecha = new DateTime(anio, mes, dia);

                //List<SaEvento> List = new DMEvento(contexto).Obtener(0, 0, 0, "", fecha);
                List<SaEvento> List = new DMEvento(contexto).ObtenerFechas(fecha);
                foreach (SaEvento ev in List)
                {
                    listBox1.Visible = true;
                    listBox1.Items.Add(ev.DesEvento);
                }
            }
            else
            {
                // Manejar el caso en el que los valores no son válidos.
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //display();
        }
    }
}
