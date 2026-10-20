namespace Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario("Mario", 3, 3, "Normal");
            mario.Saltar();
            Luigi luigi = new Luigi("Luigi", 3, 1);
            PersonajeMario[] hermanos = new PersonajeMario[2];
            hermanos[0] = new Mario("Mario", 3, 0);
            hermanos[1] = new Luigi("Luigi", 3, 0);

            BloqueInterrogacion[] bloques = new BloqueInterrogacion[3];
            for (int i = 0; i < bloques.Length; i++)
            {
                bloques[i] = new BloqueInterrogacion();
            }

            Console.WriteLine("=== 1) Saltos polimórficos ===");
            for (int i = 0; i < hermanos.Length; i++)
            {
                hermanos[i].Saltar();
            }

            Console.WriteLine("\n=== 2) Golpeando bloques ===");
            for (int i = 0; i < bloques.Length; i++)
            {
                Console.WriteLine("-- Bloque " + (i + 1));
                for (int j = 0; j < hermanos.Length; j++)
                {
                    bloques[i].Golpear(hermanos[j]);   
                }
            }

            Console.WriteLine("\n=== 3) Daño polimórfico ===");
            for (int ronda = 1; ronda <= 4; ronda++)
            {
                Console.WriteLine("-- Ronda " + ronda);
                for (int i = 0; i < hermanos.Length; i++)
                {
                    hermanos[i].RecibirDanio(1);
                }
            }

            Console.WriteLine("\n=== 4) Validación de Vidas ===");
            hermanos[1].Vidas = -5;        

            Console.WriteLine("\n=== Estado final ===");
            for (int i = 0; i < hermanos.Length; i++)
            {
                Console.WriteLine($"{hermanos[i].getNombre} +  | Vidas:  + {hermanos[i].Vidas} +  | Monedas:  + {hermanos[i].monedas}");
            }
        }
    }
}
