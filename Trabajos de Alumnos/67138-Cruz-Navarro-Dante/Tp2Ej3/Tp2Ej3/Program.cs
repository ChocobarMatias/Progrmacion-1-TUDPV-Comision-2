namespace Tp2Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] slime = { 30, 40, 50, 60 };
            int op;
            while (slime.Any(x => x != 0))
            {
                Console.WriteLine("Indica a cual de los 4 slimes va a atacar");
                Console.WriteLine("elija del 0 al 3");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        if (slime[0] > 0)
                        {
                            slime[0] = slime[0] - 20;
                            if (slime[0] < 0)
                            {
                                slime[0] = 0;
                                Console.WriteLine($"{slime[0]} de vida restante");
                            }
                            else
                            {
                                Console.WriteLine($"{slime[0]} de vida restante");
                            }
                        }
                        else
                        {
                            Console.WriteLine("este slime ya fue derrotado");
                            slime[0] = 0;
                        }
                        break;
                    case 1:
                        if (slime[1] > 0)
                        {
                            slime[1] = slime[1] - 20;
                            if (slime[1] < 0)
                            {
                                slime[1] = 0;
                                Console.WriteLine($"{slime[1]} de vida restante");
                            }
                            else
                            {
                                Console.WriteLine($"{slime[1]} de vida restante");
                            }
                        }
                        else
                        {
                            Console.WriteLine("este slime ya fue derrotado");
                            slime[1] = 0;
                        }
                        break;
                    case 2:
                        if (slime[2] > 0)
                        {
                            slime[2] = slime[2] - 20;
                            if (slime[2] < 0)
                            {
                                slime[2] = 0;
                                Console.WriteLine($"{slime[2]} de vida restante");
                            }
                            else
                            {
                                Console.WriteLine($"{slime[2]} de vida restante");
                            }
                        }
                        else
                        {
                            Console.WriteLine("este slime ya fue derrotado");
                            slime[2] = 0;
                        }
                        break;
                    case 3:
                        if (slime[3] > 0)
                        {
                            slime[3] = slime[3] - 20;
                            if (slime[3] < 0)
                            {
                                slime[1] = 0;
                                Console.WriteLine($"{slime[3]} de vida restante");
                            }
                            else
                            {
                                Console.WriteLine($"{slime[3]} de vida restante");
                            }
                        }
                        else
                        {
                            Console.WriteLine("este slime ya fue derrotado");
                            slime[3] = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion invalida elija otra opcion");
                        break;
                }
            }
        }
    }
}