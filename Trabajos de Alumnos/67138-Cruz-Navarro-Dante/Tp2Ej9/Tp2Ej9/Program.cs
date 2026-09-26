namespace Tp2Ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] armas = { "Rifle", "Pistola", "Escopeta" };
            int[] balas = { 30, 15, 8 };
            int op = 1;

            Console.WriteLine("Elija que arma disparar");
            Console.WriteLine("1-Rifle , 2-Pistola , 3-Escopeta , 0- Salir");

            while (op != 0)
            {
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if (balas[0] > 0)
                        {
                            balas[0] = balas[0] - 1;
                            Console.WriteLine("Se disparo con exito");
                        }
                        else
                        {
                            Console.WriteLine("No quedan balas de Rifle");
                        }
                        break;

                    case 2:
                        if (balas[1] > 0)
                        {
                            balas[1] = balas[1] - 1;
                            Console.WriteLine("Se disparo con exito");
                        }
                        else
                        {
                            Console.WriteLine("No quedan balas de Pistola");
                        }
                        break;

                    case 3:
                        if (balas[2] > 0)
                        {
                            balas[2] = balas[2] - 1;
                            Console.WriteLine("Se disparo con exito");
                        }
                        else
                        {
                            Console.WriteLine("No quedan balas de Escopeta");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Hasta la proxima");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida elija otra");
                        break;
                }
            }
        }
    }
}