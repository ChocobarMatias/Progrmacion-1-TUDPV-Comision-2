namespace TP_2_ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] cargas = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese las cargas de la gema " + gemas[i] + ": ");
                cargas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1 - Recargar todas las gemas");
            Console.WriteLine("2 - Buscar gemas agotadas");
            Console.Write("Elija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < 4; i++)
                    {
                        cargas[i] = cargas[i] + 5;

                        Console.WriteLine(gemas[i] +
                                          " ahora tiene " +
                                          cargas[i] +
                                          " cargas.");
                    }
                    break;

                case 2:
                    for (int i = 0; i < 4; i++)
                    {
                        if (cargas[i] == 0)
                        {
                            Console.WriteLine("La gema " + gemas[i] +
                                              " está agotada.");
                        }
                        else
                        {
                            Console.WriteLine("La gema " + gemas[i] +
                                              " todavía tiene cargas.");
                        }
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
