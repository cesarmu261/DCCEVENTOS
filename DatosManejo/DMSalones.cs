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
    public class DMSalones : IDisposable
    {

        private EventosContext contexto { get; set; }
        public DMSalones(EventosContext contexto)
        {
            this.contexto = contexto;
        }

        public List<SaEventoSalone> Obtener( int CodSalon = 0, string Descripcion ="", 
            string DescripcionLa = "" , string codestado = "")
        {
            List<SaEventoSalone> clientes = new List<SaEventoSalone>();
            if (CodSalon != 0)
            {
                clientes = contexto.SaEventoSalones.AsNoTracking().Where(a => a.CodSalon == (CodSalon)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(Descripcion))
                {
                    clientes = clientes.Where(a => a.DesSalon.Contains(Descripcion)).ToList();
                    if (clientes.Count > 1 && !String.IsNullOrEmpty(DescripcionLa))
                    {
                        clientes = clientes.Where(a => a.DeslarSalon.Contains(DescripcionLa)).ToList();

                        if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                        {
                            clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                        }
                    }
                }
            }
            else if (!String.IsNullOrEmpty(Descripcion))
            {
                clientes = contexto.SaEventoSalones.AsNoTracking().Where(a => a.DesSalon.Contains(Descripcion)).ToList();

                if (clientes.Count > 1 && !String.IsNullOrEmpty(DescripcionLa))
                {
                    clientes = clientes.Where(a => a.DeslarSalon.Contains(DescripcionLa)).ToList();

                    if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                    {
                        clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                    }
                }
            }
            else if (!String.IsNullOrEmpty(DescripcionLa))
            {
                clientes = contexto.SaEventoSalones.AsNoTracking().Where(a => a.DeslarSalon.Contains(DescripcionLa)).ToList();
                if (clientes.Count > 1 && !String.IsNullOrEmpty(codestado))
                {
                    clientes = clientes.Where(a => a.CodEstado.Contains(codestado)).ToList();
                }
            }
            else
            {
                return contexto.SaEventoSalones.AsNoTracking().ToList();
            }
            return clientes;


        }

        public InfoCompartidaCapas Crear(SaEventoSalone salones)
        {
            try
            {
                contexto.SaEventoSalones.Add(salones);
                return new InfoCompartidaCapas() { informacion =    salones };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al agregar {salones.CodSalon}" };
            }
        }
        public InfoCompartidaCapas Crear(List<SaEventoSalone> salones)
        {
            try
            {
                foreach (var item in salones)
                {
                    contexto.SaEventoSalones.Add(item);
                }
                return new InfoCompartidaCapas() { informacion = salones };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Modificar(SaEventoSalone salones)
        {
            try
            {
                contexto.SaEventoSalones.Attach(salones).State = EntityState.Modified;
                return new InfoCompartidaCapas() { informacion = salones };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al modificar {salones.CodSalon}" };
            }
        }
        public InfoCompartidaCapas Modificar(List<SaEventoSalone> salones)
        {
            try
            {
                foreach (var item in salones)
                {
                    contexto.SaEventoSalones.Attach(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                return new InfoCompartidaCapas() { informacion = salones };
            }
            catch (Exception e)
            {
                return new InfoCompartidaCapas() { error = e.Message };
            }
        }
        public InfoCompartidaCapas Eliminar(SaEventoSalone salones)
        {
            try
            {
                contexto.SaEventoSalones.Remove(salones);
                return new InfoCompartidaCapas() { informacion = salones };
            }
            catch (Exception)
            {
                return new InfoCompartidaCapas() { error = $"Error al eliminar {salones.CodSalon}" };
            }
        }
        public void Dispose()
        {
            contexto.Database.CloseConnection();
        }
        public int Obtenedescripcion(string nombre)
        {
            return contexto.SaEventoSalones.Where(a => a.DesSalon == nombre).FirstOrDefault().CodSalon;
        }
    }
}
