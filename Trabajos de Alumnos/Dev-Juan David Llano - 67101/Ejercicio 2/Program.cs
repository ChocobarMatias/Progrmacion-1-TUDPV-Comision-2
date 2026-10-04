using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Numero_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { Console.OutputEncoding = System.Text.Encoding.UTF8; }
            catch { }

            Titulo("MARCADOR TOP 5 DE SPEEDRUN");

            float[] tiempos = new float[5];

            Console.WriteLine("Cargue el tiempo de los 5 corredores, en segundos:");
            Console.WriteLine();
            for (int i = 0; i < tiempos.Length; i++)
            {
                tiempos[i] = LeerDecimal("  Tiempo del corredor " + (i + 1) + ": ");
            }

            Console.WriteLine();
            Console.WriteLine("Tiempos cargados:");
            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.WriteLine("  Corredor " + (i + 1) + ": " + tiempos[i] + " seg");
            }
            bool seguir = true;
            while (seguir)
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese una marca objetivo (0 o menos para salir):");
                float marca = LeerDecimal("  Marca exigida: ");

                if (marca <= 0)
                {
                    seguir = false;
                    Console.WriteLine("  Clasificación finalizada.");
                }
                else
                {
                    int clasificados = 0;
                    for (int i = 0; i < tiempos.Length; i++)
                    {
                        if (tiempos[i] <= marca)
                        {
                            Console.WriteLine("    Corredor " + (i + 1) + " (" + tiempos[i] + " seg) -> CLASIFICA");
                            clasificados++;
                        }
                        else
                        {
                            Console.WriteLine("    Corredor " + (i + 1) + " (" + tiempos[i] + " seg) -> queda afuera");
                        }
                    }

                    Console.WriteLine();
                    if (clasificados == 0)
                        Console.WriteLine("  Ningún corredor logró la marca de " + marca + " seg.");
                    else
                        Console.WriteLine("  " + clasificados + " de 5 corredores lograron un tiempo menor o igual a " + marca + " seg.");
                }
            }

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
        static float LeerDecimal(string mensaje)
        {
            float valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                if (entrada != null)
                {
                    entrada = entrada.Trim().Replace(',', '.');
                    if (float.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
                        return valor;
                }
                Console.WriteLine("  >> Valor no válido. Ingrese un número (ejemplo: 12.5).");
            }
        }
    }
}