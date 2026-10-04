namespace Tp2Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cartas = { 10, 25, 50, 80, 120 };
            int op = 0, gemas;
            Console.WriteLine("Ingrese la cantidad de gemas que posee");
            gemas = int.Parse(Console.ReadLine());
            for (int i = 0; i < cartas.Length; i++)
            {
                if (gemas >= cartas[i])
                {
                    op = op + 1;
                }
            }
            switch (op)
            {
                case 0:
                    Console.WriteLine("No le alcanza para ninguna carta");
                    break;
                case 1:
                    Console.WriteLine($"A usted le alcanza para comprar la carta de {cartas[0]} gemas");
                    break;
                case 2:
                    Console.WriteLine($"A usted le alcanza para comprar las cartas de {cartas[0]} o {cartas[1]} gemas");
                    break;
                case 3:
                    Console.WriteLine($"A usted le alcanza para comprar las cartas de {cartas[0]} , {cartas[1]} o {cartas[2]} gemas");
                    break;
                case 4:
                    Console.WriteLine($"A usted le alcanza para comprar las cartas de {cartas[0]} , {cartas[1]} , {cartas[2]} o {cartas[3]} gemas");
                    break;
                case 5:
                    Console.WriteLine($"A usted le alcanza para comprar las cartas de {cartas[0]} , {cartas[1]} , {cartas[2]} , {cartas[3]} o {cartas[4]} gemas");
                    break;
                default:
                    break;
            }
        }
    }
}