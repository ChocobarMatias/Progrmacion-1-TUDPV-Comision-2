using System;

int[] xp = new int[5];
int total = 0;

for (int i = 0; i < xp.Length; i++)
{
    Console.WriteLine($"ingrese la xp de la mision {i + 1}: ");
    xp[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < xp.Length; i++)
{
    if (xp[i] > 100)
    {
        xp[i] = xp[i] + xp[i] * 20 / 100;
        Console.WriteLine($"mision {i + 1}: conseguiste un 20% de xp extra");
    }
    else
    {
        Console.WriteLine($"mision {i + 1}: No conseguiste bonus de xp extra");
    }
}

Console.WriteLine("tabla de misiones");
for (int i = 0; i < xp.Length; i++)
{
    Console.WriteLine($"mision {i + 1}: {xp[i]}");
    total += xp[i];
}
Console.WriteLine($"xp total: {total}");
