using System;

int[] fases = new int[3];

for (int i = 0; i < fases.Length; i++)
{
    Console.WriteLine($"ingrese el daño de la fase {i + 1}: ");
    fases[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("elija una opcion: ");
Console.WriteLine("1: calcular promedio de daño");
Console.WriteLine("2: identificar la fase mas destructiva");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        int suma = 0;
        for (int i = 0; i < fases.Length; i++)
        {
            suma += fases[i];
        }
        double promedio = suma / 3.0;
        Console.WriteLine($"promedio de daño: {promedio}");
        break;

    case 2:
        if (fases[0] >= fases[1] && fases[0] >= fases[2])
        {
            Console.WriteLine($"la fase mas destructiva es la fase 1 con {fases[0]} de daño");
        }
        else if (fases[1] >= fases[0] && fases[1] >= fases[2])
        {
            Console.WriteLine($"la fase mas destructiva es la fase 2 con {fases[1]} de daño");
        }
        else
        {
            Console.WriteLine($"la fase mas destructiva es la fase 3 con {fases[2]} de daño");
        }
        break;

    default:
        Console.WriteLine("opcion incorrecta");
        break;
}
