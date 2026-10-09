namespace Trabajo_Practico___Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gemas = { "fuego", "hielo", "rayo", "veneno" };
            int[] cargas = new int[4];
            for (int i = 0; i < gemas.Length; i++)
            {
                Console.WriteLine($"ingrese cargas de {gemas[i]}:");
                cargas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elige 2 opciones: 1. Recargar todas las gemas(+5)/2. buscar si alguna gema esta agotada");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        cargas[i] += 5;
                    }
                    Console.WriteLine("recargaste todas las gemas +5");
                    break;

                case 2:
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (cargas[i] <= 0)
                        {
                            Console.WriteLine($"La gema {gemas[i]} tienen 0 de carga");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("opcion invalida");
                    break;
            }
        }
    }
}
