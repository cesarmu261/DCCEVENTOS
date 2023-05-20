using DatosManejo;
using Entidades;
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
    }
}