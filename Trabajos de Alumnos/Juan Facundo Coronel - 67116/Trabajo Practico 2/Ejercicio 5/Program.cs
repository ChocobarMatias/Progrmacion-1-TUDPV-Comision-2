namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flechas = new int[6];
            int cantidad_flechas = 0;
            int daño_total = 0;
            int acumulador = 0;
            int daño_referencia;
            Console.WriteLine("Tienes 6 flechas");
            for (int i = 0; i < flechas.Length; i++)
            {
                Console.WriteLine($"Carga el daño de la flecha {i + 1}");
                flechas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ahora la flecha {i + 1} hace {flechas[i]} de daño");

            }

            Console.WriteLine("Ingresa el daño de referencia que las flechas deben superar ");
            daño_referencia = int.Parse(Console.ReadLine());
            while (acumulador < flechas.Length)
            {
                if (flechas[acumulador] > daño_referencia)
                {
                    daño_total = daño_total + flechas[acumulador];

                }

                acumulador++;
            }
            Console.WriteLine($"El daño total que hiciste es de {daño_total}");

        }
    }
}
