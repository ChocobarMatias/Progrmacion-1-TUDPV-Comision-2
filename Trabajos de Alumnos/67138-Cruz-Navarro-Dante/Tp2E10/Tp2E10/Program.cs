namespace Tp2E10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] exp = new int[5];
            int total = 0;

            Console.WriteLine("Ingrese la experiencia resivida en las 5 misiones");

            for (int i = 0; i < exp.Length; i++)
            {
                exp[i] = int.Parse(Console.ReadLine());
                if (exp[i] > 100)
                {
                    double porc = exp[i] * 0.20;
                    exp[i] = exp[i] + (int)porc;
                    total = total + exp[i];
                }
                else
                {
                    total = total + exp[i];
                }
            }

            Console.WriteLine("La experiencia ganada en las misiones fue:");
            Console.WriteLine();

            for (int i = 0; i < exp.Length; i++)
            {
                Console.Write($"{exp[i]} / ");
            }

            Console.WriteLine();
            Console.WriteLine($"La experiencia total fue: {total} puntos de experiencia");
        }
    }
}