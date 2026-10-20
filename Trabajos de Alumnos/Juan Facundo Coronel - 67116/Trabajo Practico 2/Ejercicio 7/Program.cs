namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            bool[] trampas = { false, true, false, false, true, false };
            int posicion = 0;
            bool sigueVivo = true;

            Console.WriteLine("Comienza el recorrido en la baldosa 0 (Meta : Baldosa 5)");

            

            while (posicion < 5 && sigueVivo)
            {

                Console.WriteLine("Estas en la baldosa: " + posicion);
                Console.Write("Elige paso a dar (1 para avanzar, 2 avanzar 2): ");
                int eleccion = int.Parse(Console.ReadLine());

                posicion += eleccion; 

                if (posicion >= 5)
                {
                    Console.WriteLine("¡Llegaste a la meta! ¡Felicidades!");
                    
                }

                if (trampas[posicion])
                {
                    Console.WriteLine("Perdiste " + posicion + " Fin de la partida");
                    sigueVivo = false;
                }
                else
                {

                    Console.WriteLine("Seguis vivo pisaste balsoda segura " + posicion);
                }

            }

            if (sigueVivo)
            {
                Console.WriteLine("¡Felicidades! Has completado el recorrido.");
                
            }
        }
    }
}
