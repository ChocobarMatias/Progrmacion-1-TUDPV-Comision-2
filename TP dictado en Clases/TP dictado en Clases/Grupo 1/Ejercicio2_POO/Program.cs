using System;

namespace POO
{
    class Item
    {
       
        public string Nombre { get; set; }

        
        private float peso;
        public float Peso
        {
            get { return peso; }
            set
            {
                if (value <= 0)
                {
                    peso = 0.5f;
                }
                else
                {
                    peso = value;
                }
            }
        }

        public Item(string nombre, float peso)
        {
            this.Nombre = nombre;
            this.Peso = peso;   
        }

        public virtual void Usar()
        {
            Console.WriteLine($"Usas el ítem '{Nombre}' (peso: {Peso} kg).");
        }
    }

 
    class Pocion : Item
    {
        public int PuntosRecuperacion { get; set; }

        public Pocion(string nombre, float peso, int puntosRecuperacion)
            : base(nombre, peso)
        {
            this.PuntosRecuperacion = puntosRecuperacion;
        }

        public override void Usar()
        {
            Console.WriteLine($"Bebes la poción '{Nombre}' y restauras {PuntosRecuperacion} puntos de vida.");
        }
    }

    class ArmaEquipable : Item
    {
        public int Danio { get; set; }

        public ArmaEquipable(string nombre, float peso, int danio)
            : base(nombre, peso)
        {
            this.Danio = danio;
        }

        public override void Usar()
        {
            Console.WriteLine($"Equipas el arma '{Nombre}'. Poder de ataque: {Danio}.");
        }
    }

   
    class CofreBotin
    {
        private bool _abierto = false;
        private Item[] itemsContenidos = new Item[2];

        public CofreBotin(Item item1, Item item2)
        {
            itemsContenidos[0] = item1;
            itemsContenidos[1] = item2;
        }

        public void Abrir()
        {
            if (_abierto != true)
            {
                _abierto = true;
                Console.WriteLine("Abres el cofre. Dentro encuentras:");
                for (int i = 0; i < itemsContenidos.Length; i++)
                {
                    itemsContenidos[i].Usar();   
                }
            }
            else
            {
                Console.WriteLine("El cofre ya estaba abierto.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pocion pocion = new Pocion("Poción Roja", 0.3f, 50);
            ArmaEquipable espada = new ArmaEquipable("Espada de Hierro", 3.5f, 25);

            CofreBotin cofre = new CofreBotin(pocion, espada);

            cofre.Abrir();
            cofre.Abrir();
        }
    }
}
