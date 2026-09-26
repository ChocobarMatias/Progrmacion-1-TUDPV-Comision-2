namespace TP_2_ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] slimes = { 30, 40, 50, 60 };

            bool haySlimesVivos = true;

            while (haySlimesVivos)
            {
                Console.WriteLine("Slime 0 - Vida: " + slimes[0]);
                Console.WriteLine("Slime 1 - Vida: " + slimes[1]);
                Console.WriteLine("Slime 2 - Vida: " + slimes[2]);
                Console.WriteLine("Slime 3 - Vida: " + slimes[3]);

                Console.Write("Elija un slime para atacar (0 al 3): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        if (slimes[0] <= 0)
                        {
                            Console.WriteLine("Ese slime ya fue derrotado.");
                        }
                        else
                        {
                            slimes[0] = slimes[0] - 20;

                            if (slimes[0] < 0)
                            {
                                slimes[0] = 0;
                            }

                            Console.WriteLine("Atacaste al slime 0.");
                        }
                        break;

                    case 1:
                        if (slimes[1] <= 0)
                        {
                            Console.WriteLine("Ese slime ya fue derrotado.");
                        }
                        else
                        {
                            slimes[1] = slimes[1] - 20;

                            if (slimes[1] < 0)
                            {
                                slimes[1] = 0;
                            }

                            Console.WriteLine("Atacaste al slime 1.");
                        }
                        break;

                    case 2:
                        if (slimes[2] <= 0)
                        {
                            Console.WriteLine("Ese slime ya fue derrotado.");
                        }
                        else
                        {
                            slimes[2] = slimes[2] - 20;

                            if (slimes[2] < 0)
                            {
                                slimes[2] = 0;
                            }

                            Console.WriteLine("Atacaste al slime 2.");
                        }
                        break;

                    case 3:
                        if (slimes[3] <= 0)
                        {
                            Console.WriteLine("Ese slime ya fue derrotado.");
                        }
                        else
                        {
                            slimes[3] = slimes[3] - 20;

                            if (slimes[3] < 0)
                            {
                                slimes[3] = 0;
                            }

                            Console.WriteLine("Atacaste al slime 3.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

                haySlimesVivos = false;

                for (int i = 0; i < 4; i++)
                {
                    if (slimes[i] > 0)
                    {
                        haySlimesVivos = true;
                    }
                }
            }

            Console.WriteLine("Todos los slimes fueron derrotados.");
            Console.ReadKey();
        }
    }
