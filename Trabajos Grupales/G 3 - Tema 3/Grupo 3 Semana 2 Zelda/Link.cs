using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_3_Semana_2_Zelda
{
    public class Link
    {
        private string nombre;
        private int corazones;
        private int saludmaxima;
        private ItemZelda[] alforja;
        private EspadaMaestra espada = new EspadaMaestra("espada", 30);
        private ArcoFuerza arco = new ArcoFuerza("flechas", 20, 15);


        public Link(string nombre, int corazones, int saludmaxima)

        {
            this.nombre = nombre;
            this.corazones = corazones;
            this.saludmaxima = saludmaxima;
            this.alforja = new ItemZelda[2];
        }
        public void equiparItem(EspadaMaestra espada, ArcoFuerza arco)

        {
            alforja[0] = espada;
            alforja[1] = arco;
            Console.WriteLine("se han equpado ambos items");


        }
            public void accionarItem(int slot)
        {
            switch (slot)
            {
                case 0:
                    alforja[0].usar(this);
                    break;
                case 1:
                    alforja[1].usar(this);
                    break;
                default:
                    Console.WriteLine("slot invalido");
                    break;
            }
        }
        public int Corazones
        {
            get { return corazones; }
            set { corazones = value; }
           
        }
        public int Saludmaxima
        {
            get { return saludmaxima; }
            set { saludmaxima = value; }
        }




    }  

    
}
