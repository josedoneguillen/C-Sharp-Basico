using System;

namespace patron_de_diamante
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Escriba un programa en C # para mostrar un patrón de diamante: */
            Console.WriteLine("Patrón de diamante");

            /* Declaracion de variables */
            int size;
            int count=1;

            /* Solicitar al usuario cantidad de lineas */
            Console.WriteLine("Ingrese un numero");
            size = Convert.ToInt32(Console.ReadLine());

            /* Primer ciclo que imprime el total de lineas */
            for(int i=1;i<=2*size-1;i++)
            {
                /* Segundo ciclo para imprimir espacios a la izquierda del asterisco para pocionarlo en la consola y lograr la figura */
                for(int j=count;j<=size;j++)
                {
                    Console.Write("  "); 
                }

                /* Tercer ciclo para imprimir asterisco mas un espacio a su derecha */
                for(int k=1;k<=count*2-1;k++)
                {
                    Console.Write("* ");
                }
                
                /* Condicional que decide si es la parte superior o inferior del diamante para retroceder el contador e imprimir una nueva linea en ambos casos*/
                if(i<size)
                {
                    count++;
                    Console.Write(Environment.NewLine); 
                }
                else
                {
                    count--;
                    Console.Write(Environment.NewLine); 
                }
            }

            /* Esperar letra para cerrar */
            Console.ReadKey();
        }
    }
}
