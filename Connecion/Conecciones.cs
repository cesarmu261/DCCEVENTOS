namespace Coneccion
{
    public class Conecciones
    {
        public string ObtenerConeccion(string empresa)
        {
            //return "Server=WSDEVELOP02\\WSDEVELOP022;Database=eventos;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //return "Server=192.168.1.5\\SERVIDOR;Database=eventos;UID=sa; PWD=evista;TrustServerCertificate=True;";
            return "Server=WSDEVELOP00\\WSDEVELOP00;Database=eventos;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";

        }
        public string ObtenerConeccion2(string empresa)
        {
            //return "Server=WSDEVELOP02\\WSDEVELOP022;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //return "Server=192.168.1.5\\SERVIDOR;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            return "Server=WSDEVELOP00\\WSDEVELOP00;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //192.168.1.5\SERVIDOR
        }
    }
    
}