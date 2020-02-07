using System;

namespace palindromas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10.Escribir un programa que diga si dos palabras son palindromas.
             */

            /* Declaracion de variables */
            string palabra, invertida = "";

            Console.WriteLine("Validar palabras palindromas, Ej: OSO");

            /* Solicitar al usuario ingrsar una palabra */
            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();

            /* Ciclo for para recorrer los caracteres de la palabra */
            for (int a = (palabra.Length - 1); a >= 0; a--) 
            {
                invertida += palabra[a];
            }

            /* Condicional para comparar resultado */
            if (palabra == invertida)
            {
                Console.WriteLine("Esta palabra es palindroma! =D ");
            }
            else 
            {
                Console.WriteLine("Esta palabra NO es palindroma =( ");
            }

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
