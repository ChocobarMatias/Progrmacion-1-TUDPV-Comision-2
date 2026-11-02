using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_3
{
    public class Pokemon
    {
        protected string Apodo;
        protected int vida;
        protected int nivel;
        public Pokemon(string apodo, int vida, int nivel)
        {
            this.Apodo = apodo;
            this.vida = vida;
            this.nivel = nivel;

        }
        public virtual void Atacar(Pokemon objetivo)
        {
            Console.WriteLine($"{Apodo} Usa un ataque normal contra {objetivo.Apodo}!");
            objetivo.vida -= 5;
        }
        public void recibirAtaque(int danio)
        {
            vida -= danio;
            if (vida <= 0)
            {
                Console.WriteLine($"{Apodo} ha sido derrotado!");

            }
        }
        public string obtenerapodo
        {
            get { return Apodo; }
            set { Apodo = value; }
        }
        public int obtenervida
        {
            get { return vida; }
            set { vida = value; }
        }
        public int obtenernivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
    }

}
