namespace Tp2Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gemas = { "fuego", "hielo", "rayo", "veneno" };
            int[] carga = new int[gemas.Length];
            int op;

            Console.WriteLine("Ingrese la carga de cada gema");

            for (int i = 0; i < gemas.Length; i++)
            {
                Console.WriteLine($"Carga gema {gemas[i]}");
                carga[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1-Recargar 5 puntos a las gemas");
            Console.WriteLine("2-Verificar si hay gemas descargadas");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    for (int i = 0; i < carga.Length; i++)
                    {
                        carga[i] = carga[i] + 5;
                    }
                    for (int i = 0; i < carga.Length; i++)
                    {
                        Console.WriteLine($"La carga de la gema de {gemas[i]} ahora es {carga[i]}");
                    }
                    break;
                case 2:
                    for (int i = 0; i < carga.Length; i++)
                    {
                        if (carga[i] == 0)
                        {
                            Console.WriteLine($"La gema de {gemas[i]} esta descargada");
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