using System;

namespace revertir_numero_entero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 9.Escriba un programa que solicite al usuario que ingrese un número entero y luego muestre el número con los dígitos invertidos. 
             * Por ejemplo, si la entrada es 12345, la salida debería ser 54321.
             */

            /* Declaracion de variables */
            int numero, cifra, inverso = 0;


            Console.WriteLine("número con los dígitos invertidos");

            /* Solicitar al usuario un numeros entero */
            Console.WriteLine("Ingrese un numero grande: ");
            numero = Convert.ToInt32(Console.ReadLine());

            /* Ciclo for para recorrer el numero */
            while (numero != 0)
            {   
                /* Se optiene el resto del numero para opetener la ultima cifra */
                cifra = numero % 10;
                /* El inverso es igual a si mismo multiplicado por diez mas la cifra resto del numero dividido entre 10 */
                inverso = (inverso * 10) + cifra;
                /* El numero se divide a si mismo entre diez mientras no sea igual a cero */
                numero /= 10;
            }

            /* Imprimir el resultado del numero inverso */
            Console.WriteLine(inverso);

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
