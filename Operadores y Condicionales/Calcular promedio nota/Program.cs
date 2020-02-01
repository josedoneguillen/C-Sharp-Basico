using System;

namespace Calcular_promedio_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             6 realizar un programa que calcule el promedio de 4 números y si el resultado es mayor de 70
             mostrarme la literal que obtuve siendo A >= 90 y <= 100 , B >= 80 y <= 89 y C >= 70 y <= 79, 
             de sacar menos de 70 debe decirme que he reprobado.
             */
            Console.WriteLine("Calcular promedio nota");

            /* Declaración de variables */
            int nota1, nota2, nota3, nota4;
            double promedio;
            char literal = ' ';

            /* Solicitar las notas al usuario*/
            Console.WriteLine("Ingrese la nota1:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la nota2:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la nota3:");
            nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la nota4:");
            nota4 = Convert.ToInt32(Console.ReadLine());

            /* Calcular el promedio */
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            /* Evaluar el promedio literalmente */
            if (promedio < 70)
            {

                literal = 'F';

            } 
            else if (promedio >= 70 && promedio <= 79) {

                literal = 'C';

            }
            else if (promedio >= 80 && promedio <= 89)
            {

                literal = 'B';

            }
            else if (promedio >= 90 && promedio <= 100)
            {

                literal = 'A';

            }

            //Imprimir resultado en pantalla
            if (literal == 'F')
            {
                Console.WriteLine("REPROBADO");
            }
            else 
            {

                Console.WriteLine("APROBADO");

            }

            Console.WriteLine("El promedio es: " + promedio + " y la calificacion literal optenida fue: " + literal);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
