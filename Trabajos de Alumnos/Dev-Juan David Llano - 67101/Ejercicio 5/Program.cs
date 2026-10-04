using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("EJERCICIO 5 - FILTRADO DE DAÑO POR RÁFAGA");

            int[] danio = new int[6];

            Console.WriteLine("Cargue el daño de las 6 flechas de la ráfaga:");
            Console.WriteLine();
            for (int i = 0; i < danio.Length; i++)
            {
                danio[i] = LeerEntero("  Daño de la flecha " + (i + 1) + ": ");
            }
            bool seguir = true;
            while (seguir)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese un daño de referencia (-1 para salir):");
                int referencia = LeerEntero("  Daño de referencia: ");

                if (referencia < 0)
                {
                    seguir = false;
                    Console.WriteLine("  Análisis finalizado.");
                }
                else
                {
                    int totalFiltrado = 0;
                    int impactos = 0;

                    Console.WriteLine();
                    for (int i = 0; i < danio.Length; i++)
                    {
                        if (danio[i] > referencia)
                        {
                            Console.WriteLine("    Flecha " + (i + 1) + ": " + danio[i] + " -> SUPERA el filtro");
                            totalFiltrado = totalFiltrado + danio[i];
                            impactos++;
                        }
                        else
                        {
                            Console.WriteLine("    Flecha " + (i + 1) + ": " + danio[i] + " -> descartada");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("  Impactos que superaron " + referencia + ": " + impactos);
                    Console.WriteLine("  Daño total acumulado de esos impactos: " + totalFiltrado);
                }
            }

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

