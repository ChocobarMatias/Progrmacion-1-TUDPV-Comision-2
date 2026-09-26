using System;

class Program
{
    static void Main()
    {
        
        int[] expMisiones = new int[5];

      
        Console.WriteLine("=== CARGA DE PUNTOS DE EXP (MISIONES) ===");
        for (int i = 0; i < expMisiones.Length; i++)
        {
            Console.Write($"Ingrese los puntos de EXP de la misión {i + 1}: ");
            expMisiones[i] = int.Parse(Console.ReadLine());
        }

      
        for (int i = 0; i < expMisiones.Length; i++)
        {
            if (expMisiones[i] > 100)
            {
                int bono = (int)(expMisiones[i] * 0.20);
                expMisiones[i] += bono;
                Console.WriteLine($"[BONO APLICADO] ¡La misión {i + 1} superó los 100 puntos! Se añadió un 20% extra (+{bono} EXP).");
            }
        }

        
        Console.WriteLine("\n=== TABLA DE EXP ACTUALIZADA ===");
        int expTotal = 0;

        for (int i = 0; i < expMisiones.Length; i++)
        {
            Console.WriteLine($"- Misión {i + 1}: {expMisiones[i]} EXP");
            expTotal += expMisiones[i]; 
        }

        Console.WriteLine($"\n-> Experiencia total acumulada del clan: {expTotal} pts.");
    }
}