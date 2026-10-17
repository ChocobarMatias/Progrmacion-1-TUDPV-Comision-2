using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3
{
    public class Empoleon : Pokemon
    {
        public Empoleon(string apodo, int vida, int nivel) : base(apodo, vida, nivel)
        {
            
        }
        public override void Atacar(Pokemon objetivo)
        {
            Console.WriteLine($"{Apodo} uso Pistola de agua contra {objetivo.obtenerapodo}!");
            objetivo.recibirAtaque(12);
        }
    }
}
