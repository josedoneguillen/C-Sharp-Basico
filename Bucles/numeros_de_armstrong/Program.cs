using System;

namespace numeros_de_armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6.Escriba un programa para imprimir todos los números de Armstrong entre 1 y 500. 
             * Si la suma de los cubos de cada dígito del número es igual al número mismo, entonces el número se llama número de Armstrong.
             * Por ejemplo, 153 = (1 * 1 * 1) + (5 * 5 * 5) + (3 * 3 * 3)
             */
            Console.WriteLine("Numeros de armstrong entre 1 y 500");

            /* Ciclo for para contar del 1 al 500 y usar la funcion armstrong */
            for (int i = 1; i <= 500; i++)
            {
                Armstrong(i);
            }
            
        /* Esperar letra para cerrar */
        Console.WriteLine("Pulse una tecla para cerrar el programa.");
        Console.ReadKey();
        }

        /* funcion para validar un numero Armstrog */
        public static void Armstrong(int n) 
        {
            int a, b = 0, c;
            c = n;

            while (n > 0)
            {
                a = n % 10;
                n = n / 10;
                b = b + (a * a * a);
            }
            if (c == b)
            {
                Console.WriteLine(c);
            }

        }
    }
}
