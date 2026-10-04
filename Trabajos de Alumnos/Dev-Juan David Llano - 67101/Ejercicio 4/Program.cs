using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Solucion
{
    class Program
    {
        private static void Titulo(string v)
        {
            Console.WriteLine("== " + v + " ==");
        }
        private static int LeerEntero(string v)
        {
            int result;
            while (true)
            {
                Console.Write(v);
                if (int.TryParse(Console.ReadLine(), out result))
                    return result;
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }
        private static int LeerEnteroEnRango(string v)
        {
            int result;
            while (true)
            {
                Console.Write(v);
                if (int.TryParse(Console.ReadLine(), out result) && (result == 1 || result == 2))
                    return result;
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("TIENDA DE CARTA");

            int[] costos = { 10, 25, 40, 80, 120 };
            Console.WriteLine("Catalogo de Cartas (moneda en gemas):");
            for (int i = 0; i < costos.Length; i++)
            {
                Console.WriteLine($"Carta {i + 1}: {costos[i]} gemas");
            }

            Console.WriteLine();
            int gemas = LeerEntero("Cuantas gemas tienes disponibles? ");

            Console.WriteLine();
            Console.WriteLine("¿Que deseas comprar'");
            Console.WriteLine(" 1 - Monstrar Cartas Disponibles Para Comprar");
            Console.WriteLine(" 2 - Identificar la carta mas alta en precio");
            int opcion = LeerEnteroEnRango("Ingrese su opción (1 o 2): ");
            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Cartas disponibles para comprar:");
                    for (int i = 0; i < costos.Length; i++)
                    {
                        if (costos[i] <= gemas)
                        {
                            Console.WriteLine($"Carta {i + 1}: {costos[i]} gemas");
                        }
                    }
                    break;
                case 2:
                    int maxCosto = costos.Max();
                    int cartaMasAlta = Array.IndexOf(costos, maxCosto) + 1;
                    Console.WriteLine($"La carta más alta en precio es la Carta {cartaMasAlta} con un costo de {maxCosto} gemas.");
                    break;
            }
        }
    }
}