namespace TP_2_ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] trampas = { false, true, false, false, true, false };

            int posicion = 0;
            bool perdio = false;

            while (posicion < 5 && perdio == false)
            {
                Console.WriteLine("Posición actual: " + posicion);
                Console.Write("¿Cuántos casilleros quiere avanzar?: ");

                int avance = int.Parse(Console.ReadLine());

                posicion = posicion + avance;

                if (posicion > 5)
                {
                    posicion = 5;
                }

                if (trampas[posicion] == true)
                {
                    Console.WriteLine("Pisaste una trampa.");
                    perdio = true;
                }
                else
                {
                    Console.WriteLine("La baldosa es segura.");
                }
            }

            if (perdio == true)
            {
                Console.WriteLine("Perdiste.");
            }
            else
            {
                Console.WriteLine("Llegaste a la meta.");
            }

            Console.ReadKey();
        }
    }
}
