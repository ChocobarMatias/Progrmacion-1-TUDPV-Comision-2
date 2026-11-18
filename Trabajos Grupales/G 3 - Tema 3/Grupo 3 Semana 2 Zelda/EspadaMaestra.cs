using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_3_Semana_2_Zelda
{
    public class EspadaMaestra : ItemZelda
    {
        public EspadaMaestra(string nombre, int durabilidad):base(nombre,durabilidad)
        {
            this.nombre = "EspadaMaestra";
            this.durabilidad = durabilidad;

            
        }
        public override void usar(Link link)
        {
            if (link.Corazones == link.Saludmaxima)
            {
                Console.WriteLine("lanzando rayo de energia");
                
            }
            else
            {
                Console.WriteLine ("se uso un ataque normal");
            }
                

        }
    }
}
