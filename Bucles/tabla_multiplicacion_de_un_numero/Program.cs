using System;

namespace tabla_multiplicacion_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4.Realizar una aplicación que introduzca un número e imprima la tabla de multiplicar de ese numero.
             */
            Console.WriteLine("Tabla de multiplicacion de un numero");

            /* Declaracion de variables */
            int n;

            /* Solicitar al usuario el numero hasta el cual iterar */
            Console.WriteLine("Ingrese un numero para ver su tabla de multiplicacion:");
            n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            /* Ciclo while para contar hasta el numero ingresado por el usuario */
            for (int i = 1; i <= 12; i++)
            {
                /* Imprimir el valor actual de n en cada iteracion */
                Console.WriteLine(i + " x " + n + " = " + (i*n));
            }

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
