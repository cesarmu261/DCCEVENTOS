using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Coneccion
{
    public class Conecciones
    {
        public string ObtenerConeccion(string empresa)
        {
            //return "Server=WSDEVELOP02\\WSDEVELOP022;Database=eventos;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //return "Server=192.168.1.5\\SERVIDOR;Database=eventos;UID=sa; PWD=evista;TrustServerCertificate=True;";
            //return "Server=WSDEVELOP00\\WSDEVELOP00;Database=eventos;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            return ObtenerConexion(0);
        }
        public string ObtenerConeccion2(string empresa)
        {
            //return "Server=WSDEVELOP02\\WSDEVELOP022;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //return "Server=192.168.1.5\\SERVIDOR;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //return "Server=WSDEVELOP00\\WSDEVELOP00;Database=cuotas_v100;UID=sa; PWD=Usuario1;TrustServerCertificate=True;";
            //192.168.1.5\SERVIDOR
            return ObtenerConexion(1);
        }
        public string ObtenerConexion(int numeroConexion)
        {
            string nombreArchivo = "Conf.txt";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,nombreArchivo);

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                if (numeroConexion >= 0 && numeroConexion < lineas.Length)
                {
                    return lineas[numeroConexion];
                }
                else
                {
                    return "Número de conexión no válido";
                }
            }
            else
            {
                return "El archivo Conf.txt no se encuentra en la ubicación esperada.";
            }
        }


    }

}