using System;

namespace ciclo_para_sumar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8.Escriba un bucle do-while que le pida al usuario que ingrese dos números. Se deben agregar los números y mostrar la suma. 
             * El bucle debe preguntarle al usuario si desea volver a realizar la operación. 
             * Si es así, el ciclo debería repetirse; de lo contrario debería terminar.
             */

            /* Declaracion de variables */
            int num1, num2, resultado, opc = 1;

            Console.WriteLine("Calcular la suma de dos numeros");

            /* Insertando salto de linea para mejor legibilidad durante la ejecucion */
            Console.Write(Environment.NewLine);

            /* Inciar ciclo do while de calculo */
            do
            {

                /* Solicitar al usuario los numeros para la operacion */
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                /* Insertando salto de linea para mejor legibilidad durante la ejecucion */
                Console.Write(Environment.NewLine);

                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                /* Realizar la suma */
                resultado = num1 + num2;

                /* Insertando salto de linea para mejor legibilidad durante la ejecucion */
                Console.Write(Environment.NewLine);

                /* Imprimir el resultado */
                Console.WriteLine("La suma de {0} mas {1} es: {2}", num1, num2, resultado);

                /* Insertando salto de linea para mejor legibilidad durante la ejecucion */
                Console.Write(Environment.NewLine);

                /* Preguntar al usuario si desea realizar la operacion nuevamante */
                Console.WriteLine("Si desea volver a realizar la operacion, digite en numero de la opcion elegida:");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                opc = Convert.ToInt32(Console.ReadLine());

                /* Insertando salto de linea y separador para mejor legibilidad durante la ejecucion */
                Console.Write(Environment.NewLine);
                Console.WriteLine("********************************************************************************");

                /* Switch para validar la opcion */
                if (opc != 1) 
                {
                        /*Si la opcion no es 1 romper el ciclo */
                        break;
                }


            } while (opc == 1);

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
