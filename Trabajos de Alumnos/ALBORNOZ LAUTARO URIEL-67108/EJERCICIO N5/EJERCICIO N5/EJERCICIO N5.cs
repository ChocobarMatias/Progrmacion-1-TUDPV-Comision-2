using System;

class Program
{
    static void Main()
    {
      
        int[] danoFlechas = new int[6];

     
        Console.WriteLine("=== CARGA DE DAÑO DE FLECHAS ===");
        for (int i = 0; i < danoFlechas.Length; i++)
        {
            Console.Write($"Ingrese el daño de la flecha {i + 1}: ");
            danoFlechas[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("\n=== FILTRADO DE DAÑO POR RÁFAGA ===");
        Console.WriteLine("Consejo: Ingrese un número negativo para salir del programa.\n");

        while (true)
        {
            Console.Write("Ingrese el daño de referencia: ");
            int referencia = int.Parse(Console.ReadLine());

          
            if (referencia < 0)
            {
                Console.WriteLine("Saliendo del sistema de filtrado...");
                break;
            }

            int acumuladorDano = 0;
            int contadorImpactos = 0;

          
            for (int i = 0; i < danoFlechas.Length; i++)
            {
                if (danoFlechas[i] > referencia)
                {
                    acumuladorDano += danoFlechas[i]; 
                    contadorImpactos++;
                }
            }

        
            Console.WriteLine($"-> Flechas que superaron el daño: {contadorImpactos}");
            Console.WriteLine($"-> Daño total acumulado de esos impactos: {acumuladorDano} pts.\n");
        }
    }
}