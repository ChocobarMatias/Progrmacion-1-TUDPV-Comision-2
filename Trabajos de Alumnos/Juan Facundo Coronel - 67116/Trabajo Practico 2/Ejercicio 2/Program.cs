namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] corredores = new float[5];
            bool salir = false;

            for (int i = 0; i < corredores.Length; i++)
            {
                Console.WriteLine($"Ingresa el  tiempo del corredor número {i + 1}");
                corredores[i] = float.Parse(Console.ReadLine());
            }
            while (salir == false)
            {
                Console.WriteLine("Ingresa el tiempo objetivo para clasificar. Los corredores que hayan logrado un tiempo inferior o igual habrán superado la prueba.");
                float objetivo = float.Parse(Console.ReadLine());
                int cantidad = 0;
                for (int i = 0; i < corredores.Length; i++)
                {
                    if (corredores[i] <= objetivo)
                    {
                        cantidad++;


                    }

                }
                Console.WriteLine($"{cantidad} corredores han conseguido superar la prueba");
                Console.WriteLine("¿Quieres continuar  1. Si /  2. No");
                int op = int.Parse(Console.ReadLine());
                while (op != 1 && op != 2)
                {
                    if (op < 1 || op > 2)
                    {
                        Console.WriteLine("Opcion invalida");
                        Console.WriteLine("Elige una opcion nuevamente");
                        op = int.Parse(Console.ReadLine());
                    }
                }
                if (op == 2)
                {
                    salir = true;
                    Console.WriteLine("Saliste");
                }
                else
                {
                    Console.WriteLine("Sigues");
                }

            }
        }
    }
}
