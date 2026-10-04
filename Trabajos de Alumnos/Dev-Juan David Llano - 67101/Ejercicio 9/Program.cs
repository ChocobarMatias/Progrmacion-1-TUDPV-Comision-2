using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("EJERCICIO 9 - SISTEMA DE MUNICIÓN");

            string[] nombres = { "Rifle", "Pistola", "Escopeta" };
            int[] municion = { 30, 15, 8 };
            int disparosTotales = 0;

            Console.WriteLine("Armas disponibles:");
            Console.WriteLine("  1 - Rifle     (30 balas)");
            Console.WriteLine("  2 - Pistola   (15 balas)");
            Console.WriteLine("  3 - Escopeta  (8 balas)");
            Console.WriteLine("  0 - Terminar");

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.Write("Munición actual -> ");
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.Write(nombres[i] + ": " + municion[i] + "   ");
                }
                Console.WriteLine();

                opcion = LeerEnteroEnRango("¿Con qué arma dispara? (1-3, 0 para salir): ", 0, 3);

                switch (opcion)
                {
                    case 1:
                    case 2:
                    case 3:
                        int indice = opcion - 1;

                        if (municion[indice] > 0)
                        {
                            municion[indice] = municion[indice] - 1;
                            disparosTotales++;
                            Console.WriteLine("  ¡BANG! Disparo con " + nombres[indice] + ". Quedan " + municion[indice] + " balas.");

                            if (municion[indice] == 0)
                                Console.WriteLine("  Atención: el cargador de " + nombres[indice] + " quedó vacío.");
                        }
                        else
                        {
                            Console.WriteLine("  CLICK. El " + nombres[indice] + " está VACÍO. Elija otra arma.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("  Combate finalizado.");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=== RESUMEN DEL COMBATE ===");
            Console.WriteLine("  Disparos realizados: " + disparosTotales);
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("  " + nombres[i].PadRight(9) + " | Munición restante: " + municion[i]);
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
