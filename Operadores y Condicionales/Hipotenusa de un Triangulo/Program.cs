using System;

namespace Hipotenusa_de_un_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                9- Crear un programa que calcule la hipotenusa de un triángulo rectángulo,
                referencia https://www.universoformulas.com/matematicas/geometria/hipotenusa/ 
            */
            Console.WriteLine("Calcular la hipotenusa de un triángulo rectángulo");

            /* Declaración de variables */
            double a, b, h;

            /* Solicitar al usuario los valores de a y b */
            Console.WriteLine("Ingrese el valor de a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b: ");
            b = double.Parse(Console.ReadLine());

            /* Realizar cálculo */
            h = Math.Sqrt( ( Math.Pow(a, 2) ) + ( Math.Pow(b,2) ) );

            /* Imprimir el resultado */
            Console.WriteLine("la hipotenusa del triángulo rectángulo es: " + h);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
