using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CANT_SLIMES = 4;
            int[] salud = { 50, 50, 50, 50 };

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n--- Elija un slime para atacar ---");
                Console.WriteLine("1. Slime 1");
                Console.WriteLine("2. Slime 2");
                Console.WriteLine("3. Slime 3");
                Console.WriteLine("4. Slime 4");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Atacar(salud, 0);
                        break;
                    case 2:
                        Atacar(salud, 1);
                        break;
                    case 3:
                        Atacar(salud, 2);
                        break;
                    case 4:
                        Atacar(salud, 3);
                        break;
                    case 0:
                        Console.WriteLine("Combate finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void Atacar(int[] salud, int indice)
        {

            if (salud[indice] <= 0)
            {
                Console.WriteLine($"El Slime {indice + 1} ya fue derrotado.");
            }
            else
            {
                salud[indice] -= 20;
                if (salud[indice] <= 0)
                {
                    salud[indice] = 0;
                    Console.WriteLine($"¡Slime {indice + 1} derrotado!");
                }
                else
                {
                    Console.WriteLine($"Slime {indice + 1} atacado. HP restante: {salud[indice]}");
                }
            }
        }
    }
}
    

