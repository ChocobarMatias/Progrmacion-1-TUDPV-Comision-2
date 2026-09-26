namespace Tp2Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dañof = new int[3];
            int total = 0, op;

            Console.WriteLine("Ingrese el dsño resibido en las 3 fases");
            for (int i = 0; i < dañof.Length; i++)
            {
                dañof[i] = int.Parse(Console.ReadLine());
                total = total + dañof[i];
            }

            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1-Sacar el promedio, 2-Ver fase mas destructiva");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int prom = total / dañof.Length;
                    Console.WriteLine($"El promedio de daño es {prom}");
                    break;

                case 2:
                    if (dañof[0] > dañof[1])
                    {
                        if (dañof[0] > dañof[2])
                        {
                            Console.WriteLine("Se resivio mas daño en la primera fase");
                        }
                        else
                        {
                            Console.WriteLine("Se resivio mas daño en la ultima fase");
                        }
                    }
                    else
                    {
                        if (dañof[1] > dañof[2])
                        {
                            Console.WriteLine("Se resivio mas daño en la segunda fase");
                        }
                        else
                        {
                            Console.WriteLine("Se resivio mas daño en la ultima fase");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}