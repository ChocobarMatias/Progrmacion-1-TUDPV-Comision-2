using System;

class Program
{
    static void Main()
    {
      
        int[] danoFases = new int[3];

        
        Console.WriteLine("=== CARGA DE DAÑO - FASES DEL BOSS ===");
        for (int i = 0; i < danoFases.Length; i++)
        {
            Console.Write($"Ingrese el daño recibido en la fase {i + 1}: ");
            danoFases[i] = int.Parse(Console.ReadLine());
        }

       
        Console.WriteLine("\n=== ESTADÍSTICAS DEL JEFE ===");
        Console.WriteLine("1. Calcular promedio de daño entre las 3 fases");
        Console.WriteLine("2. Identificar la fase más destructiva");
        Console.Write("Elija una opción (1 o 2): ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
              
                int suma = 0;
                for (int i = 0; i < danoFases.Length; i++)
                {
                    suma += danoFases[i];
                }

                double promedio = (double)suma / danoFases.Length;
                Console.WriteLine($"\nEl promedio de daño recibido entre las 3 fases es: {promedio:F2} pts.");
                break;

            case 2:
               
                int indiceMax = 0;
                for (int i = 1; i < danoFases.Length; i++)
                {
                    if (danoFases[i] > danoFases[indiceMax])
                    {
                        indiceMax = i;
                    }
                }

                Console.WriteLine($"\nLa fase más destructiva fue la Fase {indiceMax + 1} con un total de {danoFases[indiceMax]} pts de daño.");
                break;

            default:
                Console.WriteLine("\n[ERROR] Opción no válida.");
                break;
        }
    }
}