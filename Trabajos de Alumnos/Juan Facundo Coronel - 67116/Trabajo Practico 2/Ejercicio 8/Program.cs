namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peleas contra un jefe de 3 fases");
            int[] dañoJefe = new int[3];
            int suma = 0;
            int promedio = 0; 
            int op;
           
            for (int i = 0; i< dañoJefe.Length; i++)
            {
                Console.WriteLine($"Ingrese el daño recibido en la fase {i+1}");
                dañoJefe[i] = int.Parse(Console.ReadLine());
            } 
            int MayorDaño = dañoJefe[0];
            Console.WriteLine("Elige una opcion: 1. Calcular promedio de daño entre las 3 fases / 2.  Identificar la fase más destructiva ");
            op = int.Parse(Console.ReadLine()); 
            switch (op)
            {
                case 1:
                    Console.WriteLine("Elegiste la primera opción");
                    for (int i = 0; i< dañoJefe.Length; i++)
                    {
                        suma += dañoJefe[i]; 
                    }
                    promedio = suma / 3;
                    Console.WriteLine($"El promedio de daño entre las 3 fases fue de {promedio}");
                    break;
                case 2:
                    Console.WriteLine("Elegiste la segunda opción");
                    for(int i = 0; i < dañoJefe.Length; i++)
                    {
                        if (dañoJefe[i] > MayorDaño)
                        {
                            MayorDaño = dañoJefe [i];
                        }
                    }
                    Console.WriteLine($"La fase más destructiva tuvo {MayorDaño} de daño ");
                    
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }


        }
    }
}
