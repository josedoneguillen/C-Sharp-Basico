using System;

namespace Analizador_de_Generacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                8- realizar una aplicación que según mi año de nacimiento me diga
                a cuál generación pertenezco (referencia https://www.lavanguardia.com/vivo/20180408/442342457884/descubre-que-generacion-perteneces.html ) 
            */
            Console.WriteLine("Analizador de Generación");

            /* Declaración de variables */
            int year;
            string generacion = " ";

            /* Solicitar al usuario su año de nacimiento */
            Console.WriteLine("Ingrese su año de nacimiento: ");
            year = int.Parse(Console.ReadLine());

            /* Determinar su generacion */
            if (year >= 1938 && year <= 1948) 
            {

                generacion = "Silent Generation - Los niños de la posguerra";
            }
            else if (year >= 1949 && year <= 1968)
            {

                generacion = "Baby Boom";
            }
            else if (year >= 1969 && year <= 1980)
            {

                generacion = "Generación X";
            }
            else if (year >= 1981 && year <= 1993)
            {

                generacion = "Generación Y - Millennials";
            }
            else if (year >= 1984 && year <= 2010)
            {

                generacion = "Generación Y - Millennials";
            }
            else if (year > 2010)
            {

                generacion = "Generación nueva";
            }

            /* Imprimir resultado */
            Console.WriteLine(generacion);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
