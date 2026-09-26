using System;

class Program
{
    static void Main()
    {
       
        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        int meta = 5; 

        Console.WriteLine("=== PASILLO DE MAZMORRA ===");
        Console.WriteLine("Comenzando el avance por el pasillo...\n");

        
        while (posicion < meta && !trampas[posicion])
        {
            Console.WriteLine($"-> El jugador avanzó y pisó la baldosa {posicion}: ¡Está a salvo!");
            posicion++;
        }

        
        if (posicion < trampas.Length && trampas[posicion])
        {
            Console.WriteLine($"\n[GAME OVER] ¡Pisaste la trampa en la baldosa {posicion} y perdiste!");
        }
        else
        {
            Console.WriteLine($"\n[¡VICTORIA!] ¡Felicitaciones! Has completado el recorrido llegando a la meta (baldosa {meta}).");
        }
    }
}