using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CANT_FASES = 3;
            int[] daño = new int[CANT_FASES];


            for (int i = 0; i < CANT_FASES; i++)
            {
                Console.Write($"Ingrese el daño recibido en la fase {i + 1}: ");
                daño[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n--- Menú de Estadísticas ---");
            Console.WriteLine("1. Calcular promedio de daño entre las 3 fases");
            Console.WriteLine("2. Identificar la fase más destructiva");
            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int suma = 0;
                    for (int i = 0; i < CANT_FASES; i++)
                    {
                        suma += daño[i];
                    }
                    double promedio = (double)suma / CANT_FASES;
                    Console.WriteLine($"Promedio de daño entre las 3 fases: {promedio}");
                    break;

                case 2:
                    int faseMasDestructiva = 0;
                    for (int i = 1; i < CANT_FASES; i++)
                    {

                        if (daño[i] > daño[faseMasDestructiva])
                        {
                            faseMasDestructiva = i;
                        }
                    }
                    Console.WriteLine($"La fase más destructiva fue la Fase {faseMasDestructiva + 1} con {daño[faseMasDestructiva]} de daño.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}

