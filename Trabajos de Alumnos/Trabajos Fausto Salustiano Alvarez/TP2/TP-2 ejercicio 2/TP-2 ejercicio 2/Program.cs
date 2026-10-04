namespace TP_2_ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] tiempos = new float[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el tiempo del corredor " + (i + 1) + ": ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }

            float objetivo = 1;

            while (objetivo > 0)
            {
                Console.Write("Ingrese un tiempo objetivo (0 para salir): ");
                objetivo = float.Parse(Console.ReadLine());

                if (objetivo > 0)
                {
                    int contador = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        if (tiempos[i] <= objetivo)
                        {
                            contador++;
                        }
                        else
                        {
                            // No supera la prueba
                        }
                    }

                    Console.WriteLine("Corredores que superaron la prueba: " + contador);
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