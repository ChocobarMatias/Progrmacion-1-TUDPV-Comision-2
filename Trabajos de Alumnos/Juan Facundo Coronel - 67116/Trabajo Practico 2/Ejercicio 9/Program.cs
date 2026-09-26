namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tines 3 armas: Rifle con 30 balas / Pistola con 15 balas / Escopeta con 8 balas");
            int[] municion = { 30, 15, 8 };
            string[] armas = { "Rifle", "Pistola", "Escopeta" };
            //Console.WriteLine("Elige con cual arma disparar: 1. Rifle / 2. Pistola / 3. Escopeta / 0. Salir");

            bool salir = false;

            while (salir == false)
            {
                Console.WriteLine("Elige con cual arma disparar: 1. Rifle / 2. Pistola / 3. Escopeta / 0. Salir");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        salir = true;
                        Console.WriteLine("Saliste");
                        break;

                    case 1:
                        Console.WriteLine("Elegiste el Rifle");

                        if (municion[0] <= 0)
                        {
                            Console.WriteLine($" El {armas[0]} no tiene suficiente municion");
                        }
                        else
                        {
                            municion[0] -= 1;
                            Console.WriteLine($"Al {armas[0]} le quedan {municion[0]} balas");
                        }


                        break;
                    case 2:
                        Console.WriteLine("Elegiste la Pistola");
                        if (municion[1] <= 0)
                        {
                            Console.WriteLine($" La {armas[1]} no tiene suficiente municion");
                        }
                        else
                        {
                            municion[1] -= 1;
                            Console.WriteLine($"Al {armas[1]} le quedan {municion[1]} balas");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Elegiste la Escopeta");
                        if (municion[2] <= 0)
                        {
                            Console.WriteLine($" La {armas[2]} no tiene suficiente municion");
                        }
                        else
                        {
                            municion[2] -= 1;
                            Console.WriteLine($"Al {armas[2]} le quedan {municion[2]} balas");
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.WriteLine("Elegi de nuevo");
                        break;
                }
            }
        }
    }
}
