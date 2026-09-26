using System;

int[] flechas = new int[6];

for (int i = 0; i < flechas.Length; i++)
{
    Console.WriteLine($"ingrese el daño de la flecha {i + 1}");
    flechas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("ingrese el daño de referencia");
int referencia = int.Parse(Console.ReadLine());

while (referencia != 0)
{
    int total = 0;

    for (int i = 0; i < flechas.Length; i++)
    {
        if (flechas[i] > referencia)
        {
            Console.WriteLine($"flecha {i + 1}: {flechas[i]} supera la referencia");
            total += flechas[i];
        }
        else
        {
            Console.WriteLine($"flecha {i + 1}: {flechas[i]} no supera la referencia");
        }
    }
    Console.WriteLine($"total de daño filtrado: {total}");

    Console.WriteLine("ingrese otro daño de referencia (0 para salir)");
    referencia = int.Parse(Console.ReadLine());
}

