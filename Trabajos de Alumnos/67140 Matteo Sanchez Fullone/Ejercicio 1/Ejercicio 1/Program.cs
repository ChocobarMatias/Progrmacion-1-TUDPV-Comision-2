using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {string[] armas={"espada","Hacha","arco","daga"};
            int[] durabilidad = new int[armas.Length];
            for(int i = 0;i< armas.Length; i++)
            {
                Console.WriteLine("ingrese durabilidad");
                durabilidad[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elegir 1 o 2 ");
            Console.WriteLine("1. inspeccionar el arma critica");
            Console.WriteLine("2. ver arsenal completo");

            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                {
                   for (int i = 0; i< durabilidad.Length; i++)
                   {
                      if(durabilidad[i]<20)
                      {
                        Console.WriteLine($"el arma {armas[i]} esta demasiado dañada {durabilidad[i]}");
                      }

                   }
                 break; 
                }
                case 2:
                {
                 for(int i=0; i < armas.Length;i++)
                 {
                   Console.WriteLine(armas[i]);
                 }
                 break;
             
                }
            }
        }
    }
}