using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuarios
    {
        public static int SSCod = 0;
        DataTable table;
        NRol nrol;
        public NUsuarios()
        {
            table = new DataTable();
            nrol = new NRol();
        }
        
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<Usuario> List = new DMUsuarios(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("APELLIDO");
            Table.Columns.Add("USUARIO");
            //Table.Columns.Add("CLAVE");
            Table.Columns.Add("ROL");
            Table.Columns.Add("ESTADO");
            foreach (Usuario datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.IdUsuario;
                row["NOMBRE"] = datos.Nombres;
                row["APELLIDO"] = datos.Apellidos;
                row["USUARIO"] = datos.Usuario1;
                //row["CLAVE"] = datos.Clave;
                row["ROL"] = nrol.ObtenerDescripcione( datos.IdRol);
                row["ESTADO"]= ObtenerNombreTipoestado(datos.CodEstado); ;
                Table.Rows.Add(row);
            }
            return Table;
        }
        public DataTable Obtener(string Usuarios)
        {
            EventosContext contexto = new EventosContext();
            List<Usuario> List = new DMUsuarios(contexto).Obtener(0,"","",Usuarios);

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("NOMBRE");
            Table.Columns.Add("APELLIDO");
            Table.Columns.Add("USUARIO");
            Table.Columns.Add("ROL");
            Table.Columns.Add("ESTADO");
            foreach (Usuario datos in List)
            {
                DataRow row = Table.NewRow();
                row["CODIGO"] = datos.IdUsuario;
                row["NOMBRE"] = datos.Nombres;
                row["APELLIDO"] = datos.Apellidos;
                row["USUARIO"] = datos.Usuario1;
                row["ROL"] = nrol.ObtenerDescripcione(datos.IdRol);
                row["ESTADO"] = ObtenerNombreTipoestado(datos.CodEstado); ;
                Table.Rows.Add(row);
            }
            return Table;
        }
        public InfoCompartidaCapas Guardar(Usuario datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMUsuarios(contexto).Crear(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Modificar(Usuario datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMUsuarios(contexto).Modificar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Eliminar(Usuario datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMUsuarios(contexto).Eliminar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public string ObtenerNombreTipoestado(string codigoestado)
        {
            using (var db = new EventosContext()) // Reemplazar TuContextoDeEntityFramework por el nombre de tu contexto de Entity Framework
            {
                var tipoestado = db.SaCodEstados.FirstOrDefault(t => t.CodEstado == codigoestado);
                if (tipoestado != null)
                {
                    return tipoestado.DesEstado;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public Usuario IniciarSesion(string usuario , string contrasena)
        {
            using (var contexto = new EventosContext())
            {
                var inicio = contexto.Usuarios
                    .FirstOrDefault(u => u.Usuario1 == usuario && u.Clave == contrasena);

                return inicio;
            }
        }

    }
}
   
