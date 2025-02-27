namespace EjercicioFibo
{
    using System;

    public class Matematicas
    {
        public static void Fibonacci(int cantidad)
        {
            int a = 0, b = 1;

            Console.WriteLine("Secuencia de Fibonacci:");

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(a + " ");
                int siguiente = a + b;
                a = b;
                b = siguiente;
            }

            Console.WriteLine();
        }
    }
}
