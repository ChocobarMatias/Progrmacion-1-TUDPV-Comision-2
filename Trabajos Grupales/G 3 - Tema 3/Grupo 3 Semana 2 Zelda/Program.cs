using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_3_Semana_2_Zelda
{
    public class Program
    {
        static void Main(string[] args)
        {
           Link link = new Link("Link", 3, 100);
            EspadaMaestra espada = new EspadaMaestra("espada", 30);
            ArcoFuerza arco = new ArcoFuerza("flechas", 20, 15);
            link.equiparItem(espada, arco);
            link.accionarItem(0);
            link.accionarItem(1);
        }
    }

    

}

