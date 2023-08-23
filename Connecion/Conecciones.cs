namespace Coneccion
{
    public class Conecciones
    {
        public string ObtenerConeccion(string empresa)
        {
            //return "Server=192.168.1.5\\SERVIDOR;Database=eventos;UID=sa; PWD=evista;TrustServerCertificate=True;";
            return "Server=WSDEVELOP00\\WSDEVELOP002K17;Database=eventos;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
        }
        public string ObtenerConeccion2(string empresa)
        {
            return "Server=WSDEVELOP00\\WSDEVELOP002K17;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";

            //return "Server=192.168.1.5\\SERVIDOR;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //192.168.1.5\SERVIDOR
        }
    }
    
}