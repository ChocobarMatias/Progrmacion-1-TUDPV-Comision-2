using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entrenador entrenador1 = new Entrenador();
            Entrenador entrenador2 = new Entrenador();
            entrenador1.capturarPokemon();
            entrenador2.capturarPokemon();
            entrenador1.comandarataqueequipo();
            entrenador2.comandarataqueequipo();
        }
    }
}
