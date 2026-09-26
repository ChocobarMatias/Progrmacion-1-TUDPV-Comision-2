using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{ using System; 
    internal class Program
    {
       
        
        
       static void Main()
       {
           const int CANT_CORREDORES = 5;
           float[] tiempos = new float[CANT_CORREDORES];


           for (int i = 0; i < CANT_CORREDORES; i++)
           {
              Console.Write($"Ingrese el tiempo del corredor {i + 1}: ");
              
              tiempos[i] = float.Parse(Console.ReadLine());
           }


           string continuar = "s";
           while (continuar.ToLower() == "s")
           {
               Console.Write("\nIngrese el tiempo objetivo a evaluar: ");
               float tiempoObjetivo = float.Parse(Console.ReadLine());

                int cantidadSuperaron = 0;


               for (int i = 0; i < CANT_CORREDORES; i++)
               {
                  if (tiempos[i] <= tiempoObjetivo)
                  {
                      cantidadSuperaron++;
                  }
               }

                  Console.WriteLine($"Corredores que superaron la prueba (tiempo <= {tiempoObjetivo}): {cantidadSuperaron}");

                  Console.Write("¿Desea evaluar otro tiempo objetivo? (s/n): ");
                  continuar = Console.ReadLine();
           }

             Console.WriteLine("\nPrograma finalizado.");
       }
        
    }
      
}
