using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1.Servicios
{
    internal class ImplPedi:InterfazPedi
    {
        private string apellidoP;
        private string apellidoS;
        public string pedirNomb()
        {
            //En el nombre y apellidos que se ponga debe existir al menos una a una r y el conjunto de letras arc.

            string nombre="";
            string nombreC = apellidoP + " " + apellidoS + ", " + nombre;
            Console.WriteLine("\n\tEl nombre debe contener una a, una r y el conjunto de arc");

            do
            {
                Console.Write("\n\tIntroduzca su nombre: ");
                 nombre = Console.ReadLine();

                Console.Write("\n\tIntroduzca su primer apellido: ");
                apellidoP = Console.ReadLine();

                Console.Write("\n\tIntroduzca su segundo apellido: ");
                apellidoS = Console.ReadLine();

                nombreC = apellidoP + " " + apellidoS + ", " + nombre;

                // Verifica que el nombre cumple con los requisitos
                if (cumpleRequisitos(nombreC))
                {
                    Console.WriteLine("El nombre cumple con los requisitos.");
                }
                else
                {
                    Console.WriteLine("El nombre no cumple con los requisitos. Vuelve a intentarlo.");
                    
                }

            } while (!cumpleRequisitos(nombreC)); // Repite el bucle mientras no cumpla con los requisitos
        

            do
            {
                if (nombre.Equals(apellidoS) || nombre.Equals(apellidoP))
                {
                    Console.Write("\n\tIntroduzca su nombre otra vez: ");
                    nombre = Console.ReadLine();
                }
            } while (nombre == apellidoS || nombre == apellidoP);

            Console.WriteLine("\n\t" + nombre + " " + apellidoP + " " + apellidoS);

           
            string apellidoC = apellidoP + " " + apellidoS;
            

            return nombreC;
        }
        public string devuelveApellidos()
        {
            string apellidoC=apellidoP+" "+apellidoS;
            return apellidoC;
        }

        public string pedirDni()
        {
            int dni;
            string dniC, letra;
            letra = "";

            Console.Write("\n\tIntroduzca su dni: ");
            dni = Convert.ToInt32(Console.ReadLine());

            switch (dni%23)
            {
                case 0:
                    letra = "T";
                break;

                case 1:
                    letra = "R";
                    break;

                case 2:
                    letra = "W";
                    break;
                case 3:
                    letra = "A";
                    break;
                case 4:
                    letra = "G";
                    break;
                case 5:
                    letra = "M";
                    break;
                case 6:
                    letra = "Y";
                    break;
                case 7:
                    letra = "F";
                    break;
                case 8:
                    letra = "P";
                    break;
                case 9:
                    letra = "D";
                    break;
                case 10:
                    letra = "X";
                    break;
                case 11:
                    letra = "B";
                    break;
                case 12:
                    letra = "N";
                    break;
                case 13:
                    letra = "J";
                    break;
                case 14:
                    letra = "Z";
                    break;
                case 15:
                    letra = "S";
                    break;
                case 16:
                    letra = "Q";
                    break;
                case 17:
                    letra = "V";
                    break;
                case 18:
                    letra = "H";
                    break;
                case 19:
                    letra = "L";
                    break;
                case 20:
                    letra = "C";
                    break;
                case 21:
                    letra = "K";
                    break;
                case 22:
                    letra = "E";
                    break;

            }

            dniC = dni + letra;
            return dniC;
        }

        public int pedirCodigo()
        {
            Console.Write("\n\tIntroduzca su código postal: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            if (codigo == 41001 ||codigo==41002 || codigo == 41003 || codigo == 41004 || codigo == 41005 || codigo == 41006 || codigo == 41007 || codigo == 41008 || codigo == 41009 || codigo == 41010 || codigo == 41011 || codigo == 41012 || codigo == 41013 || codigo == 41014 || codigo == 41015 || codigo == 41016 || codigo == 41017 || codigo == 41018 || codigo == 41019 || codigo == 41020 || codigo == 41092)
            {
                Console.WriteLine("\n\tEs un codigo postal de Sevilla Correcto");

            }
            else
            {
                Console.WriteLine("\n\tNo es un código postal de Sevilla");
            }

            return codigo;
            
        }

        static bool cumpleRequisitos(string nombre)
        {
            // Verifica que haya al menos una "a", una "r" y el conjunto de letras "arc"
            bool tieneA = nombre.Contains("a", StringComparison.OrdinalIgnoreCase);
            bool tieneR = nombre.Contains("r", StringComparison.OrdinalIgnoreCase);
            bool tieneARC = nombre.Contains("arc", StringComparison.OrdinalIgnoreCase);

            return tieneA && tieneR && tieneARC;
        }
    }
}
