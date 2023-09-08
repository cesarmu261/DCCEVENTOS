using Datos;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosManejo
{
    public class DMTrans
    {
        private EventosContext contexto { get; set; }
        public DMTrans(EventosContext contexto)
        {
            this.contexto = contexto;
        }

        public List<SaEvTipoTransaccion> Obtener(int codigo = 0, string Descripcion = "")
        {
            List<SaEvTipoTransaccion> tran = new List<SaEvTipoTransaccion>();
            if (codigo != 0)
            {
                tran = contexto.SaEvTipoTransaccions.AsNoTracking().Where(a => a.CodTipoTransaccion == (codigo)).ToList();
                if (tran.Count > 1 && !String.IsNullOrEmpty(Descripcion))
                {
                    tran = tran.Where(a => a.DesTipoTransaccion.Contains(Descripcion)).ToList();
                }
            }
            else if (!String.IsNullOrEmpty(Descripcion))
            {
                tran = contexto.SaEvTipoTransaccions.AsNoTracking().Where(a => a.DesTipoTransaccion.Contains(Descripcion)).ToList();
            }
            else
            {
                return contexto.SaEvTipoTransaccions.AsNoTracking().ToList();
            }
            return tran;
        }

        public InfoCompartidaCapas Crear(SaEvTipoTransaccion tra)
        {
            try
            {
                contexto.SaEvTipoTransaccions.Add(tra);
                return new InfoCompartidaCapas() { informacion = tra };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {tra.CodTipoTransaccion}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEvTipoTransaccion> tra)
        {
            try
            {
                foreach (var item in tra)
                {
                    contexto.SaEvTipoTransaccions.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = tra };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEvTipoTransaccion tra)
        {
            try
            {
                contexto.SaEvTipoTransaccions.Attach(tra).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = tra };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {tra.CodTipoTransaccion}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEvTipoTransaccion> tra)
        {
            try
            {
                foreach (var item in tra)
                {
                    contexto.SaEvTipoTransaccions.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = tra };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEvTipoTransaccion tra)
        {
            try
            {
                contexto.SaEvTipoTransaccions.Remove(tra);
                return new InfoCompartidaCapas() { informacion = tra };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {tra.CodTipoTransaccion}" };
            }
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
        public int Obtenedescripcion(string nombre)
        {
            return contexto.SaEvTipoTransaccions.Where(a => a.DesTipoTransaccion == nombre).FirstOrDefault().CodTipoTransaccion;
        }
        public string Obtenedescripcioncod(int? cod)
        {
            return contexto.SaEvTipoTransaccions.Where(a => a.CodTipoTransaccion == cod).FirstOrDefault().DesTipoTransaccion;
        }

    }
}
