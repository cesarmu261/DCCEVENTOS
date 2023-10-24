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
    public partial class CInicio : Form
    {
        private NUsuarios nusuario;
        private NPermisos npermisos;
        private NMenu nmenu;
        public static bool activo;
        public static string nombremenu;
        public CInicio()
        {
            nusuario = new NUsuarios();
            npermisos = new NPermisos();
            nmenu = new NMenu();
            InitializeComponent();
        }
        public List<Permiso> Permisos { get; set; }
        private void InicializarMenu()
        {
            string usuario = TBUsuario.Text;
            string contrasena = TBCon.Text;
            Entidades.Usuario datos = nusuario.IniciarSesion(usuario, contrasena);
            if (datos != null)
            {
                int? idRol = datos.IdRol;
                NUsuarios.SSCod = datos.IdUsuario;
                List<Permiso> permisos = npermisos.ObtenerPermisosPorRol(idRol);
                CPrincipal form = new CPrincipal();
                form.Permisos = permisos; // Asigna los permisos al formulario CPrincipal
                Permisos = permisos;
                form.ActualizarMenu(form.menuStrip1.Items); // Actualiza el estado del menú
                //form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Usuario o contraseña incorrectos.");
            }
        }
        private void BTAceptar_Click(object sender, EventArgs e)
        {
            InicializarMenu();
        }
        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                InicializarMenu();
            }
        }
    }
}


