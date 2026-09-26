using System;

float[] tiempos = new float[5];

for (int i = 0; i < tiempos.Length; i++)
{
    Console.WriteLine($"ingrese el tiempo del corredor {i + 1}");
    tiempos[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine("ingrese el tiempo objetivo");
float objetivo = float.Parse(Console.ReadLine());

while (objetivo != 0)
{
    int corredor = 0;

    for (int i = 0; i < tiempos.Length; i++)
    {
        if (tiempos[i] <= objetivo)
        {
            Console.WriteLine($"corredor {i + 1}: clasifica");
            corredor++;
        }
        else
        {
            Console.WriteLine($"corredor {i + 1}: no clasifica");
        }
    }
    Console.WriteLine($"corredores que superaron la prueba: {corredor}");

    Console.WriteLine("ingrese otro tiempo objetivo (0 para salir)");
    objetivo = float.Parse(Console.ReadLine());
}

