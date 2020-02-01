using System;

namespace Signo_Zodiacal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3- Crear un programa que te diga tu signo zodiacal según tu día y mes de nacimiento. */
            Console.WriteLine("Signo zodiacal según tu dia y mes de nacimiento");

            /* Declaración de variables */
            int dia = 0;
            int mes = 0;
            string signo = "";

            /* Solicitar al usuario los valores para dia y mes */
            Console.WriteLine("Ingrese su día de nacimiento: ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());

            /* Procesar signo zodiacal según día y mes de nacimiento */
            if ((dia >= 20 && mes == 1 ) || (dia <= 18 && mes == 2 )) 
            {

                signo = "Acuario";

            } 
            else if ((dia >= 19 && mes == 2) || (dia <= 20 && mes == 3))
            {

                signo = "Picis";

            } 
            else if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {

                signo = "Aries";

            } 
            else if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {

                signo = "Tauro";

            } 
            else if ((dia >= 21 && mes == 5) || (dia <= 24 && mes == 6))
            {

                signo = "Géminis";

            }
            else if ((dia >= 25 && mes == 6) || (dia <= 22 && mes == 7))
            {

                signo = "Cáncer";

            }
            else if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {

                signo = "Leo";

            }
            else if ((dia >= 24 && mes == 8) || (dia <= 23 && mes == 9))
            {

                signo = "Virgo";

            }
            else if ((dia >= 24 && mes == 9) || (dia <= 22 && mes == 10))
            {

                signo = "Libra";

            }
            else if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {

                signo = "Escorpio";

            }
            else if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            {

                signo = "Sagitario";

            }
            else if ((dia >= 22 && mes == 12) || (dia <= 18 && mes == 1))
            {

                signo = "Capricornio";

            }

            //Imprimir el resultado
            Console.WriteLine("Su signo zodiacal es: {0}", signo);

            //Esperar una tecla para cerrar
            Console.ReadKey();
        }
    }
}
