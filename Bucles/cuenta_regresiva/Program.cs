using System;

namespace cuenta_regresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *3.Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla
             * la cuenta atrás desde ese número hasta cero separados por comas.
             */
            Console.WriteLine("Cuenta regresiva");

            /* Declaracion de variables */
            int n;

            /* Solicitar al usuario el numero hasta el cual iterar */
            Console.WriteLine("Ingrese un numero:");
            n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            /* Ciclo while para contar hasta el numero ingresado por el usuario */
            while (n >= 0)
            {
                /* Imprimir el valor actual de n en cada iteracion */
                Console.Write(n);

                /* Separar por coma despues del primer elemento */
                if (n > 0)
                {
                    Console.Write(", ");
                }

                /* Reducir n en cada iteracion */
                n--;

            }

            /* Creando un salto de linea despues del for */
            Console.WriteLine(Environment.NewLine);

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
