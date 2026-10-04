namespace TP_2_ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] costos = { 10, 25, 50, 80, 120 };

            Console.Write("Ingrese la cantidad de gemas que tiene: ");
            int gemas = int.Parse(Console.ReadLine());

            Console.WriteLine("1 - Mostrar cartas que puede pagar");
            Console.WriteLine("2 - Mostrar la carta más cara");
            Console.Write("Elija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        if (gemas >= costos[i])
                        {
                            Console.WriteLine("Puede pagar la carta " + (i + 1) +
                                              " que cuesta " + costos[i] + " gemas.");
                        }
                        else
                        {
                            Console.WriteLine("No puede pagar la carta " + (i + 1) +
                                              " que cuesta " + costos[i] + " gemas.");
                        }
                    }
                    break;

                case 2:
                    int mayor = costos[0];

                    for (int i = 1; i < 5; i++)
                    {
                        if (costos[i] > mayor)
                        {
                            mayor = costos[i];
                        }
                    }

                    Console.WriteLine("La carta más cara cuesta " + mayor + " gemas.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
