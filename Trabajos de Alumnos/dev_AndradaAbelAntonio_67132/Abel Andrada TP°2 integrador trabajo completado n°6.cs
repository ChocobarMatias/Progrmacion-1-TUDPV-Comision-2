using System;

string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
int[] cargas = new int[4];

for (int i = 0; i < gemas.Length; i++)
{
    Console.WriteLine($"ingrese las cargas de {gemas[i]}: ");
    cargas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("1. recargar todas (+5)");
Console.WriteLine("2. buscar gemas agotadas");
Console.WriteLine("elija una opcion: ");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        Console.WriteLine("recargaste todas las gemas +5");
        for (int i = 0; i < gemas.Length; i++)
        {
            cargas[i] += 5;
            Console.WriteLine($"{gemas[i]}: {cargas[i]} cargas");
        }
        break;

    case 2:
        int agotadas = 0;
        for (int i = 0; i < gemas.Length; i++)
        {
            if (cargas[i] <= 0)
            {
                Console.WriteLine($"la gema {gemas[i]} esta agotada");
                agotadas++;
            }
        }
        if (agotadas == 0)
        {
            Console.WriteLine("no hay gemas agotadas");
        }
        else
        {
            Console.WriteLine($"gemas agotadas: {agotadas}");
        }
        break;

    default:
        Console.WriteLine("opcion invalida");
        break;
}
