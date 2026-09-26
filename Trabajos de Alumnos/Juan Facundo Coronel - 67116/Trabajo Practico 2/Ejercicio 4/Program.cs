namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tienes un mazo de 5 cartas. Las cartas valen 10, 25, 50, 80, 120.");

            int[] valorCartas = { 10, 25, 50, 80, 120 };
            int cantidad = 0;
            int valorAlto = valorCartas[0];
            Console.WriteLine("Ingresa la cantidad de gemas que tienes:");
            int gemas = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija lo que quiere hacer: 1. Mostrar las cartas que puedes pagar / 2. Identificar la carta más cara del catálogo.");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine(" Elegiste ver que cartas puedes pagar");
                    for (int i = 0; i < valorCartas.Length; i++)
                    {
                        if (gemas >= valorCartas[i])
                        {
                            Console.WriteLine($" Puedes comprar la carta {i + 1}");
                            cantidad++;

                        }
                    }
                    Console.WriteLine($" En total puedes pagar {cantidad} cartas");
                    break;
                case 2:
                    Console.WriteLine("Elegiste ver la carta más cara del catálogo");
                    for (int i = 0; i < valorCartas.Length; i++)
                    {
                        if (valorCartas[i] > valorAlto)
                        {
                            valorAlto = valorCartas[i];

                        }

                    }
                    Console.WriteLine($"La carta más alta es {valorAlto}");
                    break;
                default:
                    Console.WriteLine("Opcion no disponible");
                    break;
            }

        }
    }
}
