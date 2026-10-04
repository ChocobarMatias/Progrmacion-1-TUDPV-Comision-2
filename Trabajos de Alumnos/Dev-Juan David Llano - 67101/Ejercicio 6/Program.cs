using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("EJERCICIO 6 - GEMAS Y CARGAS MÁGICAS");

            string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] cargas = new int[4];

            Console.WriteLine("Cargue las cargas mágicas de cada gema (0 a 50):");
            Console.WriteLine();
            for (int i = 0; i < gemas.Length; i++)
            {
                cargas[i] = LeerEnteroEnRango("  Cargas de la gema de " + gemas[i] + ": ", 0, 50);
            }

            Console.WriteLine();
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("  1 - Recargar todas las gemas (+5 cargas)");
            Console.WriteLine("  2 - Buscar si hay alguna gema agotada");
            int opcion = LeerEnteroEnRango("Opción: ", 1, 2);
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("=== RECARGA GENERAL (+5 a cada gema) ===");
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        int antes = cargas[i];
                        cargas[i] = cargas[i] + 5;
                        Console.WriteLine("  " + gemas[i].PadRight(8) + " : " + antes + " -> " + cargas[i] + " cargas");
                    }
                    Console.WriteLine();
                    Console.WriteLine("  Todas las gemas fueron recargadas.");
                    break;

                case 2:
                    Console.WriteLine("=== BÚSQUEDA DE GEMAS AGOTADAS ===");
                    int agotadas = 0;

                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (cargas[i] == 0)
                        {
                            Console.WriteLine("  La gema de " + gemas[i] + " está AGOTADA.");
                            agotadas++;
                        }
                    }

                    if (agotadas == 0)
                        Console.WriteLine("  Ninguna gema está agotada. Todas tienen cargas disponibles.");
                    else
                        Console.WriteLine("  Total de gemas agotadas: " + agotadas + " de " + gemas.Length);
                    break;
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

        static int LeerEnteroEnRango(string mensaje, int minimo, int maximo)
        {
            while (true)
            {
                int valor = LeerEntero(mensaje);
                if (valor >= minimo && valor <= maximo)
                    return valor;
                Console.WriteLine("  >> Debe ingresar un número entre " + minimo + " y " + maximo + ".");
            }
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