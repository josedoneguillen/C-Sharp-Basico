using System;

namespace imprimir_letra_n
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 11.Escriba un programa  para mostrar un patrón en forma de N con asterisco.
             */

            Console.WriteLine("patrón en forma de N con asterisco");

            /* Filas */
            for (int a = 1; a <= 7; a++) 
            {
                /* Columnas */
                for (int b = 1; b <= 5; b++)
                {
                    /* Determinar espacios y asteriscos segun posicion */
                    if (b > 1 && b < 5)
                    {
                        
                        if (a > 2 && a < 6)
                        {
                            if (a == 3 && b > 2)
                            {
                                Console.Write(" ");
                            }
                            else if ((a == 4 && b == 2) || (a == 4 && b == 4))
                            {
                                Console.Write(" ");
                            }
                            else if ((a == 5 && b > 1 && b < 4))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }

                        }
                        else 
                        {
                            Console.Write(" ");
                        }

                    }
                    else 
                    {
                        Console.Write("*");
                    }

                }

                /* Salto de linea al final de cada fila */
                Console.Write(Environment.NewLine);

            }

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
