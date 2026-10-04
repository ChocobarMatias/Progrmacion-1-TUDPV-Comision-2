using System;

int[] slimes = { 30, 40, 50, 60 };

while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
{
    Console.WriteLine($"vida de slimes: {slimes[0]}, {slimes[1]}, {slimes[2]}, {slimes[3]}");
    Console.WriteLine("elija que slime atacar (0, 1, 2, 3)");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 0:
        case 1:
        case 2:
        case 3:
            if (slimes[op] <= 0)
            {
                Console.WriteLine($"el slime {op} ya fue derrotado");
            }
            else
            {
                slimes[op] -= 20;
                if (slimes[op] <= 0)
                {
                    slimes[op] = 0;
                    Console.WriteLine($"derrotaste al slime {op}");
                }
                else
                {
                    Console.WriteLine($"le restaste 20 hp al slime {op}");
                }
            }
            break;

        default:
            Console.WriteLine("opcion invalida");
            break;
    }
}

