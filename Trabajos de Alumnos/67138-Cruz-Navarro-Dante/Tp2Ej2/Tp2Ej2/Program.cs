namespace Tp2Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] tiempos = new float[5];
            float obj;
            int cont = 0;
            bool seguir = true;
            Console.WriteLine("Ingresar los tiempos de los 5 corredores");
            for (int i = 0; i < tiempos.Length; i++)
            {
                tiempos[i] = float.Parse(Console.ReadLine());
            }
            while (seguir == true)
            {
                Console.WriteLine("Ingrese el tiempo objetivo");
                obj = float.Parse(Console.ReadLine());
                for (int i = 0; i < tiempos.Length; i++)
                {
                    if (tiempos[i] <= obj)
                    {
                        cont = cont + 1;
                    }
                }
                Console.WriteLine($"Un total de {cont} corredores superaron el tiempo objetivo");
                Console.WriteLine();
                Console.WriteLine("¿desea continuar con un nuevo objetivo?");
                Console.WriteLine("ingrese true para continuar o false para salir");
                seguir = bool.Parse(Console.ReadLine());
            }
        }
    }
}