﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using DatosManejo;
using InfoCompartidaCaps;
using Entidades;

using Microsoft.EntityFrameworkCore;

namespace Negocio
{
    public class NConceptos
    {
        DataTable conceptos;
        public static string SSCodcon;
        public NConceptos()
        {
            conceptos = new DataTable();
        }
        public DataTable ObtenerConceptos()
        {
            EventosContext contexto = new EventosContext();
            conceptos = ToolsDBContext.ToDataTable<SaEveConcepto>(new DMConceptos(contexto).Obtener());
            conceptos.Columns.Remove(conceptos.Columns[conceptos.Columns.Count - 1]);
            conceptos.Columns.Remove(conceptos.Columns[conceptos.Columns.Count - 1]);
            return conceptos;
        }
        public DataTable ObtenerConceptos2( string descripcion)
        {
            EventosContext contexto = new EventosContext();
            List<SaEveConcepto> conceptosList = new DMConceptos(contexto).Obtener2(descripcion);

            DataTable conceptosTable = new DataTable();
            conceptosTable.Columns.Add("CodConceptos");  // Reemplaza "Columna1" con el nombre de la columna real que deseas incluir
            conceptosTable.Columns.Add("DesConceptos");
            conceptosTable.Columns.Add("CostosConceptos");
            conceptosTable.Columns.Add("Costoprecio");
            foreach (SaEveConcepto concepto in conceptosList)
            {
                DataRow row = conceptosTable.NewRow();
                row["CodConceptos"] = concepto.CodConceptos;  // Reemplaza "Columna1" y "Propiedad1" con los nombres reales de la columna y propiedad que deseas incluir
                row["DesConceptos"] = concepto.DesConceptos;  // Reemplaza "Columna2" y "Propiedad2" con los nombres reales de la columna y propiedad que deseas incluir
                row["CostosConceptos"] = concepto.CostosConceptos;                                        // Asigna los valores de más columnas según tus necesidades
                row["Costoprecio"] = concepto.Costoprecio;
                conceptosTable.Rows.Add(row);
            }

            return conceptosTable;
            
        }


        public InfoCompartidaCapas Guardar(SaEveConcepto concepto)
        {

            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rporcentajes = new DMConceptos(contexto).Crear(concepto);
            if (String.IsNullOrEmpty(rporcentajes.error))
            {
                contexto.SaveChanges();
            }
            return rporcentajes;
        }
        
        public InfoCompartidaCapas Eliminar(SaEveConcepto concepto)
        {
            EventosContext contexto = new EventosContext();
            InfoCompartidaCapas rconcepto = new DMConceptos(contexto).Eliminar(concepto);
            if (String.IsNullOrEmpty(rconcepto.error))
            {
                contexto.SaveChanges();
            }
            return rconcepto;
        }
        public InfoCompartidaCapas GestionarDataTable(DataTable tablaconceptos, DataTable conceptoExistencia)
        {
            EventosContext contexto = new EventosContext();
            tablaconceptos.Merge(conceptoExistencia);
            contexto.Database.OpenConnection();
            System.Data.Common.DbConnection coneccion = contexto.Database.GetDbConnection();
            System.Data.Common.DbTransaction transaccion = coneccion.BeginTransaction();
            contexto.TransaccionBR(coneccion, transaccion);
            DMConceptos dmconceptos = new DMConceptos(contexto);
            List<SaEveConcepto> modificarconcepto = (from a in tablaconceptos.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>() select new SaEveConcepto() { CodConceptos = a.Field<int>("Codigo"), CodCategoria = a.Field<int>("Categoria"),DesConceptos = a.Field<String>("Descripcion"), CostosConceptos = a.Field<decimal>("Costos Conceptos"), Costoprecio = a.Field<decimal>("Costos uni"), CodEstado = a.Field<string>("Estado"), CodPorcentaje = a.Field<int>("codPorcentaje"), Porciento = a.Field<decimal>("Porciento") }).ToList();
            InfoCompartidaCapas rModArt = dmconceptos.Modificar(modificarconcepto);
            if (!String.IsNullOrEmpty(rModArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rModArt;
            }
            List<SaEveConcepto> crearcategoria = (from a in tablaconceptos.Select(null, null, DataViewRowState.ModifiedCurrent).ToList<DataRow>()select new SaEveConcepto(){ CodConceptos = a.Field<int>("Codigo"), CodCategoria = a.Field<int>("Categoria"), DesConceptos = a.Field<String>("Descripcion"), CostosConceptos = a.Field<decimal>("Costos Conceptos"), Costoprecio = a.Field<decimal>("Costos uni"), CodEstado = a.Field<string>("Estado"), CodPorcentaje = a.Field<int>("codPorcentaje"), Porciento = a.Field<decimal>("Porciento") }).ToList();
            InfoCompartidaCapas rCreArt = dmconceptos.Crear(crearcategoria);
            if (!String.IsNullOrEmpty(rCreArt.error))
            {
                contexto.Database.RollbackTransaction();
                return rCreArt;
            }
            contexto.SaveChanges();
            contexto.Database.CommitTransaction();
            return new InfoCompartidaCapas() { informacion = tablaconceptos };
        }
    }
}
