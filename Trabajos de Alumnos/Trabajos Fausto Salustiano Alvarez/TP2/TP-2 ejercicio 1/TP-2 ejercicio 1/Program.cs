namespace TP_2_ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese la durabilidad de " + armas[i] + ": ");
                durabilidad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1 - Inspeccionar armas críticas");
            Console.WriteLine("2 - Ver arsenal completo");
            Console.Write("Elija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < 4; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine("ALERTA: " + armas[i] + " tiene durabilidad crítica: " + durabilidad[i]);
                        }
                        else
                        {
                            Console.WriteLine(armas[i] + " está en buen estado.");
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(armas[i] + " - Durabilidad: " + durabilidad[i]);
                    }
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

            Console.ReadKey();
        }
    }
}