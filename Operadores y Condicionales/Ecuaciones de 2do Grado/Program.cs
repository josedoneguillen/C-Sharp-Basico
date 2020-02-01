using System;

namespace Ecuaciones_de_2do_Grado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
                4- Crear un programa que resuelva ecuaciones de segundo grados por la fórmula general, 
                para calcular raíz cuadrada en c# se utiliza la clase Math y el método sqrt , (Math.sqrt) 
                formula: x = (-b +||- raiz(b^2 - 4ac)) / 2a; 
                referencia https://matematicascercanas.com/2016/11/01/formula-ecuaciones-polinomicas-segundo-grado/  
            */
            Console.WriteLine("resuelva ecuaciones de segundo grados por la fórmula general: x = (-b +/- raiz(b^2 - 4ac)) / 2a;");

            /* Declaración de variables */
            int a; //Término cuadrático
            int b; //Término lineal
            int c; //Término independiente
            double x1; //Variable x positiva
            double x2; //Variable x negativa

            /* Solicitar al usuario el valor de las varibles de la ecuación */
            Console.WriteLine("Ingrese el valor de a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c:");
            c = Convert.ToInt32(Console.ReadLine());

            /* Realizar cálculo para encontrar el valor de x1 y x2 via formula general */
            x1 = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * b * c))) / ( 2 * a);
            x2 = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * b * c))) / (2 * a);

            /* Impripir los valores en pantalla */
            Console.WriteLine("El valor de x1 es: " + x1 + "\n" + "El valor de x2 es: " + x2);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
 