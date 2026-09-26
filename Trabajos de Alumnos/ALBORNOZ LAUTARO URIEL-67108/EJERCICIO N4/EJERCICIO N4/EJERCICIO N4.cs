using System;

class Program
{
    static void Main()
    {
      
        int[] costos = { 10, 25, 50, 80, 120 };

   
        Console.Write("Ingrese la cantidad de gemas que posee: ");
        int gemasUsuario = int.Parse(Console.ReadLine());

        Console.WriteLine("\n=== TIENDA DE CARTAS ===");
        Console.WriteLine("1. Mostrar cartas que puede pagar");
        Console.WriteLine("2. Identificar la carta más cara del catálogo");
        Console.Write("Elija una opción (1 o 2): ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\n--- CARTAS DISPONIBLES PARA SU COMPRA ---");
                bool puedeComprarAlguna = false;

           
                for (int i = 0; i < costos.Length; i++)
                {
                    if (gemasUsuario >= costos[i])
                    {
                        Console.WriteLine($"- Carta #{i + 1}: Cuesta {costos[i]} gemas (¡Puedes pagarla!)");
                        puedeComprarAlguna = true;
                    }
                }

                if (!puedeComprarAlguna)
                {
                    Console.WriteLine("Lo sentimos, no tienes suficientes gemas para adquirir ninguna carta.");
                }
                break;

            case 2:
    
                int indiceMasCara = 0;
                for (int i = 1; i < costos.Length; i++)
                {
                    if (costos[i] > costos[indiceMasCara])
                    {
                        indiceMasCara = i;
                    }
                }

                Console.WriteLine($"\nLa carta más cara del catálogo es la #${indiceMasCara + 1} con un valor de {costos[indiceMasCara]} gemas.");
                break;

            default:
                Console.WriteLine("\n[ERROR] Opción no válida.");
                break;
        }
    }
}