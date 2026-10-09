namespace Trabajo_practico_2___ejercicio_9
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] municion = { 30, 15, 8 }; 
            string[] nombresArmas = { "Rifle", "Pistola", "Escopeta" };

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n--- Elija un arma para disparar ---");
                Console.WriteLine("1. Rifle");
                Console.WriteLine("2. Pistola");
                Console.WriteLine("3. Escopeta");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Disparar(municion, 0, nombresArmas);
                        break;
                    case 2:
                        Disparar(municion, 1, nombresArmas);
                        break;
                    case 3:
                        Disparar(municion, 2, nombresArmas);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema de disparo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void Disparar(int[] municion, int indice, string[] nombresArmas)
        {
            
            if (municion[indice] > 0)
            {
                municion[indice]--;
                Console.WriteLine($"¡Disparo con {nombresArmas[indice]}! Balas restantes: {municion[indice]}");
            }
            else
            {
                Console.WriteLine($"{nombresArmas[indice]} está vacía. No se puede disparar.");
            }
        }
    }
}
