using System;

string[] armas = { "espada", "hacha", "arco", "daga" };
int[] durabilidad = new int[4];

for (int i = 0; i < armas.Length; i++)
{
    Console.WriteLine($"ingrese la durabilidad de {armas[i]}: ");
    durabilidad[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("1: inspeccionar armas criticas");
Console.WriteLine("2: ver arsenal completo");
Console.WriteLine("elija una opcion: ");
int op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        int criticas = 0;
        for (int i = 0; i < armas.Length; i++)
        {
            if (durabilidad[i] <= 20)
            {
                Console.WriteLine($"alerta: {armas[i]} tiene durabilidad {durabilidad[i]}");
                criticas++;
            }
        }
        if (criticas == 0)
        {
            Console.WriteLine("no hay armas criticas");
        }
        else
        {
            Console.WriteLine($"armas criticas: {criticas}");
        }
        break;

    case 2:
        Console.WriteLine("arsenal completo");
        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine($"{armas[i]}: {durabilidad[i]}");
        }
        break;

    default:
        Console.WriteLine("opcion incorrecta");
        break;
}
