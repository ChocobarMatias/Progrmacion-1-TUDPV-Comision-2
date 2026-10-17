namespace Ejercicio_10
{
    using System;

    class Program
    {
        static void Main()
        {
            const int CANT_MISIONES = 5;
            int[] exp = new int[CANT_MISIONES];
            int expTotal = 0;


            for (int i = 0; i < CANT_MISIONES; i++)
            {
                Console.Write($"ingresa los puntos de exp obtenidos {i + 1}: ");
                exp[i] = int.Parse(Console.ReadLine());


                if (exp[i] > 100)
                {
                    int bono = (int)(exp[i] * 0.20);
                    exp[i] = exp[i] + bono;
                    Console.WriteLine($" la mision {i + 1} superó los 100 puntos. Obtuviste el bono: +{bono}");
                }
                else
                {
                    Console.WriteLine($" la misión {i + 1} no alcanzó el bono.");
                }
            }


            Console.WriteLine("\ntabla de exp obtenida:");
            for (int i = 0; i < CANT_MISIONES; i++)
            {
                Console.WriteLine($"Misión {i + 1}: {exp[i]} EXP");
                expTotal += exp[i];
            }

            Console.WriteLine($"\nExperiencia total acumulada: {expTotal} EXP");
        }
    }
}
