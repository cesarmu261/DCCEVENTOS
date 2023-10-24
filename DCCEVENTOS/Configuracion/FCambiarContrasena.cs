using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
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

namespace DCCEVENTOS.Configuracion
{
    public partial class FCambiarContrasena : Form
    {
        private NUsuarios nusuario;
        public FCambiarContrasena()
        {
            nusuario = new NUsuarios();
            InitializeComponent();
        }
        private void Nuevo()
        {
            TBConAnt.Text = string.Empty;
            TBConCon.Text = string.Empty;
            TBConNue.Text = string.Empty;
        }
        private void ModificarContrasena()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TBConAnt.Text) || string.IsNullOrWhiteSpace(TBConNue.Text)
                || string.IsNullOrWhiteSpace(TBConCon.Text))
                {
                    MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
                    return; // Salir del método sin agregar el registro
                }
                EventosContext context = new EventosContext();
                Entidades.Usuario datos = new Entidades.Usuario();

                List<Entidades.Usuario> List = new DMUsuarios(context).Obtener(NUsuarios.SSCod);
                foreach (Entidades.Usuario clave in List)
                {
                    if (TBConAnt.Text != clave.Clave)
                    {
                        MessageBox.Show("DEBE CAPTURAR CORRECTAM ENTA LA CONTRASENA ANTIGUA");
                        return;

                    }
                    else if (TBConNue.Text == TBConCon.Text)
                    {
                        datos.IdUsuario = NUsuarios.SSCod;


                        datos.Nombres = clave.Nombres;
                        datos.Apellidos = clave.Apellidos;
                        datos.Usuario1 = clave.Usuario1;
                        datos.IdRol = clave.IdRol;
                        datos.CodEstado = clave.CodEstado;


                        datos.Clave = TBConNue.Text;

                        InfoCompartidaCapas rGuardar = nusuario.Modificar(datos);
                        if (!String.IsNullOrEmpty(rGuardar.error))
                        {
                            MessageBox.Show(rGuardar.error);
                        }
                        MessageBox.Show("CONTRASEÑA CAMBIADA");
                    }
                    else
                    {
                        MessageBox.Show("POR VAOR VERIFIQUE QUE ESTEN BIEN LOS CAMPOS DE CONTRASEÑA NUEVO Y CONFIRMACION");
                        return;
                    }

                }


            }
            catch (Exception e)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS DATOS PARA EL REGISTRO");
            }
        }
        private void BTAceptar_Click(object sender, EventArgs e)
        {
            ModificarContrasena();
            Nuevo();
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
