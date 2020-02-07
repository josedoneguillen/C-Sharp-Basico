using System;

namespace sumatoria_de_numero_pares_impares_y_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 12.Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla la suma de todos los numeros pares, 
             * de todos los impares y de todos los numeros primos desde 1 hasta ese número ingresado por el usuario.
             */

            /* Declaracion de variables */
            int numero, pares = 0, impares = 0, primos = 0;

            Console.WriteLine("Suma de todos los numeros pares, impares y primos");

            /* Solicitar al usuario un numeros entero */
            Console.WriteLine("Ingrese un numero entero: ");
            numero = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            /* Ciclo for para contar hasta el numero del usuario */
            for (int a = 1; a <= numero; a++) 
            {
                /* Validar que tipo de numero es */
                if (a % 2 == 0)
                {
                    pares += a;

                    if (a == 2)
                    {
                        primos += a;
                    }
                }
                else
                {
                    impares += a;

                    if (a != 2)
                    {

                        bool primo = true;
                        int maximo = (int)(Math.Sqrt(a));
                        for (int b = 3; b <= maximo; b += 2)
                        {

                            if (a % b == 0)
                            {
                                primo = false;
                                break;
                            }
                        }

                        if (primo && a != 2)
                        {
                            primos += a;
                        }
                    }

                }
            }

            /* Imprimir resultados */
            Console.WriteLine("Total de numeros pares: " + pares);
            Console.WriteLine("Total de numeros impares: " + impares);
            Console.WriteLine("Total de numeros primos: " + (primos-1));
            Console.WriteLine("Total: " + (pares + impares + (primos-1)));

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
