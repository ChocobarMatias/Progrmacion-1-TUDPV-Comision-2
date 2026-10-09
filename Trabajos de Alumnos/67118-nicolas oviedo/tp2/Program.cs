namespace tp2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Sistema de Inventario y Durabilidad de Armas
            //string [] armas={"Espada","Hacha","Arco","Daga"};
            //int[] durabilidad = new int[armas.Length];
            //Console.WriteLine("ingresa la durabilidad de tus armas: Espada, Hacha, Arco, Daga");
            //for (int i = 0;i< armas.Length; i++)
            //{

            //    durabilidad[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("quieres ver las armas apunto de rromperse elige 1 o si quieres ver tu inventario elige el 2");
            //int opcion = int.Parse(Console.ReadLine());
            //switch (opcion)
            //{
            //    case 1:
            //        Array.Sort(durabilidad);
            //        for (int i = 0; i < armas.Length; i++)
            //        {
            //            if (durabilidad[i] <= 20)

            //            {
            //                Console.WriteLine("¡CUIDADO! tu " + armas[i] + " esta por rromperse llevala a reparar (" + durabilidad[i] + ")");
            //            }
            //        }
            //            break;
            //    case 2:
            //        Array.Sort(durabilidad);
            //        for (int i = 0; i < armas.Length; i++)
            //        {
            //            Console.WriteLine(armas[i] + "-durabilidad:" + durabilidad[i]);
            //        }

            //        break;


            //}
            //Ejercicio 2: TOP 5 speedrun
            //const int CANT_CORREDORES = 5;
            //float[] tiempos = new float[CANT_CORREDORES];


            //for (int i = 0; i < CANT_CORREDORES; i++)
            //{
            //    Console.Write($"Ingrese el tiempo del corredor {i + 1}: ");
            //    tiempos[i] = float.Parse(Console.ReadLine());
            //}


            //string continuar = "s";
            //while (continuar.ToLower() == "s")
            //{
            //    Console.Write("\nIngrese el tiempo objetivo a evaluar: ");
            //    float tiempoObjetivo = float.Parse(Console.ReadLine());

            //    int cantidadSuperaron = 0;


            //    for (int i = 0; i < CANT_CORREDORES; i++)
            //    {
            //        if (tiempos[i] <= tiempoObjetivo)
            //        {
            //            cantidadSuperaron++;
            //        }
            //    }

            //    Console.WriteLine($"Corredores que superaron la prueba (tiempo <= {tiempoObjetivo}): {cantidadSuperaron}");

            //    Console.Write("¿Desea evaluar otro tiempo objetivo? (s/n): ");
            //    continuar = Console.ReadLine();
            //}
            //Ejercicio 3: Combate contra horda de slimes
            //int[] slime = { 10, 35, 50, 22 };
            //int primerslime = slime[0];
            //int segundoslime = slime[1];
            //int tercerslime = slime[2];
            //int cuartoslime = slime[3];
            //int ataque = 20;
            //slime[0] = slime[0] - ataque;
            //slime[1] = slime[1] - ataque;
            //slime[2] = slime[2] - ataque;
            //slime[3] = slime[3] - ataque;
            //Console.WriteLine("tienes 4 slimes en frente! la vida de cada uno es:10, 35, 50 22...");
            //Console.WriteLine("a cual decides atacar?");
            //int elegir = int.Parse(Console.ReadLine());
            //switch (elegir)
            //{
            //    case 1:
            //        if (slime[0] <= 0)
            //        {
            //            Console.WriteLine("has atacado al primer slime, fue derrotado bien hecho!");
            //        }

            //        break;

            //    case 2:
            //        Console.WriteLine("has atacado al segundo slime " + slime[1] + "el slime sigue intacto buen intento"); 
            //        break;
            //    case 3:
            //        Console.WriteLine("has atacado al tercer slime " + slime[2] + " el slime sigue intacto buen intento");
            //        break;
            //    case 4:
            //        Console.WriteLine("has atacado al cuarto slime " + slime[3] + " el slime sigue intacto buen intento");
            //        break;
            //}
            //Ejercicio 4: Canje de recompensas en tienda de cartas
            //int[] cartas = { 10, 25, 50, 80, 120 };

            //Console.WriteLine("Porfavor ingrese las gemas que tienes a mano");

            //int gemas= int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Has ingresado a un pequeño bazar y un vendedor ambulante se te acerca");
            //Console.WriteLine("Te ofrece 5 cartas presiona 1 para ver cuales puedes comprar o el 2 si quieres saber cual es la mas cara");
            //int opciones = int.Parse(Console.ReadLine());
            //switch (opciones)
            //{
            //    case 1:
            //        for (int i = 0; i < cartas.Length; i++)
            //        {
            //            if (gemas >= cartas[i])
            //            {
            //                Console.WriteLine($"Puedes comprarle las cartas de {cartas[i]}");
            //            }
            //        }

            //        break;
            //    case 2:
            //        Console.WriteLine("La carta mas cara es la de 120");
            //        break;
            //}
            //Ejercicio 5:Registro y Filtrado de Daño por Rafaga
            //int [] flechas = new int [6];
            //Console.WriteLine("6 flechas estan por darte! ingresa el daño que te hace cada una rapido!");
            //for (int i = 0; i < flechas.Length; i++)
            //{
            //    flechas[i] = int.Parse(Console.ReadLine());
            //}
            //    int referencia = 1;
            //while (referencia != 0)
            //{
            //    Console.WriteLine("ingrese daño de referencia (0 para salir): ");
            //    referencia = int.Parse(Console.ReadLine());

            //    if (referencia != 0)
            //    {
            //        int total = 0;
            //        for(int i=0; i < flechas.Length; i++)
            //        {
            //            if (flechas[i] > referencia)
            //            {
            //                total = total + flechas[i];
            //            }
            //        }
            //        Console.WriteLine($"Total de daño filtrado: { total}");
            //    }
            //}
            //Ejercicio 6: Selector de elementos y Cargas Magicas
            //string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            //int[] cargas = new int[4];
            //for (int i = 0; i < gemas.Length; i++)
            //{
            //    Console.WriteLine($"ingresa las cargas de {gemas[i]}:");
            //    cargas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("si quieres recargar tus gemas con 5 cargas elige 1, si quieres ver cual gema se esta agotando entonces elige 2");
            //int op = int.Parse(Console.ReadLine());
            //switch (op)
            //{
            //    case 1:
            //        for (int i = 0; i < gemas.Length; i++)
            //        {
            //            cargas[i] += 5;
            //        }
            //        Console.WriteLine("Recargaste todas las gemas dandoles 5 cargas!");
            //        break;
            //    case 2:
            //        for (int i = 0; i < gemas.Length; i++)
            //        {
            //            if (cargas[i] <= 0)
            //            {
            //                Console.WriteLine($"la gema de {gemas[i]} tienen 0 cargas recargala rapido!");
            //            }
            //        }
            //        break;
            //}
            //Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra
            //bool[] trampas = { true, true, false, true, true, false };
            //int posicion = 0;

            //bool sigueVivo = true;

            //Console.WriteLine("Comienza el recorrido en la baldosa 0 (Meta : Baldosa 5)");

            //while (posicion < 5 && sigueVivo)
            //{

            //    Console.WriteLine("Estas en la baldosa:" + posicion);
            //    Console.Write("Elige paso a dar (1 para avanzar, 2 avanzar 2): ");
            //    int eleccion = int.Parse(Console.ReadLine());

            //    posicion += eleccion; 

            //    if (posicion >= 5)
            //    {
            //        Console.WriteLine("¡Llegaste a la meta! ¡Felicidades!");
            //        break;
            //    }

            //    if (trampas[posicion])
            //    {
            //        Console.WriteLine("Perdiste" + posicion + "Fin de la partida");
            //        sigueVivo = false;
            //    }
            //    else
            //    {

            //        Console.WriteLine("seguis vivo pisaste balsoda segura" + posicion);
            //    }

            //}

            //if (sigueVivo)
            //{
            //    Console.WriteLine("¡Felicidades! Has completado el recorrido.");
            //    Console.ReadKey();
            //}
            //Ejercicio 8:Estadisticas de Fases del Boss
            //int[] danioFases = new int[3];

            //for (int i = 0; i < danioFases.Length; i++)
            //{
            //    Console.Write("Daño de la fase " + (i + 1) + ": ");
            //    danioFases[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("1. Calcular promedio");
            //Console.WriteLine("2. Fase más destructiva");
            //Console.Write("Elegí una opción: ");
            //int opcion = int.Parse(Console.ReadLine());

            //switch (opcion)
            //{
            //    case 1:
            //        int suma = 0;
            //        for (int i = 0; i < danioFases.Length; i++)
            //        {
            //            suma += danioFases[i];
            //        }
            //        double promedio = (double)suma / danioFases.Length;
            //        Console.WriteLine("Promedio de daño: " + promedio);
            //        break;

            //    case 2:
            //        int mayor = danioFases[0];
            //        int faseMayor = 1;

            //        if (danioFases[1] > mayor)
            //        {
            //            mayor = danioFases[1];
            //            faseMayor = 2;
            //        }
            //        if (danioFases[2] > mayor)
            //        {
            //            mayor = danioFases[2];
            //            faseMayor = 3;
            //        }

            //        Console.WriteLine("La fase más destructiva es la fase " + faseMayor + " con " + mayor + " de daño");
            //        break;
            //}
            //Ejercicio 9: Sistema de Municion y Disparo por Cargador
            //int[] municion = { 30, 15, 8 }; 
            //int opcion = 1;

            //while (opcion != 0)
            //{
            //    Console.WriteLine("1. Rifle");
            //    Console.WriteLine("2. Pistola");
            //    Console.WriteLine("3. Escopeta");
            //    Console.WriteLine("0. Salir");
            //    Console.Write("Elegí arma: ");
            //    opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            if (municion[0] > 0)
            //            {
            //                municion[0]--;
            //                Console.WriteLine("Disparo con Rifle. Balas restantes: " + municion[0]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Rifle vacío");
            //            }
            //            break;

            //        case 2:
            //            if (municion[1] > 0)
            //            {
            //                municion[1]--;
            //                Console.WriteLine("Disparo con Pistola. Balas restantes: " + municion[1]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Pistola vacía");
            //            }
            //            break;

            //        case 3:
            //            if (municion[2] > 0)
            //            {
            //                municion[2]--;
            //                Console.WriteLine("Disparo con Escopeta. Balas restantes: " + municion[2]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Escopeta vacía");
            //            }
            //            break;
            //    }
            //}
            //Ejercicio 10: Asignador y Verificador de Bonificador de EXP 
            //int[] exp = new int[5];
            //int total = 0;

            //for (int i = 0; i < exp.Length; i++)
            //{
            //    Console.Write("EXP de la misión " + (i + 1) + ": ");
            //    exp[i] = int.Parse(Console.ReadLine());

            //    if (exp[i] > 100)
            //    {
            //        exp[i] = exp[i] + (exp[i] * 20 / 100);
            //    }

            //    total += exp[i];
            //}

            //Console.WriteLine("Tabla de EXP actualizada:");
            //for (int i = 0; i < exp.Length; i++)
            //{
            //    Console.WriteLine("Misión " + (i + 1) + ": " + exp[i]);
            //}

            //Console.WriteLine("Experiencia total acumulada: " + total);
        }
    }
}
