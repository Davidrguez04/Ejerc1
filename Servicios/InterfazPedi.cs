using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad del calculo
    /// Contiene el calculo de los dias
    /// </summary>
    internal interface InterfazPedi
    {
        public string pedirNomb();
        public string pedirDni();
        public int pedirCodigo();
        public string devuelveApellidos();
    }
}
