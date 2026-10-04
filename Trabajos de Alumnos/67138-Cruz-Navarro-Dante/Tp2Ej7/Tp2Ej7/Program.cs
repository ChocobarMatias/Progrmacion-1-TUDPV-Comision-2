namespace Tp2Ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] trampa = { false, true, false, false, true, false };
            int i = 0;
            int avanzar;

            Console.WriteLine("Empieza en la posicion 0, escape de la mazmorra sin activar las trampas");

            while (trampa[i] != true && i < 5)
            {
                Console.WriteLine("¿Cuantas casillas quiere avanzar? 1 o 2");
                avanzar = int.Parse(Console.ReadLine());
                i = i + avanzar;
                Console.WriteLine($"Tu posicion ahora es {i}");
            }
            if (trampa[i] == true)
            {
                Console.WriteLine("Caiste en una trampa, perdiste");
            }
            else
            {
                Console.WriteLine("Felicidadws escapaste con exito");
            }
        }
    }
}