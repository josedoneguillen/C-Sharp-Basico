using System;

namespace Radio_Circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- Hacer un programa que calcule el radio de una circunferencia*/
            Console.WriteLine("Calcular Radio de una circunferencia");

            //Declaración de variables
            double circunferencia, radio;

            //Solicitar el valor de la circunferencia al usuario
            Console.WriteLine("Ingrese la circunferencia:");
            circunferencia = Convert.ToDouble(Console.ReadLine());

            //Procesar la información
            radio = circunferencia / Math.PI;

            //Imprimir resultado
            Console.WriteLine("El radio es: " + radio);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
