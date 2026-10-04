namespace TP_2_ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] daños = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese el daño de la flecha " + (i + 1) + ": ");
                daños[i] = int.Parse(Console.ReadLine());
            }

            int referencia = 1;

            while (referencia > 0)
            {
                Console.Write("Ingrese un daño de referencia (0 para salir): ");
                referencia = int.Parse(Console.ReadLine());

                if (referencia > 0)
                {
                    int totalFiltrado = 0;

                    for (int i = 0; i < 6; i++)
                    {
                        if (daños[i] > referencia)
                        {
                            Console.WriteLine("La flecha " + (i + 1) +
                                              " superó la referencia con " +
                                              daños[i] + " de daño.");

                            totalFiltrado = totalFiltrado + daños[i];
                        }
                        else
                        {
                            Console.WriteLine("La flecha " + (i + 1) +
                                              " no superó la referencia.");
                        }
                    }

                    Console.WriteLine("Daño total filtrado: " + totalFiltrado);
                }
                else
                {
                    Console.WriteLine("Fin del programa.");
                }
            }

            Console.ReadKey();
        }
    }
}
