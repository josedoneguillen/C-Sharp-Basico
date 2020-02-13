using System;

namespace adivina_el_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3.	Realiza una aplicación que genere un número random del 1-100 y que luego el usuario deba adivinar cuál es número que se generó, 
             * el mismo solo tendrá 10 oportunidades para adivinar al agotar las 10 oportunidades debe mostrarse cuál era el número y preguntarle si quiere volver a jugar si quiere seguir 
             * se debe generar un nuevo número random de no querer seguir jugando debe finalizar la aplicación.
             * La aplicación debe de darle pista al usuario según qué tan cerca este si está a menos o a 5 números debe decirle que está muy caliente, 
             * si está a 10 o menos número que está caliente si está a 20 o menos números que se está acercando si está a 30 o menos que esta frio si esta 50 o menos que está muy frio.
             * Ejemplo si el número random es 40 y el usuario ingresa 35 está muy caliente y si ingresa 45 también está muy caliente porque en ambos casos está a 5 números del resultado correcto.
             */

            /* Declaracion de variables */
            Random random = new Random();
            byte numero_generado = 0;
            short numero_digitado = 0;
            short ultimo_numero_digitado = 0;
            byte intentos = 0;
            byte seguir_jugando = 1;
            bool gano = false;

            /* Ciclo do while para iniciar el juego por primera ves mientras el usuario no use los intentos y quiera seguir jugando */
            do
            {
                /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                Console.Clear();

                /* Mostrar mensaje al usuario sobre la tematica del juego */
                Console.WriteLine("Adivina el numero entre 1 y 100 para Ganar!!!");

                /* Mostrar al usuario las reglas del juego */
                Console.WriteLine("Si está a mas o menos 5 números. estás muy caliente.");
                Console.WriteLine("Si está a mas o menos 10 números del muy caliente. estás caliente.");
                Console.WriteLine("Si está a mas o menos 20 números. te estás acercando.");
                Console.WriteLine("Si está a mas o menos 30 números. estás frío.");
                Console.WriteLine("Si está a mas o menos 50 números. estás muy frío.");

                /* Esperar letra para comenzar */
                Console.WriteLine(Environment.NewLine + "Pulse una tecla para comenzar.");
                Console.ReadKey();

                /* Generar numero aleatorio */
                numero_generado = Convert.ToByte(random.Next(1, 100));

                /* Ciclo while para contar los intentos del usuario por adivinar el numero */
                while (intentos < 10)
                {
                    /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                    Console.Clear();

                    /* Mostrar marcador de intentos al usuario */
                    if (intentos > 0)
                    {
                        Console.WriteLine("Numero Anterior: " + ultimo_numero_digitado);
                    }
                    Console.WriteLine("Intento: " + intentos + "/10");

                    /* Solicitar al usuario que adivine el numero */
                    Console.WriteLine(Environment.NewLine + "Adivina el numero: ");

                    /* Almacenar el numero adivinado */
                    numero_digitado = short.Parse(Console.ReadLine());

                    /* Asiganar el numero digitado al ultimo numero digitado para mostrar en el marcador durante la siguiente iteracion */
                    ultimo_numero_digitado = numero_digitado;

                    /* Declaracion if para validar si el usuario esta dentro de los rangos del numero a adivinar */
                    if (numero_digitado >= 1 && numero_digitado <= 100)
                    {
                        /* Incrementar contador ya que el usuario podra usar su oportunidad */
                        intentos++;
                    }
                    else 
                    {
                        /* Mostrar al usuario mensaje de alerta */
                        Console.WriteLine("El numero que eligio no esta entre 1 y 100");

                        /* Esperar letra para comenzar */
                        Console.WriteLine(Environment.NewLine + "Pulse una tecla para comenzar.");
                        Console.ReadKey();

                        /* Iniciar la iteracion nuevamente */
                        continue;
                    }

                    /* Declaracion if para validar si el usuario esta cerca o lejos del numero generado */
                    if (numero_digitado == numero_generado)
                    {
                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Mostrar al usuario mensaje de que ha ganado */
                        Console.WriteLine("Felicidades has ganado!!!!!");
                        gano = true;
                        break;
                    }
                    else if (numero_digitado >= (numero_generado - 5) && numero_digitado <= (numero_generado + 5))
                    {
                        Console.WriteLine("Muy caliente!");
                    }
                    else if (numero_digitado >= (numero_generado - 15) && numero_digitado <= (numero_generado + 15))
                    {
                        Console.WriteLine("Está caliente");
                    }
                    else if (numero_digitado >= (numero_generado - 20) && numero_digitado <= (numero_generado + 20))
                    {
                        Console.WriteLine("Se está acercando");
                    }
                    else if (numero_digitado >= (numero_generado - 30) && numero_digitado <= (numero_generado + 30))
                    {
                        Console.WriteLine("Está frio");
                    }
                    else if (numero_digitado <= (numero_generado + 50) || numero_digitado  >= (numero_generado + 50))
                    {
                        Console.WriteLine("Muy Frio");
                    }

                    /* Esperar letra para comenzar */
                    Console.WriteLine("Pulse una tecla para intentar de nuevo.");
                    Console.ReadKey();

                }

                /* Declaracion if para mostrar mensaje en caso de haber perdido luego de agotar todos los intentos */
                if (!gano)
                {
                    Console.WriteLine("Que mal! has perdido, el numero era: " + numero_generado);
                }

                /* Mostrar al usuario cantidad de intentos utilizados */
                Console.WriteLine("Cantidad de intentos: " + intentos);

                /* Preguntar al usuario si desea seguir jugando */
                Console.WriteLine(Environment.NewLine + "Deseas Seguir jugando?" + Environment.NewLine + "Escribe el numero de la opcion y presiona enter: " + Environment.NewLine + "1- Si" + Environment.NewLine + "2- No");
                seguir_jugando = Convert.ToByte(Console.ReadLine());

            } while (seguir_jugando == 1);

            /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
            Console.Clear();

            /* Mostrar al usuario mensaje de despedida */
            Console.WriteLine("Adios");

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
