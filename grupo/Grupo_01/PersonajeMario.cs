using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Mario
{
    internal class PersonajeMario
    {
        protected string nombre;
        protected int vida;
        protected int monedas;

        public int Vidas
        {
            get
            {
                return vida;
            }
            set
            {
                if (value <= 0)

                {
                    vida = 0;
                    Console.WriteLine("Game Over");
                }
                else
                {
                    vida = value;
                }
            }
        }
        public PersonajeMario(string nombre, int vida, int monedas)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.monedas = monedas;
        }
        public virtual void Saltar()
        {
            Console.WriteLine("Saltaste 1 bloque de altura");
        }
        public void RecibirDanio(int cantidad)
        {
            Vidas -= cantidad;
            Console.WriteLine($"Al personaje {nombre} le quedan {vida} puntos de vida");
        }

        public int setMonedas(int Monedas)
        {
            monedas = monedas + Monedas;

            return monedas;
        }
        //public void getMonedas()
        //{
        //    return monedas;
        //}

        public virtual void RecibirPowerUp(string tipo)
        {
            Console.WriteLine($"{nombre} +  recibió  + tipo + , pero no tiene efecto en él");
        }

        public void getNombre()
        {
            Console.WriteLine(nombre);  
        }

    }
}
