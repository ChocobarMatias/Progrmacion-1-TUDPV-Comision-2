namespace TP_2_ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dañoFases = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el daño recibido en la fase " + (i + 1) + ": ");
                dañoFases[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1 - Calcular promedio de daño");
            Console.WriteLine("2 - Identificar la fase más destructiva");
            Console.Write("Elija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int suma = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        suma = suma + dañoFases[i];
                    }

                    float promedio = suma / 3f;

                    Console.WriteLine("El promedio de daño es: " + promedio);
                    break;

                case 2:
                    int mayor = dañoFases[0];
                    int faseMayor = 1;

                    if (dañoFases[1] > mayor)
                    {
                        mayor = dañoFases[1];
                        faseMayor = 2;
                    }

                    if (dañoFases[2] > mayor)
                    {
                        mayor = dañoFases[2];
                        faseMayor = 3;
                    }

                    Console.WriteLine("La fase más destructiva fue la fase " +
                                      faseMayor +
                                      " con " +
                                      mayor +
                                      " de daño.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
