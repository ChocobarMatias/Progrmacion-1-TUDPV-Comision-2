namespace Tp2Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] dur = new int[armas.Length];
            int op;
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1-Ver armas criticas");
            Console.WriteLine("2-Ver listado completo de armas");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine($"Ingrese la durabilidadd de {armas[i]}");
                        dur[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (dur[i] <= 20)
                        {
                            Console.WriteLine($"ALERTA durabilidad de {armas[i]} es {dur[i]}");
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine($"ingrese la durabilidad del {armas[i]}");
                        dur[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine($"La durabilidad del {armas[i]} es {dur[i]}");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;

            }
        }
    }
}