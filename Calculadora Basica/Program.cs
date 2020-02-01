using System;

namespace Calculadora_Basica
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               5- Crear una calculadora que me permita realizar las 4 operaciones básicas , sumar , restar , dividir y multiplicar, 
               la misma debe preguntarse inicialmente la operación que deseo realizar,
               luego pedirme los números de la operación y finalmente mostrar el resultado 
            */
            Console.WriteLine("Calculadora Básica - Elija una opción");

            /* Declaración de variables */
            int opcion;
            double num1, num2;

            /* Solicitar al usuario seleccionar la operación a realizar */
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Múltipicar");

            /* Almacenar la opcion seleccionada */
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Solicitar al usuario el primer numero */
            Console.WriteLine("Digite el primer numero: ");

            /* Almacenar el primer numero */
            num1 = Convert.ToInt32(Console.ReadLine());

            /* Solicitar al usuario el segundo numero */
            Console.WriteLine("Digite el segundo numero: ");

            /* Almacenar el segundo numero */
            num2 = Convert.ToInt32(Console.ReadLine());

            /* Operar de acuerdo a la opcion seleccionada por el usuario */
            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("El resultado de su sumar {0} + {1} es: {2}", num1, num2, (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("El resultado de su restar {0} - {1} es: {2}", num1, num2, (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("El resultado de su dividir {0} / {1} es: {2}", num1, num2, (num1 / num2));
                    break;

                case 4:
                    Console.WriteLine("El resultado de su múltiplicar {0} * {1} es: {2}", num1, num2, (num1 * num2));
                    break;

                default:
                    Console.WriteLine("La opcion seleccionada no existe");
                    break;
            }

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
