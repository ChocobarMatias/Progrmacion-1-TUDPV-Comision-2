using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3
{
    public class Charizard : Pokemon
    {
        public Charizard(string apodo, int vida, int nivel) : base(apodo, vida, nivel)
        {

        }


        public override void Atacar(Pokemon objetivo)
        {
            Console.WriteLine($"{Apodo} uso Lanzallamas contra {objetivo.obtenerapodo}!");
            objetivo.recibirAtaque(10);
        }
    }


}
