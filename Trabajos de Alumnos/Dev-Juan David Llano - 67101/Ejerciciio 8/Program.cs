using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("EJERCICIO 8 - ESTADÍSTICAS DE FASES DEL BOSS");

            int[] danio = new int[3];

            Console.WriteLine("Cargue el daño recibido en cada una de las 3 fases del jefe:");
            Console.WriteLine();
            for (int i = 0; i < danio.Length; i++)
            {
                danio[i] = LeerEntero("  Daño recibido en la fase " + (i + 1) + ": ");
            }

            Console.WriteLine();
            Console.WriteLine("¿Qué desea calcular?");
            Console.WriteLine("  1 - Promedio de daño entre las 3 fases");
            Console.WriteLine("  2 - Identificar la fase más destructiva");
            int opcion = LeerEnteroEnRango("Opción: ", 1, 2);
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    int suma = 0;
                    for (int i = 0; i < danio.Length; i++)
                    {
                        suma = suma + danio[i];
                    }

                    float promedio = (float)suma / danio.Length;

                    Console.WriteLine("=== PROMEDIO DE DAÑO ===");
                    Console.WriteLine("  Daño total en las 3 fases: " + suma);
                    Console.WriteLine("  Promedio por fase: " + promedio.ToString("0.00"));

                    if (promedio >= 200)
                        Console.WriteLine("  El jefe es MUY peligroso. Conviene revisar el equipamiento.");
                    else if (promedio >= 100)
                        Console.WriteLine("  El jefe presenta una dificultad media.");
                    else
                        Console.WriteLine("  El jefe hace poco daño. El combate es manejable.");
                    break;

                case 2:
                    int posMayor = 0;
                    for (int i = 1; i < danio.Length; i++)
                    {
                        if (danio[i] > danio[posMayor])
                        {
                            posMayor = i;
                        }
                    }

                    Console.WriteLine("=== FASE MÁS DESTRUCTIVA ===");
                    for (int i = 0; i < danio.Length; i++)
                    {
                        if (i == posMayor)
                            Console.WriteLine("  Fase " + (i + 1) + ": " + danio[i] + " de daño  <<< LA MÁS DESTRUCTIVA");
                        else
                            Console.WriteLine("  Fase " + (i + 1) + ": " + danio[i] + " de daño");
                    }
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