using System;

namespace terminos_de_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 7. Escriba un programa para imprimir series de n términos de Fibonacci 
             * donde n es ingresado por el usuario a través del teclado: 0 1 1 2 3 5 8 13 24 
             */
            Console.WriteLine("series de n términos de Fibonacci");
            /* Declaracion de variables */
            int n, a = 0, b = 1, t;

            /* Solicitar al usuario el numero hasta el cual iterar la serie de fibonacci */
            Console.WriteLine("Ingrese un numero:");
            n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            /* Ciclo for para iterar la serie de fibonacci n veces */
            for (int i = 0; i < n; i++) {

                /* Imprimir numero de la serie */
                Console.WriteLine(a);

                /* Sumar numero de la serie para optener la sucesion de fibonaci para la siguiente iteracion */
                t = a + b;
                a = b;
                b = t;

            }

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
