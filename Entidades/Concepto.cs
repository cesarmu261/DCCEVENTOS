using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concepto
    {
        public string SSCodcon { get; set; }
        public string SSDescon { get; set; }
        public string SScantidad { get; set; }

        public static List<Concepto> listaConceptos = new List<Concepto>();
    }
}
