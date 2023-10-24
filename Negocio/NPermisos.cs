using DatosManejo;
using InfoCompartidaCaps;
using System;
using System.Collections.Generic;
using System.Data;
using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPermisos
    {
        public static int SSCod = 1;
        DataTable table;
        NMenu nmenu;
        public NPermisos()
        {
            table = new DataTable();
            nmenu = new NMenu();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            List<Permiso> List = new DMPermisos(contexto).Obtener();

            DataTable Table = new DataTable();
            Table.Columns.Add("CODIGO");
            Table.Columns.Add("MENU");
            foreach (Permiso datos in List)
            {
                DataRow row = Table.NewRow();
                row["MENU"] =nmenu.ObtenerDescripcione( datos.IdMenu);
                Table.Rows.Add(row);
            }
            return Table;
        }
        public bool ExisteRegistro(Permiso datos)
        {
            // Aquí debes escribir la lógica para verificar si existe un registro con los mismos valores en la base de datos
            // Puedes utilizar una consulta LINQ o realizar una consulta a través de tu ORM o método preferido

            // Ejemplo de verificación utilizando LINQ y Entity Framework
            using (var context = new EventosContext())
            {
                bool existe = context.Permisos.Any(d =>
                    d.IdMenu == datos.IdMenu &&
                    d.IdRol == datos.IdRol &&
                    d.Activo == d.Activo);

                return existe;
            }
        }
        public DataTable Obtener(int rol)
        {
            EventosContext contexto = new EventosContext();
            List<Permiso> permisos = new DMPermisos(contexto).Obtener(0, rol);
            DataTable table = new DataTable();

            // Agregar una columna de tipo bool para los datos de activo
            table.Columns.Add("Activo", typeof(bool));
            table.Columns.Add("CODIGO");
            table.Columns.Add("MENU");

            foreach (Permiso datos in permisos)
            {
                DataRow row = table.NewRow();

                // Asigna el valor de activo (un booleano) a la columna "Activo" si existe
                row["Activo"] = datos.Activo;
                //if (table.Columns.Contains("Activo"))
                //{
                //    row["Activo"] = datos.Activo.Value;
                //}

                row["CODIGO"] = datos.IdPermiso;
                // Asigna la descripción del menú a la columna "MENU"
                row["MENU"] = nmenu.ObtenerDescripcione(datos.IdMenu);
                table.Rows.Add(row);
            }

            return table;
        }

        public InfoCompartidaCapas Guardar(Permiso datos)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMPermisos(contexto).Crear(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Modificar(Permiso datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMPermisos(contexto).Modificar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }
        public InfoCompartidaCapas Eliminar(Permiso datos)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas r = new DMPermisos(contexto).Eliminar(datos);
            if (String.IsNullOrEmpty(r.error))
            {
                contexto.SaveChanges();
            }
            return r;
        }

        public List<Permiso> ObtenerPermisosPorRol(int? idRol)
        {
            EventosContext context = new EventosContext();
            return context.Permisos.Where(p => p.IdRol == idRol).ToList();
        }

        public int ObtenerCod(int rol =0)
        {
            EventosContext context = new EventosContext();
            return new DMPermisos(context).ObtenerCodigo(rol);
        }
        //public string ObtenerDescripcione(int? cod = 0)
        //{
        //    EventosContext context = new EventosContext();
        //    return new DMPermisos(context).Obtenedescripcion(cod);
        //}
    }
}
