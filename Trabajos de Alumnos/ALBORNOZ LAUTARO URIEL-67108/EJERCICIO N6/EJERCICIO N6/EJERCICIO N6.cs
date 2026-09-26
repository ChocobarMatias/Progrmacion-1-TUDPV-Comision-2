using System;

class Program
{
    static void Main()
    {
       
        string[] tiposGemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];

     
        Console.WriteLine("=== CARGA DE CARGAS MÁGICAS ===");
        for (int i = 0; i < tiposGemas.Length; i++)
        {
            Console.Write($"Ingrese las cargas para la gema de {tiposGemas[i]}: ");
            cargas[i] = int.Parse(Console.ReadLine());
        }

      
        Console.WriteLine("\n=== MENÚ DE GEMAS MÁGICAS ===");
        Console.WriteLine("1. Recargar todas (+5 cargas)");
        Console.WriteLine("2. Buscar si hay alguna gema agotada (0 cargas)");
        Console.Write("Elija una opción (1 o 2): ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
               
                for (int i = 0; i < cargas.Length; i++)
                {
                    cargas[i] += 5;
                }

                Console.WriteLine("\n¡Todas las gemas han sido recargadas con éxito (+5 cargas)!");
                Console.WriteLine("--- Estado actualizado del inventario ---");
                for (int i = 0; i < tiposGemas.Length; i++)
                {
                    Console.WriteLine($"- Gema de {tiposGemas[i]}: {cargas[i]} cargas");
                }
                break;

            case 2:
              
                bool hayAgotada = false;

                Console.WriteLine("\n--- BÚSQUEDA DE GEMAS AGOTADAS ---");
                for (int i = 0; i < cargas.Length; i++)
                {
                    if (cargas[i] == 0)
                    {
                        Console.WriteLine($"[ALERTA] ¡La gema de {tiposGemas[i]} está totalmente agotada (0 cargas)!");
                        hayAgotada = true;
                    }
                }

                if (!hayAgotada)
                {
                    Console.WriteLine("Excelente: No hay gemas agotadas en el inventario.");
                }
                break;

            default:
                Console.WriteLine("\n[ERROR] Opción no válida.");
                break;
        }
    }
}