using System;

class Program
{
    static void Main()
    {
        float[] tiempos = new float[5];

        Console.WriteLine("=== CARGA DE TIEMPOS DE SPEEDRUN ===");
        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.Write($"Ingrese el tiempo del corredor {i + 1} (en segundos): ");
            tiempos[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n=== CLASIFICACIÓN POR TIEMPO OBJETIVO ===");
       

        while (true)
        {
            Console.Write("Ingrese el tiempo objetivo a evaluar: ");
            float tiempoObjetivo = float.Parse(Console.ReadLine());

            if (tiempoObjetivo < 0)
            {
                Console.WriteLine("Saliendo del sistema de speedrun...");
                break;
            }

            int clasificados = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] <= tiempoObjetivo)
                {
                    clasificados++;
                }
            }

            Console.WriteLine($"-> Resultado: {clasificados} corredor(es) superaron la prueba con un tiempo menor o igual a {tiempoObjetivo}s.\n");
        }
    }
}