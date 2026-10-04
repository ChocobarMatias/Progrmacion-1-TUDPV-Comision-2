namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Cuidado! Te atacan 4 slimes. Sus vidas son: 30, 40, 50 y 60");
            int[] slimes = { 30, 40, 50, 60 };
            int slimes_vivos = 4;

            Console.WriteLine("Elige a cual de los slimes quieres atacar (1-4)");
            int op = int.Parse(Console.ReadLine());


            while (slimes_vivos > 0)
            {
                switch (op)
                {
                    case 1:


                        if (slimes[0] <= 0)
                        {

                            Console.WriteLine("El slime ya está muerto");
                        }
                        else
                        {
                            Console.WriteLine("Has atacado al slime 1");
                            slimes[0] = slimes[0] - 20;
                            if (slimes[0] <= 0)
                            {
                                slimes[0] = 0;
                                slimes_vivos--;
                                Console.WriteLine("Has derrotado al slime 1");

                            }
                            else
                            {
                                Console.WriteLine($"Hiciste 20 puntos de daño. Al slime 1 le quedan {slimes[0]}  puntos de vida");
                            }
                        }
                        break;
                    case 2:
                        if (slimes[1] <= 0)
                        {

                            Console.WriteLine("El slime ya está muerto");
                        }
                        else
                        {
                            Console.WriteLine("Has atacado al slime 2");
                            slimes[1] = slimes[1] - 20;
                            if (slimes[1] <= 0)
                            {
                                slimes[1] = 0;
                                slimes_vivos--;
                                Console.WriteLine("Has derrotado al slime 2");

                            }
                            else
                            {
                                Console.WriteLine($"Hiciste 20 puntos de daño. Al slime 2 le quedan {slimes[1]}  puntos de vida");
                            }
                        }

                        break;
                    case 3:
                        if (slimes[2] <= 0)
                        {

                            Console.WriteLine("El slime ya está muerto");
                        }
                        else
                        {
                            Console.WriteLine("Has atacado al slime 3");
                            slimes[2] = slimes[2] - 20;
                            if (slimes[2] <= 0)
                            {
                                slimes[2] = 0;
                                slimes_vivos--;
                                Console.WriteLine("Has derrotado al slime 3");

                            }
                            else
                            {
                                Console.WriteLine($"Hiciste 20 puntos de daño. Al slime 3 le quedan {slimes[2]}  puntos de vida");
                            }
                        }
                        break;
                    case 4:
                        if (slimes[3] <= 0)
                        {

                            Console.WriteLine("El slime ya está muerto");
                        }
                        else
                        {
                            Console.WriteLine("Has atacado al slime 4");
                            slimes[3] = slimes[3] - 20;
                            if (slimes[3] <= 0)
                            {
                                slimes[3] = 0;
                                slimes_vivos--;
                                Console.WriteLine("Has derrotado al slime 4");

                            }
                            else
                            {
                                Console.WriteLine($"Hiciste 20 puntos de daño. Al slime 4 le quedan {slimes[3]}  puntos de vida");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Esa opcion no es válida");
                        break;
                }
                if (slimes_vivos > 0)
                {
                    Console.WriteLine("Elige a que slime quieres atacar (1-4)");
                    op = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Todos los slimes han sido derrotados");

                }

            }
        }
    }
}
