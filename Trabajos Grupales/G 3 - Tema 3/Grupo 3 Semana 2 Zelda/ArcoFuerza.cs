using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_3_Semana_2_Zelda
{
    public class ArcoFuerza : ItemZelda
    {
        protected int flechasrestantes;
        public ArcoFuerza(string nombre, int durabilidad,int flechasrestantes) : base(nombre, durabilidad)
        {
            this.nombre = "ArcoFuerza";
            this.durabilidad = durabilidad;
            this.flechasrestantes = flechasrestantes;
        }
        public override void usar(Link link)
            
        {
            if (flechasrestantes > 0)
            {
                Console.WriteLine("lanzando flecha de energia");
                flechasrestantes--;
            }
            else
            {
                Console.WriteLine("no hay flechas restantes");
            }
        }


    }
}
