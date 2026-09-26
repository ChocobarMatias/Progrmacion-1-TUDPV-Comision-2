Console.WriteLine("Tienes 4 armas");
string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
int[] durabilidad = new int[4];

for (int i = 0; i < armas.Length; i++)
{
    Console.WriteLine("Ingresa la durabilidad de las armas");
    durabilidad[i] = int.Parse(Console.ReadLine());
    Console.WriteLine($"La durabilidad del arma {armas[i]} es {durabilidad[i]}");
}
Console.WriteLine("Elija la opcion 1 o 2");
Console.WriteLine("Opcion 1: Inspeccionar armas críticas.  Opción 2: Ver arsenal completo. Opción 3: Salir");
int op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        for (int i = 0; i < armas.Length; i++)
        {
            if (durabilidad[i] < 25)
            {
                Console.WriteLine($"El arma {armas[i]} está en estada crítico le quedan {durabilidad[i]} puntos de durabilidad");
            }
        }
        break;
    case 2:
        Console.WriteLine("Tienes las siguientes armas");
        for (int i = 0; i < armas.Length; i++)
        {

            Console.WriteLine(armas[i]);
        }
        break;
    default:
        Console.WriteLine("Saliste");
        break;
}