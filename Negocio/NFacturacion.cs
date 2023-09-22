using Datos;
using DatosManejo;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NFacturacion
    {
        public void GenerarFactura(string Nombrecliente, string montotxt, string ivatxt, string Subtotaltxt)
        {
            string DSFecha = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
            string DSHora = DateTime.Today.Hour.ToString() + ":" + DateTime.Today.Minute.ToString() + ":" + DateTime.Today.Second.ToString();
            string DSCadenaConexion = "Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB= C:\\Compacw\\Empresas\\DCC040820K65 ;Exclusive=No; Collate=Machine;NULL=NO;DELETED=YES;BACKGROUNDFETCH=NO;";
            string DSCadenaComando = "";
            string DSColumnas = "";
            int DIIdDocumento = 0;
            int ID = 0;
            int DIIdDocumento2 = 0;
            int DIIdDocumento3 = 0;
            int DIIdCliente = 0;
            int DIRenglon = 0;
            int DIIdProducto = 0;
            string DSCodigoCliente = "";
            string DSRazonSocial = "";
            string DSRFC = "";
            string DSRF = "";
            decimal DDSubtotal = 0;
            decimal DDIva = 0;
            decimal DDTotal = 0;
            string total = montotxt;
            string iva = ivatxt;

            string subtotal = Subtotaltxt;
            string DSCEmail = "";

            DDTotal = Convert.ToDecimal(total);
            DDIva = Convert.ToDecimal(iva);
            DDSubtotal = Convert.ToDecimal(subtotal);


            EventosContext contexto = new EventosContext();
            List<SaEveCliente> List = new DMCliente(contexto).Obtener(0, "", Nombrecliente);
            foreach (var t in List)
            {

                DSRazonSocial = t.RazonSocial.ToString();
                DSRFC = t.Rfc.ToString();
                DSCodigoCliente = t.CodTercero.ToString();
                DSCEmail = t.Correo.ToString();
                DSRF = t.CodRegimenfiscal.ToString();
            }

            DSCadenaComando = "SELECT MAX(cfolio) FROM MGW10008";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DIIdDocumento = Convert.ToInt32(DComando.ExecuteScalar());
                    DConexion.Close();
                }
            }

            DSCadenaComando = "SELECT MAX(CIDDOCUM01) FROM MGW10008";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    ID = Convert.ToInt32(DComando.ExecuteScalar());
                    DConexion.Close();
                }
            }

            DIIdDocumento++;
            ID++;

            DSCadenaComando = "SELECT CIDCLIEN01 FROM MGW10002 WHERE CCODIGOC01 = '" + DSCodigoCliente + "'";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DIIdCliente = Convert.ToInt32(DComando.ExecuteScalar());
                    DConexion.Close();
                }
            }

            DSCadenaComando = "UPDATE MGW10002 SET CRAZONSO01 = '" + DSRazonSocial + "', CRFC = '" + DSRFC + "', CEMAIL1 = '" + DSCEmail + "', CREGIMFISC = '" + DSRF + "' WHERE CCODIGOC01 = '" + DSCodigoCliente + "'";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DConexion.Close();
                }
            }

            //metododepago   '" & tipoPago & "'
            string DSColumnas5 = ID + ", 4, 3007, '', " + DIIdDocumento + ", {" + DSFecha + "}, " + DIIdCliente + ", '" + DSRazonSocial + "', '" + DSRFC + "', {" + DSFecha + "}, {" + DSFecha + "}, 0, 1, 1, 1, 1, 1, " + DDSubtotal + ", " + DDIva + ", " + DDTotal + ", " + DDTotal + ", 1, 1, 202, 1, 1,{'01/01/1900 00:00:00:000'}, {'01/01/1900 00:00:00:000'}, '', '',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'','','',{'01/01/1900 00:00:00:000'},0,0,0,0,'','','','',0,0,0,0,0,0,{'12/30/1899 00:00:00:000'},0, 0, 0, 1, 0, '01','', '', '33000',0,0 ";
            string DSCadenaComando5 = "INSERT INTO MGW10008 (CIDDOCUM01, CIDDOCUM02, CIDCONCE01, CSERIEDO01, CFOLIO, CFECHA, CIDCLIEN01, CRAZONSO01, CRFC, CFECHAVE01, CFECHAPR01, CIDAGENTE, CIDMONEDA, CTIPOCAM01, CUSACLIE01, CAFECTADO, CESTADOC01, CNETO, CIMPUESTO1, CTOTAL, CPENDIENTE,CTOTALUN01,CUNIDADE01, CSISTORIG, CNUMPARCIA, CCANTPARCI,CFECHAEN01, CFECHAUL01, CREFEREN01, COBSERVA01,CNATURAL01, CIDDOCUM03, CPLANTILLA,CUSAPROV01, CIMPRESO, CCANCELADO, CDEVUELTO, CIDPREPO01,CIDPREPO02, CIMPUESTO2, CIMPUESTO3, CRETENCI01, CRETENCI02,CDESCUEN01, CDESCUEN02, CDESCUEN03, CGASTO1, CGASTO2,CGASTO3, CDESCUEN04, CPORCENT01, CPORCENT02, CPORCENT03, CPORCENT04, CPORCENT05, CPORCENT06,CTEXTOEX01, CTEXTOEX02, CTEXTOEX03,CFECHAEX01,CIMPORTE01, CIMPORTE02, CIMPORTE03, CIMPORTE04,CDESTINA01, CNUMEROG01, CMENSAJE01, CCUENTAM01,CNUMEROC01, CPESO, CBANOBSE01, CBANDATO01, CBANCOND01, CBANGASTOS,CTIMESTAMP,CIMPCHEQ01, CIDMONEDCA, CTIPOCAMCA, CESCFD, CTIENECFD,CMETODOPAG,CCONDIPAGO, CNUMCTAPAG, CLUGAREXPE,CIDPROYE01,CIDCUENTA) VALUES (" + DSColumnas5 + ")";

            using (System.Data.Odbc.OdbcConnection DConexion = new System.Data.Odbc.OdbcConnection(DSCadenaConexion))
            {
                System.Data.Odbc.OdbcCommand DComando = new System.Data.Odbc.OdbcCommand();
                DComando.Connection = DConexion;
                DComando.CommandText = DSCadenaComando5;
                DConexion.Open();
                int DSRenAfe = DComando.ExecuteNonQuery();
                DConexion.Close();
            }

            string DSCadenaComando2 = "SELECT MAX(CIDMOVIM01) FROM MGW10010";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando2;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DIIdDocumento2 = Convert.ToInt32(DComando.ExecuteScalar());
                    DConexion.Close();
                }
            }

            DIIdDocumento2++;






            DSCadenaComando = "SELECT CIDPRODU01 FROM MGW10005 WHERE CCODIGOP01 = '1001'";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DIIdProducto = Convert.ToInt32(DComando.ExecuteScalar());
                    DConexion.Close();
                }
            }


            DSColumnas = DIIdDocumento2 + ", " + ID + ",1, 4, " + DIIdProducto + ",0,1.00,0.00,1.00,0,0," + DDSubtotal + "," + DDSubtotal + ",0.00,0.00," + DDSubtotal + "," + (Convert.ToDouble(DDSubtotal) * (0.16)) + ",16,0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00," + Convert.ToDouble(DDSubtotal) * (1.16) + ",0.00,'','RENTA DE SALON',2, 1, 1,{" + DSFecha + "},0, 0, 0, 1.00, 0.00, 0.00, 0.00, 1, 0,'','','',{'01/01/1900 00:00:00:000'}, 0.00, 0.00, 0.00, 0.00,{'12/30/1899 00:00:00:000'},0.00,'',0.00,0,0";
            DSCadenaComando = "INSERT INTO MGW10010(CIDMOVIM01, CIDDOCUM01, CNUMEROM01, CIDDOCUM02, CIDPRODU01,CIDALMACEN, CUNIDADES, CUNIDADE01, CUNIDADE02, CIDUNIDAD, CIDUNIDA01, CPRECIO, CPRECIOC01, CCOSTOCA01, CCOSTOES01, CNETO, CIMPUESTO1,CPORCENT01, CIMPUESTO2,CPORCENT02, CIMPUESTO3, CPORCENT03, CRETENCI01, CPORCENT04, CRETENCI02, CPORCENT05, CDESCUEN01, CPORCENT06, CDESCUEN02, CPORCENT07, CDESCUEN03, CPORCENT08, CDESCUEN04, CPORCENT09, CDESCUEN05, CPORCENT10,CTOTAL,CPORCENT11, CREFEREN01,COBSERVA01, CAFECTAE01, CAFECTAD01, CAFECTAD02,CFECHA,CMOVTOOC01, CIDMOVTO01, CIDMOVTO02, CUNIDADE03, CUNIDADE04, CUNIDADE05, CUNIDADE06, CTIPOTRA01, CIDVALOR01, CTEXTOEX01,CTEXTOEX02, CTEXTOEX03,CFECHAEX01, CIMPORTE01, CIMPORTE02, CIMPORTE03, CIMPORTE04,CTIMESTAMP,CGTOMOVTO, CSCMOVTO, CCOMVENTA, CIDMOVDEST, CNUMCONSOL) VALUES(" + DSColumnas + ")";

            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DConexion.Close();
                }
            }


            string DSCadenaComando3 = "SELECT MAX(CIDFOLDIG) FROM MGW10045";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando3;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DIIdDocumento3 = Convert.ToInt32(DComando.ExecuteScalar());
                    DConexion.Close();
                }
            }

            DIIdDocumento3++;

            string DSCadenaComando4 = "INSERT INTO MGW10045(CIDFOLDIG, CIDDOCTODE, CIDCPTODOC, CIDDOCTO, CFOLIO, CESTADO, CENTREGADO, CFECHAEMI, CESTRAD, cidfirmarl, cnoorden, CSerie, cnoaprob, cfecaprob, choraemi, cemail, carchdidis, cidcptoori, cfechacanc, choracanc, ccadpedi, carchcbb, cinivig, cfinvig, CTipo, cserierec, cfoliorec, crfc, crazon, csisorigen, cejerpol, cperpol, ctipopol, cnumpol, ctipoldesc, ctotal, caliasbdct, ccfdprueba, cdesestado, cpagadoban, cdespagban, creferen01, cobserva01, ccodconcba, cdesconcba, cnumctaban, cfolioban, ciddocdeba, cusuautban, cuuid, cusuban01, cautusba01, cusuban02, cautusba02, cusuban03, cautusba03, cdescaut01, cdescaut02, cdescaut03, cerrorval, cacusecan, CIDDOCALDI) VALUES(" + DIIdDocumento3 + ", 4, 3007, " + ID + ", " + DIIdDocumento + ", 1, 0, {" + DSFecha + "}, 3, 0, 0, '', 0, {'01/01/1900 00:00:00:000'}, '', '', '', 0, {'01/01/1900 00:00:00:000'}, '', '', '', {'01/01/1900 00:00:00:000'}, {'01/01/1900 00:00:00:000'}, 'I', '', 0, '" + DSRFC + "', '" + DSRazonSocial + "', 0, 0, 0, 0, 0, '', " + DDTotal + ", '', 0, '', 0, '', '', '', '', '', '', '', 0, '', '', '', 0, '', 0, '', 0, '', '', '', 0, '', 0)";
            using (OdbcConnection DConexion = new OdbcConnection(DSCadenaConexion))
            {
                using (OdbcCommand DComando = new OdbcCommand())
                {
                    DComando.Connection = DConexion;
                    DComando.CommandText = DSCadenaComando4;
                    DConexion.Open();
                    int DSRenAfe = DComando.ExecuteNonQuery();
                    DConexion.Close();
                }
            }

        }
    }
}

