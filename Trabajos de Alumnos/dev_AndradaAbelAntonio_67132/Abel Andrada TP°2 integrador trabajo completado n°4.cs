using System;

int[] cartas = { 10, 25, 50, 80, 120 };

Console.WriteLine("ingrese sus gemas");
int gemas = int.Parse(Console.ReadLine());

Console.WriteLine("elija una opcion");
Console.WriteLine("1: mostrar cartas que puede pagar");
Console.WriteLine("2: identificar la carta mas cara");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        int alcanza = 0;
        Console.WriteLine("cartas que puede pagar");
        for (int i = 0; i < cartas.Length; i++)
        {
            if (cartas[i] <= gemas)
            {
                Console.WriteLine($"carta {i + 1}: {cartas[i]} gemas");
                alcanza++;
            }
        }
        if (alcanza == 0)
        {
            Console.WriteLine("no puede pagar ninguna carta");
        }
        else
        {
            Console.WriteLine($"total: {alcanza} cartas");
        }
        break;

    case 2:
        int masCara = cartas[0];
        int posicion = 0;
        for (int i = 1; i < cartas.Length; i++)
        {
            if (cartas[i] > masCara)
            {
                masCara = cartas[i];
                posicion = i;
            }
        }
        Console.WriteLine($"la carta mas cara es la carta {posicion + 1} con {masCara} gemas");
        break;

    default:
        Console.WriteLine("opcion invalida");
        break;
}
