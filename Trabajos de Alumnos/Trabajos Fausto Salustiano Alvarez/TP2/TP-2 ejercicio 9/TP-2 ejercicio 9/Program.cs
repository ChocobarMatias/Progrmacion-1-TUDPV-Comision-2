namespace TP_2_ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] municion = { 30, 15, 8 };

            int opcion = 1;

            while (opcion != 0)
            {
                Console.WriteLine("1 - Rifle: " + municion[0] + " balas");
                Console.WriteLine("2 - Pistola: " + municion[1] + " balas");
                Console.WriteLine("3 - Escopeta: " + municion[2] + " balas");
                Console.WriteLine("0 - Salir");

                Console.Write("Elija un arma: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (municion[0] > 0)
                        {
                            municion[0] = municion[0] - 1;
                            Console.WriteLine("Disparaste con el rifle.");
                        }
                        else
                        {
                            Console.WriteLine("El rifle está vacío.");
                        }
                        break;

                    case 2:
                        if (municion[1] > 0)
                        {
                            municion[1] = municion[1] - 1;
                            Console.WriteLine("Disparaste con la pistola.");
                        }
                        else
                        {
                            Console.WriteLine("La pistola está vacía.");
                        }
                        break;

                    case 3:
                        if (municion[2] > 0)
                        {
                            municion[2] = municion[2] - 1;
                            Console.WriteLine("Disparaste con la escopeta.");
                        }
                        else
                        {
                            Console.WriteLine("La escopeta está vacía.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}