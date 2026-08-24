using System;

namespace JuegoDelCalamar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // 1. CONSTANTES
            // ==========================================
            const string NOMBRE_JUEGO = "EL JUEGO DEL CALAMAR";
            const int TOTAL_CUPOS = 3;
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;

            const string PRUEBA_1 = "Luz roja, luz verde";
            const string PRUEBA_2 = "Dalgona (galleta de azúcar)";
            const string PRUEBA_3 = "Tira y afloja";

            const string ESTADO_VIVO = "SOBREVIVE";
            const string ESTADO_FUERA = "ELIMINADO";

            // ==========================================
            // 2. VARIABLES
            // ==========================================
            string jugador1 = "";
            string jugador2 = "";
            string jugador3 = "";
            string jugadorElegido = "";

            int numeroJugador = 0;
            int edad = 0;
            int opcionJugador = 0;
            int opcionPrueba = 0;
            int decision = 0;
            int puntaje = 0;

            string estadoFinal = ESTADO_FUERA;
            string clasificacion = "";
            string pruebaElegida = "Ninguna";

            // ==========================================
            // 3. PORTADA
            // ==========================================
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                  ║");
            Console.WriteLine("║             EL JUEGO DEL CALAMAR                ║");
            Console.WriteLine("║                                                  ║");
            Console.WriteLine("║                 ○    △    □                     ║");
            Console.WriteLine("║                                                  ║");
            Console.WriteLine("║              UNICEN - PROGRAMACIÓN II           ║");
            Console.WriteLine("║                                                  ║");
            Console.WriteLine("║         ¡BIENVENIDO A LA COMPETENCIA!           ║");
            Console.WriteLine("║                                                  ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");

            Console.WriteLine();
            Console.WriteLine("Premio acumulado: " + PREMIO_TOTAL + " wones");
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("Edad mínima      : " + EDAD_MINIMA + " años");
            Console.WriteLine();

            Console.WriteLine("==================================================");
            Console.WriteLine("      ¿ESTÁS LISTO PARA ENTRAR A LA ARENA?");
            Console.WriteLine("==================================================");

            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para comenzar...");
            Console.ReadKey();
            Console.Clear();

            // ==========================================
            // 4. REGISTRO DE JUGADORES
            // ==========================================
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║             REGISTRO DE JUGADORES                ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");

            Console.WriteLine();

            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();

            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();

            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Jugadores inscritos:");
            Console.WriteLine("001 - " + jugador1);
            Console.WriteLine("002 - " + jugador2);
            Console.WriteLine("003 - " + jugador3);
            Console.WriteLine();

            // ==========================================
            // 5. PRIMERA DECISIÓN: ELEGIR JUGADOR
            // ==========================================
            Console.WriteLine("--- SELECCIÓN DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);

            Console.Write("¿Qué jugador entra a la arena (1-3)?: ");
            opcionJugador = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = 1;
            }
            else if (opcionJugador == 2)
            {
                jugadorElegido = jugador2;
                numeroJugador = 2;
            }
            else if (opcionJugador == 3)
            {
                jugadorElegido = jugador3;
                numeroJugador = 3;
            }
            else
            {
                jugadorElegido = "SIN JUGADOR";
                numeroJugador = 0;
                estadoFinal = ESTADO_FUERA;
            }

            // ==========================================
            // 6. CONTROL DE EDAD Y SELECCIÓN DE PRUEBA
            // ==========================================
            if (numeroJugador != 0)
            {
                Console.WriteLine(
                    "Jugador seleccionado: 00" +
                    numeroJugador + " - " + jugadorElegido);

                Console.Write(
                    "Ingrese la edad de " + jugadorElegido + ": ");

                edad = int.Parse(Console.ReadLine());

                if (edad < EDAD_MINIMA)
                {
                    Console.WriteLine(
                        "ACCESO DENEGADO. " +
                        jugadorElegido +
                        " no cumple con la edad mínima.");

                    estadoFinal = ESTADO_FUERA;
                }
                else
                {
                    Console.WriteLine(
                        "ACCESO PERMITIDO. " +
                        jugadorElegido +
                        " puede competir.");

                    puntaje = puntaje + 20;
                    Console.WriteLine();

                    // ==========================================
                    // 7. SELECCIÓN DE PRUEBA
                    // ==========================================
                    Console.WriteLine("--- SELECCIÓN DE PRUEBA ---");
                    Console.WriteLine("1) " + PRUEBA_1);
                    Console.WriteLine("2) " + PRUEBA_2);
                    Console.WriteLine("3) " + PRUEBA_3);

                    Console.Write("Elija la prueba (1-3): ");
                    opcionPrueba = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // ==========================================
                    // PRUEBA 1
                    // ==========================================
                    if (opcionPrueba == 1)
                    {
                        pruebaElegida = PRUEBA_1;

                        Console.WriteLine("PRUEBA: " + PRUEBA_1);
                        Console.WriteLine("¿Qué hace cuando la muñeca gira?");
                        Console.WriteLine("1) Seguir corriendo");
                        Console.WriteLine("2) Quedarse inmóvil");
                        Console.WriteLine("3) Esconderse detrás de otro");

                        Console.Write("Opción: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 70;
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 40;
                        }
                        else
                        {
                            Console.WriteLine("Respuesta inválida.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }

                    // ==========================================
                    // PRUEBA 2 - DALGONA
                    // ==========================================
                    else if (opcionPrueba == 2)
                    {
                        pruebaElegida = PRUEBA_2;

                        Console.WriteLine("PRUEBA: " + PRUEBA_2);
                        Console.WriteLine("Elija la figura de la galleta:");
                        Console.WriteLine("1) Triángulo (fácil)");
                        Console.WriteLine("2) Estrella   (medio)");
                        Console.WriteLine("3) Sombrilla  (difícil)");

                        Console.Write(
                            "Figura elegida por " +
                            jugadorElegido + ": ");

                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 50;
                        }
                        else if (decision == 2)
                        {
                            // IF ANIDADO: Galleta Estrella
                            Console.Write(
                                "¿Lame la galleta? " +
                                "(1 = sí / 2 = no): ");

                            decision = int.Parse(Console.ReadLine());

                            if (decision == 1)
                            {
                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 65;
                            }
                            else
                            {
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else if (decision == 3)
                        {
                            // IF ANIDADO: Galleta Sombrilla
                            Console.WriteLine(
                                "La sombrilla es la figura " +
                                "más difícil del juego.");

                            Console.Write(
                                "¿Usa la aguja calentada " +
                                "con el encendedor? " +
                                "(1 = sí / 2 = no): ");

                            decision = int.Parse(Console.ReadLine());

                            if (decision == 1)
                            {
                                Console.WriteLine(
                                    "La aguja caliente corta " +
                                    "el azúcar. " +
                                    jugadorElegido +
                                    " lo logra!");

                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 80;
                            }
                            else
                            {
                                estadoFinal = ESTADO_FUERA;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Figura inexistente.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }

                    // ==========================================
                    // PRUEBA 3 - TIRA Y AFLOJA
                    // ==========================================
                    else if (opcionPrueba == 3)
                    {
                        pruebaElegida = PRUEBA_3;

                        Console.WriteLine("PRUEBA: " + PRUEBA_3);
                        Console.WriteLine("¿Qué estrategia usa?");
                        Console.WriteLine("1) Jalar con toda la fuerza");
                        Console.WriteLine("2) Inclinarse hacia atrás");
                        Console.WriteLine("3) Soltar la cuerda");

                        Console.Write("Opción: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                        else if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 75;
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_FUERA;
                        }
                        else
                        {
                            Console.WriteLine("Estrategia inválida.");
                            estadoFinal = ESTADO_FUERA;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Esa prueba no existe.");
                        estadoFinal = ESTADO_FUERA;
                    }
                }
            }
            else
            {
                pruebaElegida = "SIN PRUEBA";
                estadoFinal = ESTADO_FUERA;
            }

            // ==========================================
            // 8. CLASIFICACIÓN POR PUNTAJE
            // ==========================================
            if (puntaje >= 90)
            {
                clasificacion = "FINALISTA";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "AVANZA A LA SIGUIENTE RONDA";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "PASA CON OBSERVACIONES";
            }
            else
            {
                clasificacion = "FUERA DE COMPETENCIA";
            }

            // ==========================================
            // 9. REPORTE FINAL
            // ==========================================
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║       REPORTE FINAL - EL JUEGO DEL CALAMAR      ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝");

            Console.WriteLine("Jugador       : " + jugadorElegido);
            Console.WriteLine("Número        : 00" + numeroJugador);
            Console.WriteLine("Prueba        : " + pruebaElegida);
            Console.WriteLine("Estado        : " + estadoFinal);
            Console.WriteLine("Puntaje       : " + puntaje + " / 100");
            Console.WriteLine("Clasificación : " + clasificacion);

            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine(
                    "Premio en juego: " +
                    PREMIO_TOTAL + " wones");
            }

            Console.WriteLine(
                "==================================================");

            Console.ReadKey();
        }
    }
}