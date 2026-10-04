using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("EJERCICIO 7 - PASILLO DE MAZMORRA");

            bool[] trampas = { false, true, false, false, true, false };
            const int META = 5;

            int posicion = 0;
            bool perdio = false;
            int pasos = 0;

            Console.WriteLine("El pasillo tiene 6 baldosas, numeradas de 0 a 5.");
            Console.WriteLine("Usted arranca en la baldosa 0 y la meta es la baldosa " + META + ".");
            Console.WriteLine("En cada turno puede avanzar 1, 2 o 3 baldosas.");
            Console.WriteLine("Dos baldosas tienen trampa. Si pisa una, pierde.");

            while (!perdio && posicion < META)
            {
                Console.WriteLine();
                Console.WriteLine("  Posición actual: baldosa " + posicion + " | Faltan " + (META - posicion) + " baldosas");

                int avance = LeerEnteroEnRango("  ¿Cuántas baldosas avanza? (1 a 3): ", 1, 3);

                if (posicion + avance > META)
                {
                    Console.WriteLine("  No puede avanzar tanto: se pasaría de la meta. Intente con menos.");
                }
                else
                {
                    posicion = posicion + avance;
                    pasos++;
                    Console.WriteLine("  Avanza a la baldosa " + posicion + "...");

                    if (trampas[posicion])
                    {
                        perdio = true;
                        Console.WriteLine("  ¡CLICK! Se activó una trampa en la baldosa " + posicion + ".");
                    }
                    else
                    {
                        Console.WriteLine("  Baldosa segura.");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            if (perdio)
            {
                Console.WriteLine("  DERROTA. Cayó en la trampa de la baldosa " + posicion + ".");
                Console.WriteLine("  Las trampas estaban en las baldosas 1 y 4.");
            }
            else
            {
                Console.WriteLine("  ¡VICTORIA! Llegó a la meta en " + pasos + " movimientos.");
                Console.WriteLine("  Esquivó las trampas de las baldosas 1 y 4.");
            }
            Console.WriteLine("==========================================");

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