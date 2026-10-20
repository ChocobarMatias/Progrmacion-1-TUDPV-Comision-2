namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] experiencia = new int[5];
            float bono = 1.20f;
            int total = 0; 
            for (int i = 0; i < experiencia.Length; i++)

            {
                Console.WriteLine($"Ingrese la experiencia adquirida en la misión {i + 1}");
                experiencia[i] = int.Parse(Console.ReadLine());

                if (experiencia[i] > 100)
                {
                    experiencia[i] = (int)(experiencia[i] * bono);
                    Console.WriteLine("La misión alcanzó la experiencia necesaria para obtener el bono del 20%");
                }
                else
                {
                    Console.WriteLine("La misión no cumplió con lo suficiente para obtener el bono");
                }

                    total += experiencia[i]; 
               
            }
            
           for (int i = 0;i < experiencia.Length;i++)
            {
                Console.WriteLine($"La misión {i + 1} otorgó {experiencia[i]} puntos de experiencia");
            }
            Console.WriteLine($"Obtuviste en total {total} puntos de experiencia");
        }
    }
}
