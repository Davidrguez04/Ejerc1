/*En el nombre y apellidos que se ponga debe existir al menos una a una r y el conjunto de letras arc.

Desarrolla el programa con la arquitectura vista en clase:
Pide un nombre, primer y segundo apellidos, por consola y valida que el nombre no coincide con ninguno de los
apellidos. 
Pide el dni por consola y valida que tiene un formato correcto: en el enlace se explica como se calcula la letra 
de un dni para poder validarlo. 
Pide el código postal por consola y valida que es de la ciudad de Sevilla: en el enlace tienes los códigos postales
de Sevilla.
Concatena el nombre y los apellidos en una sola variable de tipo string con el siguiente formato: "apellido1 
apellido2, nombre."
Separa la concatenación y guarda los apellidos unidos en una sola variable.
Calcula el tamaño de la variable con el nombre completo.
Recupera y muestra por consola el décimo carácter de la variable con los apellidos.
Busca la primera vez que aparece la letra a en el nombre completo.
Busca la primera vez que aparezca la letra r a partir de la posición 3 y hasta la posición 10 en el nombre completo.
Toma la variable nombre y guárdala en una nueva variable separando cada letra: Marcos -> M a r c o s
Indica la posición del valor "arc" dentro del nombre completo.
 */
using Ejerc1.Servicios;

namespace Ejerc1.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// 16-01-2021 David Rodriguez Alonso
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 16-01-2024 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            InterfazPedi ni = new ImplPedi();

            string nombre=ni.pedirNomb();

            string dni=ni.pedirDni();

            Console.WriteLine("\n\t"+nombre+" = "+dni);

            int codigo=ni.pedirCodigo();

            string apellidos=ni.devuelveApellidos();

            // Calcula el tamaño de la variable con el nombre completo
            int tamañoNombreCompleto = nombre.Length;

            // Recupera y muestra por consola el décimo carácter de la variable con los apellidos
            char decimoCaracterApellidos = apellidos.Length >= 10 ? apellidos[9] : '\0';
            Console.WriteLine("\n\tDécimo carácter de los apellidos:" +decimoCaracterApellidos);

            // Busca la primera vez que aparece la letra 'a' en el nombre completo
            int primeraA = nombre.IndexOf('a');
            Console.WriteLine("\n\tPrimera vez que aparece la letra 'a':" +primeraA);

            // Busca la primera vez que aparece la letra 'r' a partir de la posición 3 y hasta la posición 10
            int primeraR = nombre.IndexOf('r', 3, 7);
            Console.WriteLine("\n\tPrimera vez que aparece la letra 'r' entre la posición 3 y 10:"+ primeraR);

            // Guarda el nombre separando cada letra
            string nombreSeparado = string.Join(" ", nombre.ToCharArray());
            Console.WriteLine("\n\tNombre separado: "+nombreSeparado);

            // Indica la posición del valor "arc" dentro del nombre completo
            int posicionArc = nombre.IndexOf("arc");
            Console.WriteLine("\n\tPosición de 'arc' en el nombre completo:"+ posicionArc);
        

        Console.Write("\n\tPulse una tecla para salir del programa ");
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }
    }
}
