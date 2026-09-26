using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gemas = { "fuego", "hielo", "rayo", "veneno" };
            int[] cargas = new int[4];
            for (int i = 0; i < gemas.Length; i++)
            {
              Console.WriteLine($"ingrese cargas de {gemas[i]}:");
                cargas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("ELIGE 2 OPCIONES:1.RECARGAR TODAS LAS GEMAS(+5)/2.BUSCAR SI ALGUNA GEMA ESTA AGOTADA");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    for(int i = 0 ; i < gemas.Length; i++)
                    {
                        cargas[i] += 5;
                    }
                    Console.WriteLine("recargar todas las gemas  + 5");
                    break;
                case 2:
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (cargas[i] <= 0)
                        {
                            Console.WriteLine($"la gema de {gemas[i]} tiene 0 de carga");
                        }
                    }
                    break;
                }
            
            
            

            
        
        }
    }
}






