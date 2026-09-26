using System;

class Program
{
    static void Main()
    {
      
        int[] slimes = { 30, 40, 50, 60 };

  
        while (true)
        {
            bool hayVivos = false;

            Console.WriteLine("\n=== ESTADO DE LA HORDA DE SLIMES ===");
            for (int i = 0; i < slimes.Length; i++)
            {
                if (slimes[i] > 0)
                {
                    Console.WriteLine($"[Slime {i}] - Salud: {slimes[i]} HP");
                    hayVivos = true;
                }
                else
                {
                    Console.WriteLine($"[Slime {i}] - Derrotado (0 HP)");
                }
            }

            if (!hayVivos)
            {
                Console.WriteLine("\n¡Has derrotado a toda la horda de slimes! ¡Victoria!");
                break;
            }

            Console.Write("\nElige el número de slime a atacar (0 al 3): ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                case 1:
                case 2:
                case 3:

                    if (slimes[opcion] <= 0)
                    {
                        Console.WriteLine($"\n[AVISO] ¡El Slime {opcion} ya está derrotado! Elige otro objetivo.");
                    }
                    else
                    {
                        slimes[opcion] -= 20; 
                        if (slimes[opcion] < 0)
                        {
                            slimes[opcion] = 0;
                        }
                        Console.WriteLine($"\n¡Ataque certero! El Slime {opcion} ahora tiene {slimes[opcion]} HP.");
                    }
                    break;

                default:
                    Console.WriteLine("\n[ERROR] Objetivo inválido. Debes elegir un número entre 0 y 3.");
                    break;
            }
        }
    }
}