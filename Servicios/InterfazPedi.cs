using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1.Servicios
{
    internal interface InterfazPedi
    {
        public string pedirNomb();
        public string pedirDni();
        public int pedirCodigo();
        public string devuelveApellidos();
    }
}
