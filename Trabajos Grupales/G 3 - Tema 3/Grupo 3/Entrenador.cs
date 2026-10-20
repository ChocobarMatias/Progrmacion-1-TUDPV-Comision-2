using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3
{
    internal class Entrenador
    {
        private string nombre;
        Pokemon[] equipo= new Pokemon[3];
        public void capturarPokemon()
        {
            for (int i = 0; i < equipo.Length; i++)
            {
                
                    Console.WriteLine("eliga capturar a 1_Charizard o 2_Empoleon");

                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                        Console.WriteLine("escribe un apodo para el pokemon");
                            string apodopokemon = Console.ReadLine();
                        Console.WriteLine("escribe la vida del pokemon");
                            int vidapokemon = int.Parse(Console.ReadLine());
                        Console.WriteLine("escribe el nivel del pokemon");
                            int nivelpokemon = int.Parse(Console.ReadLine());
                            equipo[i] = new Charizard(apodopokemon, vidapokemon, nivelpokemon);
                            break;

                        case 2:
                        Console.WriteLine("escribe un apodo para el pokemon");
                            apodopokemon = Console.ReadLine();
                        Console.WriteLine("escribe la vida del pokemon");
                            vidapokemon = int.Parse(Console.ReadLine());
                        Console.WriteLine("escribe el nivel del pokemon");
                            nivelpokemon = int.Parse(Console.ReadLine());
                            equipo[i] = new Empoleon(apodopokemon, vidapokemon, nivelpokemon);
                            break;

                        default:
                            Console.WriteLine("opcion no valida");
                            i--;
                            break;
                    }


            }

        }
        public void comandarataqueequipo()
        {
            for (int i = 0; i < equipo.Length; i++)
            {
                Console.WriteLine($"{equipo[i].obtenerapodo} ataco al pokemon rival");
            }
        }

    }
}
