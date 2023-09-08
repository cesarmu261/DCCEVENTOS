﻿using Datos;
using DatosManejo;
using Entidades;
using InfoCompartidaCaps;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPago
    {
        public static int SSCod = 1;
        NTipoPago nTipoPago;
        NTrans NTrans;
        DataTable table;
        public NPago()
        {
            table = new DataTable();
            nTipoPago = new NTipoPago();
            NTrans = new NTrans();
        }
        public DataTable Obtener()
        {
            EventosContext contexto = new EventosContext();
            table = ToolsDBContext.ToDataTable<SaEvePago>(new DMPagos(contexto).Obtener());
            return table;
        }

        public DataTable ObtenerPago(int cod)
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePago> List = new DMPagos(contexto).Obtener(0,cod);
            DataTable Table = new DataTable();
            Table.Columns.Add("FOLIO");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            Table.Columns.Add("COD EVENTO");
            Table.Columns.Add("TIPO TRANS");
            Table.Columns.Add("FECHA DE PAGO");
            Table.Columns.Add("COD PAGO");
            Table.Columns.Add("MONTO A PAGADO");
            Table.Columns.Add("ESTADO");

            foreach (SaEvePago Entidad in List)
            {
                if (ObtenerNombreTipoestado(Entidad.CodEstado) == "ACTIVO")
                {
                    DataRow row = Table.NewRow();
                    row["FOLIO"] = Entidad.CodPagos;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                    row["COD EVENTO"] = Entidad.CodEvento;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                    row["TIPO TRANS"] = NTrans.ObtenerDescripcione(Entidad.CodTipoTransaccion);
                    row["FECHA DE PAGO"] = Entidad.FechaDePago;
                    row["COD PAGO"] = nTipoPago.ObtenerDescripcione(Entidad.CodPago);
                    row["MONTO A PAGADO"] = Entidad.Montoapagar;
                    row["ESTADO"] = ObtenerNombreTipoestado(Entidad.CodEstado);
                    Table.Rows.Add(row);
                }
            }

            return Table;

        }
        public DataTable ObtenerPago()
        {
            EventosContext contexto = new EventosContext();
            List<SaEvePago> List = new DMPagos(contexto).Obtener();
            DataTable Table = new DataTable();
            Table.Columns.Add("FOLIO");
            Table.Columns.Add("COD EVENTO");
            Table.Columns.Add("TIPO TRANS");
            Table.Columns.Add("FECHA DE PAGO");
            Table.Columns.Add("COD PAGO");
            Table.Columns.Add("MONTO A PAGADO");
            Table.Columns.Add("ESTADO");

            foreach (SaEvePago Entidad in List)
            {
                DataRow row = Table.NewRow();
                row["FOLIO"] = Entidad.CodPagos;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["COD EVENTO"] = Entidad.CodEvento;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["TIPO TRANS"] = NTrans.ObtenerDescripcione(Entidad.CodTipoTransaccion);
                row["FECHA DE PAGO"] = Entidad.FechaDePago;
                row["COD PAGO"] = nTipoPago.ObtenerDescripcione(Entidad.CodPago);
                row["MONTO A PAGADO"] = Entidad.Montoapagar;
                row["ESTADO"] = ObtenerNombreTipoestado(Entidad.CodEstado);
                Table.Rows.Add(row);
            }
            return Table;
        }

        public InfoCompartidaCapas Guardar(SaEvePago comp)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rguardar = new DMPagos(contexto).Crear(comp);
            if (String.IsNullOrEmpty(rguardar.error))
            {
                contexto.SaveChanges();
            }
            return rguardar;
        }

        public InfoCompartidaCapas Modificar(SaEvePago comp)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rmodificar = new DMPagos(contexto).Modificar(comp);
            if (String.IsNullOrEmpty(rmodificar.error))
            {
                contexto.SaveChanges();
            }
            return rmodificar;
        }
        public InfoCompartidaCapas Eliminar(SaEvePago comp)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas reliminar = new DMPagos(contexto).Eliminar(comp);
            if (String.IsNullOrEmpty(reliminar.error))
            {
                contexto.SaveChanges();
            }
            return reliminar;
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
       

    }
}
