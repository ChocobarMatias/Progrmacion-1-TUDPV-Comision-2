using System;
 
String[] Arma = { "Pistola", "Escopeta", "Rifle" };
int[] balas = { 10, 5, 15 };
int Op = -1;
 
for (int i = 0; i < Arma.Length; i++)
{
    Console.WriteLine($"{Arma[i]} tiene {balas[i]} balas");
}
 
Console.WriteLine("Elija que arma quiere disparar:");
Console.WriteLine("1: pistola");
Console.WriteLine("2: Escopeta");
Console.WriteLine("3: Rifle");
Console.WriteLine("0: Salir");
 
while (Op != 0)
{
    Op = int.Parse(Console.ReadLine());
 
    switch (Op)
    {

        case 0:
            Console.WriteLine("Saliste");
            break;

        case 1:
            if (balas[0] > 0)
            {
                balas[0] = balas[0] - 1;
                Console.WriteLine($"Acabas de disparar una {Arma[0]}");
            }
            else
            {
                Console.WriteLine("No quedan balas de pistola");
            }
            break;
 
        case 2:
            if (balas[1] > 0)
            {
                balas[1] = balas[1] - 1;
                Console.WriteLine($"Acabas de disparar una {Arma[1]}");
            }
            else
            {
                Console.WriteLine("No quedan balas de escopeta");
            }
            break;
 
        case 3:
            if (balas[2] > 0)
            {
                balas[2] = balas[2] - 1;
                Console.WriteLine($"Acabas de disparar un {Arma[2]}");
            }
            else
            {
                Console.WriteLine("No quedan balas de rifle");
            }
            break;
 
        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
}