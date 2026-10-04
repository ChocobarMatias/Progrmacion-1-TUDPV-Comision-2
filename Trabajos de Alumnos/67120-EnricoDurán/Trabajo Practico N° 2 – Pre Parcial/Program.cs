using System;
namespace TPn2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Sistema de Inventario y Durabilidad de Armas 

            /*
            string[] armas = {"Espada", "Hacha", "Arco", "Daga"};
            int[] durabilidad = new int[4];

            Console.WriteLine("==Inventario|Durabilidad de armas==");
            for (int i = 0;  i < armas.Length; i++)
            {
                Console.WriteLine("*Arma: " + armas[i] + " (0-100)*");
                Console.Write("Durabilidad: ");
                durabilidad[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("==Seleccione accion==");
            Console.WriteLine("1. Inspeccionar durabilidad");
            Console.WriteLine("2. Ver arenal completo");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("*Durabilidad de armas*");
                    for (int j = 0; j < armas.Length; j++)
                    {
                        if (durabilidad[j] > 0 && durabilidad[j] <= 20)
                        {
                            Console.WriteLine(armas[j] + " - Durabilidad crítica: " + durabilidad[j]);
                        }
                        else if (durabilidad[j] <= 99 && durabilidad[j] > 20)
                        {
                            Console.WriteLine(armas[j] + " - Durabilidad estable: " + durabilidad[j]);
                        }
                        else if (durabilidad[j] == 0)
                        {
                            Console.WriteLine(armas[j] + " - Arma rota");
                        }
                        else if (durabilidad[j] == 100)
                        {
                            Console.WriteLine(armas[j] + " - Durabilidad al máximo");
                        }
                        else
                        {
                            Console.WriteLine(armas[j] + " #Durabilidad inválida#");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("**Arsenal**");
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine("______________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("*Arma: " + armas[i]);
                        Console.WriteLine("Durabilidad: " + durabilidad[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Selección inválida");
                    break;

            } */

            //===================================================================================================================================

            //Ejercicio 2: Marcador Top 5 de Speedrun
            /*
            string[] corredores = {"Corredor 1", "Corredor 2", "Corredor 3", "Corredor 4", "Corredor 5"};
            float[] tiempos = new float[5];
            int continuar = 1;

            Console.WriteLine("==Velocidad de corredores==");

            for (int i = 0; i < corredores.Length; i++)
            {
                Console.Write("Tiempo del " + corredores[i] + ": ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }
            Console.Clear();

            while (continuar == 1)
            {
                Console.WriteLine("==Evaluacion de SpeedRun==");
                Console.WriteLine("*Ingrese el tiempo máximo*");
                float tiempoMax = float.Parse(Console.ReadLine());
                float cantidadEncontrada = 0;

                for (int i = 0; i < corredores.Length; i++)
                {
                    if (tiempos[i] <= tiempoMax)
                    {
                        Console.Write(corredores[i] + " demoró: " + tiempos[i] + " minutos");
                        Console.WriteLine(" *Pasa la prueba*");
                        cantidadEncontrada++;
                    }
                    else if (tiempos[i] > tiempoMax)
                    {
                        Console.Write(corredores[i] + " demoró: " + tiempos[i] + " minutos");
                        Console.WriteLine(" *No pasa la prueba*");
                        cantidadEncontrada++;
                    }
                }
                if (cantidadEncontrada > 0)
                {
                    Console.WriteLine("Corredores encontrados: " + cantidadEncontrada);
                }
                else
                {
                    Console.WriteLine("##No se encotraron corredores con ese tiempo##");
                }
                Console.WriteLine("*¿Desea realizar otra busqueda?*");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                continuar = int.Parse(Console.ReadLine());
                Console.Clear();
            }  
            Console.WriteLine("==Evaluación de Speedrun finalizada=="); 
            */

            //===================================================================================================================================

            //Ejercicio 3: Combate contra Horda de Slimes 
            /*
            int[] slimes = { 30, 40, 50, 60 };
            int vidaTotal = 180;
            int ataquePlayer = 20;

            Console.WriteLine("==Se acercan 4 slimes==");
            Console.WriteLine("Slime 1: " + slimes[0] + " HP");
            Console.WriteLine("Slime 2: " + slimes[1] + " HP");
            Console.WriteLine("Slime 3: " + slimes[2] + " HP");
            Console.WriteLine("Slime 4: " + slimes[3] + " HP");
            Console.WriteLine("===============================================");

            while (vidaTotal > 0)
            {
                Console.WriteLine("Elija a cual va atacar (1-4)");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if (slimes[0] > 0)
                        {
                            slimes[0] -= ataquePlayer;
                            vidaTotal -= ataquePlayer;
                            Console.WriteLine("Ataco al slime 1: " + slimes[0] + " HP");
                        }
                        else if (slimes[0] <= 0)
                        {
                            Console.WriteLine("Este slime ya fue derrotado");
                        }
                            break;
                    case 2:
                        if (slimes[1] > 0)
                        {
                            slimes[1] -= ataquePlayer;
                            vidaTotal -= ataquePlayer;
                            Console.WriteLine("Ataco al slime 2: " + slimes[1] + " HP");
                        }
                        else if (slimes[1] <= 0)
                        {
                            Console.WriteLine("Este slime ya fue derrotado");
                        }
                        break;
                    case 3:
                        if (slimes[2] > 0)
                        {
                            slimes[2] -= ataquePlayer;
                            vidaTotal -= ataquePlayer;
                            Console.WriteLine("Ataco al slime 3: " + slimes[2] + " HP");
                        }
                        else if (slimes[2] <= 0)
                        {
                            Console.WriteLine("Este slime ya fue derrotado");
                        }
                        break;
                    case 4:
                       if (slimes[3] > 0)
                        {
                            slimes[3] -= ataquePlayer;
                            vidaTotal -= ataquePlayer;
                            Console.WriteLine("Ataco al slime 4: " + slimes[3] + " HP");
                        }
                        else if (slimes[3] <= 0)
                        {
                            Console.WriteLine("Este slime ya fue derrotado");
                        }
                        break;
                    default:
                        Console.WriteLine("No ataco a ningun slime");
                        break;
                }
            }
            if (vidaTotal <= 0)
            {
                Console.WriteLine("Felicidades a derrotado a todos los slimes");
            } 
            */

            //===================================================================================================================================

            //Ejercicio 4: Canje de Recompensas en Tienda de Cartas
            /*
            int[] costoCartas = { 10, 25, 50, 80, 120 };
            int mayorValor = costoCartas[0];
            int cartasEncontradas = 0;

            Console.WriteLine("Ingrese sus gemas");
            int gemasPlayer = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Qué desea saber?");
            Console.WriteLine("1. Mostrar cartas que puede pagar");
            Console.WriteLine("2. Mostrar la carta más cara del catálogo");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < costoCartas.Length; i++)
                    {
                        if (costoCartas[i] <= gemasPlayer)
                        {
                            Console.WriteLine("Le alcanza para esta carta de costo: " + costoCartas[i] + " gemas");
                            cartasEncontradas++;
                        }
                    }
                    Console.WriteLine("Cartas encontradas: " + cartasEncontradas);
                    break;
                case 2:
                    for (int j = 0; j < costoCartas.Length; j++)
                    {
                        if (costoCartas[j] > mayorValor)
                        {
                            mayorValor = costoCartas[j];
                        }
                    }
                    Console.WriteLine("La Carta más cara del catálogo es de: " + mayorValor + " gemas");
                    break;
                default:
                    Console.WriteLine("Selección inválida");
                    break;
            }
            */

            //===================================================================================================================================

            //Ejercicio 5: Registro y Filtrado de Daño por Ráfaga 
            /*
            string[] flechas = { "Flecha 1", "Flecha 2", "Flecha 3", "Flecha 4", "Flecha 5", "Flecha 6" };
            int[] dañoFlechas = new int[6];
            int consultaDaño = 1;

            Console.WriteLine("==Ingrese el daño de 6 flechas==");
            for (int i = 0; i < flechas.Length; i++)
            {
                Console.Write("Daño de flecha: ");
                dañoFlechas[i] = int.Parse(Console.ReadLine());
            }
            while (consultaDaño == 1)
            {
                Console.WriteLine("==Ingrese el daño esperado==");
                int dañoMin = int.Parse(Console.ReadLine());
                int dañoTotal = 0;

                Console.Clear();

                Console.WriteLine("*Impactos que superaron el daño*");
                for (int i = 0; i < flechas.Length; i++)
                {
                    if (dañoFlechas[i] > dañoMin)
                    {
                        Console.WriteLine(flechas[i] + ": " + dañoFlechas[i]);
                        dañoTotal += dañoFlechas[i];
                    }
                }
                Console.WriteLine("*Daño total de los impactos: " + dañoTotal + " *");

                Console.WriteLine("======================================================");
                Console.WriteLine("==Desea revisar otros impactos?==");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                int accion = int.Parse(Console.ReadLine());
                if (accion == 2)
                {
                    consultaDaño++;
                }
                else if (accion == 1)
                {
                    Console.Clear ();
                }
            }
            */

            //===================================================================================================================================

            //Ejercicio 6: Selector de Elementos y Cargas Mágicas
            /*
            string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] cargaMagica = new int[4];
            int recarga = 5;

            Console.WriteLine("==Ingrese la cantidad de cargas por gema==");
            Console.WriteLine("(0-100)");
            for (int i = 0; i < cargaMagica.Length; i++)
            {
                Console.Write("Gema de " + gemas[i] + ": ");
                cargaMagica[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Recargar todas las gemas");
            Console.WriteLine("2. Ver gemas agotadas");
            int accion = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("=========================================");
            switch (accion)
            {
                case 1:
                    for (int i = 0;i < cargaMagica.Length; i++)
                    {
                        if (cargaMagica[i] == 100)
                        {
                            Console.WriteLine("Gema de " + gemas[i] + ": Carga al máximo");
                        }
                        else if (cargaMagica[i] < 100 && cargaMagica[i] >= 0)
                        {
                            cargaMagica[i] += recarga;
                            Console.Write("Gema de " + gemas[i] + ": " + "+ " + recarga + " de recarga");
                            Console.WriteLine(" | Carga de: " + cargaMagica[i]);
                        }
                        else if (cargaMagica[i] < 0)
                        {
                            Console.WriteLine("Nivel de carga inválido");
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < cargaMagica.Length; i++)
                    {
                        if (cargaMagica[i] == 0)
                        {
                            Console.Write("Gema de " + gemas[i] + " agotada");
                            Console.WriteLine(" | Carga: " + cargaMagica[i]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Selección inválida");
                    break;
            }
            */

            //===================================================================================================================================

            //Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra
           /*
            bool[] trampas = { false, true, false, false, true, false };
            int posicion = 0;
            bool vidaJugador = true;

            Console.WriteLine("==Entras a un pasillo==");
            Console.WriteLine("==Tu meta es llegar a la baldosa 5 sin activar las trampa==");
            while (vidaJugador && posicion < 5)
            {
                Console.WriteLine("*Te encuentras en la baldosa: "+ posicion + "*");
                Console.WriteLine("1. Avanzar una posicion | 2. Avanzar dos posiciones");
                int accion = int.Parse(Console.ReadLine());
                
                posicion += accion;

                if (posicion >= 5)
                {
                    Console.WriteLine("*FELICIDADES LLEGASTE A LA META*");
                    break;
                }
                if (trampas[posicion])
                {
                    Console.WriteLine("*¡¡Activaste una trampa!!*");
                    Console.WriteLine("Perdiste en baldosa: " + posicion);
                    vidaJugador = false;
                }
                else
                {
                    Console.WriteLine("*Baldosa segura: " + posicion + "*");
                }
            }
           if (vidaJugador)
            {
                Console.WriteLine("==Completaste el recorrido==");
                Console.ReadKey();
            }
           */

            //===================================================================================================================================

            //Ejercicio 8: Estadísticas de Fases del Boss 
            /*
            string[] fasesBoss = { "Fase 1", "Fase 2", "Fase 3" };
            int[] dañoFase = new int[3];
            int suma = 0;
            int promedio = 0;

            Console.WriteLine("==Ingrese el daño que recibió en cada fase (1-50)==");
            for (int i = 0; i < fasesBoss.Length; i++)
            {
                Console.Write(fasesBoss[i] + ": ");
                dañoFase[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("1.Calcular promedio de daño entre las 3 fases");
            Console.WriteLine("2.Mostrar la fase más destructiva");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("*Promedio de daño de las 3 fases*");
                    for (int i = 0; i < dañoFase.Length; i++)
                    {
                        suma += dañoFase[i];
                    }
                    promedio = (int)suma / dañoFase.Length;
                    Console.WriteLine("Recibió en promedio " + promedio + " de daño");
                    break;
                case 2:
                    Console.WriteLine("*Fase más destructiva* ");
                    {
                        if (dañoFase[0] > dañoFase[1] && dañoFase[0] > dañoFase[2])
                        {
                            Console.WriteLine(fasesBoss[0] + " fue la más destructiva");
                        }
                        else if (dañoFase[1] > dañoFase[2] && dañoFase[1] > dañoFase[0])
                        {
                            Console.WriteLine(fasesBoss[1] + " fue la más destructiva");
                        }
                        else
                        {
                            Console.WriteLine(fasesBoss[2] + " fue la más destructiva");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Selección inválida");
                    break;
            }
            */

            //===================================================================================================================================

            //Ejercicio 9: Sistema de Munición y Disparo por Cargador
            /*
            string[] armas = { "Rifle", "Pistola", "Escopeta" };
            int[] municion = { 30, 15, 8, };

            while (municion[0] > 0 || municion[1] > 0 || municion[2] > 0)
            {
                Console.WriteLine("==Elija un arma==");
                Console.WriteLine("1.Rifle");
                Console.WriteLine("2.Pistola");
                Console.WriteLine("3.Escopeta");
                int opcionArma = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcionArma)
                {
                    case 1:
                        Console.WriteLine("*Eligio Rifle*");
                        if (municion[0] > 0)
                        {
                            if (municion[0] < 20)
                            {
                                Console.WriteLine("Balas insuficientes");
                            }
                            else if (municion[0] > 10)
                            {
                                municion[0] -= 20;
                                Console.WriteLine("Disparando...");
                                Thread.Sleep(500);
                                Console.WriteLine("Disparaste 20 balas | Munición restante: " + municion[0]);
                            }
                        }
                        else
                        {
                            municion[0] = 0;
                            Console.WriteLine("No tiene balas suficientes, arma vacía");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("*Eligio Pistola*");
                        if (municion[1] > 0)
                        {
                            if (municion[1] < 10)
                            {
                                Console.WriteLine("Balas insuficientes");
                            }
                            else if (municion[1] > 5)
                            {
                                municion[1] -= 10;
                                Console.WriteLine("Disparando...");
                                Thread.Sleep(500);
                                Console.WriteLine("Disparaste 10 balas | Munición restante: " + municion[1]);
                            }
                        }
                        else
                        {
                            municion[1] = 0;
                            Console.WriteLine("No tiene balas suficientes, arma vacía");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("*Eligio Escopeta*");
                        if (municion[2] > 0)
                        {
                            if (municion[2] < 5)
                            {
                                Console.WriteLine("Balas insuficientes");
                            }
                            else if (municion[2] > 5)
                            {
                                municion[2] -= 4;
                                Console.WriteLine("Disparando...");
                                Thread.Sleep(500);
                                Console.WriteLine("Disparaste 4 balas | Munición restante: " + municion[2]);
                            }
                        }
                        else
                        {
                            municion[2] = 0;
                            Console.WriteLine("No tiene balas suficientes, arma vacía");
                        }
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("Acción inválida");
                        break;
                }

            }
            Console.WriteLine("Todas las armas se quedaron sin balas");
            */

            //===================================================================================================================================

            //Ejercicio 10: Asignador y Verificador de Bonificación de EXP
            /*
            string[] misiones = { "Primera Misión", "Segunda Misión", "Tercera Misión", "Cuarta Misión", "Quita Misión" };
            double[] exp = new double[5];
            double totalExp = 0;

            Console.WriteLine("==Ingrese la exp recolectada en cada misión==");
            for (int i = 0; i < misiones.Length; i++)
            {
                Console.Write("* " + misiones[i] + ": ");
                exp[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("==Datos de la partida==");
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] > 100)
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine(misiones[i] + " | Experiencia adquirida: " + exp[i]);
                    double bonificacion = exp[i] * 0.20;
                    Console.WriteLine("* Bono del 20% por superar los 100 exp: " + bonificacion);
                    Console.WriteLine("* Experiencia adquirida + el bono: " + (exp[i] + bonificacion));
                    Console.WriteLine("=========================================");
                    totalExp += exp[i];
                }
                else if (exp[i] <= 100)
                {
                    Console.WriteLine(misiones[i] + " | Experiencia adquirida: " + exp[i]);
                    totalExp += exp[i];
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Exp total: " + totalExp);
            */
        }
    } 
}