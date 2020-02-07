using System;

namespace numeros_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               2. Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla
               todos los números impares desde 1 hasta ese número separados por comas.
            */
            Console.WriteLine("Imprime numeros impares");

            /* Declaracion de variables */
            int n;

            /* Solicitar al usuario el numero hasta el cual iterar */
            Console.WriteLine("Ingrese un numero:");
            n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            /* Ciclo for para contar hasta el numero ingresado por el usuario */
            for (int i = 1; i <= n; i+=2) 
            {
                /* Separar por coma despues del primer elemento */
                if (i > 1) 
                {
                    Console.Write(", ");
                }

                Console.Write(i);

            }

            /* Creando un salto de linea despues del for */
            Console.WriteLine(Environment.NewLine);

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
