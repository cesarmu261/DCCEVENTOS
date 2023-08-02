namespace Coneccion
{
    public class Conecciones
    {
        public string ObtenerConeccion(string empresa)
        {
            return "Server=WSDEVELOP00\\WSDEVELOP002K17;Database=eventos;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
        }
        public string ObtenerConeccion2(string empresa)
        {
            return "Server=WSDEVELOP00\\WSDEVELOP002K17; Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";

        }
    }
}