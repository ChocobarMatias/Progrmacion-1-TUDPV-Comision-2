using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] experiencia = new int[5];

            int total = 0;
           
            Console.WriteLine("Has realisado 5 misiones");

            Console.WriteLine("ingrese la cantidad de exp optenida por cada mision");
           
            for(int i=0; i<experiencia.Length;i++)
            {
                experiencia[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"En la mision {i + 1} conseguiste {experiencia[i]} EXP");
                if (experiencia[i]>=100)
                {
                    experiencia[i] = (int)(experiencia[i] * 1.20F);
                    Console.WriteLine("conseguiste un bonus del 20% de EXP");
                }
                else
                {
                    Console.WriteLine("no alcansaste el bonus del 20% de EXP");
                }
                total+= experiencia[i];

                Console.WriteLine("luego de calcular el bonus esta es la lista");
                Console.WriteLine($"en la mision {i + 1} conseguiste {experiencia[i]} EXP");
            }
            Console.WriteLine($"en total conseguiste {total} experiencia ");




        }
    }
}

