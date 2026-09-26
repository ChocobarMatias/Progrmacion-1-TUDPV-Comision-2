using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Arma = { "rifle","pistola", "escopeta"};
            int[] balas = { 30, 15, 8 };
            int op = 1;
            for (int i=0 ; i < Arma.Length; i++)
            {
                Console.WriteLine($"{Arma[i]} tiene {balas[i]}"); 
            }
            Console.WriteLine("elija con que arma quiere disparar");
            Console.WriteLine("1-rifle, 2-pistola, 3-escopeta");
            while (op != 0)
            {
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                 case 1:
                    
                    if(balas[0] > 0)
                    {
                       balas[0] = balas[0] - 1;
                            Console.WriteLine($"se disparan el {Arma[0]} con exito");
                            Console.WriteLine($"balas restantes:{balas[0]}");
                    }
                    else
                    {
                            Console.WriteLine("se acabaron las balas del rifle");
                    }
                  break;
                    case 2:
                        if(balas[1] > 0)
                        {
                            balas[1] = balas[1] - 1;
                            Console.WriteLine($"se disparo la {Arma[1]} con exito");
                            Console.WriteLine($"balas restantes:{balas[1]}");

                        }
                        else
                        {
                            Console.WriteLine("ya no queda balas en la pistola");
                        }
                        break;

                        case 3:

                         if(balas[2] > 0)
                        {
                            balas[2] = balas[2] - 1;
                            Console.WriteLine($"se disparo la {Arma[2]} con exito");
                            Console.WriteLine($"balas restantes:{balas[2]}");

                        }
                        else
                        {
                            Console.WriteLine("no queda balas de escopeta");
                        }
                        break;
                    case 0:
                        Console.WriteLine("hasta pronto");
                        break;

                    default:
                        Console.WriteLine("opcion invalida");
                        break;
                    }
                }
            }
        }
    }




