using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("EJERCICIO 10 - BONIFICACIÓN DE EXP DEL CLAN");

            int[] exp = new int[5];

            Console.WriteLine("Cargue los puntos de EXP obtenidos en cada una de las 5 misiones:");
            Console.WriteLine();
            for (int i = 0; i < exp.Length; i++)
            {
                exp[i] = LeerEntero("  EXP de la misión " + (i + 1) + ": ");
            }

            Console.WriteLine();
            Console.WriteLine("=== APLICACIÓN DEL BONO ===");
            Console.WriteLine("Las misiones que superaron los 100 puntos reciben un 20% extra.");
            Console.WriteLine();

            int totalAcumulado = 0;
            int misionesConBono = 0;

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] > 100)
                {
                    int original = exp[i];
                    exp[i] = (int)(exp[i] * 1.20);
                    misionesConBono++;
                    Console.WriteLine("  Misión " + (i + 1) + ": " + original + " + 20% -> " + exp[i] + " EXP");
                }
                else
                {
                    Console.WriteLine("  Misión " + (i + 1) + ": " + exp[i] + " EXP (sin bono)");
                }

                totalAcumulado = totalAcumulado + exp[i];
            }

            Console.WriteLine();
            Console.WriteLine("=== TABLA FINAL DEL ARRAY ===");
            for (int i = 0; i < exp.Length; i++)
            {
                Console.WriteLine("  exp[" + i + "] = " + exp[i]);
            }

            Console.WriteLine();
            Console.WriteLine("  Misiones bonificadas: " + misionesConBono + " de " + exp.Length);
            Console.WriteLine("  EXPERIENCIA TOTAL ACUMULADA: " + totalAcumulado);

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
        static void Titulo(string texto)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("  " + texto);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine();
        }

        static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                if (entrada != null && int.TryParse(entrada.Trim(), out valor))
                    return valor;
                Console.WriteLine("  >> Valor no válido. Ingrese un número entero.");
            }
        }
    }
}
