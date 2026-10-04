namespace TP_2_Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] experiencia = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese la EXP de la misión " + (i + 1) + ": ");
                experiencia[i] = int.Parse(Console.ReadLine());

                if (experiencia[i] > 100)
                {
                    experiencia[i] = experiencia[i] + (experiencia[i] * 20 / 100);
                }
                else
                {
                    experiencia[i] = experiencia[i];
                }
            }

            int total = 0;

            Console.WriteLine("Tabla de experiencia actualizada:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Misión " + (i + 1) + ": " + experiencia[i] + " EXP");

                total = total + experiencia[i];
            }

            Console.WriteLine("Experiencia total acumulada: " + total);

            Console.ReadKey();
        }
    }
}
