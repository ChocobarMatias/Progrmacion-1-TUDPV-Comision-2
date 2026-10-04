using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("COMBATE CONTRA HORDA DE SLIMES");

            int[] slimes = { 30, 70, 100, 140 };
            const int DAÑO_POR_GOLPE = 20;
            int turno = 1;

            Console.WriteLine("Hay 4 slimes. Cada golpe resta " + DAÑO_POR_GOLPE + " HP.");

            while (HayAlgunSlimeVivo(slimes))
            {
                Console.WriteLine();
                Console.WriteLine("--- Turno " + turno + " ---");

                for (int i = 0; i < slimes.Length; i++)
                {
                    if (slimes[i] > 0)
                        Console.WriteLine("  Slime " + i + ": " + slimes[i] + " HP");
                    else
                        Console.WriteLine("  Slime " + i + ": DERROTADO");
                }

                int objetivo = LeerEnteroEnRango("¿A cuál slime ataca? (0 a 3): ", 0, 3);

                switch (objetivo)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (slimes[objetivo] <= 0)
                        {
                            Console.WriteLine("  El slime " + objetivo + " ya fue derrotado. El golpe se pierde.");
                        }
                        else
                        {
                            slimes[objetivo] = slimes[objetivo] - DAÑO_POR_GOLPE;

                            if (slimes[objetivo] <= 0)
                            {
                                slimes[objetivo] = 0;
                                Console.WriteLine("  ¡Golpe certero! El slime " + objetivo + " fue DERROTADO.");
                            }
                            else
                            {
                                Console.WriteLine("  Golpe al slime " + objetivo + ". Le quedan " + slimes[objetivo] + " HP.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("  Objetivo no válido.");
                        break;
                }

                turno++;
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("  ¡HORDA ELIMINADA! Todos los slimes cayeron.");
            Console.WriteLine("  Turnos utilizados: " + (turno - 1));
            Console.WriteLine("==========================================");

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
        static void Titulo(string texto)
        {
            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
            Console.WriteLine("  " + texto);
            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
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
        static bool HayAlgunSlimeVivo(int[] slimes)
        {
            for (int i = 0; i < slimes.Length; i++)
            {
                if (slimes[i] > 0)
                    return true;
            }
            return false;
        }
    }
}