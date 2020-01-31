using System;

namespace Calcular_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2- Crear un programa que calcule el imc y te diga según el resultado cual es tu composición corporal. Referencia (https://www.texasheart.org/heart-health/heart-information-center/topics/calculadora-del-indice-de-masa-corporal-imc/ ) */
            Console.WriteLine("Calcular Indice de Masa Corporal (IMC) ");

            //Declaración de variables
            double pesoKg, alturaMetros, IMC;
            string composicionCorporal = " ";

            //Solicitar valor de pesoKG al usuario
            Console.WriteLine("Ingrese su peso en Kilogramos:");
            pesoKg = Convert.ToDouble(Console.ReadLine());

            //Solicitar valor de alturaMetros al usuario
            Console.WriteLine("Ingrese su altura en metros:");
            alturaMetros = Convert.ToDouble(Console.ReadLine());

            //Procesar informacion haciendo el calculo
            IMC = pesoKg / Math.Pow(alturaMetros, 2);

            //Condicionar el mensaje de la composicion corporal del usuario segun su IMC
            if (IMC < 18.5)
            {

                composicionCorporal = "peso inferior al normal";

            } else if (IMC > 18.5 && IMC <= 24.9) 
            {

                composicionCorporal = "normal";

            } else if (IMC > 25 && IMC <= 29.9)
            {

                composicionCorporal = "peso superior al normal";

            } else if (IMC > 30)
            {

                composicionCorporal = "obesidad";

            }

            //Imprimir resultado
            Console.WriteLine("Su IMC es: " + IMC + ", Su composicion corporal:" + composicionCorporal);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
