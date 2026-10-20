using System;
namespace POO
{
    class Personaje
        {
            protected string nombre;
            protected int vida; 

            public Personaje(string nombre, int vida)
            {
                this.nombre = nombre;
                this.vida = vida;

            }
            public virtual void Atacar(Personaje objetivo)
            {
                int danio = 10;
                Console.WriteLine($"El personaje está siendo atacado por {nombre}. Le hizo {danio} de daño");
            }
            public void RecibirDanio(int cant)
            {
                vida -= cant;
                if (vida <= 0)
                {
                    vida = 0;
                }
            }
            public bool EstaVivo()
            {
                return vida > 0;
            }
        public void MostrarEstado()
        {
            Console.WriteLine($"{nombre} -> Vida: {vida}");
        }


    }
        class Guerrero : Personaje
        {
            private int fuerzaFisica;

            public Guerrero(string nombre, int vida, int fuerzaFisica)
                : base(nombre, vida)
            {
                this.fuerzaFisica = fuerzaFisica;
            }

            public override void Atacar(Personaje objetivo)
            {
                Console.WriteLine($"{nombre} golpea con fuerza ({fuerzaFisica} de daño)");
                objetivo.RecibirDanio(fuerzaFisica);
            }
        }
        class Mago : Personaje
        {
            private int mana;

            public Mago(string nombre, int vida, int mana)
                : base(nombre, vida)
            {
                this.mana = mana;
            }

            public override void Atacar(Personaje objetivo)
            {
                if (mana >= 10)
                {
                    mana -= 10;
                    Console.WriteLine($"{nombre} lanza un hechizo (30 de daño)");
                    objetivo.RecibirDanio(30);
                }
                else
                {
                    Console.WriteLine($"{nombre} da un golpe débil (5 de daño)");
                    objetivo.RecibirDanio(5);
                }
            }
        }

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Guerrero guerrero = new Guerrero("Yo", 100, 15);
            Mago mago = new Mago("Martin", 80, 20);

            
            Personaje[] grupo = new Personaje[2];
            grupo[0] = guerrero;
            grupo[1] = mago;

            Console.WriteLine("Estado incial");
            for (int i = 0; i < grupo.Length; i++)
            {
                grupo[i].MostrarEstado();
            }

            Console.WriteLine("Ronda de combate");
            
            grupo[0].Atacar(grupo[1]); 
            grupo[1].Atacar(grupo[0]); 

            Console.WriteLine("Estado final");
            for (int i = 0; i < grupo.Length; i++)
            {
                grupo[i].MostrarEstado();
                Console.WriteLine(grupo[i].EstaVivo() ? "  (sigue vivo)" : "  (derrotado)");
            }
        }
    }

    }


