namespace Tp2Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flecha = new int[6];
            int refe, total = 0;
            Console.WriteLine("Ingrese el daño de 6 ataques de flechas");

            for (int i = 0; i < flecha.Length; i++)
            {
                flecha[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el daño de referencia/defensa");
            refe = int.Parse(Console.ReadLine());

            for (int i = 0; i < flecha.Length; i++)
            {
                if (flecha[i] > refe)
                {
                    total = total + flecha[i];
                }
            }

            Console.WriteLine($"El total de daño filtrado es de: {total} puntos de daño");
        }
    }
}