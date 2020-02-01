using System;

namespace Conversiones_de_Moneda
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             7- realiza un programa me permita realizar las siguientes conversiones de moneda de peso a dólar y viceversa , 
             de peso a euro y viceversa y de euro a dólar y viceversa , 
             debe preguntarse inicialmente cuál tipo de conversión voy a realizar y luego pedirme el valor de cada moneda y mostrar el resultado.
             */
            Console.WriteLine("Conversiones de moneda");

            /* Declaración de variables */
            const double tasaDolar = 53.5;
            const double tasaEuro = 55.5;
            double peso, dolar, euro, valor;
            byte opcion;
            string mensaje = " ";

            /* Solicitar opciones al usuario */
            Console.WriteLine("Escoger una opción");
            Console.WriteLine("1- peso a dólar");
            Console.WriteLine("2- dólar a peso ");
            Console.WriteLine("3- peso a euro");
            Console.WriteLine("4- euro a peso");

            opcion = byte.Parse(Console.ReadLine());

            /* Solicitar al cliente el valor */
            Console.WriteLine("Ingrese la cantidad: ");
            valor = int.Parse(Console.ReadLine());

            /* Procesar según opción */
            switch (opcion)
            {
                case 1:
                    dolar = Math.Round(valor / tasaDolar, 2);
                    mensaje = "RD$ " + valor + " - Pesos Dominicanos son: US$ " + dolar + " - Dólares Americanos";
                    break;

                case 2:
                    peso = Math.Round(valor * tasaDolar, 2);
                    mensaje = "US$ " + valor + " - Dólares Americanos son: RD$ " + peso + " - Pesos Dominicanos";
                    break;

                case 3:
                    euro = Math.Round(valor / tasaEuro, 2);
                    mensaje = "RD$ " + valor + " - Pesos Dominicanos son: EUR$ " + euro + " - Euros";
                    break;

                case 4:
                    peso = Math.Round(valor * tasaEuro, 2);
                    mensaje = "EUR$ " + valor + " - Euros son: RD$ " + peso + " - Pesos Dominicanos";
                    break;
                default:
                    mensaje = "La opción que escogio no esta disponible";
                    break;
            }

            /* Imprimir resultado */
            Console.WriteLine(mensaje);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
