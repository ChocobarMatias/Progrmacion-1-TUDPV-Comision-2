using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flechas = new int[6];

            Console.WriteLine("ingrese el daño de las 6 flechas");

            for(int i = 0; i<flechas.Length; i++)
            {
                flechas[i] = int.Parse(Console.ReadLine());
            }
            int referencia = 1;   // valor inicial para que entre al while

            while (referencia != 0)
            {
                Console.Write("Ingresá daño de referencia (0 para salir): ");
                referencia = int.Parse(Console.ReadLine());

                if (referencia != 0)
                {
                    int total = 0;   // acumulador

                    for (int i = 0; i < flechas.Length; i++)
                    {
                        if (flechas[i] > referencia)
                        {
                            total = total + flechas[i];
                        }
                    }

                    Console.WriteLine("Total de daño filtrado: " + total);
                }
            }
        }
    }
}
