using System;

class Program
{
    static void Main()
    {
      
        int[] municion = { 30, 15, 8 };

        string[] nombresArmas = { "Rifle", "Pistola", "Escopeta" };

        Console.WriteLine("=== SISTEMA DE MUNICIÓN Y DISPARO ===");

       
        while (true)
        {
            Console.WriteLine("\n--- ESTADO DEL ARSENAL ---");
            for (int i = 0; i < municion.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {nombresArmas[i]}: {municion[i]} balas");
            }
            Console.WriteLine("0. Salir del sistema");

            Console.Write("\nElija el arma con la que desea disparar (1-3) o 0 para salir: ");
            int opcion = int.Parse(Console.ReadLine());

          
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("\nSaliendo del sistema de disparo...");
                    return;

                case 1:
                case 2:
                case 3:
                   
                    int indiceArma = opcion - 1;

                    
                    if (municion[indiceArma] > 0)
                    {
                        municion[indiceArma]--; 
                        Console.WriteLine($"\n¡PUM! Has disparado el/la {nombresArmas[indiceArma]}. Balas restantes: {municion[indiceArma]}");
                    }
                    else
                    {
                        Console.WriteLine($"\n[¡ADVERTENCIA!] El/La {nombresArmas[indiceArma]} se encuentra VACÍO/A. ¡No quedan balas!");
                    }
                    break;

                default:
                    Console.WriteLine("\n[ERROR] Opción no válida. Elija un número entre 0 y 3.");
                    break;
            }
        }
    }
}