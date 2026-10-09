namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            const int CANT_FLECHAS = 6;
            int[] daño = new int[CANT_FLECHAS];

            
            for (int i = 0; i < CANT_FLECHAS; i++)
            {
                Console.Write($"Ingrese el daño de la flecha {i + 1}: ");
                daño[i] = int.Parse(Console.ReadLine());
            }

    
            string continuar = "s";
            while (continuar.ToLower() == "s")
            {
                Console.Write("\nIngrese el daño de referencia: ");
                int referencia = int.Parse(Console.ReadLine());

                int totalFiltrado = 0;

                for (int i = 0; i < CANT_FLECHAS; i++)
                {
                   
                    if (daño[i] > referencia)
                    {
                        totalFiltrado += daño[i];
                        Console.WriteLine($"Flecha {i + 1} ({daño[i]}) superó la referencia.");
                    }
                    else
                    {
                        Console.WriteLine($"Flecha {i + 1} ({daño[i]}) no superó la referencia.");
                    }
                }

                Console.WriteLine($"\nTotal de daño filtrado (superó los {referencia}): {totalFiltrado}");

                Console.Write("\n¿Desea probar con otro daño de referencia? (s/n): ");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
