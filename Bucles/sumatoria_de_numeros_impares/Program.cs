using System;

namespace sumatoria_de_numeros_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5.Escriba un programa para encontrar la suma de todos los números impares entre 1 y un número ingresado por consola.
             */
            Console.WriteLine("Sumatoria de numeros impares");

            /* Declaracion de variables */
            int n = 0, total = 0;

            /* Solicitar al usuario el numero hasta el cual iterar */
            Console.WriteLine("Ingrese un numero:");
            n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            /* Ciclo for para contar hasta el numero ingresado por el usuario */
            for (int i = 1; i <= n; i += 2)
            {
                /* Separar por coma despues del primer elemento */
                if (i > 1)
                {
                    Console.Write(" + ");
                }

                /* Imprimir numero impar */
                Console.Write(i);

                /* Sumar numero impar al total */
                total += i;

            }

            /* Imprimir sumatoria de todos los numeros impares de la serie */
            Console.WriteLine(" = " + total);

            /* Creando un salto de linea despues del for */
            Console.WriteLine(Environment.NewLine);

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
