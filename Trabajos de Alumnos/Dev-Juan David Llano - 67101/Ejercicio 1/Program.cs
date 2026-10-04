namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[4];

            Console.WriteLine("Cargue la durabilidad de cada arma (0 a 100):");
            Console.WriteLine();
            for (int i = 0; i < armas.Length; i++)
            {
                durabilidad[i] = LeerEnteroEnRango("  Durabilidad de " + armas[i] + ": ", 0, 100);
            }

            Console.WriteLine();
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("  1 - Inspeccionar armas críticas");
            Console.WriteLine("  2 - Ver arsenal completo");
            int opcion = LeerEnteroEnRango("Opción: ", 1, 2);
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("=== ARMAS EN ESTADO CRÍTICO (durabilidad <= 20) ===");
                    int criticas = 0;

                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine("  ALERTA: " + armas[i] + " está por romperse (" + durabilidad[i] + " de durabilidad)");
                            criticas++;
                        }
                    }

                    if (criticas == 0)
                    {
                        Console.WriteLine("  Ningún arma está en estado crítico. El arsenal está en buenas condiciones.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("  Total de armas críticas: " + criticas);
                    }
                    break;

                case 2:
                    Console.WriteLine("=== ARSENAL COMPLETO ===");
                    for (int i = 0; i < armas.Length; i++)
                    {
                        string estado;
                        if (durabilidad[i] <= 20)
                            estado = "CRÍTICA";
                        else if (durabilidad[i] <= 50)
                            estado = "Desgastada";
                        else
                            estado = "En buen estado";

                        Console.WriteLine("  " + armas[i].PadRight(10) + " | Durabilidad: " + durabilidad[i].ToString().PadLeft(3) + " | " + estado);
                    }
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
        static void Titulo(string texto)
        {
            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
            Console.WriteLine("  " + texto);
            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
            Console.WriteLine();
        }

        static int LeerEnteroEnRango(string mensaje, int minimo, int maximo)
        {
            while (true)
            {
                int valor = LeerEntero(mensaje);
                if (valor >= minimo && valor <= maximo)
                    return valor;
                Console.WriteLine("  >> Debe ingresar un número entre " + minimo + " y " + maximo + ".");
            }
        }

        static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                if (entrada != null && int.TryParse(entrada.Trim(), out valor))
                    return valor;
                Console.WriteLine("  >> Valor no válido. Ingrese un número entero.");
            }
        }
    }
}